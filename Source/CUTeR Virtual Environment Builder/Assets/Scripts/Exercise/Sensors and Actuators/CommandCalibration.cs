using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandCalibration : MonoBehaviour
{
    RobotController _robotController;
    private List<Text> PWMTextList = new List<Text>() { null, null, null };
    private List<InputField> thetaInputfield = new List<InputField>() { null, null, null };
    private List<InputField> offsetInputfield = new List<InputField>() { null, null, null };
    private List<InputField> scaleInputfield = new List<InputField>() { null, null, null };
    private List<float> angleList = new List<float> { 0, 0, 0 };
    private List<float> offsetList = new List<float> { 0, 0, 0 };
    private List<float> scaleList = new List<float> { 0, 0, 0 };
    private List<int> pwmList = new List<int> { 0, 0, 0 };
    //private int scale = 1;
    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("EditorAdmin").GetComponent<EditorController>().GetRobotController();
        _robotController.GetJoystickController().HideHandleText();
        for (int i = 0; i < 3; i++)
        {
            //Debug.Log("Input/Line" + (i + 1) + "/Value");
            thetaInputfield[i] = transform.Find("Input/Line" + (i + 2) + "/£c").GetComponent<InputField>();
            offsetInputfield[i] = transform.Find("Input/Line" + (i + 2) + "/Offset").GetComponent<InputField>();
            scaleInputfield[i] = transform.Find("Input/Line" + (i + 2) + "/Scale").GetComponent<InputField>();
            PWMTextList[i] = transform.Find("Input/Line" + (i + 2) + "/PWM").GetComponent<Text>();
        }
        for (int i = 0; i < 3; i++)
        {
            int index = i;
            thetaInputfield[i].onValueChanged.RemoveAllListeners();
            thetaInputfield[i].onValueChanged.AddListener((value) => { SetTheta(index, value); });
            scaleInputfield[i].onValueChanged.RemoveAllListeners();
            scaleInputfield[i].onValueChanged.AddListener((value) => { SetScale(index, value); });
            offsetInputfield[i].onValueChanged.RemoveAllListeners();
            offsetInputfield[i].onValueChanged.AddListener((value) => { SetOffset(index, value); });
        }
        _robotController.PauseSendCmdToRobot();
    }
    private void OnDisable()
    {
        _robotController.StartSendCmdToRobot();
        _robotController.GetJoystickController().ShowHandleText();
    }
    private void FixedUpdate()
    {
    }

    public void SetTheta(int index, string value)
    {
        angleList[index] = float.Parse(value);
        pwmList[index] = (int)(angleList[index] * scaleList[index] + offsetList[index]);
        PWMTextList[index].text = pwmList[index].ToString();
    }
    public void SetOffset(int index, string value)
    {
        offsetList[index] = float.Parse(value);
        pwmList[index] = (int)(angleList[index] * scaleList[index] + offsetList[index]);
        PWMTextList[index].text = pwmList[index].ToString();
    }
    public void SetScale(int index, string value)
    {
        scaleList[index] = float.Parse(value);
        pwmList[index] = (int)(angleList[index] * scaleList[index] + offsetList[index]);
        PWMTextList[index].text = pwmList[index].ToString();
    }
    public void SetPWM()
    {
        _robotController.SetJointPWMs(pwmList);
    }
    public void SetCaliData()
    {
        _robotController.SetCmdCaliData(offsetList, scaleList);
    }

    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
