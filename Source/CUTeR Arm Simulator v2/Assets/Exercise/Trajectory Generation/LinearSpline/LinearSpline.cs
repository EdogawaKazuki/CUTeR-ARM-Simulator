using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LinearSpline : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    TMP_InputField a0Input;
    TMP_InputField a1Input;
    TMP_InputField tInput;
    float a0 = 0;
    float a1 = 0;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
        a0Input = transform.Find("Input/Line1/a0").GetComponent<TMP_InputField>();
        a0Input.onValueChanged.AddListener(SetA0);
        a1Input = transform.Find("Input/Line1/a1").GetComponent<TMP_InputField>();
        a1Input.onValueChanged.AddListener(SetA1);
        tInput = transform.Find("Input/Line2/T").GetComponent<TMP_InputField>();
        tInput.onValueChanged.AddListener(SetT);
        drawer = GetComponent<DrawGraph>();
    }
    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        if (t == 0)
            return;
        Debug.Log("" + a0 + "," + a1 + "," + t);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 50 * t + 1; i++)
        {
            float angle = a0 + a1 * (i / 50f);
            JointAngleList.Add(angle);
            _trajController.PushTrajPoints(new List<float> { angle, 90, -90 });
        }
        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
        drawer.ClearGraph("JointAngle");
        drawer.ShowGraph(JointAngleList, "JointAngle");


    }

    public void SetA0(string value)
    {
        float.TryParse(value, out a0);
        UpdateTrajectory();
    }
    public void SetA1(string value)
    {
        float.TryParse(value, out a1);
        UpdateTrajectory();
    }
    public void SetT(string value)
    {
        float.TryParse(value, out t);
        UpdateTrajectory();
    }
    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
