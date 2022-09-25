using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private EndEffectorController _endEffectorController;
    [SerializeField]
    private RobotJoystickController _joystickController;
    [SerializeField]
    private RobotJointController _robotJointController;
    [SerializeField]
    private EditorController _editorController;
    [SerializeField]
    private RobotClient _robotClient;
    [SerializeField]
    private PathRecoder _pathRecoder;
    private List<float> _offset = new List<float>() { 5291.044970195919f, 7582.74192603952f, 6625.3032796151165f, 0, 0, 0 };
    private List<float> _scale = new List<float>() { 31.11781897735022f, -31.795396910065065f, 32.084929193885245f, 0, 0, 0 };
    [SerializeField]
    private StaticRobotTrajectoryController _staticRobotTrajectoryController;
    private int _currentDoF = 6;
    static public float A1 = 10;  //length properties of the teaching robot arm (in cm)
    static public float A2 = 2.8f; //length properties of the teaching robot arm (in cm)
    static public float L1 = 19.2f; //length properties of the teaching robot arm (in cm)
    static public float L2 = 21;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap
    private List<int> _pwmList = new List<int>() { 0, 0, 0, 0, 0, 0 };
    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("set joints");
        SetRobotDoF(3);
        SetJointAngles(new List<float> { 0, 180, -140, 0, 0, 0 });
    }
    // Update is called once per frame
    void Update()
    {
        _pathRecoder.AddPoint(_robotJointController.GetJointTransformByIndex(_currentDoF).position);

    }
    #endregion
    #region Methods
    public void SetJointAngle(int index, float angle)
    {
        //LockRobotArm();
        _robotJointController.SetJointAngle(index, angle);
        _joystickController.SetAngleSliderValue(index, angle);
        _pwmList[index] = (int)(GetJointAngle(index) * _scale[index] + _offset[index]);
    }
    public List<int> GetSendPWM()
    {
        return _pwmList;
    }
    public void SetJointPWM(int index, int pwm)
    {
        _pwmList[index] = pwm;
        SetJointAngle(index, (pwm - _offset[index]) / _scale[index]);
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
    public void SetJointAngles(List<float> angles)
    {
        //LockRobotArm();
        _pathRecoder.AddPoint(_robotJointController.GetJointTransformByIndex(_currentDoF).position);
        for (int i = 0; i < angles.Count; i++)
        {
            _joystickController.SetAngleSliderValue(i, angles[i]);
        }
        for(int i = 0; i < _pwmList.Count; i++)
        {
            _pwmList[i] = (int)(GetJointAngle(i) * _scale[i] + _offset[i]);
        }
        _robotJointController.SetJointAngles(angles);
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
        Debug.Log(_editorController);
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
        return _robotClient.GetReadPWM();
    }
    public void SetCaliData(List<float> offset, List<float> scale, int groupNumber = 0)
    {

        _offset = offset;
        _scale = scale;
        for(int i = 0; i < _offset.Count; i++)
        {
            PlayerPrefs.SetFloat("_offset" + i, _offset[i]);
            PlayerPrefs.SetFloat("_scale" + i, _scale[i]);
        }
        PlayerPrefs.Save();
    }
    public RobotJoystickController GetJoystickController() { return _joystickController; }
    public void HideJointLink(int index) { _robotJointController.HideJointLink(index); }
    public void ShowJointLink(int index) { _robotJointController.ShowJointLink(index); }
    public void UnlockRobotArm() { _robotClient.Unlock(); }
    public void LockRobotArm() { _robotClient.Lock(); }
    public void SetRobotArmLock(bool value) { if (value) _robotClient.Lock(); else _robotClient.Unlock(); }
    public void SetJointSignActivate(bool value) { _robotJointController.SetSignActivate(value); }

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
    #endregion
}
