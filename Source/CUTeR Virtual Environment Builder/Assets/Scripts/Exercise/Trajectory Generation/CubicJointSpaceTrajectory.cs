using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicJointSpaceTrajectory : MonoBehaviour
{
    [SerializeField]
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
    float t = 0;
    int showTable = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        _trajController = _robotController.GetTrajController();
        drawer = GetComponent<DrawGraph>();
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

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + b0 + "," + b1 + "," + c0 + "," + c1 + "," + t);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 20 * t + 1; i++)
        {
            float t = i / 20f;
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
        _trajController.SetStatus("Ready to play", new Color32(255, 255, 255, 78));

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
        float.TryParse(value, out t);
        UpdateTrajectory();
    }
}
