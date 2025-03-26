using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using System.Threading;
using Unity.VisualScripting;
using TMPro;

public class CubicSplineSelfLearning : MonoBehaviour
{
    public RobotController _robotController;
    public StaticRobotTrajectoryController _trajController;
    public GeneralRobotControl _generalRobotControl;
    public GeneralAudioControl _generalAudioControl;
    public GeneralVisualControl _generalVisualControl;
    public GeneralInteractiveControl _generalInteractiveControl;
    [SerializeField] private AudioClip[] audio_list;
    [SerializeField] private Texture2D[] texture_list;
    private List<Sprite> image_sprite_list = new List<Sprite>();
    private List<Vector2> image_size_list = new List<Vector2>();
    PlayableDirector timeline;
    TMP_Text Text;

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

        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
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
        bool skip_audio = true;
        _generalAudioControl.skip_audio = skip_audio;

        GameObject menu = transform.Find("Menu")?.gameObject;
        menu.SetActive(false);
        GameObject returnButton = transform.Find("return").gameObject;
        returnButton.SetActive(true);

        // Start the timer
        isTimerRunning = true;
        elapsedTime = 0f;
        bool debug = false;
        _generalRobotControl._currentState = GeneralRobotControl.State.init;

        if (!debug)
        {
            // first action: move to initial position
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(1.0f));

            // Show Linear Spline Image
            /* _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[0], image_size_list[0]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(true)); */

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[0], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[0].length));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[1], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(3.0f));
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        3.0f
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[1].length - 7.0f));

            float a = 0.75f;
            List<List<float>> jointTrajList1 = LinearHardcode1(a);
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectory(jointTrajList1));
            // List<List<float>> reversedJointTrajList1 = new List<List<float>>();
            // for (int i = 0; i <= jointTrajList1.Count - 1; i++)
            // {
            //     List<float> reversedElement = new List<float>(jointTrajList1[i]);
            //     reversedElement.Reverse();
            //     reversedJointTrajList1.Add(reversedElement);
            // }
            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectory(reversedJointTrajList1));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.0f));
        
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        new List<float> { -90, 0, 0, 0, 0, 0 },
                        a
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { -90, 0, 0, 0, 0, 0 },
                        new List<float> { 90, 0, 0, 0, 0, 0 },
                        2 * a
                    )
            );
            _generalRobotControl.actionQueue.Enqueue(
                () =>
                    _generalRobotControl.MoveStartEndJointSpacePositionCubicTrajectory(
                        new List<float> { 90, 0, 0, 0, 0, 0 },
                        new List<float> { 0, 0, 0, 0, 0, 0 },
                        a
                    )
            );

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[2], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[2].length));
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
            /* _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(8.0f));

            // Show Linear Spline Cross Image
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[1], image_size_list[1]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[2].length - 8.0f)); */

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[3], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(3.0f));
            
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[2], image_size_list[2]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[3].length - 5.0f));


            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(false));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[4], 1.0f));

            List<List<float>> jointTrajList = Hardcode1(2.0f); 
            List<List<float>> TaskTrajList = _generalRobotControl.SolveJointSpaceTrajectories(jointTrajList);

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.MoveToTargetTaskSpacePositionCubicTrajectory3DOF(TaskTrajList[0], 2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DrawTrajectory(TaskTrajList));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(6.0f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectory(jointTrajList));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[4].length - 2.0f - 6.0f - 2.0f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[2], image_size_list[2]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(true));
            


            // _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[5], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[5].length));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[6], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("$$\\text{Let} \\theta(t) = a_0 + a_1t + a_2t^2 + a_3t^3 $$"));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatexStatus(true));
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[6].length - 4.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(false));

            // first equation
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[7], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("$$\\text{Let }\\theta(t) = a_0 + a_1t + a_2t^2 + a_3t^3 $$The acceleration is given by:$$ \\dotaccent{\\theta}(t) = a_1 + 2a_2t + 3a_3t^2 $$"));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatexStatus(true));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.0f));

            // second equation
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[8], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.5f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("$$\\text{Let } \\theta(t) = a_0 + a_1t + a_2t^2 + a_3t^3 $$The acceleration is given by:$$ \\dotaccent{\\theta}(t) = a_1 + 2a_2t + 3a_3t^2 $$ The acceleration is given by:$$ \\ddot{\theta}(t) = 2a_2 + 6a_3t $$"));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2.0f));


            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[9], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatexStatus(false));
            _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.SetImage(image_sprite_list[6], image_size_list[6]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.SetImageStatus(true));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[9].length));

            int correctOption1 = 1;
            List<string> textList1 = new List<string>
            {
                "What are the shape for the velocity and acceleration graph respectively?",
                "cubic, quadratic",
                "quadratic, linear",
                "linear, quadratic",
                "quadratic, cubic",
            };

            _generalRobotControl.actionQueue.Enqueue(
                () => _generalInteractiveControl.SetMCWithAnswer(textList1, correctOption1)
            );

            // answer for first MC
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[10], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[10].length));

            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[11], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[11].length));

            int correctOption2 = 1;
            List<string> textList2 = new List<string>
            {
                "What do the graphs tell you about the motion's characteristics?\n" +
                "   I. The motion starts and ends smoothly with zero velocity.\n" +
                "   II. The acceleration changes gradually without sudden jumps.\n" +
                "   III. The displacement changes most rapidly at the start and end.",
                "I only",
                "I and II",
                "I and III",
                "II and III",
            };

            _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.SetImageStatus(false));
            _generalRobotControl.actionQueue.Enqueue(
                () => _generalInteractiveControl.SetMCWithAnswer(textList2, correctOption2)
            );

            // Answer for second MC
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[12], 1.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[12].length));

        }
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[13], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[13].length));

        // solve a0
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[14], 1.0f));
         _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(6f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\begin{align*}\\theta_{\\text{start}} &= a_0 + a_1 t + a_2 t^2 + a_3 t^3\\big|_{t=0} \\end{align*}"));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatexStatus(true));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(4f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\begin{align*}\\theta_{\\text{start}} &= a_0 + a_1 t + a_2 t^2 + a_3 t^3\\big|_{t=0} \\\\&= a_0 + a_1 \\cdot 0 + a_2 \\cdot 0^2 + a_3 \\cdot 0^3 \\end{align*}"));

        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(5f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\begin{align*}\\theta_{\\text{start}} &= a_0 + a_1 t + a_2 t^2 + a_3 t^3\\big|_{t=0} \\\\&= a_0 + a_1 \\cdot 0 + a_2 \\cdot 0^2 + a_3 \\cdot 0^3 \\\\\\Rightarrow a_0 &= \\theta_{\\text{start}}\\end{align*}"));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[14].length - 15f));

        // solve a1
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[15], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(3f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\begin{align*}\\dotaccent{\\theta}_{\\text{start}} = 0 &= a_1 + 2 a_2 t + 3 a_3 t^2\\big|_{t=0} \\end{align*}"));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(6f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\begin{align*}\\dotaccent{\\theta}_{\\text{start}} = 0 &= a_1 + 2 a_2 t + 3 a_3 t^2\\big|_{t=0} \\\\&= a_1+2 a_2 \\cdot 0 + 3 a_3 \\cdot 0^2 \\end{align*}"));

        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(8.5f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\begin{align*}\\dotaccent{\\theta}_{\\text{start}} = 0 &= a_1 + 2 a_2 t + 3 a_3 t^2\\big|_{t=0} \\\\&= a_1+2 a_2 \\cdot 0 + 3 a_3 \\cdot 0^2 \\\\\\Rightarrow a_1 &= 0\\end{align*}"));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[15].length - 17.5f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(1f));

        // formulate simul for a2 and a3
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[16], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(2f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\[\\left\\{\\begin{array}{l}\\theta_{\\text{end}} = \\theta(t) \\big|_{t=T} \\\\\\dotaccent{\\theta}_{\\text{end}} = \\dotaccent{\\theta}(t) \\big|_{t=T}\\end{array}\\right.\\]"));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[16].length - 2f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(1f));


        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[17], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(1f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex("\\[\\left\\{\\begin{array}{l}\\theta_{\\text{end}} = a_0 + a_1 T + a_2 T^2 + a_3 T^3 \\\\0 = a_1 + 2 a_2 T + 3 a_3 T^2\\end{array}\\right.\\]"));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(8f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatex(@"
        \begin{align*}
        \text{Solving (1) and (2)}\\
        a_2 &= \frac{3(\theta_{\text{end}} - \theta_{\text{start}})}{T^2} \\
        a_3 &= -\frac{2(\theta_{\text{end}} - \theta_{\text{start}})}{T^3}
        \end{align*}
        "));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[17].length - 9f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetLatexStatus(false));

        // matrix form
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[18], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(6f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[16], image_size_list[16]));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(true));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[18].length-6.0f));

        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[19], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[19].length));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(false));

        // conclusion
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[20], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[20].length));

        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[21], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[21].length));


        int correctOption3 = 1;
        List<string> textList3 = new List<string>
            {
                "What is the difference between a Path and a Trajectory?" +
                "\n   I. Path: straight line, Trajectory: nonlinear" +
                "\n   II. Path: spatial information, Trajectory: spatial + time information" +
                "\n   III. Path: is fixed, Trajectory: can change",
                "I only",
                "II only",
                "I and III",
                "II and III",
            };

        _generalRobotControl.actionQueue.Enqueue(
            () => _generalInteractiveControl.SetMCWithAnswer(textList3, correctOption3)
        );
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.PlayAudioInstant(audio_list[22], 1.0f));
        _generalRobotControl.actionQueue.Enqueue(() => _generalAudioControl.Wait(audio_list[22].length));

        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetGameObjectActive(menu, true));

        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(false));
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.CloseAllGraphs());
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.HideTraj());
        _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.DisableMC());

        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGameObjectActive(menu, true)
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

    public List<List<float>> Hardcode1(float second)
    {
        List<List<float>> trajList = new List<List<float>>();
        int num_of_frames = (int)(second / _generalRobotControl.fs);
        Vector3 a0 = new Vector3(90, 0, 0);
        Vector3 target = new Vector3(-90, 0, 0);
        Vector3 a1 = new Vector3(0, 0, 0); // Assuming a1 is initialized as (0, 0, 0) for simplicity
        Vector3 a2 = 3 * (target - a0) * (1 / (second * second));
        Vector3 a3 = -2 * (target - a0) * (1 / (second * second * second));

        for (int i = 0; i < 6; i++) // Assuming dof is 3 for simplicity
        {
            List<float> tmp = new List<float>();
            if (i < 3)
            {
                for (int j = 0; j < num_of_frames; j++)
                {
                    double t = (double)j / (num_of_frames - 1) * second;
                    tmp.Add((float)(a0[i] + a1[i] * t + a2[i] * t * t + a3[i] * t * t * t));
                }
            }
            else
            {
                for (int j = 0; j < num_of_frames; j++)
                {
                    tmp.Add(0);
                }
            }

            trajList.Add(tmp);
        }
        return trajList;
    }

    public List<List<float>> LinearHardcode1(float second)
    {
        List<List<float>> trajList = new List<List<float>>();
        int num_of_frames = (int)(second / _generalRobotControl.fs);
        Vector3 a0 = new Vector3(0, 0, 0);
        Vector3 target = new Vector3(-90, 0, 0);
        Vector3 target2 = new Vector3(90, 0, 0);
        Vector3 target3 = new Vector3(0, 0, 0);


        for (int i = 0; i < 6; i++) // Assuming dof is 3 for simplicity
        {
            List<float> tmp = new List<float>();
            if (i < 3)
            {
                
                for (int j = 0; j < num_of_frames*4; j++)
                {
                    if (j < num_of_frames)
                    {
                        double t = (double)j / (num_of_frames - 1) * second;
                        tmp.Add((float)(a0[i] + (target[i] - a0[i]) * t / second));
                    }
                    else if (j < 3 * num_of_frames)
                    {
                        double t = (double) (j-num_of_frames) / (2 * num_of_frames - 1) * second;
                        tmp.Add((float)(target[i] + (target2[i] - target[i]) * t / second));
                    }
                    else
                    {
                        double t = (double) (j-3 * num_of_frames) / (num_of_frames - 1) * second;
                        tmp.Add((float)(target2[i] + (target3[i] - target2[i]) * t / second));
                    }
                    
                }
            }
            else
            {
                for (int j = 0; j < num_of_frames*4; j++)
                {
                    tmp.Add(0);
                }
            }

            trajList.Add(tmp);
        }
        return trajList;
    }
}

/* 
https://docs.google.com/document/d/15_nGFo_gMRtb2VqCSxswnaE1nPZLwKtYvh_9QX9BxHs/edit  script here
*/