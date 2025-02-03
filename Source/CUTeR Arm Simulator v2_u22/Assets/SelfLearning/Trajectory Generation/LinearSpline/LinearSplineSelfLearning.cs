using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class LinearSplineSelfLearning : MonoBehaviour
{
    public RobotController _robotController;
    public StaticRobotTrajectoryController _trajController;
    public GeneralRobotControl _generalRobotControl;
    public GeneralAudioControl _generalAudioControl;
    public GeneralVisualControl _generalVisualControl;
    private AudioClip[] audio_list;

    [SerializeField] private Texture2D[] texture_list;
    private List<Sprite> image_sprite_list = new List<Sprite>();
    private List<Vector2> image_size_list = new List<Vector2>();
    PlayableDirector timeline;

    int dof = 6;
    private float elapsedTime = 0f;
    private bool isTimerRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        // timeline = transform.Find("Lesson Timeline")?.GetComponent<PlayableDirector>();
        // timeline.Pause();
        Button startButton = transform.Find("Menu/MenuContainer/Start Button")?.GetComponent<Button>();
        startButton?.onClick.AddListener(OnClickStart);
        //_generalRobotControl = GameObject.Find("../..").GetComponent<GeneralRobotControl>();
        image_sprite_list = _generalVisualControl.ConvertToSpriteList(texture_list);
        image_size_list = _generalVisualControl.FindTextureSizeList(texture_list);
    }

    void OnClickStart()
    {
        // _generalAudioControl.audioSource.PlayOneShot(audio1, 1.0f);
        // timeline.Play();
        GameObject menu = transform.Find("Menu")?.gameObject;
        menu.SetActive(false);
        //_generalRobotControl.RobotAction();
        // Thread.Sleep(3000);
        // _generalRobotControl.Move_to_Initial_Position();

        // Start the timer
        isTimerRunning = true;
        elapsedTime = 0f;
        bool debug = false;
        bool skip_audio = true;
        _generalAudioControl.skip_audio = skip_audio;

        _generalRobotControl._currentState = GeneralRobotControl.State.init;

        if (!debug)
        {
            // first action: move to initial position
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
            // // second action: wait for 1 second
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[0], 1.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[0].length));


            // // oscillate 3 joints to show dof
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_Start_End_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, new List<float> { -30, 0, 0, 0, 0, 0 }, 3.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_Start_End_Joint_Space_Position_Cubic_Trajectory(new List<float> { -30, 0, 0, 0, 0, 0 },new List<float> { 30, 0, 0, 0, 0, 0 }, 3.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_Start_End_Joint_Space_Position_Cubic_Trajectory(new List<float> { 30, 0, 0, 0, 0, 0 }, new List<float> { 0, 0, 0, 0, 0, 0 }, 3.0f));

            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(0.4f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PauseAudio());

            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_Start_End_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, new List<float> { 0, -20, 0, 0, 0, 0 }, 4.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_Start_End_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, -20, 0, 0, 0, 0 }, new List<float> { 0, 20, 0, 0, 0, 0 }, 7.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_Start_End_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 20, 0, 0, 0, 0 }, new List<float> { 0, 0, 0, 0, 0, 0 }, 5.0f));


            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(0.4f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.ResumeAudio());


            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, -30, 0, 0, 0 }, 0.3f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 30, 0, 0, 0 }, 0.6f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, 0.4f));

            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[1], 1.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[1].length));

            // compute task space semi-circle trajectories
            List<List<float>> TaskTrajList2 = HardcodeTrajectory6DOFSemicircle(10);
            List<List<float>> JointTrajList2 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList2
            );
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_Start_End_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, new List<float> { JointTrajList2[0][0], JointTrajList2[1][0], JointTrajList2[2][0], 0 ,0 ,0 }, 3.0f));

            // Draw and command trajectories
            List<List<float>> TaskTrajList2_Debug =
                _generalRobotControl.SolveJointSpaceTrajectories(JointTrajList2);
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.DrawTrajectory(TaskTrajList2_Debug)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectoryWithDelay(JointTrajList2)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            // compute task space  linear trajectories
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1.0f));
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveToTargetTaskSpacePositionCubicTrajectory3DOF(
                        new List<float> { 20, 20, 10, 0, 0, 0 },
                        3f
                    )
            );
            List<List<float>> TaskTrajList0 = HardcodeTrajectory_task_space2(3);
            List<List<float>> JointTrajList0 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList0
            );

            // Draw and command trajectories
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.DrawTrajectory(TaskTrajList0)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectoryWithDelay(JointTrajList0)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            // Move to initial position
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);

            // Content of Joint Trajectories
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.PlayAudioInstant(audio_list[2], 1.0f)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.Wait(audio_list[2].length)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(
                        new List<float> { 90, 0, 0, 0, 0, 0 },
                        1f
                    )
            );

            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.PlayAudioInstant(audio_list[3], 1.0f)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.Wait(audio_list[3].length)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(
                        new List<float> { 90, 45, 0, 0, 0, 0 },
                        1f
                    )
            );

            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.PlayAudioInstant(audio_list[4], 1.0f)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.Wait(audio_list[4].length)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(
                        new List<float> { 90, 45, 45, 0, 0, 0 },
                        1f
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        1f
                    )
            );

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1f));

            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.PlayAudioInstant(audio_list[5], 1.0f)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.Wait(audio_list[5].length)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.PlayAudioInstant(audio_list[6], 1.0f)
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalAudioControl.Wait(audio_list[6].length)
            );
        }

        List<float> YList = new List<float>();
        List<float> XList = new List<float>();
        ComputeGraphValue(out XList, out YList);
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.PlotGraph(YList, name = "Graph1")
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGraphTitle("Graph1", "Joint Velocity")
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGraphStatus("Graph1", true)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.PlotGraph(XList, name = "Graph2")
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGraphStatus("Graph2", true)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.PlotGraph(YList, name = "Graph3")
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGraphStatus("Graph3", true)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.PlotGraph(XList, name = "Graph4")
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGraphStatus("Graph4", true)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.PlotGraph(YList, name = "Graph5")
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGraphStatus("Graph5", true)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.PlotGraph(XList, name = "Graph6")
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGraphStatus("Graph6", true)
        );

        _generalRobotControl.actionQueue.Enqueue(
            () =>
                _generalRobotControl.MoveToTargetTaskSpacePositionCubicTrajectory3DOF(
                    new List<float> { -30, 20, 10, 0, 0, 0 },
                    3f
                )
        );

        List<List<float>> TaskTrajList = HardcodeTrajectory_task_space(3);
        List<List<float>> JointTrajList = _generalRobotControl.SolveTaskSpaceTrajectories(
            TaskTrajList
        );

        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.DrawTrajectory(TaskTrajList)
        );
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());

        _generalRobotControl.actionQueue.Enqueue(
            () => _generalRobotControl.ExecuteTrajectoryWithDelay(JointTrajList)
        );
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

        // audio
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.PlayAudioInstant(audio_list[7], 1.0f)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetImage(image_sprite_list[0], image_size_list[0])
        );
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(true));
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.Wait(audio_list[7].length)
        );

        //audio
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1f));
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.PlayAudioInstant(audio_list[8], 1.0f)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetImage(image_sprite_list[1], image_size_list[1])
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.Wait(audio_list[8].length)
        );

        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetImage(image_sprite_list[2], image_size_list[2])
        );

        _generalRobotControl.actionQueue.Enqueue(
            () =>
                _generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(
                    new List<float> { 30, 0, 0, 0, 0, 0 },
                    1.0f
                )
        );

        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.PlayAudioInstant(audio_list[9], 1.0f)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.Wait(audio_list[9].length)
        );
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1f));

        List<List<float>> jointTrajList = HardcodeTrajectory_joint_space(3);
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalRobotControl.ExecuteTrajectoryWithDelay(jointTrajList)
        );

        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.PlayAudioInstant(audio_list[10], 1.0f)
        );
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalAudioControl.Wait(audio_list[10].length)
        );
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1f));
        // List<List<float>> TaskTrajList2 = HardcodeTrajectory_task_space_semicircle(3);
        // List<List<float>> JointTrajList2 = _generalRobotControl.SolveTaskSpaceTrajectories(TaskTrajList2);

        // _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DrawTrajectory(TaskTrajList2));
        // _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj(false));
        // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectoryWithDelay(JointTrajList2));

        // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1.0f));
        // _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.HideTraj());
        // third action: execute robot action
        // _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.RobotAction1);
        // fourth action: execute robot action reverse
        // _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.RobotAction2);
        // fifth action: move to initial position

        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(false));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.CloseAllGraphs());
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.HideTraj());

        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGameObjectActive(menu, true)
        );

        _generalRobotControl._currentState = GeneralRobotControl.State.ready;
    }

    void OnEnable() { }

    // Update is called once per frame
    void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
            // Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2") + " seconds");
        }
    }

    public void ComputeGraphValue(out List<float> XList, out List<float> YList)
    {
        XList = new List<float>();
        YList = new List<float>();
        for (int i = -10; i <= 10; i++)
        {
            float x = i;
            float y = x * x;
            YList.Add(y);
            XList.Add(x);
        }
    }

    public List<List<float>> Debug6DOF(float seconds)
    {
        // zero pos: 0, 27.83, 71.37, 0.785, 0, 0
        // leftmost zero pos: 27.83, 0, 71.37, 0.785, 0, PI/2
        // zero horizontal pos: 0, 31.43, 62.57, 0, 0, 0
        // slash vertical pos: -13.59, 13.62, 74.97, PI, 0, 0 --> 45, 0, 0, 0, -45, 45
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();
        // for (int i = 0; i < dof; i++)
        // {
        //     trajList.Add(new List<float>());
        // }
        for (int j = 0; j < num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the circular trajectory in task space
            float angle = (float)j / (num_of_frames - 1) * Mathf.PI; // Calculate the angle for each frame
            float x = 10f; // Calculate x position on the circle
            float y = 31.43f; // Fixed y position
            float z = 62.57f; // Calculate z position on the circle
            taskSpacePosition = new List<float> { x, y, z, Mathf.PI / 2, 0, 0 };
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> HardcodeTrajectory6DOFSemicircle(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();
        // for (int i = 0; i < dof; i++)
        // {
        //     trajList.Add(new List<float>());
        // }
        for (int j = 0; j < num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the circular trajectory in task space
            float angle = (float)j / (num_of_frames - 1) * Mathf.PI; // Calculate the angle for each frame
            float x = 10f * Mathf.Cos(angle); // Calculate x position on the circle
            float y = 20f; // Fixed y position
            float z = 30f + 10f * Mathf.Sin(angle); // Calculate z position on the circle
            taskSpacePosition = new List<float> { x, y, z, 0, 0, 0 };
            trajList.Add(taskSpacePosition);
            // // Use inverse kinematics to find the joint angles for the current task space position
            // List<float> jointAngles = _generalRobotControl.InverseKinematicsOpenManipulatorPro3DOF(taskSpacePosition);
            // // Add the calculated joint angles to the corresponding joint's list
            // for (int k = 0; k < dof; k++)
            // {
            //     trajList[k].Add(jointAngles[k]); // Add the angle for each joint
            // }
        }
        return trajList;
    }

    public List<List<float>> HardcodeTrajectory_task_space_semicircle(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();
        // for (int i = 0; i < dof; i++)
        // {
        //     trajList.Add(new List<float>());
        // }
        for (int j = 0; j < num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the circular trajectory in task space
            float angle = (float)j / (num_of_frames - 1) * Mathf.PI; // Calculate the angle for each frame
            float x = 10f * Mathf.Cos(angle); // Calculate x position on the circle
            float y = 20f; // Fixed y position
            float z = 30f + 10f * Mathf.Sin(angle); // Calculate z position on the circle
            taskSpacePosition = new List<float> { x, y, z };
            trajList.Add(taskSpacePosition);
            // // Use inverse kinematics to find the joint angles for the current task space position
            // List<float> jointAngles = _generalRobotControl.InverseKinematicsOpenManipulatorPro3DOF(taskSpacePosition);
            // // Add the calculated joint angles to the corresponding joint's list
            // for (int k = 0; k < dof; k++)
            // {
            //     trajList[k].Add(jointAngles[k]); // Add the angle for each joint
            // }
        }
        return trajList;
    }

    public List<List<float>> HardcodeTrajectory_task_space(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j < num_of_frames; j++)
        {
            List<float> taskSpacePosition;

            // Define the trajectory in task space
            // float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
            float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
            float y = 20f; // Fixed y position
            float z = Mathf.Lerp(10, 40, (float)j / (num_of_frames - 1)); // Fixed z position

            // float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
            // float y = 25; // Fixed y position
            // float z = 50 +  10 * (((float) j / (num_of_frames - 1))); // Fixed z position

            taskSpacePosition = new List<float> { x, y, z };

            // Add the calculated joint angles to the corresponding joint's list
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> HardcodeTrajectory_task_space2(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j < num_of_frames; j++)
        {
            List<float> taskSpacePosition;

            // Define the trajectory in task space
            // float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
            float x = Mathf.Lerp(20, -30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
            float y = Mathf.Lerp(20, 40, (float)j / (num_of_frames - 1)); // Fixed y position
            float z = Mathf.Lerp(10, 40, (float)j / (num_of_frames - 1)); // Fixed z position

            // float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
            // float y = 25; // Fixed y position
            // float z = 50 +  10 * (((float) j / (num_of_frames - 1))); // Fixed z position

            taskSpacePosition = new List<float> { x, y, z };

            // Add the calculated joint angles to the corresponding joint's list
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> HardcodeTrajectory_joint_space(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < dof; i++)
        {
            trajList.Add(new List<float>());
        }
        for (int j = 0; j < num_of_frames; j++)
        {
            List<float> jointSpacePosition;

            // Define the trajectory in task space
            // float x = Mathf.Lerp(-30, 30, (float)j / (num_of_frames - 1)); // Linearly interpolate x from -30 to 30
            float theta1 = Mathf.Lerp(50, -50, (float)j / (num_of_frames - 1)); // Linearly interpolate theta1 from -30 to 30
            float theta2 = Mathf.Lerp(0, -40, (float)j / (num_of_frames - 1)); // Linearly interpolate theta2 from 20 to 40
            float theta3 = Mathf.Lerp(10, 40, (float)j / (num_of_frames - 1)); // Linearly interpolate theta3 from 10 to 40

            jointSpacePosition = new List<float> { theta1, theta2, theta3, 0, 0, 0 };

            // Add the calculated joint angles to the corresponding joint's list
            for (int k = 0; k < dof; k++)
            {
                trajList[k].Add(jointSpacePosition[k]);
            }
        }
        return trajList;
    }
}

/* 1.	Oscillate 3 robot joints sequentially
 
2.	(Show robot arm follow joint-space trajectory of: A:(0,30,60) B:(-15,20,40), t=2)
 
3.	(Show rotation of first joint servo rotating from 0 to 90 degrees, second servo from 0 to 45 degrees, third servo from 0 to 45 degrees, highlight angle if possible)
 
4.	(Users command first servo angle from 30 degrees to 60 degrees)
   
This is only to demonstrate the task space trajectory is a linear line and follows a given straight path example.
 
7.	(Show the robot moving draw a straight line facing the surface)
Demonstrates a straight path task space trajectory facing the surface
8.	(Users command the robot arm to move by a given xyz points)
 
Exercise for user to perform a task-space trajectory by themselves
 
9.	(Show a menu-like screen to show equation)
Visualizes the equation for a single joint linear fit so that students can have easier time remembering concept
10.	(Show example of task space trajectory where velocity is constant)
 
If possible, make the end-effector facing up so it is nicer to see
 
11.	(Users Final Exercise)
Joint 1: From -90 to 0
Joint 2: From 120 to 0
Joint 3: From -150 to 0
Duration: 2 seconds
12.	(Users Ending Question: Does this motion produce a straight line in joint space?)

https://docs.google.com/document/d/15_nGFo_gMRtb2VqCSxswnaE1nPZLwKtYvh_9QX9BxHs/edit  script here
*/

/*
Direction for User Interactoin Improvment

1. User Panel Follow Camera
2. Include Slider Interaction
3. Include Keyboard Interaction
4.
*/
