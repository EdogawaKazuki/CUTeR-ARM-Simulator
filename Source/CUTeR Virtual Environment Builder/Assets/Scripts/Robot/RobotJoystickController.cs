using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotJoystickController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Transform _joyStickPanel;
    [SerializeField]
    private RobotController _robotController;
    private List<Slider> _jointAngleSliders = new List<Slider>();
    private List<Text> _jointAngleSLiderValueTexts = new List<Text>();
    private Slider _forceSlider;
    private Button _fireButton;
    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {
        SetJoystickPanel(_joyStickPanel);
        //Debug.Log(_jointAngleSliders.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Methods
    public void SetAngleSliderValue(int index, float value)
    {
        //Debug.Log(index);
        _jointAngleSliders[index].value = value;
        _jointAngleSLiderValueTexts[index].text = value.ToString("F0");
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
            text.transform.localScale = Vector3.zero;
        }
    }
    public void ShowHandleText()
    {

        foreach (var text in _jointAngleSLiderValueTexts)
        {
            text.transform.localScale = Vector3.one;
        }
    }
    public void SetJoystickPanel(Transform panel)
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
                child.GetComponent<Slider>().onValueChanged.AddListener((value) => _robotController.SetJointAngle(child.name[child.name.Length - 1] - '0', value));
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
    #endregion
}
