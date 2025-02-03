using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MathNet.Numerics.LinearAlgebra.Storage;

public class FeedbackCalibration : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    private List<TMP_Text> PWMTextList = new();
    private List<TMP_Text> thetaTextList = new();
    private List<TMP_InputField> offsetIFList = new();
    private List<TMP_InputField> scaleIFList = new();
    private List<float> offsetList = new(){ 0,0,0 };
    private List<float> scaleList = new(){ 0,0,0 };
    private void FixedUpdate()
    {
        UpdateTrajectory();
    }
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
        drawer = GetComponent<DrawGraph>();
        for (int i = 0; i < 3; i++)
        {
            int x = i;
            //Debug.Log("Input/Line" + (i + 1) + "/Value");
            PWMTextList.Add(transform.Find("Input/Line" + (i + 2) + "/PWM").GetComponent<TMP_Text>());
            thetaTextList.Add(transform.Find("Input/Line" + (i + 2) + "/Theta").GetComponent<TMP_Text>());
            offsetIFList.Add(transform.Find("Input/Line" + (i + 2) + "/Offset").GetComponent<TMP_InputField>());
            offsetIFList[i].onValueChanged.AddListener((value) => SetOffset(x, value));
            scaleIFList.Add(transform.Find("Input/Line" + (i + 2) + "/Scale").GetComponent<TMP_InputField>());
            scaleIFList[i].onValueChanged.AddListener((value) => SetScale(x, value));
        }
        _robotController.GetJoystickController().HideHandleText();
        List<float> offset = _robotController.GetFeedbackOffset();
        List<float> scale = _robotController.GetFeedbackScale();
        for (int i = 0; i < 3; i++)
        {
            offsetIFList[i].text = offset[i].ToString("F4");
            scaleIFList[i].text = scale[i].ToString("F4");
        }
        Debug.Log("enable");
    }
    private void OnDisable()
    {
        _robotController.GetJoystickController().ShowHandleText();
    }

    void UpdateTrajectory()
    {
        List<int> vs = _robotController.GetReadPWM();
        for (int i = 0; i < vs.Count; i++)
        {
            PWMTextList[i].text = vs[i].ToString();
            thetaTextList[i].text = (scaleList[i] * (vs[i] - offsetList[i])).ToString();
        }
    }
    public void SetOffset(int index, string value){
        Debug.Log(offsetList.Count);
        Debug.Log(index);
        offsetList[index] = float.Parse(value);
    }
    public void SetScale(int index, string value){
        scaleList[index] = float.Parse(value);
    }
    public void SetCaliData()
    {
        _robotController.SetFeedbackCaliData(offsetList, scaleList);
    }
    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
