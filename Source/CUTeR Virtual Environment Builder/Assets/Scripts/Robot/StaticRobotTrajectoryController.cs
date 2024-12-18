
using UnityEngine;

using MathNet.Numerics.LinearAlgebra.Double;
using SFB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
// using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class StaticRobotTrajectoryController : MonoBehaviour
{
#if UNITY_WEBGL
    private bool _isWebGL=true;
#else 
    // private bool _isWebGL = false;
#endif

    #region Variables
    private RobotController _robotController;
    private Button _openTrajectoryButton;
    private Text _trajStatusText;
    private Image _trajStatusBackground;
    private string _trajText = "";
    public List<float> angleList = new List<float>() { 0, 0, 0, 0, 0, 0};

    public enum State
    {
        init,
        stopped,
        playing,
        pause,
        looPIng,
        ready,
        loadFailed,
        finished,
        prelooPIng,
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
    private List<int> _eeTypeList;
    public bool useEndEffector = false;
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
        _trajStatusText = TrajCtrlBtnGroup.Find("status/Text").GetComponent<Text>();
        _trajStatusBackground = TrajCtrlBtnGroup.Find("status/Image").GetComponent<Image>();

        SetStatus(State.init);
        if (_openTrajectoryButton != null){
            _openTrajectoryButton.onClick.AddListener(OnClick);
            Debug.Log("add listener");
        }
            


    }
    private void FixedUpdate()
    {
        if(_currentState == State.preplaying || _currentState == State.prelooPIng)
        {
            if (_currentTrajIndex < _prepareTrajList[0].Count)
                ReadTraj(_prepareTrajList, Direction.forward);
            else
            {
                _currentTrajIndex = 0;
                if (_currentState == State.preplaying)
                    SetStatus(State.playing);
                if(_currentState == State.prelooPIng)
                    SetStatus(State.looPIng);
            }
        }
        if (_currentState == State.looPIng)
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
        for (int i = 0; i < trajList.Count; i++)
        {
            if (trajList[i][_currentTrajIndex] != 1000)
                //_robotController.SetJointAngle(i, trajList[i][_currentTrajIndex]);
                angleList[i] = trajList[i][_currentTrajIndex];

        }
        //_robotController.SetModelJointAngles(angleList);
        _robotController.SetCmdJointAngles(angleList);
        if (trajList[0][_currentTrajIndex] == 1000){
            _robotController.Fire();
            // Debug.Log("Fire");
        }
        if (useEndEffector)
            _robotController.SetEndEffector(_eeTypeList[_currentTrajIndex]);
        if (direction == Direction.forward)
            _currentTrajIndex++;
        else
            _currentTrajIndex--;
    }

    private void OnClick()
    {
        try{

            var paths = StandaloneFileBrowser.OpenFilePanel("Open Trajectory", "", "txt", false);
            if(paths.Length > 0) OnFileUpload(new Uri(paths[0]).AbsoluteUri);
        }
        catch(Exception e){
            Debug.Log(e);
            _robotController.DebugText.text = e.ToString() + "\n" + _robotController.DebugText.text;
        }
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
                Debug.LogError("DataProcesSingError: " + request.error);
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
            _eeTypeList = new List<int>();
            
            _trajLength = 0;
            _currentTrajIndex = 0;

            string[] trajsTextArray = trajText.Split(';');

            // the trajectory file is not in the correct format
            if (trajsTextArray.Length < 2 || !trajsTextArray[0].Equals("angle"))
            {
                SetStatus(State.loadFailed);
                return;
            }
            Debug.Log(trajsTextArray.Length);
            int dof = 0;
            if (trajsTextArray.Length == 1 + 6 + 1 + 1  || trajsTextArray.Length == 1 + 6 + 1)
                dof = 6;
            else if (trajsTextArray.Length == 1 + 3 + 1 + 1 || trajsTextArray.Length == 1 + 3 + 1)
                dof = 3;
            for (int i = 1; i <= dof; i++)
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
            if ((dof == 6 && trajsTextArray.Length == 1 + 6 + 1 + 1) || (dof == 3 && trajsTextArray.Length == 1 + 3 + 1 + 1)){
                string[] eeType = trajsTextArray[trajsTextArray.Length - 2].Split(',');
                // Debug.Log(trajsTextArray[trajsTextArray.Length - 2]);
                foreach (var type in eeType){
                    _eeTypeList.Add(int.Parse(type));
                }
                useEndEffector = true;
            }else{
                useEndEffector = false;
            }
            Debug.Log(trajsTextArray.Length);
            Debug.Log(useEndEffector);
            SetStatus(State.ready);
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
                _robotController.GetEditorController().StartObjectTraj();
                break;
            case State.finished:
                SetStatus("Finished", new Color32(255, 255, 255, 78));
                break;
            case State.stopped:
                if (_trajLength > 0)
                    SetStatus("Stopped", new Color32(255, 255, 255, 78));
                break;
            case State.looPIng:
                if (_trajLength > 0)
                    SetStatus("LooPIng", new Color32(100, 255, 100, 160));
                break;
            case State.playing:
                if (_trajLength > 0)
                    SetStatus("Playing", new Color32(100, 255, 100, 160));
                _robotController.GetEditorController().StartObjectTraj();
                break;
            case State.prelooPIng:
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
        List<float> initTrajFrame = new List<float>();
        for (int i = 0; i < _trajList.Count; i++)
        {
            initTrajFrame.Add(_trajList[i][0]);
        }
        _prepareTrajList = GeneratePrepareTraj(_robotController.GetJointAngles(), initTrajFrame);

        if(_prepareTrajList != null)
            SetStatus(State.prelooPIng);
        else SetStatus(State.looPIng);
    }
    public void StartTraj(bool prepare=true)
    {
        
        if (_currentState == State.stopped || _currentState == State.ready || _currentState == State.finished || _currentState == State.init)
        {
            if(_trajLength > 0)
            {
                _currentTrajIndex = 0;
                List<float> initTrajFrame = new List<float>();
                for (int i = 0; i < _trajList.Count; i++)
                {
                    initTrajFrame.Add(_trajList[i][0]);
                }
                _prepareTrajList = GeneratePrepareTraj(_robotController.GetJointAngles(), initTrajFrame);
                Debug.Log(_robotController.GetJointAngles()[0] + ", " +  _robotController.GetJointAngles()[1] + ", " + _robotController.GetJointAngles()[2]);
                if (_prepareTrajList != null && prepare)
                    SetStatus(State.preplaying);
                else SetStatus(State.playing);
            }
            else
            {
                _robotController.GetEditorController().StartObjectTraj();
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
    private List<float> GenerateCubicTraj(float start, float end, float time)
    {
        // float tStart = 0;
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

        DenseVector constants = new DenseVector(new double[] { thetaMid - thetaStart, 0, 0, thetaMid, thetaEnd, 0 });
        var solution = coefficients.LU().Solve(constants);
        a2 = (float)solution.At(0);
        a3 = (float)solution.At(1);
        b0 = (float)solution.At(2);
        b1 = (float)solution.At(3);
        b2 = (float)solution.At(4);
        b3 = (float)solution.At(5);
        List<float> result = new List<float>();
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
        Debug.Log(result.Count);
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
        }
        float time = max_distance / 30;
        Debug.Log("prepare time: " + time);
        if (time == 0)
        {
            return null;
        }
        List<List<float>> result = new List<List<float>>();
        for (int i = 0; i < end.Count; i++)
        {
            result.Add(GenerateCubicTraj(start[i], end[i], time));
        }
        Debug.Log(result.Count);
        return result;
    }
    private List<double> task_space_2_joint_space(double x, double y, double z){

        y = -y;
        List<double> angles = new List<double> { 0, 0, 0};
        double l23 = Mathf.Sqrt(RobotController.L1 * RobotController.L1 + RobotController.A2 * RobotController.A2);
        double alpha = Mathf.Sqrt(RobotController.A2/RobotController.L1);

        if(x == 0)
            angles[0] = Mathf.PI / 2;
        else{
            if (x > 0)
                angles[0] = Mathf.Atan((float)(-y/x));
            else
                angles[0] = Mathf.PI - Mathf.Atan((float)(-y/x));
            
        }

        double A = -y * Mathf.Sin((float)angles[0]) + x * Mathf.Cos((float)angles[0]);

        double B = z - RobotController.A1;
        double l4 = RobotController.L2;
        double tmp = (A * A + B * B - (l23 * l23 + l4 * l4)) / (2 * l23 * l4);
        if (tmp < -1)
            tmp = -0.999999;
        if (tmp > 1)
            tmp = 0.99999;
        angles[2] = -Mathf.Cos((float)tmp);
        if ((A * (l23 + l4 * Mathf.Cos((float)angles[2])) + B * l4 * Mathf.Sin((float)angles[2])) > 0)
            angles[1] = Mathf.Atan((float)((B * (l23 + l4 * Mathf.Cos((float)angles[2])) - A * l4 * Mathf.Sin((float)angles[2])) /
                                (A * (l23 + l4 * Mathf.Cos((float)angles[2])) + B * l4 * Mathf.Sin((float)angles[2]))));
        else
            angles[1] = Mathf.PI - Mathf.Atan((float)((B * (l23 + l4 * Mathf.Cos((float)angles[2])) - A * l4 * Mathf.Sin((float)angles[2])) /
                                            -(A * (l23 + l4 * Mathf.Cos((float)angles[2])) + B * l4 * Mathf.Sin((float)angles[2]))));

        angles[0] = angles[0] / Mathf.PI * 180 - 90;
        angles[1] = (angles[1] + alpha) / Mathf.PI * 180;
        angles[2] = (angles[2] - alpha) / Mathf.PI * 180;
        return angles;
    }
#endregion
}
