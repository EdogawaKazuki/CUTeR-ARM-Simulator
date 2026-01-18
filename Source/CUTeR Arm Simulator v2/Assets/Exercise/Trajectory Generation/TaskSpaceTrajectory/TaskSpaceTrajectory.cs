using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TaskSpaceTrajectory : MonoBehaviour
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

    Button setTrajectoryButton;

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

        setTrajectoryButton = transform.Find("Input/Line5/Set").GetComponent<Button>();

        jointDropdown.ClearOptions();
        jointDropdown.options.Add(new TMP_Dropdown.OptionData { text = "x" });
        jointDropdown.options.Add(new TMP_Dropdown.OptionData { text = "y" });
        jointDropdown.options.Add(new TMP_Dropdown.OptionData { text = "z" });
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

        setTrajectoryButton.onClick.AddListener(UpdateTrajectory);
    }
    void UpdateTrajectory()
    {
        List<float> PositionListX = new List<float>();
        List<float> AngularVelocityListX = new List<float>();
        List<float> AngularAccelerationListX = new List<float>();
        List<float> PositionListY = new List<float>();
        List<float> AngularVelocityListY = new List<float>();
        List<float> AngularAccelerationListY = new List<float>();
        List<float> PositionListZ = new List<float>();
        List<float> AngularVelocityListZ = new List<float>();
        List<float> AngularAccelerationListZ = new List<float>();

        if (total_time == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + a3 + "," + b0 + "," + b1 + "," + b2 + "," + b3 + "," + c0 + "," + c1 + "," + c2 + "," + c3 + "," + total_time);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 50 * total_time + 1; i++)
        {
            float t = i / 50f;
            float x = a0 + a1 * t + a2 * t * t + a3 * t * t * t;
            PositionListX.Add(x);
            AngularVelocityListX.Add(a1 + 2 * a2 * t + 3 * a3 * t * t);
            AngularAccelerationListX.Add(2 * a2 + 6 * a3 * t);

            float y = b0 + b1 * t + b2 * t * t + b3 * t * t * t;
            PositionListY.Add(y);
            AngularVelocityListY.Add(b1 + 2 * b2 * t + 3 * b3 * t * t);
            AngularAccelerationListY.Add(2 * b2 + 6 * b3 * t);

            float z = c0 + c1 * t + c2 * t * t + c3 * t * t * t;
            PositionListZ.Add(z);
            AngularVelocityListZ.Add(c1 + 2 * c2 * t + 3 * c3 * t * t);
            AngularAccelerationListZ.Add(2 * c2 + 6 * c3 * t);

            float[] angles = _robotController.CartesianToAngle(x, y, z);
            Debug.Log(angles[0] + "," + angles[1] + "," + angles[2]);
            _trajController.PushTrajPoints(new List<float> { angles[0], angles[1], angles[2] });

        }

        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
        switch (showTable)
        {

            case 0:
                drawer.ClearGraph("JointAngle");
                drawer.ShowGraph(PositionListX, "JointAngle");
                drawer.ClearGraph("AngularVelocityList");
                drawer.ShowGraph(AngularVelocityListX, "AngularVelocityList");
                drawer.ClearGraph("AngularAccelerationList");
                drawer.ShowGraph(AngularAccelerationListX, "AngularAccelerationList");
                break;
            case 1:
                drawer.ClearGraph("JointAngle");
                drawer.ShowGraph(PositionListY, "JointAngle");
                drawer.ClearGraph("AngularVelocityList");
                drawer.ShowGraph(AngularVelocityListY, "AngularVelocityList");
                drawer.ClearGraph("AngularAccelerationList");
                drawer.ShowGraph(AngularAccelerationListY, "AngularAccelerationList");
                break;
            case 2:
                drawer.ClearGraph("JointAngle");
                drawer.ShowGraph(PositionListZ, "JointAngle");
                drawer.ClearGraph("AngularVelocityList");
                drawer.ShowGraph(AngularVelocityListZ, "AngularVelocityList");
                drawer.ClearGraph("AngularAccelerationList");
                drawer.ShowGraph(AngularAccelerationListZ, "AngularAccelerationList");
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
        // UpdateTrajectory();
    }
    public void SetA1(string value)
    {
        float.TryParse(value, out a1);
        // UpdateTrajectory();
    }
    public void SetA2(string value)
    {
        float.TryParse(value, out a2);
        // UpdateTrajectory();
    }
    public void SetA3(string value)
    {
        float.TryParse(value, out a3);
        // UpdateTrajectory();
    }
    public void SetB0(string value)
    {
        float.TryParse(value, out b0);
        // UpdateTrajectory();
    }
    public void SetB1(string value)
    {
        float.TryParse(value, out b1);
        // UpdateTrajectory();
    }
    public void SetB2(string value)
    {
        float.TryParse(value, out b2);
        // UpdateTrajectory();
    }
    public void SetB3(string value)
    {
        float.TryParse(value, out b3);
        // UpdateTrajectory();
    }
    public void SetC0(string value)
    {
        float.TryParse(value, out c0);
        // UpdateTrajectory();
    }
    public void SetC1(string value)
    {
        float.TryParse(value, out c1);
        // UpdateTrajectory();
    }
    public void SetC2(string value)
    {
        float.TryParse(value, out c2);
        // UpdateTrajectory();
    }
    public void SetC3(string value)
    {
        float.TryParse(value, out c3);
        // UpdateTrajectory();
    }
    public void SetT(string value)
    {
        float.TryParse(value, out total_time);
        // UpdateTrajectory();
    }
    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
