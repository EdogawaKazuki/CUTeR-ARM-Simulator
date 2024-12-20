using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ParabolicBlend : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float a2 = 0;
    float b0 = 0;
    float b1 = 0;
    float c0 = 0;
    float c1 = 0;
    float c2 = 0;
    float tb = 0;
    float tf = 0;
    TMP_InputField a0Input;
    TMP_InputField a1Input;
    TMP_InputField a2Input;
    TMP_InputField b0Input;
    TMP_InputField b1Input;
    TMP_InputField c0Input;
    TMP_InputField c1Input;
    TMP_InputField c2Input;
    TMP_InputField tbInput;
    TMP_InputField tfInput;
    public List<float> joints = new List<float>{0, 0, 0};

    // Start is called before the first frame update
    void Start()
    {
    }
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
        drawer = GetComponent<DrawGraph>();

        a0Input = transform.Find("Input/Equation/Line1/a0").GetComponent<TMP_InputField>();
        a1Input = transform.Find("Input/Equation/Line1/a1").GetComponent<TMP_InputField>();
        a2Input = transform.Find("Input/Equation/Line1/a2").GetComponent<TMP_InputField>();
        tbInput = transform.Find("Input/Condition/Line1/tb(s)").GetComponent<TMP_InputField>();

        b0Input = transform.Find("Input/Equation/Line2/b0").GetComponent<TMP_InputField>();
        b1Input = transform.Find("Input/Equation/Line2/b1").GetComponent<TMP_InputField>();

        c0Input = transform.Find("Input/Equation/Line3/c0").GetComponent<TMP_InputField>();
        c1Input = transform.Find("Input/Equation/Line3/c1").GetComponent<TMP_InputField>();
        c2Input = transform.Find("Input/Equation/Line3/c2").GetComponent<TMP_InputField>();
        tfInput = transform.Find("Input/Condition/Line3/tf(s)").GetComponent<TMP_InputField>();

        a0Input.onValueChanged.AddListener((value) => { SetA0(value); });
        a1Input.onValueChanged.AddListener((value) => { SetA1(value); });
        a2Input.onValueChanged.AddListener((value) => { SetA2(value); });
        tbInput.onValueChanged.AddListener((value) => { SetTB(value); });

        b0Input.onValueChanged.AddListener((value) => { SetB0(value); });
        b1Input.onValueChanged.AddListener((value) => { SetB1(value); });

        c0Input.onValueChanged.AddListener((value) => { SetC0(value); });
        c1Input.onValueChanged.AddListener((value) => { SetC1(value); });
        c2Input.onValueChanged.AddListener((value) => { SetC2(value); });
        tfInput.onValueChanged.AddListener((value) => { SetTF(value); });
    }

    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + b0 + "," + b1 + "," + c0 + "," + c1 + "," + c2 + "," + tb + "," + tf);
        _trajController.ResetTraj(3);
        if(tb != 0)
            for (int i = 0; i < 50 * tb + 1; i++)
            {
                float t = i / 50f;
                float angle = a0 + a1 * t + a2 * t * t;
                JointAngleList.Add(angle);
                joints[0] = angle;
                _trajController.PushTrajPoints(joints);

                AngularVelocityList.Add(a1 + 2 * a2 * t);

                AngularAccelerationList.Add(2 * a2);
            }
        if(tf - tb != 0)
            for (int i = (int)(50 * tb + 1); i < 50 * (tf - tb) + 1; i++)
            {
                float t = i / 50f;
                float angle = b0 + b1 * t;
                JointAngleList.Add(angle);
                joints[0] = angle;
                _trajController.PushTrajPoints(joints);

                AngularVelocityList.Add(b1);

                AngularAccelerationList.Add(0);
            }
        if(tb != 0)
            for (int i = (int)(50 * (tf - tb) + 1); i < 50 * tf + 1; i++)
            {
                float t = i / 50f;
                float angle = c0 + c1 * t + c2 * t * t;
                JointAngleList.Add(angle);
                joints[0] = angle;
                _trajController.PushTrajPoints(joints);

                AngularVelocityList.Add(c1 + 2 * c2 * t);

                AngularAccelerationList.Add(2 * c2);
            }
        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
        try
        {
            drawer.ClearGraph("JointAngle");
            drawer.ShowGraph(JointAngleList, "JointAngle");

            drawer.ClearGraph("AngularVelocity");
            drawer.ShowGraph(AngularVelocityList, "AngularVelocity");

            drawer.ClearGraph("AngularAcceleration");
            drawer.ShowGraph(AngularAccelerationList, "AngularAcceleration");
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
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
    public void SetB0(string value)
    {
        float.TryParse(value, out b0);
        UpdateTrajectory();
    }
    public void SetB1(string value)
    {
        float.TryParse(value, out b1);
        UpdateTrajectory();
    }
    public void SetC0(string value)
    {
        float.TryParse(value, out c0);
        UpdateTrajectory();
    }
    public void SetC1(string value)
    {
        float.TryParse(value, out c1);
        UpdateTrajectory();
    }
    public void SetC2(string value)
    {
        float.TryParse(value, out c2);
        UpdateTrajectory();
    }
    public void SetTB(string value)
    {
        float.TryParse(value, out tb);
        UpdateTrajectory();
    }
    public void SetTF(string value)
    {
        float.TryParse(value, out tf);
        UpdateTrajectory();
    }
    public void Clear()
    {
        foreach(var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
