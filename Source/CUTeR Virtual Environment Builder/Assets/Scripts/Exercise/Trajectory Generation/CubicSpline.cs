using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubicSpline : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float a2 = 0;
    float a3 = 0;
    float t = 0;
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
        _trajController.ResetTraj(3);
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + t);
        for (int i = 0; i < 20 * t + 1; i++)
        {
            float _t = i / 20f;
            float angle = a0 + a1 * _t + a2 * _t * _t + a3 * _t * _t * _t;
            JointAngleList.Add(angle);
            _trajController.PushTrajPoints(new List<float> { angle, _robotController.GetJointAngle(1), _robotController.GetJointAngle(2) });

            AngularVelocityList.Add(a1 + 2 * a2 * t + 3 * a3 * _t * _t);

            AngularAccelerationList.Add(2 * a2 + 6 * a3 * _t);
        }
        _trajController.SetStatus("Ready to play", new Color32(255, 255, 255, 78));
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
    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
