using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinearSpline : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
        drawer = GetComponent<DrawGraph>();
    }
    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        if (t == 0)
            return;
        Debug.Log("" + a0 + "," + a1 + "," + t);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 50 * t + 1; i++)
        {
            float angle = a0 + a1 * (i / 50f);
            JointAngleList.Add(angle);
            _trajController.PushTrajPoints(new List<float> { angle, 90, -90 });
        }
        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
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
    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
