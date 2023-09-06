
using MathNet.Numerics.LinearAlgebra.Double;
using SFB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class StaticRobotTrajectoryController : MonoBehaviour
{
#if UNITY_WEBGL
    private bool _isWebGL=true;
#else 
    private bool _isWebGL = false;
#endif

    #region Variables
    private RobotController _robotController;
    private Button _openTrajectoryButton;
    private TMP_Text _trajStatusText;
    private Image _trajStatusBackground;
    private string _trajText = "";
    public List<float> angleList = new List<float>() { 0, 0, 0, 0, 0, 0};

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

    enum Direction
    {
        forward,
        backward,
    }
    Direction _direction;

    private List<List<float>> _trajList;
    private List<List<float>> _prepareTrajList;
    private int _currentTrajIndex;
    private int _trajLength;
    #endregion


    #region MonoBehaviour
    private void Start()
    {
    }
    private void OnEnable()
    {
        _robotController = GetComponent<RobotController>();
        Transform TrajCtrlBtnGroup = _robotController.GetRobotCanvas().transform.Find("TrajCtrlBtnGroup");
        _openTrajectoryButton = TrajCtrlBtnGroup.Find("upload").GetComponent<Button>();
        _trajStatusText = TrajCtrlBtnGroup.Find("status/Text").GetComponent<TMP_Text>();
        _trajStatusBackground = TrajCtrlBtnGroup.Find("status/Image").GetComponent<Image>();
        TrajCtrlBtnGroup.Find("play").GetComponent<Button>().onClick.AddListener(() => StartTraj(true));
        TrajCtrlBtnGroup.Find("loop").GetComponent<Button>().onClick.AddListener(() => LoopTraj());
        TrajCtrlBtnGroup.Find("stop").GetComponent<Button>().onClick.AddListener(() => StopTraj());
        SetStatus(State.init);
        if (_openTrajectoryButton != null){

            _openTrajectoryButton.onClick.AddListener(UploadTraj);
        }


    }
    private void FixedUpdate()
    {
        if(_currentState == State.preplaying || _currentState == State.prelooping)
        {
            if (_currentTrajIndex < _prepareTrajList[0].Count)
                ReadTraj(_prepareTrajList, Direction.forward);
            else if (_trajLength > 1)
            {
                _currentTrajIndex = 0;
                if (_currentState == State.preplaying)
                    SetStatus(State.playing);
                if(_currentState == State.prelooping)
                    SetStatus(State.looping);
            }else{
                SetStatus(State.finished);
            }
        }
        if (_currentState == State.looping)
        {
            if (_currentTrajIndex < 0)
            {
                _direction = Direction.forward;
                _currentTrajIndex++;
            }
            if (_currentTrajIndex >= _trajLength)
            {
                _direction = Direction.backward;
                _currentTrajIndex--;
            }
            ReadTraj(_trajList, _direction);
        }
        if (_currentState == State.playing)
        {
            if(_currentTrajIndex >= _trajLength)
            {
                SetStatus(State.finished);
            }
            else
            {
                ReadTraj(_trajList, Direction.forward);
            }
        }
    }
    #endregion


    #region Methods

    private void ReadTraj(List<List<float>> trajList, Direction direction)
    {
        // Debug.Log(trajList.Count);
        for (int i = 0; i < trajList.Count; i++)
        {
            if (trajList[i][_currentTrajIndex] != 1000)
                //_robotController.SetJointAngle(i, trajList[i][_currentTrajIndex]);
                angleList[i] = trajList[i][_currentTrajIndex];

        }
        //_robotController.SetModelJointAngles(angleList);
        _robotController.SetCmdJointAngles(angleList);
        if(_currentState != State.prelooping && _currentState != State.preplaying)
            _robotController.SetTransparentCmdJointAngles(angleList);
        if(_currentState == State.prelooping || _currentState == State.preplaying)
            _robotController.SetTransparentCmdJointAngles(new(){_trajList[0][0], _trajList[1][0], _trajList[2][0]});
        if (trajList[0][_currentTrajIndex] == 1000)
            _robotController.Fire();
        if (direction == Direction.forward)
            _currentTrajIndex++;
        else
            _currentTrajIndex--;
    }

    private void UploadTraj()
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
                SetStatus(State.loadFailed);
                return;
            }
            for (int i = 1; i < trajsTextArray.Length - 1; i++)
            {
                //Debug.Log(trajsTextArray[i]);
                string[] tmp = trajsTextArray[i].Split(',');
                if (_trajLength != 0 && _trajLength != tmp.Length)
                {
                    //Debug.Log(_trajLength + ", " + tmp.Length + ", " + i);
                    SetStatus(State.loadFailed);
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
            SetStatus(State.ready);
            List<float> tmpList = new();
            for(int i = 0; i < _robotController.GetRobotDoF(); i++)
            {
                tmpList.Add(_trajList[i][0]);
            }
            _robotController.SetTransparentCmdJointAngles(tmpList);
        }
        catch (Exception e)
        {
            Debug.Log(e);
            SetStatus(State.loadFailed);
        }
    }
    public string GetTrajString()
    {
        return _trajText;
    }
    public void SetStatus(string text, Color color)
    {
        _trajStatusBackground.color = color;
        _trajStatusText.text = text;
    }
    public void SetStatus(State state)
    {
        switch (state)
        {
            case State.ready:
                SetStatus("Ready to play", new Color32(255, 255, 255, 78));
                break;
            case State.loadFailed:
                SetStatus("Load Failed...", new Color32(255, 100, 100, 78));
                break;
            case State.pause:
                SetStatus("Paused", new Color32(255, 255, 100, 160));
                // _robotController.GetEditorController().StartObjectTraj();
                break;
            case State.finished:
                SetStatus("Finished", new Color32(255, 255, 255, 78));
                break;
            case State.stopped:
                if (_trajLength > 0)
                    SetStatus("Stopped", new Color32(255, 255, 255, 78));
                break;
            case State.looping:
                if (_trajLength > 0)
                    SetStatus("Looping", new Color32(100, 255, 100, 160));
                break;
            case State.playing:
                if (_trajLength > 0)
                    SetStatus("Playing", new Color32(100, 255, 100, 160));
                // _robotController.GetEditorController().StartObjectTraj();
                break;
            case State.prelooping:
                if (_trajLength > 0)
                    SetStatus("Preparing Robot", new Color32(255, 255, 100, 160));
                break;
            case State.preplaying:
                if (_trajLength > 0)
                    SetStatus("Preparing Robot", new Color32(255, 255, 100, 160));
                break;
            case State.init:
                SetStatus("No Trajectory", new Color32(255, 255, 255, 78));
                break;

        }
        _currentState = state;
    }

    public void LoopTraj()
    {
        _currentTrajIndex = 0;
        _prepareTrajList = GeneratePrepareTraj(_robotController.GetJointAngles(), new List<float>() { _trajList[0][0], _trajList[1][0], _trajList[2][0] });

        if(_prepareTrajList != null)
            SetStatus(State.prelooping);
        else SetStatus(State.looping);
    }
    public void StartTraj(bool prepare=true)
    {
        
        if (_currentState == State.stopped || _currentState == State.ready || _currentState == State.finished || _currentState == State.init)
        {
            if(_trajLength > 0)
            {
                _currentTrajIndex = 0;
                List<float> tmp = new();
                for(int i = 0; i < _trajList.Count; i++) tmp.Add(_trajList[i][0]); 
                _prepareTrajList = GeneratePrepareTraj(_robotController.GetJointAngles(), tmp);
                // Debug.Log(_robotController.GetJointAngles()[0] + ", " +  _robotController.GetJointAngles()[1] + ", " + _robotController.GetJointAngles()[2]);
                if (_prepareTrajList != null && prepare)
                    SetStatus(State.preplaying);
                else SetStatus(State.playing);
            }
            else
            {
                // _robotController.GetEditorController().StartObjectTraj();
            }
        }
        else if (_currentState == State.playing)
        {
            SetStatus(State.pause);
        }
        else if (_currentState == State.pause)
        {
            SetStatus(State.playing);
        }
    }
    public void StopTraj()
    {
        SetStatus(State.stopped);
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
        SetStatus(State.ready);
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
        SetStatus(State.ready);
    }
    public List<float> GenerateCubicTraj(float start, float end, float time)
    {
        float tMid = time / 2.0f;
        float tEnd = time;

        float thetaStart = start;
        float thetaMid = (end + start) / 2.0f;
        float thetaEnd = end;
        float a0, a1, a2, a3 = 0;
        float b0, b1, b2, b3 = 0;
        //Debug.Log(_t);
        a0 = thetaStart;
        a1 = 0;

        Matrix coefficients = DenseMatrix.OfArray(new double[,] {
                { tMid*tMid, tMid*tMid*tMid, 0, 0, 0, 0 },
                { 2*tMid, 3*tMid*tMid, 0, -1, -2*tMid, -3*tMid*tMid },
                { 2, 6*tMid, 0, 0, -2, -6*tMid },
                { 0, 0, 1, tMid, tMid*tMid, tMid*tMid*tMid},
                { 0, 0, 1, tEnd, tEnd*tEnd, tEnd*tEnd*tEnd },
                { 0, 0, 0, 1, 2*tEnd, 3*tEnd*tEnd } });

        DenseVector constants = new(new double[] { thetaMid - thetaStart, 0, 0, thetaMid, thetaEnd, 0 });
        var solution = coefficients.LU().Solve(constants);
        a2 = (float)solution.At(0);
        a3 = (float)solution.At(1);
        b0 = (float)solution.At(2);
        b1 = (float)solution.At(3);
        b2 = (float)solution.At(4);
        b3 = (float)solution.At(5);
        List<float> result = new();
        for (int i = 0; i < tMid * 20 + 1; i++)
        {
            float _t = i / 20f;
            float angle0 = a0 + a1 * _t + a2 * _t * _t + a3 * _t * _t * _t;
            result.Add(angle0);
        }
        for (int i = (int)(tMid * 20 + 1); i < 20 * tEnd + 1; i++)
        {
            float _t = i / 20f;
            float angle0 = b0 + b1 * _t + b2 * _t * _t + b3 * _t * _t * _t;
            result.Add(angle0);
        }
        // Debug.Log(result.Count);
        return result;
    }
    private List<List<float>> GeneratePrepareTraj(List<float> start, List<float> end)
    {
        float max_distance = 0;
        for (int i = 0; i < end.Count; i++)
        {
            float distance = Mathf.Abs(end[i] - start[i]);
            if (distance > max_distance)
            {
                max_distance = distance;
            }
            Debug.Log("distance: " + distance);
        }
        float time = max_distance / 30;
        Debug.Log("prepare time: " + time);
        if (time < 0.1f)
        {
            return null;
        }
        List<List<float>> result = new();
        for (int i = 0; i < end.Count; i++)
        {
            result.Add(GenerateCubicTraj(start[i], end[i], time));
        }
        Debug.Log(result.Count);
        return result;
    }
#endregion
}
