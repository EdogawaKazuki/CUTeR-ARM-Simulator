using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PWMCommand : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    private List<Text> PWMTextList = new List<Text>();
    private List<InputField> PWMInputfield = new List<InputField>() {null,null,null };
    private List<Button> addBtnList = new List<Button>() { null, null, null };
    private List<Button> minBtnList = new List<Button>() { null, null, null };
    private int scale = 5;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void FixedUpdate()
    {
    }

    private void OnEnable()
    {
        _robotController.GetJoystickController().HideHandleText();
        _trajController = _robotController.GetTrajController();
        for (int i = 0; i < 3; i++)
        {
            //Debug.Log("Input/Line" + (i + 1) + "/Value");
            //PWMTextList.Add(transform.Find("Input/Line" + (i + 1) + "/pwm").GetComponent<Text>());
            PWMInputfield[i] = transform.Find("Input/Line" + (i + 1) + "/pwm").GetComponent<InputField>();
            addBtnList[i] = transform.Find("Input/Line" + (i + 1) + "/+").GetComponent<Button>();
            minBtnList[i] = transform.Find("Input/Line" + (i + 1) + "/-").GetComponent<Button>();
        }
        for (int i = 0; i < 3; i++)
        {
            int index = i;
            PWMInputfield[i].onEndEdit.RemoveAllListeners();
            PWMInputfield[i].onEndEdit.AddListener((value) => { SetJointPWM(index, value); });
            addBtnList[i].onClick.RemoveAllListeners();
            addBtnList[i].onClick.AddListener(() => { SetPWMByClick(index, 1); });
            minBtnList[i].onClick.RemoveAllListeners();
            minBtnList[i].onClick.AddListener(() => { SetPWMByClick(index, -1); });
        }
        for (int i = 0; i < 3; i++)
        {
            PWMInputfield[i].text = _robotController.GetSendPWM()[i].ToString();
        }
    }
    private void OnDisable()
    {

        _robotController.GetJoystickController().ShowHandleText();
    }
    public void SetJointPWM(int index, string value)
    {
        _robotController.SetJointPWM(index, int.Parse(value));
    }
    public void SetStep(int value)
    {
        scale = 5;
        for(int i = 0; i < value; i++)
            scale = scale * 10;
    }
    public void SetPWMByClick(int index, int sign)
    {
        Debug.Log(int.Parse(PWMInputfield[index].text) + sign * scale);
        PWMInputfield[index].text = (int.Parse(PWMInputfield[index].text) + sign * scale).ToString();
        _robotController.SetJointPWM(index, int.Parse(PWMInputfield[index].text));
    }
}