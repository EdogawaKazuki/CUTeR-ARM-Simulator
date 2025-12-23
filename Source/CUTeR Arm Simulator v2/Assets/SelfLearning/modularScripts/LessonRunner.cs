using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;

// This class is responsible for running a sequence of lessons defined in LessonSO.
// It initializes the LessonContext and executes each step in the lesson sequence.

public class LessonRunner : MonoBehaviour
{
    public LessonSO lesson;
    public RobotController _robot;
    public GeneralRobotControl _generalRobotControl;
    public GeneralAudioControl _generalAudioControl;
    public GeneralVisualControl _generalVisualControl;
    public GeneralInteractiveControl _generalInteractiveControl;
    public GameObject _videoScreen;
    public bool stopSignal = false;
    public bool stopped = false;
    private float elapsedTime = 0f;
    private bool isTimerRunning = false;

    void Start()
    {
        GameObject menu = transform.Find("Menu")?.gameObject;
        menu.SetActive(true);
        _videoScreen.SetActive(false);

        Button startButton = transform
            .Find("Menu/MenuContainer/Start Button")
            ?.GetComponent<Button>();
        
        startButton?.onClick.AddListener(() => StartCoroutine(OnClickStart()));

        Button returnButton = transform
            .Find("return")
            ?.GetComponent<Button>();
        if (returnButton != null)
        {
            returnButton.onClick.AddListener(() => StartCoroutine(OnClickReturn()));
        }
        transform.Find("return").gameObject.SetActive(false);
    }

    IEnumerator OnClickReturn()
    {
        stopSignal = true;
        Debug.Log("Stop message sent");
        while (!stopped)
        {
            yield return new WaitForSeconds(0.1f); 
            Debug.Log("waitting for stop");
        }
        Debug.Log("Stopped, continue to handle other");
        stopped = false;
        elapsedTime = 0f; // Reset elapsed time
        isTimerRunning = false; // Stop the timer
        _generalRobotControl.StopActions();
        _generalRobotControl._robotController._robotJointController.ShowJointsFrame(false, JointFrameMode.Normal);
        _generalRobotControl._robotController._robotJointController.ShowJointsFrame(false, JointFrameMode.DH);
        if(!_generalRobotControl._robotClient.IsConnected())
        {
            _generalRobotControl._robotController._robotJointController.SetJointsVisible(false);
        }
         _videoScreen.SetActive(false);

        _generalInteractiveControl.CloseAllUIs();
        _generalVisualControl.CloseAll();


        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        GameObject menu = transform.Find("Menu")?.gameObject;
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGameObjectActive(menu, true)
        );
        transform.Find("return").gameObject.SetActive(false);
    }

    IEnumerator OnClickStart()
    {
        var ctx = new LessonContext
        {
            robot = _robot,
            generalRobot = _generalRobotControl,
            audio = _generalAudioControl,
            visuals = _generalVisualControl,
            interactive = _generalInteractiveControl,
            runner = this,
        };
        transform.Find("Menu").gameObject.SetActive(false);
        transform.Find("return").gameObject.SetActive(true);

        _generalVisualControl.SetTaskSpaceStatDisplayVisibility(false);
        isTimerRunning = true;
        elapsedTime = 0f;
        _generalRobotControl._currentState = GeneralRobotControl.State.init;
        // _generalRobotControl.StartLesson();
        _generalRobotControl.actionQueue.Enqueue(() => _generalRobotControl.LockSlider(true));

        Debug.Log($"Initializing robot position {_generalRobotControl}");
        // _generalRobotControl.MoveToInitialPosition();
        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        _generalRobotControl._currentState = GeneralRobotControl.State.ready;
        yield return new WaitForSeconds(4f);

        yield return StartCoroutine(RunLesson(ctx));
        _generalRobotControl.LockSlider(false);
        _generalRobotControl._currentState = GeneralRobotControl.State.ready;

        isTimerRunning = false; // Stop the timer
        _generalRobotControl.StopActions();
        if(!_generalRobotControl._robotClient.IsConnected())
        {
            _generalRobotControl._robotController._robotJointController.SetJointsVisible(false);
        }
         _videoScreen.SetActive(false);
        _generalVisualControl.CloseAll();
        _generalInteractiveControl.CloseAllUIs();

        _generalRobotControl.actionQueue.Enqueue(_generalRobotControl.MoveToInitialPosition);
        GameObject menu = transform.Find("Menu")?.gameObject;
        _generalRobotControl.actionQueue.Enqueue(
            () => _generalVisualControl.SetGameObjectActive(menu, true)
        );
        transform.Find("return").gameObject.SetActive(true);
    }
    public void SetPause(bool isPause)
    {
        if (isPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    IEnumerator RunLesson(LessonContext ctx)
    {
        Debug.Log("Running lesson: " + lesson.name);
        foreach (var step in lesson.steps)
        {
            Debug.Log("Executing step: " + step.Description);
            if (step == null || !step.isActive) continue;
            yield return step.Execute(ctx);
            if (stopSignal)
            {
                stopSignal = false;
                Debug.Log("stop signal received");
                stopped = true;
                Debug.Log("Stopped, jump out from run lesson");
                break;
            }
            Debug.Log("Executed step: " + step.Description);
        }

    }

    void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
            Debug.Log("Elapsed Time: " + elapsedTime.ToString("F2") + " seconds");
        }
    }

}