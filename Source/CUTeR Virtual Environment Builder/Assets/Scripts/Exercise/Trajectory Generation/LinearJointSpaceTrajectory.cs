using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearJointSpaceTrajectory : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float a0 = 0;
    float a1 = 0;
    float b0 = 0;
    float b1 = 0;
    float c0 = 0;
    float c1 = 0;
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
        List<float> JointAngleList1 = new List<float>();
        List<float> JointAngleList2 = new List<float>();
        List<float> JointAngleList3 = new List<float>();

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + b0 + "," + b1 + "," + c0 + "," + c1 + "," + t);
        _trajController.ResetTraj(3);
        for (int i = 0; i < 20 * t + 1; i++)
        {
            float t = i / 20f;
            float angle0 = a0 + a1 * t;
            JointAngleList1.Add(angle0);

            float angle1 = b0 + b1 * t;
            JointAngleList2.Add(angle1);

            float angle2 = c0 + c1 * t;
            JointAngleList3.Add(angle2);

            _trajController.PushTrajPoints(new List<float> { angle0, angle1, angle2 });
        }
        _trajController.SetStatus("Ready to play", new Color32(255, 255, 255, 78));
        drawer.ClearGraph("JointAngle1");
        drawer.ShowGraph(JointAngleList1, "JointAngle1");

        drawer.ClearGraph("JointAngle2");
        drawer.ShowGraph(JointAngleList2, "JointAngle2");

        drawer.ClearGraph("JointAngle3");
        drawer.ShowGraph(JointAngleList3, "JointAngle3");
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
    public void SetT(string value)
    {
        float.TryParse(value, out t);
        UpdateTrajectory();
    }
}