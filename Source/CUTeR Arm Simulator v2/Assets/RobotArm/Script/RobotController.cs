using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotController : MonoBehaviour
{
    #region Variables
    private RobotControllerUI _robotControllerUI;
    private RobotJointController _robotJointController;
    private RobotJointController _transparentRobotJointController;
    private EndEffectorController _endEffectorController;
    private RobotControllerUI _joystickController;
    private PathRecoder _pathRecoder;
    private GameObject _robotCanvas;
    private List<float> _offset;
    private List<float> _scale;
    private StaticRobotTrajectoryController _staticRobotTrajectoryController;

    private LineRenderer HeadLine;
    private Transform PointHead;

    private int MAX_ROBOT_DOF;
    [SerializeField]
    private int INIT_ROBOT_DOF = 3;
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
    static public float L1 = 19.2f; //length properties of the teaching robot arm (in cm)
    static public float L2 = 21;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap

    private List<int> _pwmList;

    public List<float> CmdJointAngles;

    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {
        // Get the max robot dof from the model
        MAX_ROBOT_DOF = _robotJointController.GetJointAngles().Count;

        // init variable lists
        CmdJointAngles = new List<float>(new float[MAX_ROBOT_DOF]);
        _offset = new List<float>(new float[MAX_ROBOT_DOF]);
        _scale = new List<float>(new float[MAX_ROBOT_DOF]);
        _pwmList = new List<int>(new int[MAX_ROBOT_DOF]);

        // read the offset and scale from the player prefs
        for (int i = 0; i < _offset.Count; i++)
        {
            _offset[i] = PlayerPrefs.GetFloat("_offset" + i, _offset[i]);
            _scale[i] = PlayerPrefs.GetFloat("_scale" + i, _scale[i]);
        }

        // set init robot dof
        SetRobotDoF(INIT_ROBOT_DOF);
    }
    void OnEnable()
    {
        // asign hooks
        _robotControllerUI = GetComponent<RobotControllerUI>();
        _robotCanvas = transform.Find("RobotCanvas").gameObject;
        //_editorController = transform.Find("/EditorAdmin").GetComponent<EditorController>();
        _joystickController = GetComponent<RobotControllerUI>();
        //_robotClient = GetComponent<RobotClient>();
        _pathRecoder = GetComponent<PathRecoder>();
        _staticRobotTrajectoryController = GetComponent<StaticRobotTrajectoryController>();
        _endEffectorController = transform.Find("EndEffectors").GetComponent<EndEffectorController>();
        _robotJointController = transform.Find("Joints").GetComponent<RobotJointController>();
        _transparentRobotJointController = transform.Find("Joints Transparent").GetComponent<RobotJointController>();

        
        HeadLine = transform.Find("VisiualContent/HeadLine").GetComponent<LineRenderer>();
        PointHead = transform.Find("VisiualContent/PointHead");
        HeadLine.SetPosition(0, new Vector3(0, 0, 0));
        // setup the ar content ui
        Transform ARCtrlGroup = GetRobotCanvas().transform.Find("ARCtrlBtnGroup");
        ARCtrlGroup.Find("AR").GetComponent<Toggle>().onValueChanged.AddListener((value) => ShowVirtualRobot(value));
        ARCtrlGroup.Find("FramesToggle").GetComponent<Toggle>().onValueChanged.AddListener((value) => ShowFrame(value));
        ARCtrlGroup.Find("3DToggle").GetComponent<Toggle>().onValueChanged.AddListener((value) => Show3DWorkSpace(value));
        ARCtrlGroup.Find("VertToggle").GetComponent<Toggle>().onValueChanged.AddListener((value) => ShowVertWorkSpace(value));
        ARCtrlGroup.Find("HorzToggle").GetComponent<Toggle>().onValueChanged.AddListener((value) => ShowHorizWorkSpace(value));
    }
    void FixedUpdate(){
        
        Vector3 origin = _robotJointController.GetJointTransform(0).position;
        Vector3 end = _robotJointController.GetJointTransform(_currentDoF).position;
        Vector3 subEnd = end - Vector3.Normalize(end - origin) * 0.015f;
        HeadLine.SetPosition(0, origin);
        HeadLine.SetPosition(1, subEnd);
        PointHead.transform.SetPositionAndRotation(end, Quaternion.LookRotation(end - origin));
    }
    #endregion
    #region Methods
    public bool CheckCollision(int index, float angle)
    {
        if (!_enableCollisionChecker) return false;
        //if (!_robotClient.IsConnected()) return false;
        
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


    // Real Robot Arm Command
    //public List<int> GetReadPWM(){ return _robotClient.GetFeedbackPWM(); }
    //public List<int> GetCmdPWM() { return _robotClient.GetCmdPWM(); }
    //public void SetFeedbackCaliData(List<float> offset, List<float> scale){_robotClient.SetFeedBackCaliData(offset, scale);}
    //public void SetCmdCaliData(List<float> offset, List<float> scale){_robotClient.SetCmdCaliData(offset, scale);}
    //public void UnlockRobotArm() { _robotClient.Unlock(); }
    //public void LockRobotArm() { SetCmdJointAngles(_robotJointController.GetJointAngles()); _robotClient.Lock(); }
    //public void SetRobotArmConnect(bool value) { _robotClient.SetConnect(value); }
    //public void SetRobotArmLock(bool value) { SetCmdJointAngles(_robotJointController.GetJointAngles());  if (value) _robotClient.Lock(); else _robotClient.Unlock(); }
    //public void SetRobotArmFilter(int index) { _robotClient.SetFilter(index); }
    //public void SetRobotArmFilterWindow(int windowSie) { _robotClient.SetAverageWindowSize(windowSie); }
    
    // Robot Client Setting
    //public void PauseSendCmdToRobot(){_robotClient.SendCmd = false;}
    //public void StartSendCmdToRobot(){_robotClient.SendCmd = true;}

    // AR Content Setting
    public void Show3DWorkSpace(bool value){transform.Find("VisiualContent/Workingspace/3d").gameObject.SetActive(value);}
    public void ShowHorizWorkSpace(bool value){transform.Find("VisiualContent/Workingspace/horiz").gameObject.SetActive(value);}
    public void ShowVertWorkSpace(bool value){transform.Find("VisiualContent/Workingspace/vert").gameObject.SetActive(value);}
    public void ShowFrame(bool value){
        HeadLine.gameObject.SetActive(value);
        PointHead.gameObject.SetActive(value);
        _robotJointController.ShowJointsFrame(value);
    }
    public void SetJointSignActivate(bool value) { _robotJointController.SetJointSignActivate(value); }
    public void SetLinkSignActivate(bool value) { _robotJointController.SetLinkSignActivate(value); }
    public void ShowVirtualRobot(bool value) 
    {
        if (!value)
        {
            _robotJointController.HideJointLink(0);
            _robotJointController.HideJointLink(1);
            _robotJointController.HideJointLink(2);
        }
        else
        {
            _robotJointController.ShowJointLink(0);
            _robotJointController.ShowJointLink(1);
            _robotJointController.ShowJointLink(2);
        }
    }
    public void SetJointSign(int index, string line1, string line2) { _robotJointController.SetJointSign(index, line1, line2); }
    public void SetJointSignActivate(int index, bool value) { _robotJointController.SetJointSignActivate(index, value); }
    public void SetLinkSignActivate(int index, bool value) { _robotJointController.SetLinkSignActivate(index, value); }

    // Get Joint Status
    public float GetJointAngle(int index) { return GetJointAngles()[index]; }
    public float GetTransparentJointAngle(int index) { return _transparentRobotJointController.GetJointAngle(index); }
    public List<float> GetJointAngles() { return _robotJointController.GetJointAngles(); }
    public List<float> GetCmdJointAngles() { return CmdJointAngles; }
    public List<int> GetSendPWM() { return _pwmList; }

    // Set Joint Status
    public void SetJointPWMs(List<int> pwm)
    {
        for (int index = 0; index < pwm.Count; index++)
        {
            SetJointPWM(index, pwm[index]);
        }
    }
    public void SetJointPWM(int index, int pwm)
    {
        //_robotClient.SendPWMCmd(index, pwm);
        //SetJointAngle(index, (pwm - _offset[index]) / _scale[index]);
    }
    public void SetCmdJointAngles(List<float> angles)
    {
        _joystickController.SetAngleSliderValues(angles);
        CmdJointAngles = angles;
        _robotJointController.SetJointAngles(angles);
    }
    public void SetCmdJointAngle(int index, float angle)
    {
        CmdJointAngles[index] = angle;
        _robotJointController.SetJointAngle(index, angle);
    }
    public void SetTransparentCmdJointAngles(List<float> angles) { _transparentRobotJointController.SetJointAngles(angles); }
    public void SetTransparentCmdJointAngle(int index, float angle) { if(_robotControllerUI._sliderStatus == 0) _transparentRobotJointController.SetJointAngle(index, angle); }
    public void MoveJointsTo(List<float> angleList)
    {
        _staticRobotTrajectoryController.ResetTraj(_currentDoF);
        _staticRobotTrajectoryController.PushTrajPoints(angleList.GetRange(0, _currentDoF));
        _staticRobotTrajectoryController.SetStatus(StaticRobotTrajectoryController.State.ready);
        _staticRobotTrajectoryController.StartTraj();
    }
    public void MoveJointTo(int index, float value)
    {
        List<float> angleList = _robotJointController.GetJointAngles();
        angleList[index] = value;
        MoveJointsTo(angleList);
    }
    

    // Endeffector Command
    public void ResetEndEffector() { _endEffectorController.ResetEndEffector(); }
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
    public void Fire(){ _endEffectorController.Fire(); }

    // Get Robot parameters
    public int GetRobotDoF() { return _currentDoF; }

    // Set Robot Parameters
    public void SetRobotDoF(int dof)
    {
        List<Transform> jointTransforms = _robotJointController.GetJointsTransform();
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
        _endEffectorController.transform.SetParent(_robotJointController.GetJointTransform(dof - 1));
        _endEffectorController.transform.localPosition = _robotJointController.GetJointTransform(dof).localPosition;
        _endEffectorController.transform.localEulerAngles = Vector3.zero;
        _currentDoF = dof;
    }    
    public void SetForce(float force) { _endEffectorController.SetForce(force); }

    // Get component
    public GameObject GetRobotCanvas() { return _robotCanvas; }
    public RobotJointController GetRobotJointController() { return _robotJointController; }
    public RobotControllerUI GetJoystickController() { return _joystickController; }
    public PathRecoder GetPathRecoder() { return _pathRecoder; }
    //public StaticRobotTrajectoryController GetTrajController() { return _staticRobotTrajectoryController; }
    //public EditorController GetEditorController() { return _editorController; }
    
    #endregion
}
