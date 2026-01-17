using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SphericalLinearInterpolation : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    TMP_InputField w0Input;
    TMP_InputField x0Input;
    TMP_InputField y0Input;
    TMP_InputField z0Input;
    TMP_InputField tInput;
    Vector3 EE_vector = new Vector3(0, 42, 0);
    float w0 = 1;
    float x0 = 0;
    float y0 = 0;
    float z0 = 0;
    float w1 = 1;
    float x1 = 0;
    float y1 = 0;
    float z1 = 0;
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
        w0Input = transform.Find("Input/Line1/w0").GetComponent<TMP_InputField>();
        w0Input.onValueChanged.AddListener(SetW0);
        x0Input = transform.Find("Input/Line1/x0").GetComponent<TMP_InputField>();
        x0Input.onValueChanged.AddListener(SetX0);
        y0Input = transform.Find("Input/Line1/y0").GetComponent<TMP_InputField>();
        y0Input.onValueChanged.AddListener(SetY0);
        z0Input = transform.Find("Input/Line1/z0").GetComponent<TMP_InputField>();
        z0Input.onValueChanged.AddListener(SetZ0);
        tInput = transform.Find("Input/Line2/T").GetComponent<TMP_InputField>();
        tInput.onValueChanged.AddListener(SetT);
        drawer = GetComponent<DrawGraph>();
        joints = _robotController.GetJointAngles();
    }

    void UpdateTrajectory()
    {
        _trajController.ResetTraj(_robotController.GetDoF());
        List<float> w = new List<float>();
        List<float> x = new List<float>();
        List<float> y = new List<float>();
        List<float> z = new List<float>();

        if (t == 0)
            return;
        // Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + t);
        Debug.Log(_robotController.GetDoF());
        Debug.Log(joints.Count);
        // for (int i = 0; i < 50 * t + 1; i++)
        // {
        //     float _t = i / 50f;
        //     float angle = a0 + a1 * _t + a2 * _t * _t + a3 * _t * _t * _t;
        //     JointAngleList.Add(angle);
        //     joints[0] = angle;
        //     _trajController.PushTrajPoints(joints);

        //     AngularVelocityList.Add(a1 + 2 * a2 * _t + 3 * a3 * _t * _t);

        //     AngularAccelerationList.Add(2 * a2 + 6 * a3 * _t);
        // }

        Quaternion q0 = new Quaternion(x0, y0, z0, w0);;
        Quaternion q1 = new Quaternion(x1, y1, z1, w1);
        // do slerp over time t
        for (int i = 0; i < 50 * t + 1; i++)
        {
            float _t = i / 50f / t;
            Quaternion qt = Quaternion.Slerp(q0, q1, _t);
            // Apply qt to end effector
            Vector3 rotatedEE = qt * EE_vector;
            float[] Angle = _robotController.CartesianToAngle(rotatedEE.x, rotatedEE.y, rotatedEE.z);
            joints[0] = Angle[0];
            joints[1] = Angle[1];
            joints[2] = Angle[2];
            Debug.Log("Rotated EE: " + rotatedEE.x + "," + rotatedEE.y + "," + rotatedEE.z);
            Debug.Log("Joints: " + Angle[0] + "," + Angle[1] + "," + Angle[2]);
            _trajController.PushTrajPoints(joints);

            w.Add(qt.w);
            x.Add(qt.x);
            y.Add(qt.y);
            z.Add(qt.z);
        }
        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
        drawer.ClearGraph("w");
        drawer.ShowGraph(w, "w");

        drawer.ClearGraph("x");
        drawer.ShowGraph(x, "x");

        drawer.ClearGraph("y");
        drawer.ShowGraph(y, "y");

        drawer.ClearGraph("z");
        drawer.ShowGraph(z, "z");

    }

    public void SetW0(string value)
    {
        float.TryParse(value, out w0);
        UpdateTrajectory();
    }
    public void SetX0(string value)
    {
        float.TryParse(value, out x0);
        UpdateTrajectory();
    }
    public void SetY0(string value)
    {
        float.TryParse(value, out y0);
        UpdateTrajectory();
    }
    public void SetZ0(string value)
    {
        float.TryParse(value, out z0);
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
