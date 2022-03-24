using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicSpline : MonoBehaviour
{
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float a2 = 0;
    float a3 = 0;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        drawer = GetComponent<DrawGraph>();
    }


    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + t);
        RobotController.Trajs[0].Clear();
        RobotController.Trajs[1].Clear();
        RobotController.Trajs[2].Clear();
        for (int i = 0; i < 20 * t + 1; i++)
        {
            float _t = i / 20f;
            float angle = a0 + a1 * _t + a2 * _t * _t + a3 * _t * _t * _t;
            JointAngleList.Add(angle);
            RobotController.Trajs[0].Add(angle);
            RobotController.Trajs[1].Add(RobotController.JointAngle[1]);
            RobotController.Trajs[2].Add(RobotController.JointAngle[2]);

            AngularVelocityList.Add(a1 + 2 * a2 * t + 3 * a3 * _t * _t);

            AngularAccelerationList.Add(2 * a2 + 6 * a3 * _t);
        }
        RobotController.trajLength = JointAngleList.Count;
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
}
