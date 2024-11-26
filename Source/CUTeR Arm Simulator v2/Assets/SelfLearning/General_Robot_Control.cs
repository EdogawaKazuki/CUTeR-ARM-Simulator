using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using System.Numerics;

public class GeneralRobotControl : MonoBehaviour
{
    public RobotController _robotController;
    public StaticRobotTrajectoryController _trajController;
    public RobotClient _robotClient;

    PlayableDirector timeline;

    int dof = 6;
    public float fs = 0.01f;
    public enum State
    {
        init,
        stopped,
        playing,
        pause,
        looping,
        ready,
        loadFailed,
        finished,
        prelooping,
        preplaying,

    }

    public State _currentState;
    public delegate IEnumerator RobotAction();
    public Queue<RobotAction> actionQueue = new Queue<RobotAction>();
    // Start is called before the first frame update
    void Start()
    {
        _currentState = State.init;
    }

    void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (actionQueue.Count > 0)
        {
            switch (_currentState)
            {
                case State.init:
                    break;
                case State.ready:
                    RobotAction nextAction = actionQueue.Dequeue();
                    StartCoroutine(nextAction());
                    _currentState = State.playing;
                    break;
                case State.playing:
                    // Robot is currently executing an action
                    break;
                case State.stopped:
                    // Robot has been stopped
                    break;
                case State.pause:
                    // Robot action is paused
                    break;
                case State.finished:
                    // Robot has finished all actions
                    _currentState = State.ready;
                    break;
                default:
                    // Handle any other states
                    break;
            }
        }
    }

    public List<float> ForwardKinematicsOpenManipulatorPro3DOF(List<float> jointAngles)
    {
        /*
        This method calculates the forward kinematics for a 3DOF robotic arm based on the following formulas:
        xp = sin(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
        yp = cos(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
        zp = l1 + l2 * sin(θ2) + l3 * sin(φ2 + φ3)
        where l1 = 15.9, l2 = sqrt(26.4^2 + 3.0^2), l3 = 38.11, φ2 = θ2 + atan(0.3/26.4)  (dont trust these)
        */
        float l1 = 15.9f;
        float l2 = Mathf.Sqrt(26.4f * 26.4f + 3.0f * 3.0f);
        float l3 = Mathf.Sqrt(38.11f * 38.11f + 3.0f * 3.0f);

        float theta1 = jointAngles[0] * Mathf.Deg2Rad;
        float phi2 = (90 - jointAngles[1]) * Mathf.Deg2Rad - Mathf.Atan2(3.0f, 26.4f); ; // Adjusting for the offset
        float phi3 = (-45 - jointAngles[2]) * Mathf.Deg2Rad + Mathf.Atan2(3.0f, 26.4f) + Mathf.Atan2(3.0f, 38.11f); // Adjusting for the offset

        float xp = Mathf.Sin(-theta1) * (l2 * Mathf.Cos(phi2) + l3 * Mathf.Cos(phi2 + phi3));
        float yp = Mathf.Cos(-theta1) * (l2 * Mathf.Cos(phi2) + l3 * Mathf.Cos(phi2 + phi3));
        float zp = l1 + l2 * Mathf.Sin(phi2) + l3 * Mathf.Sin(phi2 + phi3);

        return new List<float> { xp, yp, zp, 0, 0, 0 };
    }

    public List<float> InverseKinematicsOpenManipulatorPro3DOF(List<float> pos)
    {
        /*
        This method calculates the inverse kinematics for a 3DOF robotic arm based on the following formulas:
        xp = sin(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
        yp = cos(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
        zp = l1 + l2 * sin(θ2) + l3 * sin(φ2 + φ3)
        where l1 = 15.9, l2 = sqrt(26.4^2+3.0^2), l3 = 38.11, φ2 = θ2 + atan(0.3/26.4), φ3 = θ3 - atan(3.0/26.4) - atan(3/38.11) (dont trust these)
        */
        float l1 = 15.9f;
        float l2 = Mathf.Sqrt(26.4f * 26.4f + 3.0f * 3.0f);
        float l3 = Mathf.Sqrt(38.11f * 38.11f + 3.0f * 3.0f);
        float phi2_offset = Mathf.Atan2(3.0f, 26.4f);
        float phi3_offset = -Mathf.Atan2(3.0f, 26.4f) - Mathf.Atan2(3.0f, 38.11f);

        float xp = pos[0];
        float yp = pos[1];
        float zp = pos[2];

        float theta1 = Mathf.Atan2(-xp, yp);
        float A = -xp * Mathf.Sin(theta1) + yp * Mathf.Cos(theta1);
        float B = zp - l1;

        float phi3 = -Mathf.Acos((A * A + B * B - l2 * l2 - l3 * l3) / (2 * l2 * l3));
        float phi2 = Mathf.Atan2((B * (l2 + l3 * Mathf.Cos(phi3)) - A * l3 * Mathf.Sin(phi3)),
                                  (A * (l2 + l3 * Mathf.Cos(phi3)) + B * l3 * Mathf.Sin(phi3)));

        float theta2 = phi2 + phi2_offset;
        float theta3 = phi3 + phi3_offset;

        return new List<float> { Mathf.Rad2Deg * theta1, -Mathf.Rad2Deg * theta2 + 90, -Mathf.Rad2Deg * theta3 - 45, 0, 0, 0 };
    }

    public List<List<float>> SolveTaskSpaceTrajectories(List<List<float>> TaskTrajList)
    {
        List<List<float>> JointTrajList = new List<List<float>>();
        for (int i = 0; i < dof; i++)
        {
            JointTrajList.Add(new List<float>());
        }
        for (int j = 0; j < TaskTrajList.Count; j++)
        {
            List<float> taskSpacePosition = TaskTrajList[j];
            
            // Use inverse kinematics to find the joint angles for the current task space position
            List<float> jointAngles = InverseKinematicsOpenManipulatorPro3DOF(taskSpacePosition);
            // Add the calculated joint angles to the corresponding joint's list
            for (int k = 0; k < dof; k++)
            {
                JointTrajList[k].Add(jointAngles[k]); // Add the angle for each joint
            }
        }
        return JointTrajList;
    }
    
    public List<List<float>> SolveJointSpaceTrajectories(List<List<float>> JointTrajList)
    {
        List<List<float>> TaskTrajList = new List<List<float>>();
        for (int i = 0; i < JointTrajList[0].Count; i++)
        {
            List<float> taskSpacePosition = new List<float>();
            // Use forward kinematics to find the task space position for the current joint angles
            List<float> jointAngles = new List<float>();
            for (int k = 0; k < dof; k++)
            {
                jointAngles.Add(JointTrajList[k][i]); // Collect the angle for each joint
            }
            taskSpacePosition = ForwardKinematicsOpenManipulatorPro3DOF(jointAngles);
            TaskTrajList.Add(taskSpacePosition);
        }
        return TaskTrajList;
    }

    public List<List<float>> HardcodeTrajectory(int num_of_frames)
    {
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < dof; i++)
        {
            List<float> tmp = new List<float>();
            for (int j = 0; j < num_of_frames; j++)
            {
                if (i == 0)
                {
                    tmp.Add(-90 + 180 * j / (num_of_frames - 1)); // -90 to 90 for the first joint
                }
                else
                {
                    tmp.Add(0); // 0 for the other two joints
                }
            }
            trajList.Add(tmp);
        }
        return trajList;
    }

    public List<List<float>> HardcodeTrajectory_2_axis(int num_of_frames)
    {
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < dof; i++)
        {
            List<float> tmp = new List<float>();
            for (int j = 0; j < num_of_frames; j++)
            {
                if (i == 0)
                {
                    tmp.Add(-90 + 180 * j / (num_of_frames - 1)); // -90 to 90 for the first joint
                }
                else if (i == 2)
                {
                    tmp.Add(15 * Mathf.Sin(2 * Mathf.PI * j / 100)); // Oscillate between -90 and 90 degrees with a period of 100 frames
                }
                else
                {
                    tmp.Add(0); // 0 for the other two joints
                }
            }
            trajList.Add(tmp);
        }
        return trajList;
    }

    public List<List<float>> HardcodeTrajectory_task_space_axis(int num_of_frames)
    {
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < dof; i++)
        {
            trajList.Add(new List<float>());
        }
        for (int i = 0; i < dof; i++)
        {
            List<float> tmp = new List<float>();
            for (int j = 0; j < num_of_frames; j++)
            {
                List<float> taskSpacePosition;

                // Define the trajectory in task space
                // float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
                float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
                float y = 20f; // Fixed y position
                float z = 30f; // Fixed z position

                // float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
                // float y = 25; // Fixed y position
                // float z = 50 +  10 * (((float) j / (num_of_frames - 1))); // Fixed z position

                taskSpacePosition = new List<float> { x, y, z };

                // Use inverse kinematics to find the joint angles for the current task space position
                List<float> jointAngles = InverseKinematicsOpenManipulatorPro3DOF(taskSpacePosition);
                // Add the calculated joint angles to the corresponding joint's list
                for (int k = 0; k < dof; k++)
                {
                    trajList[k].Add(jointAngles[k]); // Add the angle for each joint
                }
            }
        }
        return trajList;
    }

    public IEnumerator Move_to_Initial_Position()
    {
        List<float> target_angles = new List<float>();
        for (int i = 0; i < dof; i++)
        {
            target_angles.Add(0);
        }
        yield return StartCoroutine(Move_to_Target_Joint_Space_Position_Cubic_Trajectory(target_angles, 2.0f));
        _currentState = State.finished;
    }

    public IEnumerator Move_to_Target_Joint_Space_Position_Linear_Trajectory(List<float> target_angles, float second)
    {
        List<float> current_angles = _robotController.GetJointAngles();
        List<List<float>> trajList = new List<List<float>>();
        int num_of_frames = (int)(second / fs);
        for (int i = 0; i < dof; i++)
        {
            List<float> tmp = new List<float>();
            for (int j = 0; j < num_of_frames; j++)
            {
                tmp.Add(current_angles[i] + (target_angles[i] - current_angles[i]) * j / (num_of_frames - 1));
            }

            trajList.Add(tmp);
        }
        yield return StartCoroutine(ExecuteTrajectoryWithDelay(trajList));
        _currentState = State.finished;
    }

    public IEnumerator Move_to_Target_Joint_Space_Position_Cubic_Trajectory(List<float> target_angles, float second)
    {
        List<float> current_angles = _robotController.GetJointAngles();
        List<List<float>> trajList = new List<List<float>>();
        int num_of_frames = (int)(second / fs);
        Vector<float> a0 = new Vector<float>(current_angles.ToArray());
        Vector<float> target = new Vector<float>(target_angles.ToArray());
        Vector<float> a1 = new Vector<float>(new float[dof]);
        Vector<float> a2 = 3 * (target - a0) * (1 / (second * second));
        Vector<float> a3 = -2 * (target - a0) * (1 / (second * second * second));

        for (int i = 0; i < dof; i++)
        {
            List<float> tmp = new List<float>();
            for (int j = 0; j < num_of_frames; j++)
            {
                double t = (double)j / (num_of_frames - 1) * second;
                float[] a0Copy = new float[dof];
                a0.CopyTo(a0Copy, 0);
                float[] a1Copy = new float[dof];
                a1.CopyTo(a1Copy, 0);
                float[] a2Copy = new float[dof];
                a2.CopyTo(a2Copy, 0);
                float[] a3Copy = new float[dof];
                a3.CopyTo(a3Copy, 0);
                tmp.Add((float)(a0Copy[i] + a1Copy[i] * t + a2Copy[i] * t * t + a3Copy[i] * t * t * t));
            }
            trajList.Add(tmp);
        }
        yield return StartCoroutine(ExecuteTrajectoryWithDelay(trajList));
        _currentState = State.finished;
    }

    public IEnumerator Move_to_Target_Task_Space_Position_Linear_Trajectory(List<float> target_position, float second)
    {
        // Get current joint angles and calculate current position using forward kinematics
        List<float> current_angles = _robotController.GetJointAngles();
        List<float> current_position = ForwardKinematicsOpenManipulatorPro3DOF(current_angles);

        // Convert target_position and current_position to System.Numerics.Vector3
        Vector<float> targetVector = new Vector<float>(target_position.ToArray());
        Vector<float> currentVector = new Vector<float>(current_position.ToArray());

        // Create trajectory list
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < dof; i++)
        {
            trajList.Add(new List<float>());
        }
        int num_of_frames = (int)(second / fs);

        // Generate trajectory to move from current position to target position
        for (int j = 0; j < num_of_frames; j++)
        {
            // Calculate the task space position for the current frame
            Vector<float> taskSpacePosition = currentVector + (targetVector - currentVector) * (float)j * (1 / (float)(num_of_frames - 1));
            float[] taskSpacePositionArray = new float[dof];
            taskSpacePosition.CopyTo(taskSpacePositionArray);
            List<float> taskSpacePositionList = new List<float>(taskSpacePositionArray);
            List<float> jointAngles = InverseKinematicsOpenManipulatorPro3DOF(taskSpacePositionList);

            // Add the calculated joint angles to the corresponding joint's list
            for (int k = 0; k < dof; k++)
            {
                trajList[k].Add(jointAngles[k]); // Add the angle for each joint
            }
        }
        

        yield return StartCoroutine(ExecuteTrajectoryWithDelay(trajList));
        _currentState = State.finished;
    }

    public IEnumerator Move_to_Target_Task_Space_Position_Cubic_Trajectory(List<float> target_position, float second)
    {
        // Get current joint angles and calculate current position using forward kinematics
        List<float> current_angles = _robotController.GetJointAngles();
        List<float> current_position = ForwardKinematicsOpenManipulatorPro3DOF(current_angles);

        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < dof; i++)
        {
            trajList.Add(new List<float>());
        }
        int num_of_frames = (int)(second / fs);

        // Convert target_position and current_position to System.Numerics.Vector3
        Vector<float> targetVector = new Vector<float>(target_position.ToArray());
        Vector<float> currentVector = new Vector<float>(current_position.ToArray());
        Vector<float> a0 = currentVector;
        Vector<float> a1 = new Vector<float>(new float[dof]);
        Vector<float> a2 = 3 * (targetVector - a0) * (1 / (second * second));
        Vector<float> a3 = -2 * (targetVector - a0) * (1 / (second * second * second));

        
        for (int j = 0; j < num_of_frames; j++)
        {
            float t = (float)j / (num_of_frames - 1) * second;
            Vector<float> pos = (a0 + a1 * t + a2 * t * t + a3 * t * t * t);
            float[] posArray = new float[dof];
            pos.CopyTo(posArray);
            List<float> posList = new List<float>(posArray);
            List<float> jointAngles = InverseKinematicsOpenManipulatorPro3DOF(posList);
            // Add the calculated joint angles to the corresponding joint's list
            for (int k = 0; k < dof; k++)
            {
                trajList[k].Add(jointAngles[k]); // Add the angle for each joint
            }
        }

        yield return StartCoroutine(ExecuteTrajectoryWithDelay(trajList));
        _currentState = State.finished;
    }

    public IEnumerator RobotAction1()
    {
        Debug.Log("This is a test statement.");
        List<List<float>> trajList = HardcodeTrajectory_2_axis(300);
        yield return StartCoroutine(ExecuteTrajectoryWithDelay(trajList));
        _currentState = State.finished;
    }

    public IEnumerator RobotAction2()
    {
        Debug.Log("This is a test statement.");
        List<List<float>> trajList = HardcodeTrajectory_task_space_axis(200);
        // reverse the trajectory on the second axis

        yield return StartCoroutine(ExecuteTrajectoryWithDelay(trajList));
        _currentState = State.finished;
    }

    public IEnumerator ExecuteTrajectoryWithDelay(List<List<float>> trajList)
    {
        for (int i = 0; i < trajList[0].Count; i++)
        {
            List<float> angles = new List<float>();
            for (int j = 0; j < trajList.Count; j++)
            {
                angles.Add(trajList[j][i]);
            }
            _robotController.SetCmdJointAngles(angles);
            // _robotClient.SendJointCmdDirect(angles, fs);
            _robotController.SendCmdToRobot(fs);

            // Add a delay here
            yield return new WaitForSeconds(fs); // Adjust the delay time as needed
        }
        _currentState = State.finished;
    }

    public IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        _currentState = State.finished;
    }

    // return to init
    // go to certain position linear
    // go to certain position cubic
    // follow a trajectory
    // wait for x seconds
}
