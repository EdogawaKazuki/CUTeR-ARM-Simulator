using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private GameObject _robotCanvas;
    private EditorController _editorController;
    private RobotJointController _robotJointController;
    private EndEffectorController _endEffectorController;
    private RobotControllerUI _joystickController;
    private RobotClient _robotClient;
    private PathRecoder _pathRecoder;
    private List<float> _offset;
    private List<float> _scale;
    private StaticRobotTrajectoryController _staticRobotTrajectoryController;
    [SerializeField]
    private RobotIndex _robotIndex;
    [SerializeField]
    private bool _enableCollisionChecker = true;
    enum RobotIndex
    {
        green,
        red,
    }
    private int _currentDoF = 6;
   
    static public float A1 = 10;  //length properties of the teaching robot arm (in cm)
    static public float A2 = 2.8f; //length properties of the teaching robot arm (in cm)
    static public float L1 = 19.4f; //length properties of the teaching robot arm (in cm)
    static public float L2 = 21;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap
    private List<int> _pwmList = new List<int>() { 0, 0, 0, 0, 0, 0 };

    public List<float> CmdJointAngles = new List<float>() { 0, 0, 0, 0, 0, 0 };
    public bool isUserInteracting;
    public Text DebugText;
    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnEnable()
    {
        CmdJointAngles = new List<float>() { 0, 0, 0, 0, 0, 0 };
        switch (_robotIndex)
        {
            case RobotIndex.green:
                // green robot
                _offset = new List<float>() { 5291.044970195919f, 7582.74192603952f, 6625.3032796151165f, 0, 0, 0 };
                _scale = new List<float>() { 31.11781897735022f, -31.795396910065065f, 32.084929193885245f, 0, 0, 0 };
                break;
            case RobotIndex.red:
                // red robot
                _offset = new List<float>() { 5324.381713648321f, 8299.03249763614f, 6835.758734584624f, 0, 0, 0 };
                _scale = new List<float>() { 33.258869468309875f, -32.76274500647959f, 33.945176689305775f, 0, 0, 0 };
                break;
            default:
                // red robot
                _offset = new List<float>() { 5324.381713648321f, 8299.03249763614f, 6835.758734584624f, 0, 0, 0 };
                _scale = new List<float>() { 33.258869468309875f, -32.76274500647959f, 33.945176689305775f, 0, 0, 0 };
                break;

        }
        for (int i = 0; i < _offset.Count; i++)
        {
            _offset[i] = PlayerPrefs.GetFloat("_offset" + i, _offset[i]);
            _scale[i] = PlayerPrefs.GetFloat("_scale" + i, _scale[i]);
        }
        _editorController = transform.Find("/EditorAdmin").GetComponent<EditorController>();
        _joystickController = GetComponent<RobotControllerUI>();
        _robotClient = GetComponent<RobotClient>();
        DebugText = _robotClient._debugText;
        _pathRecoder = GetComponent<PathRecoder>();
        _staticRobotTrajectoryController = GetComponent<StaticRobotTrajectoryController>();
        _endEffectorController = transform.Find("FunctionalTools").GetComponent<EndEffectorController>();
        _robotJointController = transform.Find("Joints").GetComponent<RobotJointController>();
        //Debug.Log("set joints");
        SetRobotDoF(3);
        SetCmdJointAngles(new List<float> { 0, 180, -140, 0, 0, 0 });
    }
    // Update is called once per frame
    void Update()
    {
        if(_pathRecoder.isRecording)
            _pathRecoder.AddPoint(_robotJointController.GetJointTransformByIndex(_currentDoF).position);

    }
    #endregion
    #region Methods
    public PathRecoder GetPathRecoder()
    {
        return _pathRecoder;
    }
    bool CheckCollision(int index, float angle)
    {
        if (!_enableCollisionChecker) return false;
        if (!_robotClient.IsConnected()) return false;
        
        float[] angles = GetJointAngles().ToArray();

        angles[index] = angle;
        double Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * angles[0]);
        double Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * angles[0]);
        double Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * angles[1]);
        double Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * angles[1]);
        double Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (angles[1] + angles[2]));
        double Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (angles[1] + angles[2]));
        double x = -Angle1Sin * Angle23Cos * 21 + (-19.2 * Angle1Sin * Angle2Cos - 2.8 * Angle1Sin * Angle2Sin) + 0.001;
        double y = Angle1Cos * Angle23Cos * 21 + (19.2 * Angle1Cos * Angle2Cos + 2.8 * Angle1Cos * Angle2Sin) + 0.001;
        double z = Angle23Sin * 21 + (19.2 * Angle2Sin - 2.8 * Angle2Cos) + 10.001;
        if (z < 0) return true;
        return false;
    }
    public void SetJointAngle(int index, float angle)
    {
        //LockRobotArm();
        if (!CheckCollision(index, angle))
        {
            // set robot model
            _robotJointController.SetJointAngle(index, angle);
            // set joystick value
            //_joystickController.SetAngleSliderValue(index, angle);
            // set storage value
            _pwmList[index] = (int)(GetJointAngle(index) * _scale[index] + _offset[index]);
        }
        else
        {
            //_joystickController.SetAngleSliderValue(index, GetJointAngle(index));
            Debug.Log("???");
        }
    }
    public void MoveJointsTo(List<float> angleList)
    {
        _staticRobotTrajectoryController.ResetTraj(angleList.Count);
        _staticRobotTrajectoryController.PushTrajPoints(angleList);
        _staticRobotTrajectoryController.SetStatus(StaticRobotTrajectoryController.State.ready);
        _staticRobotTrajectoryController.StartTraj();
    }
    public List<int> GetSendPWM()
    {
        return _pwmList;
    }
    public void SetJointPWM(int index, int pwm)
    {
        _robotClient.SendPWMCmd(index, pwm);
        //SetJointAngle(index, (pwm - _offset[index]) / _scale[index]);
    }
    public void SetJointPWMs(List<int> pwm)
    {
        for (int index = 0; index < pwm.Count; index++)
        {
            SetJointPWM(index, pwm[index]);
        }
    }
    public void SetJointSign(int index, string line1, string line2)
    {
        _robotJointController.SetJointSign(index, line1, line2);
    }

    public void SetJointSignActivate(int index, bool value)
    {
        _robotJointController.SetJointSignActivate(index, value);
    }
    public void SetLinkSignActivate(int index, bool value)
    {
        _robotJointController.SetLinkSignActivate(index, value);
    }
    public void SetModelJointAngles(List<float> angles)
    {
        //LockRobotArm();
        _pathRecoder.AddPoint(_robotJointController.GetJointTransformByIndex(_currentDoF).position);
        for (int i = 0; i < angles.Count; i++)
        {
            //_joystickController.SetAngleSliderValue(i, angles[i]);
        }
        for(int i = 0; i < _pwmList.Count; i++)
        {
            _pwmList[i] = (int)(GetJointAngle(i) * _scale[i] + _offset[i]);
        }
        _robotJointController.SetJointAngles(angles);
        
    }
    public List<float> GetCmdJointAngles()
    {
        return CmdJointAngles;
    }
    public void SetCmdJointAngles(List<float> angles)
    {
        CmdJointAngles = angles;
        if (!_robotClient.IsConnected() && false)
        {
            SetModelJointAngles(angles);
        }
        else
        {
            for (int i = 0; i < _pwmList.Count; i++)
                _joystickController.SetAngleSliderValue(i, angles[i], isUserInteracting);
        }
    }
    public void SetCmdJointAngle(int index, float angle, bool isUserInteracting)
    {
        //Debug.Log(CmdJointAngles.Count);
        //Debug.Log(index);
        _joystickController.SetAngleSliderValue(index, angle, isUserInteracting);
        CmdJointAngles[index] = angle;
    }
    public float GetJointAngle(int index)
    {
        return _robotJointController.GetJointAngle(index);
    }
    public List<float> GetJointAngles()
    {
        return _robotJointController.GetJointAngles();
    }
    public void SetEndEffector(int index)
    {
        _endEffectorController.SetEndEffector(index);
        Debug.Log(index);
        if(index == 3)
        {
            _joystickController.EnableForce(true);
        }
        else
        {
            _joystickController.EnableForce(false);
        }
    }
    public int GetEndEffector() { return _endEffectorController.GetEndEffector(); }
    public void SetForce(float force)
    {
        _endEffectorController.SetForce(force);
    }
    public void Fire()
    {
        _endEffectorController.Fire();
    }
    public void ResetEndEffector() { _endEffectorController.ResetEndEffector(); }
    public List<Transform> GetJointTransforms()
    {
        return _robotJointController.GetJointTransforms();
    }
    public void SetRobotDoF(int dof)
    {
        List<Transform> jointTransforms = _robotJointController.GetJointTransforms();
        for (int i = 0; i < jointTransforms.Count; i++)
        {
            if(i < dof)
            {
                jointTransforms[i].gameObject.SetActive(true);
            }
            else
            {
                jointTransforms[i].gameObject.SetActive(false);
            }
        }
        _endEffectorController.transform.SetParent(_robotJointController.GetJointTransformByIndex(dof - 1));
        _endEffectorController.transform.localPosition = _robotJointController.GetJointTransformByIndex(dof).localPosition;
        _endEffectorController.transform.localEulerAngles = Vector3.zero;
        _currentDoF = dof;
    }
    public int GetRobotDoF() { return _currentDoF; }
    public StaticRobotTrajectoryController GetTrajController() { return _staticRobotTrajectoryController; }
    public EditorController GetEditorController() { return _editorController; }
    public float GetJointAngleMax(int index)
    {
        return _joystickController.GetJointAngleMax(index);
    }
    public float GetJointAngleMin(int index)
    {
        return _joystickController.GetJointAngleMin(index);
    }
    public List<int> GetReadPWM()
    {
        return _robotClient.GetFeedbackPWM();
    }
    public List<int> GetCmdPWM()
    {
        return _robotClient.GetCmdPWM();
    }
    public void SetFeedbackCaliData(List<float> offset, List<float> scale)
    {
        _robotClient.SetFeedBackCaliData(offset, scale);
    }
    public void SetCmdCaliData(List<float> offset, List<float> scale)
    {
        _robotClient.SetCmdCaliData(offset, scale);
    }
    public RobotControllerUI GetJoystickController() { return _joystickController; }
    public void HideJointLink(int index) { _robotJointController.HideJointLink(index); }
    public void ShowJointLink(int index) { _robotJointController.ShowJointLink(index); }
    public void UnlockRobotArm() { _robotClient.Unlock(); }
    public void LockRobotArm() { SetCmdJointAngles(_robotJointController.GetJointAngles()); _robotClient.Lock(); }
    public void SetRobotArmConnect(bool value) { _robotClient.SetConnect(value); }
    public void SetRobotArmLock(bool value) { SetCmdJointAngles(_robotJointController.GetJointAngles());  if (value) _robotClient.Lock(); else _robotClient.Unlock(); }
    public void SetRobotArmFilter(int index) { _robotClient.SetFilter(index); }
    public void SetRobotArmFilterWindow(int windowSie) { _robotClient.SetAverageWindowSize(windowSie); }
    public void SetJointSignActivate(bool value) { _robotJointController.SetJointSignActivate(value); }
    public void SetLinkSignActivate(bool value) { _robotJointController.SetLinkSignActivate(value); }

    public void ToggleRobot(bool value)
    {
        if (!value)
        {
            HideJointLink(0);
            HideJointLink(1);
            HideJointLink(2);
        }
        else
        {
            ShowJointLink(0);
            ShowJointLink(1);
            ShowJointLink(2);
        }
    }
    public void PauseSendCmdToRobot()
    {
        _robotClient.SendCmd = false;
    }
    public void StartSendCmdToRobot()
    {
        _robotClient.SendCmd = true;
    }
    public GameObject GetRobotCanvas()
    {
        return _robotCanvas;
    }
    public RobotJointController GetRobotJointController()
    {
        return _robotJointController;
    }
    #endregion
}
