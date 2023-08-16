using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PWMCommand : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    private List<TMP_Text> PWMTextList = new List<TMP_Text>();
    private List<TMP_InputField> PWMInputfield = new List<TMP_InputField>() {null,null,null };
    private List<Button> addBtnList = new List<Button>() { null, null, null };
    private List<Button> minBtnList = new List<Button>() { null, null, null };
    private int scale = 50;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void FixedUpdate()
    {
        // List<int> vs = _robotController.GetReadPWM();
        // for (int i = 0; i < vs.Count; i++)
        // {
        //     _robotController.SetJointSign(i, "Joint " + (i + 1) + " PWM:", vs[i].ToString());
        // }
    }

    void OnEnable()
    {
        // _robotController.MoveJointsTo(new List<float>() { 0, 0, 0 });
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        for (int i = 0; i < 3; i++)
        {
            //Debug.Log("Input/Line" + (i + 1) + "/Value");
            //PWMTextList.Add(transform.Find("Input/Line" + (i + 1) + "/pwm").GetComponent<Text>());
            PWMInputfield[i] = transform.Find("Input/Line" + (i + 1) + "/pwm").GetComponent<TMP_InputField>();
            addBtnList[i] = transform.Find("Input/Line" + (i + 1) + "/+").GetComponent<Button>();
            minBtnList[i] = transform.Find("Input/Line" + (i + 1) + "/-").GetComponent<Button>();
        }
        for (int i = 0; i < 3; i++)
        {
            int index = i;
            PWMInputfield[i].onEndEdit.AddListener((value) => { SetJointPWM(index, value); });
            addBtnList[i].onClick.AddListener(() => { SetPWMByClick(index, 1); });
            minBtnList[i].onClick.AddListener(() => { SetPWMByClick(index, -1); });
        }
        for (int i = 0; i < 3; i++)
        {
            PWMInputfield[i].text = _robotController.GetCmdPWM()[i].ToString();
        }
        _robotController.PauseSendCmdToRobot();
        // _robotController.SetJointSignActivate(true);
    }
    private void OnDisable()
    {
        _robotController.StartSendCmdToRobot();
        // _robotController.SetJointSignActivate(false);
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
