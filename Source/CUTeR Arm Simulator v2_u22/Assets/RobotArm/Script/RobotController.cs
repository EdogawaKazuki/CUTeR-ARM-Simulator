using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    private RobotClient _robotClient;
    private PathRecoder _pathRecoder;
    private GameObject _robotCanvas;
    private List<float> _cmdOffset;
    private List<float> _cmdScale;
    private StaticRobotTrajectoryController _staticRobotTrajectoryController;

    private LineRenderer HeadLine;
    private Transform PointHead;

    private int MAX_ROBOT_DOF;
    [SerializeField]
    private int INIT_ROBOT_DOF = 3;
    [SerializeField]
    private bool _enableCollisionChecker = true;
    [SerializeField]
    public bool _enableTransparentRobot = false;


    enum RobotIndex
    {
        green,
        red,
    }
    private int _currentDoF = 6;
    public float A1 = 10.8f;  //length properties of the teaching robot arm (in cm)
    public float A2 = 2.8f; //length properties of the teaching robot arm (in cm)
    public float L1 = 19.4f; //length properties of the teaching robot arm (in cm)
    public float L2 = 21;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap
    public float L2_6DoF = 25.01f;
    public float L3_6DoF = 3.2f; //length properties of the teaching robot arm (in cm)

    private List<int> _pwmList;

    public List<float> CmdJointAngles;
    
    private bool _previousConnectedStatus = false;

    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {
        // Get the max robot dof from the model
        MAX_ROBOT_DOF = _robotJointController.GetJointAngles().Count;

        // init variable lists
        CmdJointAngles = new List<float>(new float[MAX_ROBOT_DOF]);
        _cmdOffset = new List<float> { 1500, 2300, 2200 };
        _cmdScale = new List<float>{ 10, -10, 10 };
        _pwmList = new List<int>(new int[MAX_ROBOT_DOF]);

        // read the offset and scale from the player prefs
        for (int i = 0; i < _cmdOffset.Count; i++)
        {
            _cmdOffset[i] = PlayerPrefs.GetFloat("_offset" + i, _cmdOffset[i]);
            _cmdScale[i] = PlayerPrefs.GetFloat("_scale" + i, _cmdScale[i]);
        }

        // set init robot dof
        SetRobotDoF(INIT_ROBOT_DOF);
    }
    void OnDisable()
    {
        for(int i = 0; i < _cmdOffset.Count; i++)
        {
            PlayerPrefs.SetFloat("_offset" + i, _cmdOffset[i]);
            PlayerPrefs.SetFloat("_scale" + i, _cmdScale[i]);
        }
    }
    void OnEnable()
    {
        
        // asign hooks
        _robotControllerUI = GetComponent<RobotControllerUI>();
        _robotCanvas = transform.Find("RobotCanvas").gameObject;
        //_editorController = transform.Find("/EditorAdmin").GetComponent<EditorController>();
        _joystickController = GetComponent<RobotControllerUI>();
        _robotClient = GetComponent<RobotClient>();
        _pathRecoder = GetComponent<PathRecoder>();
        _staticRobotTrajectoryController = GetComponent<StaticRobotTrajectoryController>();
        _endEffectorController = transform.Find("EndEffectors").GetComponent<EndEffectorController>();
        _robotJointController = transform.Find("Joints").GetComponent<RobotJointController>();
        _transparentRobotJointController = transform.Find("Joints Transparent").GetComponent<RobotJointController>();
        _robotJointController.SetPathRoot("Joints");
        _transparentRobotJointController.SetPathRoot("Joints Transparent");
        
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
        HideTransparentModel();
    }
    void FixedUpdate(){
        
        RobotJointController controller = _robotClient.IsConnected() ? _transparentRobotJointController : _robotJointController;
        Vector3 origin = controller.GetJointTransform(0).position;
        Vector3 end = controller.GetJointTransform(_currentDoF).position;
        Vector3 subEnd = end - Vector3.Normalize(end - origin) * 0.015f;
        HeadLine.SetPosition(0, origin);
        HeadLine.SetPosition(1, subEnd);
        PointHead.transform.SetPositionAndRotation(end, Quaternion.LookRotation(end - origin));

        bool isConnected = _robotClient.IsConnected();
        if (isConnected && !_previousConnectedStatus) // Rising edge detection
        {
            _robotJointController.SetJointsVisible(true);
            _endEffectorController.HideEndEffector();
        }
        else if (!isConnected && _previousConnectedStatus) // Falling edge detection
        {
            _robotJointController.SetJointsVisible(false);
            _endEffectorController.SetEndEffector(0);
        }
        _previousConnectedStatus = isConnected; // Update previous status
        Debug.Log("Is robot connected: " + isConnected);
    }
    #endregion
    #region Methods
    public bool CheckCollisionTransparent()
    {
        if (!_enableCollisionChecker) return false;
        Vector3 endeffectorPosition = _transparentRobotJointController.GetJointTransform(_currentDoF).position;
        Vector3 origin = _transparentRobotJointController.GetJointTransform(0).position;
        float x = endeffectorPosition.x - origin.x;
        float y = endeffectorPosition.y - origin.y;
        float z = endeffectorPosition.z - origin.z;
        Debug.Log("x: " + x + " y: " + y + " z: " + z);
        if (x < -0.4 || x > 0.4) return true;
        if (y < 0.1 || y > 1) return true;
        if (z < -0.7 || z > 0) return true;


        return false;
        // //if (!_robotClient.IsConnected()) return false;
        
        // float[] angles = GetJointAngles().ToArray();

        // angles[index] = angle;
        // double Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * angles[0]);
        // double Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * angles[0]);
        // double Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * angles[1]);
        // double Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * angles[1]);
        // double Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (angles[1] + angles[2]));
        // double Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (angles[1] + angles[2]));
        // double x = -Angle1Sin * Angle23Cos * 21 + (-19.2 * Angle1Sin * Angle2Cos - 2.8 * Angle1Sin * Angle2Sin) + 0.001;
        // double y = Angle1Cos * Angle23Cos * 21 + (19.2 * Angle1Cos * Angle2Cos + 2.8 * Angle1Cos * Angle2Sin) + 0.001;
        // double z = Angle23Sin * 21 + (19.2 * Angle2Sin - 2.8 * Angle2Cos) + 10.001;
        // if (z < 0) return true;
        // return false;
    }


    // Real Robot Arm Command
    public List<int> GetReadPWM(){ return _robotClient.GetFeedbackPWM(); }
    public List<int> GetCmdPWM() { return _robotClient.GetCmdPWM(); }
    public void SetFeedbackCaliData(List<float> offset, List<float> scale){_robotClient.SetFeedBackCaliData(offset, scale);}
    public void SetCmdCaliData(List<float> offset, List<float> scale){_robotClient.SetCmdCaliData(offset, scale); _cmdOffset = offset; _cmdScale = scale;}
    public void SetRobotArmLock(bool value) { SetCmdJointAngles(_robotJointController.GetJointAngles());  _robotClient.Lock(value); }
    public List<float> GetFeedbackOffset() { return _robotClient.GetFeedbackOffset(); }
    public List<float> GetCmdOffset() { return _robotClient.GetCmdOffset(); }
    public List<float> GetFeedbackScale() { return _robotClient.GetFeedbackScale(); }
    public List<float> GetCmdScale() { return _robotClient.GetCmdScale(); }

    //public void SetRobotArmFilter(int index) { _robotClient.SetFilter(index); }
    //public void SetRobotArmFilterWindow(int windowSie) { _robotClient.SetAverageWindowSize(windowSie); }
    
    // Robot Client Setting
    public void PauseSendCmdToRobot(){_robotClient.SendCmd = false;}
    public void StartSendCmdToRobot(){_robotClient.SendCmd = true;}

    // AR Content Setting
    public void Show3DWorkSpace(bool value){transform.Find("VisiualContent/Workingspace/3d").gameObject.SetActive(value);}
    public void ShowHorizWorkSpace(bool value){transform.Find("VisiualContent/Workingspace/horiz").gameObject.SetActive(value);}
    public void ShowVertWorkSpace(bool value){transform.Find("VisiualContent/Workingspace/vert").gameObject.SetActive(value);}
    public void ShowFrame(bool value){
        HeadLine.gameObject.SetActive(value);
        PointHead.gameObject.SetActive(value);
        _robotJointController.ShowJointsFrame(value && !_robotClient.IsConnected());
        _transparentRobotJointController.ShowJointsFrame(value && _robotClient.IsConnected());
    }
    public void SetJointSignActivate(bool value) { _robotJointController.SetJointSignActivate(value); }
    public void SetLinkSignActivate(bool value) { _robotJointController.SetLinkSignActivate(value); }
    public void ShowVirtualRobot(bool value) 
    {
        if (!value || _robotClient.IsConnected())
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
    public List<float> GetJointAngles() { 
        bool isConnected = _robotClient.IsConnected();
        if (isConnected) {
            return _transparentRobotJointController.GetJointAngles();
        } else {
            return _robotJointController.GetJointAngles();
        }
    }
    public List<float> GetCmdJointAngles() { return CmdJointAngles; }
    public List<int> GetSendPWM() { return _pwmList; }
    public List<Transform> GetJointsTransform() { return _robotJointController.GetJointsTransform(); }

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
        _robotClient.SendPWMCmd(index, pwm);
        SetCmdJointAngle(index, (pwm - _cmdOffset[index]) / _cmdScale[index]);
        SetTransparentCmdJointAngle(index, (pwm - _cmdOffset[index]) / _cmdScale[index]);
    }
    public void SetCmdJointAngles(List<float> angleList)
    {
        if(angleList.Count < _currentDoF){
            angleList.AddRange(new float[_currentDoF - angleList.Count]);
            for(int i = 0; i < _currentDoF; i++)
            {
                if(angleList[i] == 0) angleList[i] = GetJointAngle(i);
            }
        }
        _joystickController.SetAngleSliderValues(angleList.GetRange(0, _currentDoF));
        CmdJointAngles = angleList;
        _robotJointController.SetJointAngles(angleList.GetRange(0, _currentDoF));
    }
    public void SetCmdJointAngle(int index, float angle)
    {
        CmdJointAngles[index] = angle;
        _robotJointController.SetJointAngle(index, angle);
    }
    public void HideTransparentModel() { 
        for(int i = 0; i < _currentDoF; i++)
        _transparentRobotJointController.HideJointLink(i); 
        _transparentRobotJointController.transform.Find("Part")?.gameObject.SetActive(false);
    }
    public void ShowTransparentModel() { 
        for(int i = 0; i < _currentDoF; i++)
        _transparentRobotJointController.ShowJointLink(i); 
        _transparentRobotJointController.transform.Find("Part")?.gameObject.SetActive(true);
    }
    public void SetTransparentCmdJointAngles(List<float> angles) { 
        _transparentRobotJointController.SetJointAngles(angles); 

        if(!_enableTransparentRobot || _robotClient.IsConnected()) return;
        ShowTransparentModel();
    }
    public void SetTransparentCmdJointAngle(int index, float angle) { 
        _transparentRobotJointController.SetJointAngle(index, angle); 

        if(!_enableTransparentRobot || _robotClient.IsConnected()) return;
        ShowTransparentModel();
        if(CheckCollisionTransparent()){
            _transparentRobotJointController.SetColor(new Color(1, 0, 0, 0.254902f));
        }else{
            _transparentRobotJointController.SetColor(new Color(1, 1, 1, 0.254902f));
        }
    }
    public void MoveJointsTo(List<float> angleList)
    {
        if(angleList.Count < _currentDoF){
            angleList.AddRange(new float[_currentDoF - angleList.Count]);
            for(int i = 0; i < _currentDoF; i++)
            {
                if(angleList[i] == 0) angleList[i] = GetJointAngle(i);
            }
        }
        _staticRobotTrajectoryController.ResetTraj(_currentDoF);
        _staticRobotTrajectoryController.PushTrajPoints(angleList.GetRange(0, _currentDoF));
        _staticRobotTrajectoryController.SetStatus(StaticRobotTrajectoryController.State.ready);
        _staticRobotTrajectoryController.StartTraj();
    }
    public void MoveJointTo(int index, float value)
    {
        List<float> angleList = _robotJointController.GetJointAngles();
        angleList[index] = value;
        if(RobotClient.ROBOT_TYPE == 1 && _robotClient.IsConnected()){
            _robotClient.SendJointCmdDirect(angleList, 2.0f);
            return;
        }
        MoveJointsTo(angleList);
        if(_enableTransparentRobot)
            HideTransparentModel();
    }
    public void SendCmdToRobot(float path_time)
    {
        if(RobotClient.ROBOT_TYPE == 1 && _robotClient.IsConnected())
        {
            _robotClient.SendJointCmdDirect(CmdJointAngles, path_time);
        }
    }
    public void SetMask(bool value) { _robotJointController.SetMask(value); }
    public void ShowJointDHFrame(int index, bool value) { _robotJointController.ShowJointDHFrame(index, value); }
    public void ShowJointsDHFrame(bool value) { _robotJointController.ShowJointsDHFrame(value); }
    public void SetRobotVisible(bool value) { _robotJointController.SetJointsVisible(value); }
    // Endeffector Command
    public void ResetEndEffector() { _endEffectorController.ResetEndEffector(); }
    public void SetEndEffector(int index)
    {
        _endEffectorController.SetEndEffector(index);
        // Debug.Log(index);
        if(_endEffectorController.GetEndEffectorList()[index] == "Launcher")
        {
            _joystickController.EnableForce(true);
        }
        else
        {
            _joystickController.EnableForce(false);
        }

        if(_endEffectorController.GetEndEffectorList()[index] == "Launcher" || _endEffectorController.GetEndEffectorList()[index] == "Gripper")
        {
            _joystickController.EnableFire(true);
        }
        else
        {
            _joystickController.EnableFire(false);
        }
    }
    public void Fire(){ _endEffectorController.Fire(); }

    // Get Robot parameters
    public int GetRobotDoF() { return _currentDoF; }
    public int GetJointAngleMax(int index) { return _robotJointController.GetJointAngleMax(index); }
    public int GetJointAngleMin(int index) { return _robotJointController.GetJointAngleMin(index); }
    public List<string> GetEndEffectorNameList(){  return _endEffectorController.GetEndEffectorList(); }

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

        SetTransparentRobotDoF(dof);
        _robotControllerUI.SetRobotDoF(dof);
        _endEffectorController.transform.SetParent(_robotJointController.GetJointTransform(dof - 1));
        _endEffectorController.transform.localPosition = _robotJointController.GetJointTransform(dof).localPosition;
        _endEffectorController.transform.localEulerAngles = Vector3.zero;
        _currentDoF = dof;
    }    
    public void SetTransparentRobotDoF(int dof)
    {
        List<Transform> jointTransforms = _transparentRobotJointController.GetJointsTransform();
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
    }    
    public void SetForce(float force) { _endEffectorController.SetForce(force); }

    // Get component
    public GameObject GetRobotCanvas() { return _robotCanvas; }
    public RobotJointController GetRobotJointController() { return _robotJointController; }
    public RobotControllerUI GetJoystickController() { return _joystickController; }
    public PathRecoder GetPathRecoder() { return _pathRecoder; }
    public StaticRobotTrajectoryController GetTrajController() { return _staticRobotTrajectoryController; }
    //public EditorController GetEditorController() { return _editorController; }
    
    public float[] CartesianToAngle(float x, float y, float z)
    {
        x = -x;
        y = -y;
        float[] angles = new float[3];
        float L23 = Mathf.Sqrt(L1 * L1 + A2 * A2);
        float alpha = Mathf.Atan(A2 / L1);
        if (x == 0)
        {
            angles[0] = Mathf.PI / 2;
        }
        else
        {
            if (x > 0)
            {
                angles[0] = Mathf.Atan(-y / x);
            }
            else
            {
                angles[0] = Mathf.PI - Mathf.Atan(y / x);
            }
        }
        float A = -y * Mathf.Sin(angles[0]) + x * Mathf.Cos(angles[0]);
        float B = z - A1;
        float tmp = (A * A + B * B - (L23 * L23 + L2 * L2)) / (2 * L23 * L2);
        if (tmp < -1)
            tmp = -0.999999f;
        if (tmp > 1)
            tmp = 0.99999f;
        angles[2] = -Mathf.Acos(tmp);
        if ((A * (L23 + L2 * Mathf.Cos(angles[2])) + B * L2 * Mathf.Sin(angles[2])) > 0)
            angles[1] = Mathf.Atan((B * (L23 + L2 * Mathf.Cos(angles[2])) - A * L2 * Mathf.Sin(angles[2])) /
                                   (A * (L23 + L2 * Mathf.Cos(angles[2])) + B * L2 * Mathf.Sin(angles[2])));
        else
            angles[1] = Mathf.PI - Mathf.Atan((B * (L23 + L2 * Mathf.Cos(angles[2])) - A * L2 * Mathf.Sin(angles[2])) /
                                   -(A * (L23 + L2 * Mathf.Cos(angles[2])) + B * L2 * Mathf.Sin(angles[2])));

        angles[0] = angles[0] / Mathf.PI * 180 - 90;
        angles[1] = (angles[1] + alpha) / Mathf.PI * 180;
        angles[2] = (angles[2] - alpha) / Mathf.PI * 180;
        return angles;
    }

    #endregion
}
