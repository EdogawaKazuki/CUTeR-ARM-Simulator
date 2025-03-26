using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class IntroductionTrajectorySelfLearning : MonoBehaviour
{
    public RobotController _robotController;
    public StaticRobotTrajectoryController _trajController;
    public GeneralRobotControl _generalRobotControl;
    public GeneralAudioControl _generalAudioControl;
    public GeneralVisualControl _generalVisualControl;
    public GeneralInteractiveControl _generalInteractiveControl;

    [SerializeField]
    private AudioClip[] audio_list;

    [SerializeField]
    private Texture2D[] texture_list;
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
        Button startButton = transform
            .Find("Menu/MenuContainer/Start Button")
            ?.GetComponent<Button>();
        startButton?.onClick.AddListener(OnClickStart);
        Button returnButton = transform
            .Find("return")
            ?.GetComponent<Button>();
        returnButton?.onClick.AddListener(OnClickReturn);
        transform.Find("return").gameObject.SetActive(false);
        //_generalRobotControl = GameObject.Find("../..").GetComponent<GeneralRobotControl>();
        image_sprite_list = _generalVisualControl.ConvertToSpriteList(texture_list);
        image_size_list = _generalVisualControl.FindTextureSizeList(texture_list);
    }
    void OnClickReturn()
    {
        elapsedTime = 0f; // Reset elapsed time
        isTimerRunning = false; // Stop the timer
        _generalRobotControl.StopActions();
        _generalAudioControl.StopAudio();
        _generalVisualControl.SetImageStatus(false);
        _generalVisualControl.CloseAllGraphs();
        _generalVisualControl.ClearPoints();
        _generalVisualControl.HideTraj();
        _generalInteractiveControl.DisableMC();
        _generalVisualControl.SetTaskSpaceStatDisplayLatexVisibility(false);
        _generalVisualControl.SetTaskSpaceStatDisplayVisibility(false);
        _generalVisualControl.SetJointSpaceStatDisplayLatexVisibility(false);
        _generalVisualControl.SetJointSpaceStatDisplayVisibility(false);

        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        GameObject menu = transform.Find("Menu")?.gameObject;
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGameObjectActive(menu, true)
        );
        transform.Find("return").gameObject.SetActive(false);
    }

    void OnClickStart()
    {
        // _generalAudioControl.audioSource.PlayOneShot(audio1, 1.0f);
        // timeline.Play();
        GameObject menu = transform.Find("Menu")?.gameObject;
        menu.SetActive(false);
        GameObject returnButton = transform.Find("return").gameObject;
        returnButton.SetActive(true);
        _generalVisualControl.SetTaskSpaceStatDisplayVisibility(false);
        //_generalRobotControl.RobotAction();
        // _generalRobotControl.Move_to_Initial_Position();

        // Start the timer
        isTimerRunning = true;
        elapsedTime = 0f;
        bool debug = false;
        bool skip_audio = true;
        _generalAudioControl.skip_audio = skip_audio;

        _generalRobotControl._currentState = GeneralRobotControl.State.init;

        // _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToTargetJointSpacePositionLinearTrajectory());
        if (!debug)
        {
            // first action: move to initial position
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.StartLesson);
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[0], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[0].length));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[1], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[1].length));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[2], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetJointSpaceStatDisplayVisibility(true));
            // Move each joint and return
            for (int joint = 0; joint < dof; joint++)
            {
                List<float> startPos = new List<float>(new float[6]); // [0,0,0,0,0,0]
                List<float> movedPos = new List<float>(new float[6]); // [0,0,0,0,0,0]
                movedPos[joint] = 20f; // Only set starting joint to 20
                // Move joint forward
                _generalRobotControl.actionQueue.Enqueue(
                    () =>
                        _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                            startPos,
                            movedPos,
                            0.75f
                        )
                );

                // Return joint back
                _generalRobotControl.actionQueue.Enqueue(
                    () =>
                        _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                            movedPos,
                            startPos,
                            0.75f
                        )
                );
            }

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[2].length - 24.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetJointSpaceStatDisplayVisibility(false));
            // show revolute image
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetImage(image_sprite_list[0], image_size_list[0])
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(true));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(5.5f));
            // show prismatic image
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetImage(image_sprite_list[1], image_size_list[1])
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(5.5f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(false));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[3], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[3].length));

            // Show some vector
            /* _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetImage(image_sprite_list[2], image_size_list[2])
            );*/

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[4], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(6.0f));
            /* _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetImage(image_sprite_list[3], image_size_list[3])
            ); */
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetJointSpaceStatDisplayLatexVisibility(true));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[4].length - 6.0f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[5], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[5].length / 2 + 2.0f));

            // audio for translational and rotational dof

            // audio for Joint Space
            // display Image 1 on Configuration
            // audio for Arm Configuration
            // audio for Example
            // display Image 2 for [30, 0, 0, 0, 0, 0] Configuration
            // Move First Joint to 30 degrees
            /* _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetImage(image_sprite_list[4], image_size_list[4])
            );*/
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        new List<float> { 50, 0, 0, 0, 0, 0 },
                        3.0f
                    )
            );

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[5].length / 2 - 5.0f));
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetJointSpaceStatDisplayLatexVisibility(false));

            // audio for task space
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[6], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { 50, 0, 0, 0, 0, 0 },
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        2.0f
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[6].length - 2.0f));

            // show vector
            // move arm to init pos for next motion
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[7], 1.0f));
            // wait audio adjusted to the use in prepare time

            // display vector representation of task space
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetTaskSpaceStatDisplayLatexVisibility(true));
            // audio for task space part 2
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(3.5f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[7].length - 3.5f));


            // demonstration of 6 dofs
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[8], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(4.0f));

            // Move Along X-Axis
            List<List<float>> TaskTrajList2 = MoveAlongXAxis(10);
            List<List<float>> JointTrajList2 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList2
            );

            // Move to the start position of the next set of movements
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        new List<float>
                        {
                            JointTrajList2[0][0],
                            JointTrajList2[1][0],
                            JointTrajList2[2][0],
                            JointTrajList2[3][0],
                            JointTrajList2[4][0],
                            JointTrajList2[5][0],
                        },
                        5.0f
                    )
            );

            // FOR DEBUG FK IK ONLY
            // List<List<float>> TaskTrajList2_Debug =
            //     _generalRobotControl.SolveJointSpaceTrajectories(JointTrajList2);


            // Move along X-axis
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.DrawTrajectory(TaskTrajList2)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(JointTrajList2)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            // Move along Y-axis
            List<List<float>> TaskTrajList3 = MoveAlongYAxis(3);
            List<List<float>> JointTrajList3 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList3
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.DrawTrajectory(TaskTrajList3)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(JointTrajList3)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(0.3f));
            // Move along Z-axis
            List<List<float>> TaskTrajList4 = MoveAlongZAxis(3);
            List<List<float>> JointTrajList4 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList4
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.DrawTrajectory(TaskTrajList4)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(JointTrajList4)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            // Rotate along X-axis
            List<List<float>> TaskTrajList5 = RotateAlongXAxis(3);
            List<List<float>> JointTrajList5 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList5
            );
            // move arm to pos for x-axis rotation
            int last_index = JointTrajList4[0].Count - 1;
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        ExtractTrajPos(JointTrajList4, last_index),
                        ExtractTrajPos(JointTrajList5, 0),
                        1.0f
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(JointTrajList5)
            );

            // Rotate along Y-axis
            List<List<float>> TaskTrajList6 = RotateAlongYAxis(3);
            List<List<float>> JointTrajList6 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList6
            );
            // move arm to pos for y-axis rotation
            last_index = JointTrajList5[0].Count - 1;
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        ExtractTrajPos(JointTrajList5, last_index),
                        ExtractTrajPos(JointTrajList6, 0),
                        2.0f
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(JointTrajList6)
            );

            // Rotate along Z-axis
            List<List<float>> TaskTrajList7 = RotateAlongZAxis(3);
            List<List<float>> JointTrajList7 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList7
            );
            last_index = JointTrajList6[0].Count - 1;
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        ExtractTrajPos(JointTrajList6, last_index),
                        ExtractTrajPos(JointTrajList7, 0),
                        1.0f
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(JointTrajList7)
            );

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[9], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[9].length - 3));



            IEnumerator DisableTaskSpaceStatDisplay()
            {
                _generalVisualControl.SetTaskSpaceStatDisplayLatexVisibility(false);
                _generalVisualControl.SetTaskSpaceStatDisplayVisibility(false);
                return null;
            }
            _generalRobotControl.actionQueue.Enqueue(
                    () => DisableTaskSpaceStatDisplay()
            );


            // MC for features of Joint and Task Space
            int correctOption = 0;
            List<string> textList = new List<string>
            {
                "What are the benefits of using Joint Space Control? \n     I. Simple calculation and implementation \n     II. Intuitive control on end-effector \n     III. Precise joints movement \n     IV. Direct interaction with environment",
                "I and II",
                "I and III",
                "II and III",
                "II and IV",
            };

            _generalRobotControl.actionQueue.Enqueue(
                () => _generalInteractiveControl.SetMCWithAnswer(textList, correctOption)
            );

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[10], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[10].length - 1));


            // MC for features of Joint and Task Space
            int correctOption1 = 2;
            List<string> textList1 = new List<string>
            {
                "What are the benefits of using Task Space Control? \n     I. Simple calculation and implementation \n     II. Intuitive control on end-effector \n     III. Precise joints movement \n     IV. Direct interaction with environment",
                "I and II",
                "I and III",
                "II and III",
                "II and IV",
            };

            _generalRobotControl.actionQueue.Enqueue(
                () => _generalInteractiveControl.SetMCWithAnswer(textList1, correctOption1)
            );

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[11], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(3));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                            ExtractTrajPos(JointTrajList7, last_index),
                            new List<float> { 0, 0, 45, 0, 0, 0 },
                            2.0f
                        ));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                           new List<float> { 0, 0, 45, 0, 0, 0 },
                           new List<float> { 40, 0, 45, 0, 0, 0 },
                           2.0f
                       ));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                new List<float> { 40, 0, 45, 0, 0, 0 },
                new List<float> { -40, 0, 45, 0, 0, 0 },
                4.0f
            ));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                new List<float> { -40, 0, 45, 0, 0, 0 },
                new List<float> { 0, 0, 45, 0, 0, 0 },
                2.0f
            ));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[11].length + 1 - 13));


            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[12], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(3));
            List<List<float>> TaskTrajList8 = TaskSpaceDemo(4);
            List<List<float>> JointTrajList8 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList8
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { 0, 0, 45, 0, 0, 0 },
                        ExtractTrajPos(JointTrajList8, 0),
                        2.0f
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(
                    () => _generalVisualControl.DrawTrajectory(TaskTrajList8)
                );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(JointTrajList8)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2));
            List<List<float>> reversedJointTrajList8 = _generalRobotControl.SolveTaskSpaceTrajectories(
                TaskTrajList8
            );
            for (int i = 0; i < reversedJointTrajList8.Count; i++)
            {
                reversedJointTrajList8[i].Reverse();
            }
            List<List<float>> reversedTaskTrajList8 = new List<List<float>>(TaskTrajList8);
            reversedTaskTrajList8.Reverse();
            _generalRobotControl.actionQueue.Enqueue(
                    () => _generalVisualControl.DrawTrajectory(reversedTaskTrajList8)
                );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalRobotControl.ExecuteTrajectory(reversedJointTrajList8)
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[12].length - 15));

            // _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.DisableMC());


            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(false));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.CloseAllGraphs());
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.HideTraj());
            _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.DisableMC());

            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalVisualControl.SetGameObjectActive(menu, true)
            );
            IEnumerator ResetTaskSpaceStatDisplay()
            {
                _generalVisualControl.SetTaskSpaceStatDisplayLatexVisibility(false);
                _generalVisualControl.SetTaskSpaceStatDisplayVisibility(false);
                return null;
            }
            _generalRobotControl.actionQueue.Enqueue(
                    () => ResetTaskSpaceStatDisplay()
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                {
                    transform.Find("return").gameObject.SetActive(false);
                    return null;
                }
            );
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.EndLesson);
            _generalRobotControl._currentState = GeneralRobotControl.State.ready;
        }
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

    public List<float> ExtractTrajPos(List<List<float>> TrajList, int index)
    {
        return new List<float>
        {
            TrajList[0][index],
            TrajList[1][index],
            TrajList[2][index],
            TrajList[3][index],
            TrajList[4][index],
            TrajList[5][index],
        };
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

    public List<List<float>> TaskSpaceDemo(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j <= num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the parabolic trajectory in task space
            float x = 0;
            float y = 15f + 23f * j / num_of_frames;
            float z = 13f;
            float tx = 0 + -Mathf.PI / 2 * j / num_of_frames;

            taskSpacePosition = new List<float> { x, y, z, -Mathf.PI / 2, 0, 0 };
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> RotateAlongXAxis(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j <= num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the straight line in x-axis in task space
            float x = 0f;
            float y = 20f;
            float z = 10f;
            float angle = (float)j / num_of_frames * Mathf.PI * 4;
            float alpha = -0.2f + Mathf.PI / 6 * Mathf.Sin(angle);

            taskSpacePosition = new List<float> { x, y, z, alpha - Mathf.PI / 2, 0, 0 };
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> RotateAlongYAxis(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j <= num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the straight line in x-axis in task space
            float x = 0f;
            float y = 30f;
            float z = 20f;
            float angle = (float)j / num_of_frames * Mathf.PI * 2;
            float alpha = Mathf.PI / 3 * Mathf.Cos(angle);

            taskSpacePosition = new List<float> { x, y, z, -Mathf.PI / 2, alpha, 0 };
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> RotateAlongZAxis(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j <= num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the straight line in x-axis in task space
            float x = 0f;
            float y = 30f;
            float z = 20f;
            float angle = (float)j / num_of_frames * Mathf.PI * 4;
            float alpha = Mathf.PI / 6 * Mathf.Sin(angle);

            taskSpacePosition = new List<float> { x, y, z, -Mathf.PI / 2, 0, alpha };
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> MoveAlongXAxis(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j <= num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the straight line in x-axis in task space
            float x;
            float y = 20f;
            float z = 10f;

            if (j < num_of_frames / 4)
                x = 30f * j / num_of_frames * 4;
            else if (j < num_of_frames * 3f / 4f)
                x = 30 - 60f * (j - num_of_frames / 4f) / num_of_frames * 2;
            else
                x = -30 + 30f * (j - num_of_frames * 3f / 4) / num_of_frames * 4;

            taskSpacePosition = new List<float> { x, y, z, -Mathf.PI / 2, 0, 0 };
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> MoveAlongYAxis(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j <= num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the straight line in x-axis in task space
            float x = 0f;
            float y;
            float z = 10f;

            if (j < num_of_frames / 2)
                y = 20 + 25f * j / num_of_frames * 2;
            else
                y = 45 - 25f * (j - num_of_frames / 2f) / num_of_frames * 2;

            taskSpacePosition = new List<float> { x, y, z, -Mathf.PI / 2, 0, 0 };
            trajList.Add(taskSpacePosition);
        }
        return trajList;
    }

    public List<List<float>> MoveAlongZAxis(float seconds)
    {
        int num_of_frames = (int)(seconds / _generalRobotControl.fs);
        List<List<float>> trajList = new List<List<float>>();

        for (int j = 0; j <= num_of_frames; j++)
        {
            List<float> taskSpacePosition;
            // Define the straight line in x-axis in task space
            float x = 0f;
            float y = 20f;
            float z;

            if (j < num_of_frames / 2f)
            {
                z = 10 + 25f * j / num_of_frames * 2;
            }
            else
            {
                z = 35 - 25f * (j - num_of_frames / 2f) / num_of_frames * 2;
            }

            taskSpacePosition = new List<float> { x, y, z, -Mathf.PI / 2, 0, 0 };
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
