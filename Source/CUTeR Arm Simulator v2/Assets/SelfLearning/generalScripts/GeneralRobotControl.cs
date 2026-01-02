using System.Collections;
using System.Collections.Generic;
using System.Numerics;
// using System.Windows.Forms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;


// using MathNet.Numerics.LinearAlgebra;


public class GeneralRobotControl : MonoBehaviour
{
    public RobotController _robotController;
    public StaticRobotTrajectoryController _trajController;
    public RobotClient _robotClient;

    PlayableDirector timeline;

    int dof = 6;
    public float fs;

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

    private Coroutine currentCoroutine; // Reference to the currently running coroutine

    // Start is called before the first frame update
    void Start()
    {
        _currentState = State.init;
        fs = 1 / _robotClient.control_rate;
    }

    void OnEnable() { }

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
                    try
                    {
                        currentCoroutine = StartCoroutine(nextAction());
                        _currentState = State.playing;
                    }
                    catch
                    {
                        _currentState = State.ready;
                    }
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
                    // Robot has finished the current action
                    _currentState = State.ready;
                    break;
                default:
                    // Handle any other states
                    break;
            }
        }
    }

    // public IEnumerator StartLesson()
    // {
    //     // GameObject joystickSlider = GameObject.Find("Robot/RobotCanvas/Joystick/Panel/Slider");
    //     for (int i = 0; i < 6; i++)
    //     {
    //         GameObject sliderObject = GameObject.Find("Robot/RobotCanvas/Joystick/Panel/Slider/Joint" + i + "/Slider");
    //         if (sliderObject != null)
    //         {
    //             Slider slider = sliderObject.GetComponent<Slider>();
    //             if (slider != null)
    //             {
    //                 // Example usage: Set the slider value to 0.5
    //                 slider.interactable = false;
    //             }
    //         }
    //     }
    //     return null;
    // }

    public IEnumerator LockSlider(bool value)
    {
        // GameObject joystickSlider = GameObject.Find("Robot/RobotCanvas/Joystick/Panel/Slider");
        for (int i = 0; i < 6; i++)
        {
            GameObject sliderObject = GameObject.Find("Robot/RobotCanvas/Joystick/Panel/Slider/Joint" + i + "/Slider");
            if (sliderObject != null)
            {
                Slider slider = sliderObject.GetComponent<Slider>();
                if (slider != null)
                {
                    // Example usage: Set the slider value to 0.5
                    slider.interactable = !value;
                }
            }
        }
        return null;
    }

    private float[,] RotationMatrixX(float theta)
    {
        float cosTheta = Mathf.Cos(theta);
        float sinTheta = Mathf.Sin(theta);

        return new float[,]
        {
            { 1, 0, 0 },
            { 0, cosTheta, -sinTheta },
            { 0, sinTheta, cosTheta },
        };
    }

    private float[,] RotationMatrixY(float theta)
    {
        float cosTheta = Mathf.Cos(theta);
        float sinTheta = Mathf.Sin(theta);

        return new float[,]
        {
            { cosTheta, 0, sinTheta },
            { 0, 1, 0 },
            { -sinTheta, 0, cosTheta },
        };
    }

    private float[,] RotationMatrixZ(float theta)
    {
        float cosTheta = Mathf.Cos(theta);
        float sinTheta = Mathf.Sin(theta);

        return new float[,]
        {
            { cosTheta, -sinTheta, 0 },
            { sinTheta, cosTheta, 0 },
            { 0, 0, 1 },
        };
    }

    private float[,] MatrixMultiply(float[,] A, float[,] B)
    {
        int aRows = A.GetLength(0);
        int aCols = A.GetLength(1);
        int bRows = B.GetLength(0);
        int bCols = B.GetLength(1);

        float[,] result = new float[aRows, bCols];

        for (int i = 0; i < aRows; i++)
        {
            for (int j = 0; j < bCols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < aCols; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return result;
    }

    private float[,] Transpose(float[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        float[,] result = new float[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = A[i, j];
            }
        }

        return result;
    }

    private List<float> AnglesFromSimulation2Model(List<float> angles)
    {
        if (angles.Count < 6)
        {
            return new List<float>
            {
                Mathf.Deg2Rad * angles[0],
                -Mathf.Deg2Rad * (angles[1] - 90),
                -Mathf.Deg2Rad * (angles[2] + 45),
            };
        }
        return new List<float>
        {  
            Mathf.Deg2Rad * angles[0],
            -Mathf.Deg2Rad * (angles[1] - 90),
            -Mathf.Deg2Rad * (angles[2] + 45),
            Mathf.Deg2Rad * (angles[3] + 180),
            Mathf.Deg2Rad * angles[4],
            Mathf.Deg2Rad * (-angles[5] + 180),
        };
    }

    private List<float> AnglesFromModel2Simulation(List<float> angles)
    {
        return new List<float>
        {
            Mathf.Rad2Deg * angles[0],
            -Mathf.Rad2Deg * angles[1] + 90,
            -Mathf.Rad2Deg * angles[2] - 45,
            Mathf.Rad2Deg * angles[3],
            Mathf.Rad2Deg * angles[4],
            -Mathf.Rad2Deg * angles[5],
        };
    }

    private float[,] ComputeR_0_6(List<float> jointAngles)
    {
        // Debug.Log($"Debug: jointAngles length = {jointAngles.Count}");  Somehow joint angles has 3 elements here
        float[,] R_0_1 = RotationMatrixZ(jointAngles[0]);
        float[,] R_1_2 = RotationMatrixX(jointAngles[1]);
        float[,] R_2_3 = RotationMatrixX(jointAngles[2]);
        float[,] R_3_4 = RotationMatrixY(jointAngles[3]);
        float[,] R_4_5 = RotationMatrixX(jointAngles[4]);
        float[,] R_5_6 = RotationMatrixY(jointAngles[5]);

        float[,] R_0_6 = MatrixMultiply(
            R_0_1,
            MatrixMultiply(
                R_1_2,
                MatrixMultiply(R_2_3, MatrixMultiply(R_3_4, MatrixMultiply(R_4_5, R_5_6)))
            )
        );
        return R_0_6;
    }

    public List<float> ForwardKinematicsOpenManipulatorPro6DOF(List<float> jointAngles)
    {
        List<float> pos = ForwardKinematicsOpenManipulatorPro3DOF(jointAngles, l3_long: 25.8f);

        jointAngles = AnglesFromSimulation2Model(jointAngles);

        string angleStr = "";
        for (int i = 0; i < jointAngles.Count; i++)
        {
            angleStr += string.Format("{0:F2}", jointAngles[i]);
            if (i < jointAngles.Count - 1)
            {
                angleStr += ", ";
            }
        }
        // Debug.Log(angleStr);

        float[,] R_0_6 = ComputeR_0_6(jointAngles);

        float[,] l_6 = new float[3, 1]
        {
            { 0 },
            { 12.3f },
            { 0 },
        };

        float[,] l_0 = MatrixMultiply(R_0_6, l_6);

        float xp = pos[0] + l_0[0, 0];
        float yp = pos[1] + l_0[1, 0];
        float zp = pos[2] + l_0[2, 0];

        // Calculate Euler angles from the rotation matrix R_0_6
        float roll = Mathf.Atan2(R_0_6[2, 1], R_0_6[2, 2]); // Rotation around x-axis
        float pitch = Mathf.Atan2(-R_0_6[2, 0], Mathf.Sqrt(R_0_6[2, 1] * R_0_6[2, 1] + R_0_6[2, 2] * R_0_6[2, 2])); // Rotation around y-axis
        float yaw = Mathf.Atan2(R_0_6[1, 0], R_0_6[0, 0]); // Rotation around z-axis

        // Solve Euler Angles
        return new List<float> { xp, yp, zp, roll * Mathf.Rad2Deg, pitch * Mathf.Rad2Deg, yaw * Mathf.Rad2Deg }; // Updated to include Euler angles
    }

    public List<float> ForwardKinematicsOpenManipulatorPro3DOF(
        List<float> jointAngles,
        float l3_long = 38.11f
    )
    {
        /*
        This method calculates the forward kinematics for a 3DOF robotic arm based on the following formulas:
        xp = sin(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
        yp = cos(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
        zp = l1 + l2 * sin(θ2) + l3 * sin(φ2 + φ3)
        where l1 = 15.9, l2 = sqrt(26.4^2 + 3.0^2), l3 = 38.11, φ2 = θ2 + atan(0.3/26.4)  (dont trust these)
        */
        jointAngles = AnglesFromSimulation2Model(jointAngles);
        float l1 = 15.9f;
        float l2 = Mathf.Sqrt(26.4f * 26.4f + 3.0f * 3.0f);
        float l3 = Mathf.Sqrt(l3_long * l3_long + 3.0f * 3.0f);

        float theta1 = jointAngles[0];
        float phi2 = jointAngles[1] - Mathf.Atan2(3.0f, 26.4f); // Adjusting for the offset
        float phi3 = jointAngles[2] + Mathf.Atan2(3.0f, 26.4f) + Mathf.Atan2(3.0f, l3_long); // Adjusting for the offset

        float xp = Mathf.Sin(-theta1) * (l2 * Mathf.Cos(phi2) + l3 * Mathf.Cos(phi2 + phi3));
        float yp = Mathf.Cos(-theta1) * (l2 * Mathf.Cos(phi2) + l3 * Mathf.Cos(phi2 + phi3));
        float zp = l1 + l2 * Mathf.Sin(phi2) + l3 * Mathf.Sin(phi2 + phi3);

        return new List<float> { xp, yp, zp, 0, 0, 0 };
    }

    public List<float> SimulationInverseKinematicsOpenManipulatorPro6DOF(List<float> pos)
    {
        return AnglesFromModel2Simulation(InverseKinematicsOpenManipulatorPro6DOF(pos));
    }

    public List<float> InverseKinematicsOpenManipulatorPro6DOF(List<float> pos)
    {
        List<float> euler_angles = new List<float> { pos[3], pos[4], pos[5] };
        float[,] R_x = RotationMatrixX(euler_angles[0]);
        float[,] R_y = RotationMatrixY(euler_angles[1]);
        float[,] R_z = RotationMatrixZ(euler_angles[2]);
        float[,] R_0_6 = MatrixMultiply(R_x, MatrixMultiply(R_y, R_z));

        float[,] l_6 = new float[3, 1]
        {
            { 0 },
            { 12.3f },
            { 0 },
        };
        float[,] adjusted_pos_matrix = MatrixMultiply(R_0_6, l_6);

        List<float> adjusted_pos = new List<float>
        {
            pos[0] - adjusted_pos_matrix[0, 0],
            pos[1] - adjusted_pos_matrix[1, 0],
            pos[2] - adjusted_pos_matrix[2, 0],
        };

        List<float> angles = InverseKinematicsOpenManipulatorPro3DOF(adjusted_pos, l3_long: 25.8f);

        float[,] R_0_1 = RotationMatrixZ(angles[0]);
        float[,] R_1_2 = RotationMatrixX(angles[1]);
        float[,] R_2_3 = RotationMatrixX(angles[2]);

        float[,] R_0_3 = MatrixMultiply(R_0_1, MatrixMultiply(R_1_2, R_2_3));
        float[,] R_3_0 = Transpose(R_0_3);

        float[,] R_3_6 = MatrixMultiply(R_3_0, R_0_6);

        // Solve for theta 4, 5, 6
        float theta_4 = -Mathf.PI + Mathf.Atan2(R_3_6[0, 1], R_3_6[2, 1]);
        float theta_5 = Mathf.Acos(R_3_6[1, 1]);
        float theta_6 = -Mathf.PI + Mathf.Atan2(R_3_6[1, 0], -R_3_6[1, 2]);

        float NormalizeAngle(float angle)
        {
            while (angle < -Mathf.PI)
                angle += 2 * Mathf.PI;
            while (angle > Mathf.PI)
                angle -= 2 * Mathf.PI;
            return angle;
        }

        // Usage
        theta_4 = NormalizeAngle(theta_4);
        theta_6 = NormalizeAngle(theta_6);

        angles[3] = theta_4;
        angles[4] = theta_5;
        angles[5] = theta_6;

        return angles;
    }

    public List<float> SimulationInverseKinematicsOpenManipulatorPro3DOF(List<float> pos)
    {
        return AnglesFromModel2Simulation(InverseKinematicsOpenManipulatorPro3DOF(pos));
    }

    public List<List<float>> InverseKinematicsOpenManipulatorPro2DOFFullSolution(
        List<float> pos,
        float l3_long = 38.11f
    )
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
        float l3 = Mathf.Sqrt(l3_long * l3_long + 3.0f * 3.0f);
        float phi2_offset = Mathf.Atan2(3.0f, 26.4f);
        float phi3_offset = -Mathf.Atan2(3.0f, 26.4f) - Mathf.Atan2(3.0f, l3_long);

        float xp = 0;
        float yp = pos[1];
        float zp = pos[2];

        float theta1 = 0;
        float A = -xp * Mathf.Sin(theta1) + yp * Mathf.Cos(theta1);
        float B = zp - l1;

        float phi3 = -Mathf.Acos((A * A + B * B - l2 * l2 - l3 * l3) / (2 * l2 * l3));
        float phi2 = Mathf.Atan2(
            (B * (l2 + l3 * Mathf.Cos(phi3)) - A * l3 * Mathf.Sin(phi3)),
            (A * (l2 + l3 * Mathf.Cos(phi3)) + B * l3 * Mathf.Sin(phi3))
        );

        float phi3_2 = -phi3;
        float phi2_2 = Mathf.Atan2(
            (B * (l2 + l3 * Mathf.Cos(phi3_2)) - A * l3 * Mathf.Sin(phi3_2)),
            (A * (l2 + l3 * Mathf.Cos(phi3_2)) + B * l3 * Mathf.Sin(phi3_2))
        );

        float theta2 = phi2 + phi2_offset;
        float theta3 = phi3 + phi3_offset;  
        
        float theta2_2 = phi2_2 + phi2_offset;
        float theta3_2 = phi3_2 + phi3_offset;

        // return new List<float> { Mathf.Rad2Deg * theta1, -Mathf.Rad2Deg * theta2 + 90, -Mathf.Rad2Deg * theta3 - 45, 0, 0, 0 };
        return new List<List<float>> {AnglesFromModel2Simulation(new List<float> { theta1, theta2, theta3, 0, 0, 0 }), AnglesFromModel2Simulation(new List<float> { theta1, theta2_2, theta3_2, 0, 0, 0 }) };
    }

    public List<float> InverseKinematicsOpenManipulatorPro3DOF(
        List<float> pos,
        float l3_long = 38.11f
    )
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
        float l3 = Mathf.Sqrt(l3_long * l3_long + 3.0f * 3.0f);
        float phi2_offset = Mathf.Atan2(3.0f, 26.4f);
        float phi3_offset = -Mathf.Atan2(3.0f, 26.4f) - Mathf.Atan2(3.0f, l3_long);

        float xp = pos[0];
        float yp = pos[1];
        float zp = pos[2];

        float theta1 = Mathf.Atan2(-xp, yp);
        float A = -xp * Mathf.Sin(theta1) + yp * Mathf.Cos(theta1);
        float B = zp - l1;

        float phi3 = -Mathf.Acos((A * A + B * B - l2 * l2 - l3 * l3) / (2 * l2 * l3));
        float phi2 = Mathf.Atan2(
            (B * (l2 + l3 * Mathf.Cos(phi3)) - A * l3 * Mathf.Sin(phi3)),
            (A * (l2 + l3 * Mathf.Cos(phi3)) + B * l3 * Mathf.Sin(phi3))
        );

        float theta2 = phi2 + phi2_offset;
        float theta3 = phi3 + phi3_offset;

        // return new List<float> { Mathf.Rad2Deg * theta1, -Mathf.Rad2Deg * theta2 + 90, -Mathf.Rad2Deg * theta3 - 45, 0, 0, 0 };
        return new List<float> { theta1, theta2, theta3, 0, 0, 0 };
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

            // Check if the first element has 3 or 6 elements and use the appropriate inverse kinematics method
            List<float> jointAngles;
            if (taskSpacePosition.Count == 6)
            {
                jointAngles = SimulationInverseKinematicsOpenManipulatorPro6DOF(taskSpacePosition);
            }
            else if (taskSpacePosition.Count == 3)
            {
                jointAngles = SimulationInverseKinematicsOpenManipulatorPro3DOF(taskSpacePosition);
            }
            else
            {
                // Handle unexpected case (e.g., log an error or throw an exception)
                Debug.LogError("Invalid task space position length: " + taskSpacePosition.Count);
                continue; // Skip this iteration
            }

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

            taskSpacePosition = ForwardKinematicsOpenManipulatorPro6DOF(jointAngles);

            TaskTrajList.Add(taskSpacePosition);
        }
        return TaskTrajList;
    }

    public IEnumerator MoveToInitialPosition()
    {
        List<float> current_angles = _robotController.GetJointAngles();
        Debug.Log("Current angles: " + string.Join(", ", current_angles));
        List<float> target_angles = new List<float>();
        for (int i = 0; i < dof; i++)
        {
            target_angles.Add(0);
        }
        float distance = 0;
        for (int i = 0; i < dof; i++)
        {
            distance = Mathf.Max(distance, Mathf.Abs(current_angles[i] - target_angles[i]) * (dof-i)/dof);  // weighted, lower indexed joints have heavier weight
        }
        float duration = Mathf.Max(1.0f, 2.0f * distance / 40);
        yield return StartCoroutine(
            MoveToTargetJointSpacePositionCubicTrajectory(target_angles, duration)
        );
        _currentState = State.finished;
    }

    public IEnumerator MoveToTargetJointSpacePositionLinearTrajectory(
        List<float> target_angles,
        float second
    )
    {
        List<float> current_angles = _robotController.GetJointAngles();
        List<List<float>> trajList = new List<List<float>>();
        int num_of_frames = (int)(second / fs);
        for (int i = 0; i < dof; i++)
        {
            List<float> tmp = new List<float>();
            for (int j = 0; j < num_of_frames; j++)
            {
                tmp.Add(
                    current_angles[i]
                        + (target_angles[i] - current_angles[i]) * j / (num_of_frames - 1)
                );
            }

            trajList.Add(tmp);
        }
        yield return StartCoroutine(ExecuteTrajectory(trajList));
        _currentState = State.finished;
    }

    public IEnumerator MoveStartEndJointSpacePositionCubicTrajectory(
        List<float> start_angles,
        List<float> target_angles,
        float second
    )
    {
        List<float> current_angles = start_angles;
        List<List<float>> trajList = new List<List<float>>();
        int num_of_frames = (int)(second / fs);

        float[] a0 = new float[dof];
        float[] a1 = new float[dof];
        float[] a2 = new float[dof];
        float[] a3 = new float[dof];

        for (int i = 0; i < dof; i++)
        {
            a0[i] = current_angles[i];
            a1[i] = 0;
            a2[i] = 3 * (target_angles[i] - a0[i]) * (1 / (second * second));
            a3[i] = -2 * (target_angles[i] - a0[i]) * (1 / (second * second * second));
        }

        for (int i = 0; i < dof; i++)
        {
            List<float> tmp = new List<float>();
            for (int j = 0; j < num_of_frames; j++)
            {
                double t = (double)j / (num_of_frames - 1) * second;
                tmp.Add((float)(a0[i] + a1[i] * t + a2[i] * t * t + a3[i] * t * t * t));
            }
            trajList.Add(tmp);
        }
        yield return StartCoroutine(ExecuteTrajectory(trajList));
        _currentState = State.finished;
    }

    public IEnumerator MoveToTargetJointSpacePositionCubicTrajectory(
        List<float> target_angles,
        float second
    )
    {
        List<float> current_angles = _robotController.GetJointAngles();
        yield return StartCoroutine(
            MoveStartEndJointSpacePositionCubicTrajectory(current_angles, target_angles, second)
        );
    }

    public IEnumerator MoveToTargetTaskSpacePositionLinearTrajectory(
        List<float> target_position,
        float second
    )
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
            Vector<float> taskSpacePosition =
                currentVector
                + (targetVector - currentVector) * (float)j * (1 / (float)(num_of_frames - 1));
            float[] taskSpacePositionArray = new float[dof];
            taskSpacePosition.CopyTo(taskSpacePositionArray);
            List<float> taskSpacePositionList = new List<float>(taskSpacePositionArray);
            List<float> jointAngles = SimulationInverseKinematicsOpenManipulatorPro3DOF(
                taskSpacePositionList
            );

            // Add the calculated joint angles to the corresponding joint's list
            for (int k = 0; k < dof; k++)
            {
                trajList[k].Add(jointAngles[k]); // Add the angle for each joint
            }
        }

        yield return StartCoroutine(ExecuteTrajectory(trajList));
        _currentState = State.finished;
    }

    public IEnumerator MoveToTargetTaskSpacePositionCubicTrajectory3DOF(
        List<float> target_position,
        float second
    )
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
            List<float> jointAngles = SimulationInverseKinematicsOpenManipulatorPro3DOF(posList);
            // Add the calculated joint angles to the corresponding joint's list
            for (int k = 0; k < dof; k++)
            {
                trajList[k].Add(jointAngles[k]); // Add the angle for each joint
            }
        }

        yield return StartCoroutine(ExecuteTrajectory(trajList));
        _currentState = State.finished;
    }

    public IEnumerator MoveToTargetTaskSpacePositionCubicTrajectory6DOF(
        List<float> target_position,
        float second
    )
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
            List<float> jointAngles = SimulationInverseKinematicsOpenManipulatorPro3DOF(posList);
            // Add the calculated joint angles to the corresponding joint's list
            for (int k = 0; k < dof; k++)
            {
                trajList[k].Add(jointAngles[k]); // Add the angle for each joint
            }
        }

        yield return StartCoroutine(ExecuteTrajectory(trajList));
        _currentState = State.finished;
    }


    public IEnumerator ExecuteTrajectory(List<List<float>> trajList)
    {
        // timer
        for (int i = 0; i < trajList[0].Count; i++)
        {
            List<float> angles = new List<float>();
            for (int j = 0; j < trajList.Count; j++)
            {
                angles.Add(trajList[j][i]);
            }
            // Debug.Log("Angles at frame " + i + ": " + string.Join(", ", angles));

            _robotController.SetCmdJointAngles(angles);
            _robotController.SendCmdToRobot(fs);

            // _robotClient.SendJointCmdDirect(angles, fs);

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

    public void SetFinish()
    {
        _currentState = State.finished;
    }

    public void StopActions()
    {
        // Stop the current action and clear the action queue
        actionQueue.Clear();
        SetFinish();

        // Stop the currently running coroutine if it exists
        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
            currentCoroutine = null; // Clear the reference
        }
    }

    // return to init
    // go to certain position linear
    // go to certain position cubic
    // follow a trajectory
    // wait for x seconds
}
