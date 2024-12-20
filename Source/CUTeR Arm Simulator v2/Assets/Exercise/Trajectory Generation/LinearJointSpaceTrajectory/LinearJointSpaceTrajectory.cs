using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LinearJointSpaceTrajectory : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float b0 = 0;
    float b1 = 0;
    float c0 = 0;
    float c1 = 0;
    float t = 0;

    TMP_InputField a0Input;
    TMP_InputField a1Input;
    TMP_InputField b0Input;
    TMP_InputField b1Input;
    TMP_InputField c0Input;
    TMP_InputField c1Input;
    TMP_InputField tInput;
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
        a1Input = transform.Find("Input/Line1/a1").GetComponent<TMP_InputField>();

        b0Input = transform.Find("Input/Line2/b0").GetComponent<TMP_InputField>();
        b1Input = transform.Find("Input/Line2/b1").GetComponent<TMP_InputField>();

        c0Input = transform.Find("Input/Line3/c0").GetComponent<TMP_InputField>();
        c1Input = transform.Find("Input/Line3/c1").GetComponent<TMP_InputField>();

        tInput = transform.Find("Input/Line4/T").GetComponent<TMP_InputField>();

        a0Input.onValueChanged.AddListener((value) => { SetA0(value); });
        a1Input.onValueChanged.AddListener((value) => { SetA1(value); });

        b0Input.onValueChanged.AddListener((value) => { SetB0(value); });
        b1Input.onValueChanged.AddListener((value) => { SetB1(value); });

        c0Input.onValueChanged.AddListener((value) => { SetC0(value); });
        c1Input.onValueChanged.AddListener((value) => { SetC1(value); });

        tInput.onValueChanged.AddListener((value) => { SetT(value); });
    }

    void UpdateTrajectory()
    {
        List<float> JointAngleList1 = new List<float>();
        List<float> JointAngleList2 = new List<float>();
        List<float> JointAngleList3 = new List<float>();

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + b0 + "," + b1 + "," + c0 + "," + c1 + "," + t);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 50 * t + 1; i++)
        {
            float t = i / 50f;
            float angle0 = a0 + a1 * t;
            JointAngleList1.Add(angle0);

            float angle1 = b0 + b1 * t;
            JointAngleList2.Add(angle1);

            float angle2 = c0 + c1 * t;
            JointAngleList3.Add(angle2);

            _trajController.PushTrajPoints(new List<float> { angle0, angle1, angle2 });
        }
        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
        drawer.ClearGraph("JointAngle1");
        drawer.ShowGraph(JointAngleList1, "JointAngle1");

        drawer.ClearGraph("JointAngle2");
        drawer.ShowGraph(JointAngleList2, "JointAngle2");

        drawer.ClearGraph("JointAngle3");
        drawer.ShowGraph(JointAngleList3, "JointAngle3");
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
