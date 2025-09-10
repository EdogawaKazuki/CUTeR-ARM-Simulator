using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

public class RobotControllerUI : MonoBehaviour
{
    #region Variables
    private Transform _joyStickPanel;
    private RobotController _robotController;
    private RobotClient _robotClient;
    private List<Slider> _jointAngleSliders = new();
    private List<TMP_Text> _jointAngleSLiderValueTexts = new();
    private Slider _forceSlider;
    private TMP_Text _forceSliderValueText;
    private Button _fireButton;
    private bool isUserInterect = false;
    public float[] _lastSliderValue;
    public int[] _sliderStatus;
    #endregion
    #region MonoBehaviour
    private void OnEnable()
    {
        _robotController = GetComponent<RobotController>();
        _robotClient = GetComponent<RobotClient>();
        _joyStickPanel = _robotController.GetRobotCanvas().transform.Find("Joystick/Panel");
        SetupJoystickPanel(_joyStickPanel);
        SetupSettingPanel(_robotController.GetRobotCanvas().transform.Find("RobotSettingPanel/Window"));
        EnableFire(false);
        EnableForce(false);
        _lastSliderValue = new float[_jointAngleSliders.Count];
        _sliderStatus = new int[_jointAngleSliders.Count];
        // SetupARControlbar(_robotController.GetRobotCanvas().transform.Find("ARCtrlBtnGroup"));
        //Debug.Log(_jointAngleSliders.Count);
    }
    #endregion
    #region Methods

    // Set joystick slider value
    public void SetAngleSliderValue(int index, float value)
    {
        // Debug.Log("index = " + index);
        if(!isUserInterect){
            return;
        }
        // Debug.Log(value);
        bool isCollision = _robotController.CheckCollisionTransparent();
        // Debug.Log("Slider: " + _sliderStatus[index] + " last: " + _lastSliderValue[index] + " collision: " + isCollision);
        if(isCollision){
            // if there is collision, set the slider value to the last value
            // if the value is greater than the last value, set the slider status to -1, means the slider is moving to the negative direction
            // if(value > _lastSliderValue[index])
            //     _sliderStatus[index] = -1;
            // else if(value < _lastSliderValue[index])
            //     _sliderStatus[index] = 1;
            _jointAngleSliders[index].value = _lastSliderValue[index];
        }
        else{
            // if there is no collision, set the slider value to the new value
            _lastSliderValue[index] = value;
            _sliderStatus[index] = 0;
            // _jointAngleSliders[index].value = value;
            _jointAngleSLiderValueTexts[index].text = value.ToString("F0");
        }
        
        // if(_sliderStatus[index] != 0){
        //     // if the slider is moving, check the direction of the slider, if the slider is supposed to move to the positive direction, and the value is greater than the last value, set the slider status to 0
        //     if(_sliderStatus[index] == 1 && value > _lastSliderValue[index]){
        //         _sliderStatus[index] = 0;
        //         _lastSliderValue[index] = value;
        //     }
        //     else if(_sliderStatus[index] == -1 && value < _lastSliderValue[index]){
        //         _sliderStatus[index] = 0;
        //         _lastSliderValue[index] = value;
        //     }
        // }
    }
    public void SetAngleSliderValues(List<float> values)
    {
        for(int i = 0; i < values.Count; i++)
        {
            _jointAngleSliders[i].value = values[i];
            _jointAngleSLiderValueTexts[i].text = values[i].ToString("F0");
        }
    }
    // Show or hide joystick handle text
    public void HideHandleText()
    {
        foreach(var text in _jointAngleSLiderValueTexts)
        {
            text.transform.localEulerAngles = new Vector3(0, 90, 0);
        }
    }
    public void ShowHandleText()
    {
        foreach (var text in _jointAngleSLiderValueTexts)
        {
            text.transform.localEulerAngles = Vector3.zero;
        }
    }
    // Setup panels
    public void SetupJoystickPanel(Transform panel)
    {
        // Debug.Log(_robotController.GetJointAngleMax(0));
        _joyStickPanel = panel.Find("Slider");
        _jointAngleSliders.Clear();
        _jointAngleSLiderValueTexts.Clear();
        for (int i = 0; i < _joyStickPanel.childCount; i++)
        {
            Transform child = _joyStickPanel.GetChild(i);
            if (child.name.Contains("Joint"))
            {
                _jointAngleSliders.Add(child.Find("Slider").GetComponent<Slider>());
                _jointAngleSliders[i].maxValue = _robotController.GetJointAngleMax(i);
                _jointAngleSliders[i].minValue = _robotController.GetJointAngleMin(i);
                _jointAngleSliders[i].value = _robotController.GetJointAngle(i);
                _jointAngleSLiderValueTexts.Add(child.Find("Slider/Handle Slide Area/Handle/Value").GetComponent<TMP_Text>());
                _jointAngleSLiderValueTexts[i].text = _jointAngleSliders[i].value.ToString("F0");
                // child.GetComponent<Slider>().onValueChanged.AddListener((value) => _robotController.SetCmdJointAngle(child.name[^1] - '0', value));
                child.Find("Slider").GetComponent<Slider>().onValueChanged.AddListener((value) => SetAngleSliderValue(child.name[^1] - '0', value));
                EventTrigger eventTrigger = child.Find("Slider").gameObject.AddComponent<EventTrigger>();
                EventTrigger.Entry pointerDownEntry = new(){ eventID = EventTriggerType.PointerDown };
                pointerDownEntry.callback.AddListener((eventData) => OnPointerDown(eventData, child.name[^1] - '0'));
                eventTrigger.triggers.Add(pointerDownEntry);
                EventTrigger.Entry pointerUpEntry = new(){ eventID = EventTriggerType.PointerUp };
                pointerUpEntry.callback.AddListener((eventData) => OnPointerUp(eventData, child.name[^1] - '0'));
                eventTrigger.triggers.Add(pointerUpEntry);
            }
            else if (child.name == "Fire")
            {
                _fireButton = child.Find("Button").GetComponent<Button>();
                _fireButton.onClick.AddListener(_robotController.Fire);
            }
            else if (child.name == "Force")
            {
                _forceSlider = child.Find("Slider").GetComponent<Slider>();
                _forceSliderValueText = child.Find("Slider/Handle Slide Area/Handle/Value").GetComponent<TMP_Text>();
                _forceSlider.onValueChanged.AddListener((value) =>{
                        _forceSliderValueText.text = value.ToString("F0");
                        _robotController.SetForce(value);
                    });
            }
        }

    }
    UnityEngine.Events.UnityAction<float> fn; // pointer for move transparent robot listener
    public void OnPointerDown(BaseEventData eventData, int index)
    {
        // Debug.Log("OnPointerDown: " + index);
        isUserInterect = true;
        // _lastSliderValue[index] = eventData.selectedObject.GetComponent<Slider>().value;
        // Debug.Log(_lastSliderValue);
        // add move transparent robot listenre  
        if(_robotController._enableTransparentRobot)
            eventData.selectedObject.GetComponent<Slider>().onValueChanged.AddListener(fn = (value) => _robotController.SetTransparentCmdJointAngle(index, value));
        else
            eventData.selectedObject.GetComponent<Slider>().onValueChanged.AddListener(fn = (value) => _robotController.SetCmdJointAngle(index, value));
        if(RobotClient.ROBOT_TYPE == RobotClient.RobotType.OpenManipulatorPro){
            _robotClient.isReceive = false;
        }
    }
    public void OnPointerUp(BaseEventData eventData, int index)
    {
        // Debug.Log("OnPointerUp: " + index);
        isUserInterect = false;
        // remove move transparent robot listenre  
        eventData.selectedObject.GetComponent<Slider>().onValueChanged.RemoveListener(fn);// Move "real robot" to transparent robot position

        if(_robotController._enableTransparentRobot){
            _robotController.MoveJointTo(index, _jointAngleSliders[index].value);
            // _robotController.HideTransparentModel();
        }
        // _sliderStatus[index] = 0;
        if(RobotClient.ROBOT_TYPE == RobotClient.RobotType.OpenManipulatorPro){
            _robotClient.isReceive = true;
        }
    }
    public void UpdateJoysticPanelkHeight(){
        int count = 8;
        for(int i = 0; i < _joyStickPanel.childCount; i++)
        {
            Transform child = _joyStickPanel.GetChild(i);
            if(child.gameObject.activeSelf)
            {
                count--;
            }
        }
        _joyStickPanel.parent.GetComponent<RectTransform>().offsetMin  = new Vector2(0, count * 30);
    }
    public void EnableFire(bool value)
    {
        _joyStickPanel.Find("Fire").gameObject.SetActive(value);  
        UpdateJoysticPanelkHeight();
    }
    public void EnableForce(bool value)
    {
        _joyStickPanel.Find("Force").gameObject.SetActive(value);
        _forceSlider.value = 50;
        UpdateJoysticPanelkHeight();
        // _joyStickPanel.getcom
    }
    // public void SetupControlBar(Transform robotCtrlBtnGroup)
    // {
    //     //robotCtrlBtnGroup.Find("play").GetComponent<Button>().onClick.AddListener(() => _robotController.GetEditorController().StartTraj());
    //     //robotCtrlBtnGroup.Find("loop").GetComponent<Button>().onClick.AddListener(() => _robotController.GetEditorController().LoopTraj());
    //     //robotCtrlBtnGroup.Find("reset").GetComponent<Button>().onClick.AddListener(() => _robotController.GetEditorController().StopTraj());
    //     robotCtrlBtnGroup.Find("erase").GetComponent<Button>().onClick.AddListener(() => _robotController.GetPathRecoder().ClearRecording());
    //     robotCtrlBtnGroup.Find("draw").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.GetPathRecoder().SetRecording(value));
    // }
    public void SetupSettingPanel(Transform panel)
    {
        // Setup Robot DoF Dropdown
        TMP_Dropdown tmp_Dropdown =  panel.Find("Robot/RobotType/Dropdown").gameObject.GetComponent<TMP_Dropdown>();
        tmp_Dropdown.ClearOptions();
        TMP_Dropdown.OptionData newData = new TMP_Dropdown.OptionData { text = "Select Robot DoF" };
        tmp_Dropdown.options.Add(newData);
        for(int i = 0; i < _robotController.GetRobotDoF(); i++){
            newData = new TMP_Dropdown.OptionData { text = (i + 1).ToString() };
            tmp_Dropdown.options.Add(newData);
        }
        tmp_Dropdown.value = _robotController.GetRobotDoF();
        tmp_Dropdown.onValueChanged.AddListener((value) => { if(value!= 0) _robotController.SetRobotDoF(value); });

        // Setup Robot Endeffector Dropdown
        
        tmp_Dropdown =  panel.Find("Robot/EndEffector/Dropdown").gameObject.GetComponent<TMP_Dropdown>();
        tmp_Dropdown.ClearOptions();
        newData = new TMP_Dropdown.OptionData { text = "Select Endeffector" };
        tmp_Dropdown.options.Add(newData);
        foreach(string name in _robotController.GetEndEffectorNameList()){
            newData = new TMP_Dropdown.OptionData { text = name };
            tmp_Dropdown.options.Add(newData);
        }
        tmp_Dropdown.value = 1;
        tmp_Dropdown.onValueChanged.AddListener((value) => { if(value!= 0) _robotController.SetEndEffector(value - 1); });

        // Setup Robot Connection
        // panel.Find("Robot/RobotServer/Robot/Connect/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.SetRobotArmConnect(value));
        // panel.Find("Robot/RobotServer/Robot/Lock/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.SetRobotArmLock(value));
        // panel.Find("Robot/Filter/Dropdown").gameObject.GetComponent<Dropdown>().onValueChanged.AddListener((value) => _robotController.SetRobotArmFilter(value));
        // panel.Find("Robot/Filter/Slider").gameObject.GetComponent<Slider>().onValueChanged.AddListener((value) => _robotController.SetRobotArmFilterWindow((int)value));
        panel.Find("Robot/SmoothSliding/Enable/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController._enableTransparentRobot = value);
    }
    public void SetRobotDoF(int value)
    {
        for (int i = 0; i < _joyStickPanel.childCount; i++)
        {
            Transform child = _joyStickPanel.GetChild(i);
            if (child.name.Contains("Joint"))
            {
                child.gameObject.SetActive(i < value);
            }
        }
        UpdateJoysticPanelkHeight();
    }
    #endregion
}
