using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuinticSpline : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    TMP_InputField a0Input;
    TMP_InputField a1Input;
    TMP_InputField a2Input;
    TMP_InputField a3Input;
    TMP_InputField a4Input;
    TMP_InputField a5Input;
    TMP_InputField tInput;
    float a0 = 0;
    float a1 = 0;
    float a2 = 0;
    float a3 = 0;
    float a4 = 0;
    float a5 = 0;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
        drawer = GetComponent<DrawGraph>();
        a0Input = transform.Find("Input/Line1/a0").GetComponent<TMP_InputField>();
        a0Input.onValueChanged.AddListener(SetA0);
        a1Input = transform.Find("Input/Line1/a1").GetComponent<TMP_InputField>();
        a1Input.onValueChanged.AddListener(SetA1);
        a2Input = transform.Find("Input/Line1/a2").GetComponent<TMP_InputField>();
        a2Input.onValueChanged.AddListener(SetA2);
        a3Input = transform.Find("Input/Line2/a3").GetComponent<TMP_InputField>();
        a3Input.onValueChanged.AddListener(SetA3);
        a4Input = transform.Find("Input/Line2/a4").GetComponent<TMP_InputField>();
        a4Input.onValueChanged.AddListener(SetA4);
        a5Input = transform.Find("Input/Line2/a5").GetComponent<TMP_InputField>();
        a5Input.onValueChanged.AddListener(SetA5);
        tInput = transform.Find("Input/Line3/T").GetComponent<TMP_InputField>();
        tInput.onValueChanged.AddListener(SetT);
    }

    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + a3 + "," + a4 + "," + a5 + "," + t);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 50 * t + 1; i++)
        {
            float t = i / 50f;
            float angle = a0 + a1 * t + a2 * t * t + a3 * t * t * t + a4 * t * t * t * t + a5 * t * t * t * t * t;
            JointAngleList.Add(angle);
            _trajController.PushTrajPoints(new List<float> { angle, 90, -90 });

            AngularVelocityList.Add(a1 + 2 * a2 * t + 3 * a3 * t * t + 4 * a4 * t * t * t + 5 * a5 * t * t * t * t);

            AngularAccelerationList.Add(2 * a2 + 6 * a3 * t + 12 * a4 * t * t + 20 * a5 * t * t * t);
        }
        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
        drawer.ClearGraph("JointAngle");
        drawer.ShowGraph(JointAngleList, "JointAngle");

        drawer.ClearGraph("AngularVelocity");
        drawer.ShowGraph(AngularVelocityList, "AngularVelocity");

        drawer.ClearGraph("AngularAcceleration");
        drawer.ShowGraph(AngularAccelerationList, "AngularAcceleration");
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
    public void SetA2(string value)
    {
        float.TryParse(value, out a2);
        UpdateTrajectory();
    }
    public void SetA3(string value)
    {
        float.TryParse(value, out a3);
        UpdateTrajectory();
    }
    public void SetA4(string value)
    {
        float.TryParse(value, out a4);
        UpdateTrajectory();
    }
    public void SetA5(string value)
    {
        float.TryParse(value, out a5);
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
