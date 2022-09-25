using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackCalibration : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    private List<Text> PWMTextList = new List<Text>();
    private List<Text> thetaTextList = new List<Text>();
    private List<InputField> offsetIFList = new List<InputField>();
    private List<InputField> scaleIFList = new List<InputField>();
    private List<float> offsetList = new List<float> {0,0,0 };
    private List<float> scaleList = new List<float> {0,0,0 };
    // Start is called before the first frame update
    void Start()
    {
        _trajController = _robotController.GetTrajController();
        drawer = GetComponent<DrawGraph>();
        for (int i = 0; i < 3; i++)
        {
            //Debug.Log("Input/Line" + (i + 1) + "/Value");
            PWMTextList.Add(transform.Find("Input/Line" + (i + 2) + "/PWM").GetComponent<Text>());
            thetaTextList.Add(transform.Find("Input/Line" + (i + 2) + "/£c").GetComponent<Text>());
            offsetIFList.Add(transform.Find("Input/Line" + (i + 2) + "/Offset").GetComponent<InputField>());
            scaleIFList.Add(transform.Find("Input/Line" + (i + 2) + "/Scale").GetComponent<InputField>());
        }
    }
    private void FixedUpdate()
    {
        UpdateTrajectory();
    }
    private void OnEnable()
    {
        _robotController.GetJoystickController().HideHandleText();
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

    public void SetOffset1(string value)
    {
        float result = offsetList[0];
        float.TryParse(value, out result);
        offsetList[0] = result;
    }
    public void SetOffset2(string value)
    {
        float result = offsetList[1];
        float.TryParse(value, out result);
        offsetList[1] = result;
    }
    public void SetOffset3(string value)
    {
        float result = offsetList[2];
        float.TryParse(value, out result);
        offsetList[2] = result;
    }
    public void SetScale1(string value)
    {
        float result = scaleList[0];
        float.TryParse(value, out result);
        scaleList[0] = result;
    }
    public void SetScale2(string value)
    {
        float result = scaleList[1];
        float.TryParse(value, out result);
        scaleList[1] = result;
    }
    public void SetScale3(string value)
    {
        float result = scaleList[2];
        float.TryParse(value, out result);
        scaleList[2] = result;
    }
    public void SetCaliData()
    {
        _robotController.SetCaliData(offsetList, scaleList);
    }
    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
