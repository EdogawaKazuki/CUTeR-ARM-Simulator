using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubicJointSpaceTrajectory : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float a2 = 0;
    float a3 = 0;
    float b0 = 0;
    float b1 = 0;
    float b2 = 0;
    float b3 = 0;
    float c0 = 0;
    float c1 = 0;
    float c2 = 0;
    float c3 = 0;
    float total_time = 0;

    TMP_InputField a0Input;
    TMP_InputField a1Input;
    TMP_InputField a2Input;
    TMP_InputField a3Input;
    TMP_InputField b0Input;
    TMP_InputField b1Input;
    TMP_InputField b2Input;
    TMP_InputField b3Input;
    TMP_InputField c0Input;
    TMP_InputField c1Input;
    TMP_InputField c2Input;
    TMP_InputField c3Input;
    TMP_InputField tInput;
    TMP_Dropdown jointDropdown;
    public List<float> joints;

    int showTable = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
        drawer = GetComponent<DrawGraph>();

        jointDropdown = transform.Find("Input/Line0/Dropdown").GetComponent<TMP_Dropdown>();

        a0Input = transform.Find("Input/Line1/a0").GetComponent<TMP_InputField>();
        a1Input = transform.Find("Input/Line1/a1").GetComponent<TMP_InputField>();
        a2Input = transform.Find("Input/Line1/a2").GetComponent<TMP_InputField>();
        a3Input = transform.Find("Input/Line1/a3").GetComponent<TMP_InputField>();

        b0Input = transform.Find("Input/Line2/b0").GetComponent<TMP_InputField>();
        b1Input = transform.Find("Input/Line2/b1").GetComponent<TMP_InputField>();
        b2Input = transform.Find("Input/Line2/b2").GetComponent<TMP_InputField>();
        b3Input = transform.Find("Input/Line2/b3").GetComponent<TMP_InputField>();

        c0Input = transform.Find("Input/Line3/c0").GetComponent<TMP_InputField>();
        c1Input = transform.Find("Input/Line3/c1").GetComponent<TMP_InputField>();
        c2Input = transform.Find("Input/Line3/c2").GetComponent<TMP_InputField>();
        c3Input = transform.Find("Input/Line3/c3").GetComponent<TMP_InputField>();

        tInput = transform.Find("Input/Line4/T").GetComponent<TMP_InputField>();

        jointDropdown.ClearOptions();
        jointDropdown.options.Add(new TMP_Dropdown.OptionData { text = "1" });
        jointDropdown.options.Add(new TMP_Dropdown.OptionData { text = "2" });
        jointDropdown.options.Add(new TMP_Dropdown.OptionData { text = "3" });
        jointDropdown.onValueChanged.AddListener((value) => { SetTable(value); });

        a0Input.onValueChanged.AddListener((value) => { SetA0(value); });
        a1Input.onValueChanged.AddListener((value) => { SetA1(value); });
        a2Input.onValueChanged.AddListener((value) => { SetA2(value); });
        a3Input.onValueChanged.AddListener((value) => { SetA3(value); });

        b0Input.onValueChanged.AddListener((value) => { SetB0(value); });
        b1Input.onValueChanged.AddListener((value) => { SetB1(value); });
        b2Input.onValueChanged.AddListener((value) => { SetB2(value); });
        b3Input.onValueChanged.AddListener((value) => { SetB3(value); });

        c0Input.onValueChanged.AddListener((value) => { SetC0(value); });
        c1Input.onValueChanged.AddListener((value) => { SetC1(value); });
        c2Input.onValueChanged.AddListener((value) => { SetC2(value); });
        c3Input.onValueChanged.AddListener((value) => { SetC3(value); });

        tInput.onValueChanged.AddListener((value) => { SetT(value); });

        joints = _robotController.GetJointAngles();
    }

    void UpdateTrajectory()
    {
        List<float> JointAngleList1 = new List<float>();
        List<float> AngularVelocityList1 = new List<float>();
        List<float> AngularAccelerationList1 = new List<float>();
        List<float> JointAngleList2 = new List<float>();
        List<float> AngularVelocityList2 = new List<float>();
        List<float> AngularAccelerationList2 = new List<float>();
        List<float> JointAngleList3 = new List<float>();
        List<float> AngularVelocityList3 = new List<float>();
        List<float> AngularAccelerationList3 = new List<float>();

        if (total_time == 0)
            return;

        // Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + a3 + "," + c0 + "," + c1 + "," + total_time);
        _trajController.ResetTraj(_robotController.GetDoF());
        for (int i = 0; i < 50 * total_time + 1; i++)
        {
            float t = i / 50f;
            float angle0 = a0 + a1 * t + a2 * t * t + a3 * t * t * t;
            JointAngleList1.Add(angle0);
            AngularVelocityList1.Add(a1 + 2 * a2 * t + 3 * a3 * t * t);
            AngularAccelerationList1.Add(2 * a2 + 6 * a3 * t);

            float angle1 = b0 + b1 * t + b2 * t * t + b3 * t * t * t;
            JointAngleList2.Add(angle1);
            AngularVelocityList2.Add(b1 + 2 * b2 * t + 3 * b3 * t * t);
            AngularAccelerationList2.Add(2 * b2 + 6 * b3 * t);

            float angle2 = c0 + c1 * t + c2 * t * t + c3 * t * t * t;
            JointAngleList3.Add(angle2);
            AngularVelocityList3.Add(c1 + 2 * c2 * t + 3 * c3 * t * t);
            AngularAccelerationList3.Add(2 * c2 + 6 * c3 * t);
            _trajController.PushTrajPoints(new List<float> { angle0,angle1, angle2 });

        }

        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);

        switch (showTable)
        {

            case 0:
                drawer.ClearGraph("JointAngle");
                drawer.ShowGraph(JointAngleList1, "JointAngle");
                drawer.ClearGraph("AngularVelocityList");
                drawer.ShowGraph(AngularVelocityList1, "AngularVelocityList");
                drawer.ClearGraph("AngularAccelerationList");
                drawer.ShowGraph(AngularAccelerationList1, "AngularAccelerationList");
                break;
            case 1:
                drawer.ClearGraph("JointAngle");
                drawer.ShowGraph(JointAngleList2, "JointAngle");
                drawer.ClearGraph("AngularVelocityList");
                drawer.ShowGraph(AngularVelocityList2, "AngularVelocityList");
                drawer.ClearGraph("AngularAccelerationList");
                drawer.ShowGraph(AngularAccelerationList2, "AngularAccelerationList");
                break;
            case 2:
                drawer.ClearGraph("JointAngle");
                drawer.ShowGraph(JointAngleList3, "JointAngle");
                drawer.ClearGraph("AngularVelocityList");
                drawer.ShowGraph(AngularVelocityList3, "AngularVelocityList");
                drawer.ClearGraph("AngularAccelerationList");
                drawer.ShowGraph(AngularAccelerationList3, "AngularAccelerationList");
                break;
        }
    }
    public void SetTable(int value)
    {
        showTable = value;
        UpdateTrajectory();
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
    public void SetB2(string value)
    {
        float.TryParse(value, out b2);
        UpdateTrajectory();
    }
    public void SetB3(string value)
    {
        float.TryParse(value, out b3);
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
    public void SetC3(string value)
    {
        float.TryParse(value, out c3);
        UpdateTrajectory();
    }
    public void SetT(string value)
    {
        float.TryParse(value, out total_time);
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
