using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearSpline : MonoBehaviour
{
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        drawer = GetComponent<DrawGraph>();
    }
    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        if (t == 0)
            return;
        Debug.Log("" + a0 + "," + a1 + "," + t);
        RobotController.Trajs[0].Clear();
        RobotController.Trajs[1].Clear();
        RobotController.Trajs[2].Clear();
        for (int i = 0; i < 20 * t + 1; i++)
        {
            float angle = a0 + a1 * (i / 20f);
            JointAngleList.Add(angle);
            RobotController.Trajs[0].Add(angle);
            RobotController.Trajs[1].Add(RobotController.JointAngle[1]);
            RobotController.Trajs[2].Add(RobotController.JointAngle[2]);
        }
        RobotController.trajLength = JointAngleList.Count;
        drawer.ClearGraph("JointAngle");
        drawer.ShowGraph(JointAngleList, "JointAngle");


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
    public void SetT(string value)
    {
        float.TryParse(value, out t);
        UpdateTrajectory();
    }
}
