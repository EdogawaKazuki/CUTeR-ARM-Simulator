using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuinticSpline : MonoBehaviour
{
    DrawGraph drawer;
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
        drawer = GetComponent<DrawGraph>();
    }


    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + a3 + "," + a4 + "," + a5 + "," + t);
        RobotController.Trajs[0].Clear();
        RobotController.Trajs[1].Clear();
        RobotController.Trajs[2].Clear();
        for (int i = 0; i < 20 * t + 1; i++)
        {
            float t = i / 20f;
            float angle = a0 + a1 * t + a2 * t * t + a3 * t * t * t + a4 * t * t * t * t + a5 * t * t * t * t * t;
            JointAngleList.Add(angle);
            RobotController.Trajs[0].Add(angle);
            RobotController.Trajs[1].Add(RobotController.JointAngle[1]);
            RobotController.Trajs[2].Add(RobotController.JointAngle[2]);

            AngularVelocityList.Add(a1 + 2 * a2 * t + 3 * a3 * t * t + 4 * a4 * t * t * t + 5 * a5 * t * t * t * t);

            AngularAccelerationList.Add(2 * a2 + 6 * a3 * t + 12 * a4 * t * t + 20 * a5 * t * t * t);
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
}
