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
        Text = transform.Find("Text (TMP)")?.GetComponent<TMP_Text>();
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
        Text.text = @"Let \u03B8(t) = a<sub>0</sub> + a<sub>1</sub>t + a<sub>2</sub>t<sup>2</sup> + a<sub>3</sub>t<sup>3</sup>
        
The velocity is given by:
    \u03B8\&nbsp;\u0307(t) = a<sub>1</sub> + 2a<sub>2</sub>t + 3a<sub>3</sub>t<sup>2</sup>
        
The acceleration is given by:
    \u03B8\&nbsp;\u0307\u0307(t) = 2a<sub>2</sub> + 6a<sub>3</sub>t";
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


            List<List<float>> jointTrajList = Hardcode1(2.5f);
            List<List<float>> TaskTrajList = _generalRobotControl.SolveJointSpaceTrajectories(jointTrajList);

            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DrawTrajectory(TaskTrajList));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Task_Space_Position_Cubic_Trajectory(TaskTrajList[0], 2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectoryWithDelay(jointTrajList));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.Move_to_Initial_Position);

            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[0], image_size_list[0]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImageStatus(true));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[1], image_size_list[1]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[2], image_size_list[2]));

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));

            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DrawTrajectory(TaskTrajList));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.DisplayTraj());
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Move_to_Target_Task_Space_Position_Cubic_Trajectory(TaskTrajList[0], 2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.ExecuteTrajectoryWithDelay(jointTrajList));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.ClearPoints());

            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[3], image_size_list[3]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[4], image_size_list[4]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[5], image_size_list[5]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[6], image_size_list[6]));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[7], image_size_list[7]));_generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.SetImage(image_sprite_list[8], image_size_list[8]));
            
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));
            
            
            
        }
        List<string> textList = new List<string> {
                "Do you know why the acceleration graph has a negative linear line?",
                "placeholder1",
                "placeholder2", 
                "placeholder3",
                "placeholder4"
            };


            _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.SetMC(textList));
            _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.WaitForMCAnswer());
            _generalRobotControl.actionQueue.Enqueue(() => _generalInteractiveControl.DisableMC());
            _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.Wait(2.0f));

            
        
        // fifth action: move to initial position
        _generalRobotControl.actionQueue.Enqueue(() => _generalVisualControl.CloseAllGraphs());
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
        Vector3 a0 = new Vector3(120, 0, 0);
        Vector3 target = new Vector3(-120, 0, 0);
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
}

/* 
https://docs.google.com/document/d/15_nGFo_gMRtb2VqCSxswnaE1nPZLwKtYvh_9QX9BxHs/edit  script here
*/