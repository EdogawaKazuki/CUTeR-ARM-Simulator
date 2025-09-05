using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubicSpline : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    TMP_InputField a0Input;
    TMP_InputField a1Input;
    TMP_InputField a2Input;
    TMP_InputField a3Input;
    TMP_InputField tInput;
    float a0 = 0;
    float a1 = 0;
    float a2 = 0;
    float a3 = 0;
    float t = 0;
    public List<float> joints;
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
        a2Input = transform.Find("Input/Line1/a2").GetComponent<TMP_InputField>();
        a2Input.onValueChanged.AddListener(SetA2);
        a3Input = transform.Find("Input/Line1/a3").GetComponent<TMP_InputField>();
        a3Input.onValueChanged.AddListener(SetA3);
        tInput = transform.Find("Input/Line2/T").GetComponent<TMP_InputField>();
        tInput.onValueChanged.AddListener(SetT);
        drawer = GetComponent<DrawGraph>();
        joints = _robotController.GetJointAngles();
    }

    void UpdateTrajectory()
    {
        _trajController.ResetTraj(_robotController.GetDoF());
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();

        if (t == 0)
            return;

        // Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + t);
        Debug.Log(_robotController.GetDoF());
        Debug.Log(joints.Count);
        for (int i = 0; i < 50 * t + 1; i++)
        {
            float _t = i / 50f;
            float angle = a0 + a1 * _t + a2 * _t * _t + a3 * _t * _t * _t;
            JointAngleList.Add(angle);
            joints[0] = angle;
            _trajController.PushTrajPoints(joints);

            AngularVelocityList.Add(a1 + 2 * a2 * _t + 3 * a3 * _t * _t);

            AngularAccelerationList.Add(2 * a2 + 6 * a3 * _t);
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
