using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RobotControllerUI : MonoBehaviour
{
    #region Variables
    private Transform _joyStickPanel;
    private RobotController _robotController;
    private List<Slider> _jointAngleSliders = new List<Slider>();
    private List<Text> _jointAngleSLiderValueTexts = new List<Text>();
    private Slider _forceSlider;
    private Text _forceText;
    private Button _fireButton;
    public bool isUserInteracting;
    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        _robotController = GetComponent<RobotController>();
        _joyStickPanel = _robotController.GetRobotCanvas().transform.Find("Joystick/Panel");
        SetupJoystickPanel(_joyStickPanel);
        SetupControlBar(_robotController.GetRobotCanvas().transform.Find("TrajCtrlBtnGroup"));
        SetupSettingPanel(_robotController.GetRobotCanvas().transform.Find("RobotSettingPanel/Window"));
        //Debug.Log(_jointAngleSliders.Count);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Methods
    public void SetAngleSliderValue(int index, float value, bool isUserInteracting)
    {
        _jointAngleSliders[index].value = value;
        _jointAngleSLiderValueTexts[index].text = value.ToString("F0");
        _robotController.SetJointAngle(index, value);
    }
    public float GetJointAngleMax(int index)
    {
        return _jointAngleSliders[index].maxValue;
    }
    public float GetJointAngleMin(int index)
    {
        return _jointAngleSliders[index].minValue;
    }
    public void HideHandleText()
    {
        foreach(var text in _jointAngleSLiderValueTexts)
        {
            text.transform.localEulerAngles = new Vector3(0, 90, 0);
            //text.transform.localScale = Vector3.zero;
        }
    }
    public void ShowHandleText()
    {

        foreach (var text in _jointAngleSLiderValueTexts)
        {
            text.transform.localEulerAngles = Vector3.zero;
            //text.transform.localScale = Vector3.one / 10;
        }
    }
    public void SetupJoystickPanel(Transform panel)
    {
        _joyStickPanel = panel;
        _jointAngleSliders.Clear();
        _jointAngleSLiderValueTexts.Clear();
        for (int i = 0; i < _joyStickPanel.childCount; i++)
        {
            Transform child = _joyStickPanel.GetChild(i);
            if (child.name.Contains("Joint"))
            {
                _jointAngleSliders.Add(child.GetComponent<Slider>());
                _jointAngleSLiderValueTexts.Add(child.Find("Handle Slide Area/Handle/Value").GetComponent<Text>());
                _jointAngleSLiderValueTexts[i].text = _jointAngleSliders[i].value.ToString("F0");
                child.GetComponent<Slider>().onValueChanged.AddListener((value) => _robotController.SetCmdJointAngle(child.name[child.name.Length - 1] - '0', value, isUserInteracting));
                EventTrigger eventTrigger = child.gameObject.AddComponent<EventTrigger>();
                EventTrigger.Entry pointerDownEntry = new EventTrigger.Entry();
                pointerDownEntry.eventID = EventTriggerType.PointerDown;
                pointerDownEntry.callback.AddListener(OnPointerDown);
                eventTrigger.triggers.Add(pointerDownEntry);
                EventTrigger.Entry pointerUpEntry = new EventTrigger.Entry();
                pointerUpEntry.eventID = EventTriggerType.PointerUp;
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
                _forceText = child.Find("Handle Slide Area/Handle/Value").GetComponent<Text>();
                _forceSlider.onValueChanged.AddListener({_robotController.SetForce; _forceText.text = _forceSlider.value.ToString("F0"); });
            }
        }

    }
    public void OnPointerDown(BaseEventData eventData)
    {
        // The user starts interacting with the slider (clicks on it)
        isUserInteracting = true;
    }

    public void OnPointerUp(BaseEventData eventData)
    {
        // The user stops interacting with the slider (releases the click)
        isUserInteracting = false;
    }
    public void EnableForce(bool value)
    {
        Debug.Log(value);
        _joyStickPanel.Find("Force").GetComponent<Slider>().interactable = value;
    }
    public void SetupControlBar(Transform robotCtrlBtnGroup)
    {
        robotCtrlBtnGroup.Find("play").GetComponent<Button>().onClick.AddListener(() => _robotController.GetEditorController().StartTraj());
        robotCtrlBtnGroup.Find("loop").GetComponent<Button>().onClick.AddListener(() => _robotController.GetEditorController().LoopTraj());
        robotCtrlBtnGroup.Find("reset").GetComponent<Button>().onClick.AddListener(() => _robotController.GetEditorController().StopTraj());
        robotCtrlBtnGroup.Find("erase").GetComponent<Button>().onClick.AddListener(() => _robotController.GetPathRecoder().ClearRecording());
        robotCtrlBtnGroup.Find("draw").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.GetPathRecoder().SetRecording(value));
    }
    public void SetupSettingPanel(Transform panel)
    {
        panel.Find("Robot/RobotType/Dropdown").gameObject.GetComponent<Dropdown>().onValueChanged.AddListener((value) => _robotController.SetRobotDoF(value));
        panel.Find("Robot/EndEffector/Dropdown").gameObject.GetComponent<Dropdown>().onValueChanged.AddListener((value) => _robotController.SetEndEffector(value));
        panel.Find("Robot/RobotServer/Connect/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.SetRobotArmConnect(value));
        panel.Find("Robot/RobotServer/Lock/Toggle").gameObject.GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.SetRobotArmLock(value));
        panel.Find("Robot/Filter/Dropdown").gameObject.GetComponent<Dropdown>().onValueChanged.AddListener((value) => _robotController.SetRobotArmFilter(value));
        panel.Find("Robot/Filter/Slider").gameObject.GetComponent<Slider>().onValueChanged.AddListener((value) => _robotController.SetRobotArmFilterWindow((int)value));
    }
    #endregion
}
