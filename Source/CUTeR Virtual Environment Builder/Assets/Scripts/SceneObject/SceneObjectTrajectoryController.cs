using SFB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SceneObjectTrajectoryController : MonoBehaviour
{
    #region Variables
    public string _trajText = "";
    public List<Vector3> _trajPositionList = new List<Vector3>();
    public List<Vector3> _trajRotationList = new List<Vector3>();

    enum State
    {
        stopped,
        playing,
        pause
    }

    public bool runTraj = false;

    private State _currentState;
    private Text _loadResultText;
    public int _currentTrajIndex = 0;
    public int _trajLength = 0;
    // private bool _isWebGL = false;
    public bool _useTraj = true;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _currentState = State.stopped;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (_currentState == State.playing)
        {
            if (_currentTrajIndex >= _trajLength)
            {
                _currentState = State.stopped;
            }
            else
            {
                transform.localPosition = _trajPositionList[_currentTrajIndex];
                transform.localEulerAngles = _trajRotationList[_currentTrajIndex];
                _currentTrajIndex++;
            }
        }
    }

    public void AddOnClickListener(Button button, Text resultText)
    {
        _loadResultText = resultText;
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OnLoadTrajBtnClick);
    }
    private void OnLoadTrajBtnClick()
    {
            var paths = StandaloneFileBrowser.OpenFilePanel("Open Trajectory", "", "txt", false);
            if (paths.Length > 0) OnFileUpload(new Uri(paths[0]).AbsoluteUri);
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
                Debug.Log("Received: " + request.downloadHandler.text.Length);
                SetTrajByText(request.downloadHandler.text);
                break;
        }
    }
    // process trajectory text
    public void SetTrajByText(string trajText)
    {
        _trajText = trajText;
        _currentState = State.stopped;
        _trajPositionList = new List<Vector3>();
        _trajRotationList = new List<Vector3>();
        _trajLength = 0;
        _currentTrajIndex = 0;

        string[] trajsTextArray = trajText.Split(';');
        Debug.Log(trajText);
        Debug.Log(trajsTextArray.Length);
        if (trajsTextArray.Length != 7)
        {
            //_loadResultText.text = "Load Failed, wrong trajectory file format";
            Debug.Log("Load obj traj failed, wrong trajectory file format");
            return;
        }

        string[] xPositionArray = trajsTextArray[0].Split(',');
        string[] yPositionArray = trajsTextArray[1].Split(',');
        string[] zPositionArray = trajsTextArray[2].Split(',');
        string[] xRotationArray = trajsTextArray[3].Split(',');
        string[] yRotationArray = trajsTextArray[4].Split(',');
        string[] zRotationArray = trajsTextArray[5].Split(',');

        _trajLength = xPositionArray.Length;
        for (int i = 0; i < xPositionArray.Length; i++)
        {
            try
            {
                _trajPositionList.Add(new Vector3(-float.Parse(xPositionArray[i]), float.Parse(zPositionArray[i]), -float.Parse(yPositionArray[i])));
                _trajRotationList.Add(new Vector3(float.Parse(xRotationArray[i]), float.Parse(zRotationArray[i]), float.Parse(yRotationArray[i])));
            }catch (Exception)
            {
                _loadResultText.text = "Load Failed, wrong trajectory file format.";
                return;
            }
        }
        transform.localPosition = _trajPositionList[0];
        transform.localEulerAngles = _trajRotationList[0];
        _currentState = State.stopped;
    }
    public void StartTraj()
    {
        Debug.Log(_useTraj + " " + _currentState);
        if (_useTraj)
        {

            if (_currentState == State.stopped)
            {
                _currentTrajIndex = 0;
                _currentState = State.playing;
            }
            else if (_currentState == State.playing)
            {
                _currentState = State.pause;
            }
            else if (_currentState == State.pause)
            {
                _currentState = State.playing;
            }
        }

    }
    public void StopTraj()
    {
        if (_useTraj)
        {
            _currentState = State.stopped;
            transform.localPosition = _trajPositionList[0];
            transform.localEulerAngles = _trajRotationList[0];
        }
    }
    public string GetTrajText() { return _trajText; }
    public void SetIsUseTraj(bool value) { _useTraj = value; }
    public bool GetIsUseTraj() { return _useTraj; }
}
