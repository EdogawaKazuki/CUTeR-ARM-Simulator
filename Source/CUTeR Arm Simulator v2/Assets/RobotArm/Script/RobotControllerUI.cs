using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RobotControllerUI : MonoBehaviour
{
    #region Variables
    private Transform _joyStickPanel;
    private RobotController _robotController;
    private List<Slider> _jointAngleSliders = new();
    private List<Text> _jointAngleSLiderValueTexts = new();
    private Slider _forceSlider;
    private Button _fireButton;
    private bool isUserInterect = false;
    public float _lastSliderValue = 0;
    public int _sliderStatus = 0;
    #endregion
    #region MonoBehaviour
    private void OnEnable()
    {
        _robotController = GetComponent<RobotController>();
        _joyStickPanel = _robotController.GetRobotCanvas().transform.Find("Joystick/Panel");
        SetupJoystickPanel(_joyStickPanel);
        SetupSettingPanel(_robotController.GetRobotCanvas().transform.Find("RobotSettingPanel/Window"));
        // SetupARControlbar(_robotController.GetRobotCanvas().transform.Find("ARCtrlBtnGroup"));
        //Debug.Log(_jointAngleSliders.Count);
    }
    #endregion
    #region Methods

    // Set joystick slider value
    public void SetAngleSliderValue(int index, float value)
    {
        if(!isUserInterect){
            return;
        }
        // Debug.Log(value);
        if(_sliderStatus != 0){
            if(_sliderStatus == 1 && value > _lastSliderValue){
                _sliderStatus = 0;
            }
            else if(_sliderStatus == -1 && value < _lastSliderValue){
                _sliderStatus = 0;
            }
            else{
                _jointAngleSliders[index].value = _lastSliderValue;
                return;
            }
        }
        if(_robotController.CheckCollision(index, value)){
            if(value > _lastSliderValue)
                _sliderStatus = -1;
            else if(value < _lastSliderValue)
                _sliderStatus = 1;
            else
                _sliderStatus = 0;
            _jointAngleSliders[index].value = _lastSliderValue;
            return;
        }
        else{
            _lastSliderValue = value;
            // _jointAngleSliders[index].value = value;
            _jointAngleSLiderValueTexts[index].text = value.ToString("F0");
        }
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
                _jointAngleSliders.Add(child.GetComponent<Slider>());
                _jointAngleSliders[i].maxValue = _robotController.GetJointAngleMax(i);
                _jointAngleSliders[i].minValue = _robotController.GetJointAngleMin(i);
                _jointAngleSliders[i].value = _robotController.GetJointAngle(i);
                _jointAngleSLiderValueTexts.Add(child.Find("Handle Slide Area/Handle/Value").GetComponent<Text>());
                _jointAngleSLiderValueTexts[i].text = _jointAngleSliders[i].value.ToString("F0");
                // child.GetComponent<Slider>().onValueChanged.AddListener((value) => _robotController.SetCmdJointAngle(child.name[^1] - '0', value));
                child.GetComponent<Slider>().onValueChanged.AddListener((value) => SetAngleSliderValue(child.name[^1] - '0', value));
                EventTrigger eventTrigger = child.gameObject.AddComponent<EventTrigger>();
                EventTrigger.Entry pointerDownEntry = new(){ eventID = EventTriggerType.PointerDown };
                pointerDownEntry.callback.AddListener(OnPointerDown);
                eventTrigger.triggers.Add(pointerDownEntry);
                EventTrigger.Entry pointerUpEntry = new(){ eventID = EventTriggerType.PointerUp };
                pointerUpEntry.callback.AddListener(OnPointerUp);
                eventTrigger.triggers.Add(pointerUpEntry);
            }
            else if (child.name == "Fire")
            {
                _fireButton = child.GetComponent<Button>();
                _fireButton.onClick.AddListener(_robotController.Fire);
            }
            else if (child.name == "Force")
            {
                _forceSlider = child.GetComponent<Slider>();
                _forceSlider.onValueChanged.AddListener(_robotController.SetForce);
            }
        }

    }
    UnityEngine.Events.UnityAction<float> fn; // pointer for move transparent robot listener
    public void OnPointerDown(BaseEventData eventData)
    {
        isUserInterect = true;
        _lastSliderValue = eventData.selectedObject.GetComponent<Slider>().value;
        Debug.Log(_lastSliderValue);
        // add move transparent robot listenre  
        eventData.selectedObject.GetComponent<Slider>().onValueChanged.AddListener(fn = (value) => _robotController.SetTransparentCmdJointAngle(eventData.selectedObject.name[^1] - '0', value));
       
    }
    public void OnPointerUp(BaseEventData eventData)
    {
        isUserInterect = false;
        // remove move transparent robot listenre  
        eventData.selectedObject.GetComponent<Slider>().onValueChanged.RemoveListener(fn);// Move "real robot" to transparent robot position
        _robotController.MoveJointTo(eventData.selectedObject.name[^1] - '0', eventData.selectedObject.GetComponent<Slider>().value);
        _sliderStatus = 0;
    }
    public void EnableForce(bool value)
    {
        Debug.Log(value);
        _joyStickPanel.Find("Force").GetComponent<Slider>().interactable = value;
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
        panel.Find("Robot/RobotType/Dropdown").gameObject.GetComponent<Dropdown>().onValueChanged.AddListener((value) => _robotController.SetRobotDoF(value));
        panel.Find("Robot/EndEffector/Dropdown").gameObject.GetComponent<Dropdown>().onValueChanged.AddListener((value) => _robotController.SetEndEffector(value));
        panel.Find("Robot/RobotServer/Connect/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.SetRobotArmConnect(value));
        panel.Find("Robot/RobotServer/Lock/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.SetRobotArmLock(value));
        // panel.Find("Robot/Filter/Dropdown").gameObject.GetComponent<Dropdown>().onValueChanged.AddListener((value) => _robotController.SetRobotArmFilter(value));
        //panel.Find("Robot/Filter/Slider").gameObject.GetComponent<Slider>().onValueChanged.AddListener((value) => _robotController.SetRobotArmFilterWindow((int)value));
    }
    #endregion
}
