using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using System.Threading;

public class LessonRobotControl : MonoBehaviour
{
    public RobotController _robotController;
    public StaticRobotTrajectoryController _trajController;
    public GeneralRobotControl _generalRobotControl;
    public GeneralAudioControl _generalAudioControl;
    public GeneralVisualControl _generalVisualControl;
    public AudioClip audio1;
    [SerializeField] private AudioClip[] audio_list;
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
        timeline = transform.Find("Lesson Timeline")?.GetComponent<PlayableDirector>();
        timeline.Pause();
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
        bool debug = true;
        _generalRobotControl._currentState = GeneralRobotControl.State.init;

        if (!debug)
        {
            // first action: move to initial position
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.Move_to_Initial_Position);
            // second action: wait for 1 second
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[0], 1.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(audio_list[0].length));



            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { -30, 0, 0, 0, 0, 0 }, 0.3f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 30, 0, 0, 0, 0, 0 }, 0.6f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, 0.4f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(0.4f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PauseAudio());

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, -20, 0, 0, 0, 0 }, 0.4f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 20, 0, 0, 0, 0 }, 0.7f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, 0.5f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(0.4f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.ResumeAudio());


            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, -30, 0, 0, 0 }, 0.3f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 30, 0, 0, 0 }, 0.6f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, 0.4f));

            // _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[1], 1.0f));
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(audio_list[1].length));

            List<List<float>> TaskTrajList2 = HardcodeTrajectory_task_space_semicircle(3);
            List<List<float>> JointTrajList2 = _generalRobotControl.SolveTaskSpaceTrajectories(TaskTrajList2);

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Task_Space_Position_Cubic_Trajectory(new List<float> { TaskTrajList2[0][0], TaskTrajList2[0][1], TaskTrajList2[0][2], 0 ,0 ,0 }, 1.0f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DrawTrajectory(TaskTrajList2));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectoryWithDelay(JointTrajList2));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Task_Space_Position_Cubic_Trajectory(new List<float> { 20, 20, 10, 0, 0, 0 }, 3f));
            List<List<float>> TaskTrajList0 = HardcodeTrajectory_task_space2(3);
            List<List<float>> JointTrajList0 = _generalRobotControl.SolveTaskSpaceTrajectories(TaskTrajList0);

            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DrawTrajectory(TaskTrajList0));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectoryWithDelay(JointTrajList0));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.Move_to_Initial_Position);

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[2], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(audio_list[2].length));

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 40, 0, 0, 0, 0, 0 }, 1f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 40, 40, 0, 0, 0, 0 }, 1f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 40, 40, 40, 0, 0, 0 }, 1f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 0, 0, 0, 0, 0, 0 }, 1f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[3], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(audio_list[3].length));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[4], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(audio_list[4].length));
        }
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Task_Space_Position_Cubic_Trajectory(new List<float> { -30, 20, 10, 0, 0, 0 }, 3f));

        List<List<float>> TaskTrajList = HardcodeTrajectory_task_space(3);
        List<List<float>> JointTrajList = _generalRobotControl.SolveTaskSpaceTrajectories(TaskTrajList);

        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DrawTrajectory(TaskTrajList));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());

        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectoryWithDelay(JointTrajList));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

        // audio

        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[0], image_size_list[0]));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(true));

        //audio
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1f));

        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[1], image_size_list[1]));
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Joint_Space_Position_Cubic_Trajectory(new List<float> { 50, 0, 10, 0, 0, 0 }, 1.0f));

        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1f));

        List<List<float>> jointTrajList = HardcodeTrajectory_joint_space(3);
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectoryWithDelay(jointTrajList));
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
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.HideTraj());

        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.Move_to_Initial_Position);
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetGameObjectActive(menu, true));


        _generalRobotControl._currentState = GeneralRobotControl.State.ready;
    }

    void OnEnable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
            // Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2") + " seconds");
        }
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

/* 1.	(Show robot arm with the first servo joint 35 deg, the second joint 50 deg, the last joint 15 deg, show menu additionally)
 
2.	(Show robot arm follow joint-space trajectory of: A:(0,30,60) B:(-15,20,40), t=2)
 
3.	(Show rotation of first joint servo rotating from 0 to 90 degrees, highlight angle if possible)
 
4.	(Users command first servo angle from 30 degrees to 60 degrees)
 
5.	(Users command second servo angle from 15 to 45 degrees, third servo angle from 60 to 90)
 
6.	(Show axis with first servo as origin with numbers on surface if possible)
 
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