using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicBlend : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float a2 = 0;
    float b0 = 0;
    float b1 = 0;
    float c0 = 0;
    float c1 = 0;
    float c2 = 0;
    float tb = 0;
    float tf = 0;
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
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + b0 + "," + b1 + "," + c0 + "," + c1 + "," + c2 + "," + tb + "," + tf);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 20 * tb + 1; i++)
        {
            float t = i / 20f;
            float angle = a0 + a1 * t + a2 * t * t;
            JointAngleList.Add(angle);
            _trajController.PushTrajPoints(new List<float> { angle, _robotController.GetJointAngle(1), _robotController.GetJointAngle(2) });

            AngularVelocityList.Add(a1 + 2 * a2 * t);

            AngularAccelerationList.Add(2 * a2);
        }
        for (int i = (int)(20 * tb + 1); i < 20 * (tf - tb) + 1; i++)
        {
            float t = i / 20f;
            float angle = b0 + b1 * t;
            JointAngleList.Add(angle);
            _trajController.PushTrajPoints(new List<float> { angle, _robotController.GetJointAngle(1), _robotController.GetJointAngle(2) });

            AngularVelocityList.Add(b1);

            AngularAccelerationList.Add(0);
        }
        for (int i = (int)(20 * (tf - tb) + 1); i < 20 * tf + 1; i++)
        {
            float t = i / 20f;
            float angle = c0 + c1 * t + c2 * t * t;
            JointAngleList.Add(angle);
            _trajController.PushTrajPoints(new List<float> { angle, _robotController.GetJointAngle(1), _robotController.GetJointAngle(2) });

            AngularVelocityList.Add(c1 + 2 * c2 * t);

            AngularAccelerationList.Add(2 * c2);
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
    public void SetC2(string value)
    {
        float.TryParse(value, out c2);
        UpdateTrajectory();
    }
    public void SetTB(string value)
    {
        float.TryParse(value, out tb);
        UpdateTrajectory();
    }
    public void SetTF(string value)
    {
        float.TryParse(value, out tf);
        UpdateTrajectory();
    }
}
