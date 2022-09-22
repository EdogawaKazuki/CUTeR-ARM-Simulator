using SFB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class StaticRobotTrajectoryController : MonoBehaviour
{
#if UNITY_WEBGL
    private bool _isWebGL=true;
#else 
    private bool _isWebGL = false;
#endif

    #region Variables
    private RobotController _robotController;
    [SerializeField]
    private Button _openTrajectoryButton;
    [SerializeField]
    private Text _loadResultText;
    [SerializeField]
    private Text _trajStatusText;
    [SerializeField]
    private Image _trajStatusBackground;
    private string _trajText = "";

    enum State
    {
        stopped,
        playing,
        pause,
        looping,
    }

    private State _currentState;

    private List<List<float>> _trajList;
    private int _currentTrajIndex;
    private int _trajLength;
    private bool _isBackward = false;
    #endregion


    #region MonoBehaviour
    private void Start()
    {
        _robotController = GetComponent<RobotController>();
        _currentState = State.stopped;
        if(_openTrajectoryButton != null)
            _openTrajectoryButton.onClick.AddListener(OnClick);
    }
    private void FixedUpdate()
    {
        if(_currentState == State.playing || _currentState == State.looping)
        {
            if(_currentTrajIndex < 0)
            {
                _isBackward = false;
                _currentTrajIndex++;
            }
            if(_currentTrajIndex >= _trajLength)
            {
                if(_currentState == State.looping)
                {
                    _isBackward = true;
                    _currentTrajIndex--;
                }
                else
                {
                    _currentState = State.stopped;
                    SetStatus("Finished", new Color32(255, 255, 255, 78));
                }
            }
            else
            {
                for (int i = 0; i < _trajList.Count; i++)
                {
                    if (_trajList[i][_currentTrajIndex] == 1000)
                        _robotController.Fire();
                    else
                        _robotController.SetJointAngle(i, _trajList[i][_currentTrajIndex]);
                }
                if(!_isBackward)
                    _currentTrajIndex++;
                else
                    _currentTrajIndex--;
            }
        }
    }
    #endregion


    #region Methods


    private void OnClick()
    {
            var paths = StandaloneFileBrowser.OpenFilePanel("Open Trajectory", "", "txt", false);
            if(paths.Length > 0) OnFileUpload(new Uri(paths[0]).AbsoluteUri);
    }

    private void OnFileUpload(string url)
    {
        StartCoroutine(OutputRoutine(url));
    }

    // get trajectory file
    private IEnumerator OutputRoutine(string url)
    {
        var request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();
        switch (request.result)
        {
            case UnityWebRequest.Result.ConnectionError:
            case UnityWebRequest.Result.DataProcessingError:
                Debug.LogError("DataProcessingError: " + request.error);
                break;
            case UnityWebRequest.Result.ProtocolError:
                Debug.LogError("ProtocolError: " + request.error);
                break;
            case UnityWebRequest.Result.Success:
                _trajText = request.downloadHandler.text;
                //Debug.Log("Received: " + request.downloadHandler.text.Length);
                break;
        }
        ProcessTraj(_trajText);
    }
    // process trajectory text
    public void ProcessTraj(string trajText)
    {
        try
        {
            _trajText = trajText;
            _currentState = State.stopped;
            _trajList = new List<List<float>>();
            _trajLength = 0;
            _currentTrajIndex = 0;

            string[] trajsTextArray = trajText.Split(';');

            if (trajsTextArray.Length < 2 || !trajsTextArray[0].Equals("angle"))
            {
                SetStatus("Load Failed...", new Color32(255, 100, 100, 78));
                return;
            }
            for (int i = 1; i < trajsTextArray.Length - 1; i++)
            {
                //Debug.Log(trajsTextArray[i]);
                string[] tmp = trajsTextArray[i].Split(',');
                if (_trajLength != 0 && _trajLength != tmp.Length)
                {
                    //Debug.Log(_trajLength + ", " + tmp.Length + ", " + i);
                    SetStatus("Load Failed...", new Color32(255, 100, 100, 78));
                    return;
                }
                else
                {
                    _trajList.Add(new List<float>());
                    _trajLength = tmp.Length;
                    foreach (var point in tmp)
                    {
                        if (point.Equals("fire"))
                        {
                            _trajList[i - 1].Add(1000);
                        }
                        else
                        {
                            _trajList[i - 1].Add(float.Parse(point));
                        }
                    }
                }
            }
            SetStatus("Ready to play", new Color32(255, 255, 255, 78));
        }
        catch (Exception e)
        {
            Debug.Log(e);
            _loadResultText.text = "Load Failed...";
        }
    }
    public string GetTrajString()
    {
        return _trajText;
    }
    public void SetStatus(string text, Color color)
    {
        Debug.Log(text);

        _trajStatusBackground.color = color;
        _trajStatusText.text = text;
    }
    public void LoopTraj()
    {
        _currentState = State.looping;
        SetStatus("Looping", new Color32(100, 255, 100, 160));
    }
    public void StartTraj()
    {
        if (_currentState == State.stopped)
        {
            _isBackward = false;
            _currentTrajIndex = 0;
            _currentState = State.playing;
            SetStatus("Playing", new Color32(100, 255, 100, 160));
        }
        else if (_currentState == State.playing)
        {
            _currentState = State.pause;
            SetStatus("Paused", new Color32(255, 255, 100, 160));
        }
        else if (_currentState == State.pause)
        {
            _isBackward = false;
            _currentState = State.playing;
            SetStatus("Playing", new Color32(100, 255, 100, 160));
        }
    }
    public void StopTraj()
    {
        _currentState = State.stopped;
        SetStatus("Stopped", new Color32(255, 255, 255, 78));
    }
    public void ResetTraj(int size)
    {
        _trajList = new List<List<float>>();
        for(int i = 0; i < size; i++)
        {
            _trajList.Add(new List<float>());
        }
        _trajLength = 0;
        _currentTrajIndex = 0;
        _currentState = State.stopped;
    }
    public void PushTrajPoints(List<float> pointSet)
    {
        for(int i = 0; i < pointSet.Count; i++)
        {
            _trajList[i].Add(pointSet[i]);
        }
        _trajLength++;
    }
    public void SetTraj(List<List<float>> traj)
    {
        _trajList = traj;
        _trajLength = _trajList[0].Count;
        SetStatus("Ready to play", new Color32(255, 255, 255, 78));
    }
#endregion
}
