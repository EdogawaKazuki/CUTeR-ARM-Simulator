using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskSpaceTrajectory : MonoBehaviour
{
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
        drawer = GetComponent<DrawGraph>();
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

        if (t == 0)
            return;

        Debug.Log("" + a0 + "," + a1 + "," + a2 + "," + a3 + "," + b0 + "," + b1 + "," + b2 + "," + b3 + "," + c0 + "," + c1 + "," + c2 + "," + c3 + "," + t);
        RobotController.Trajs[0].Clear();
        RobotController.Trajs[1].Clear();
        RobotController.Trajs[2].Clear();
        for (int i = 0; i < 20 * t + 1; i++)
        {
            float t = i / 20f;
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

            float[] angles = CartesianToAngle(x, y, z);
            //Debug.Log(angles[0] + "," + angles[1] + "," + angles[2]);
            RobotController.Trajs[0].Add(angles[0]);
            RobotController.Trajs[1].Add(angles[1]);
            RobotController.Trajs[2].Add(angles[2]);

        }
        RobotController.trajLength = PositionListX.Count;

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

    float[] CartesianToAngle(float x, float y, float z)
    {
        x = -x;
        y = -y;
        float[] angles = new float[3];
        float l1 = 10.18f;
        float l2 = 19.41f;
        float l3 = 2.91f;
        float l23 = Mathf.Sqrt(l2 * l2 + l3 * l3);
        float l4 = 20.2f;
        float alpha = Mathf.Atan(l3 / l2);
        if (x == 0)
        {
            angles[0] = Mathf.PI / 2;
        }
        else
        {
            if (x > 0)
            {
                angles[0] = Mathf.Atan(-y / x);
            }
            else
            {
                angles[0] = Mathf.PI - Mathf.Atan(y / x);
            }
        }
        float A = -y * Mathf.Sin(angles[0]) + x * Mathf.Cos(angles[0]);
        float B = z - l1;
        float tmp = (A * A + B * B - (l23 * l23 + l4 * l4)) / (2 * l23 * l4);
        if (tmp < -1)
            tmp = -0.999999f;
        if (tmp > 1)
            tmp = 0.99999f;
        angles[2] = -Mathf.Acos(tmp);
        if ((A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])) > 0)
            angles[1] = Mathf.Atan((B * (l23 + l4 * Mathf.Cos(angles[2])) - A * l4 * Mathf.Sin(angles[2])) /
                                   (A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])));
        else
            angles[1] = Mathf.PI - Mathf.Atan((B * (l23 + l4 * Mathf.Cos(angles[2])) - A * l4 * Mathf.Sin(angles[2])) /
                                   -(A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])));

        angles[0] = angles[0] / Mathf.PI * 180 - 90;
        angles[1] = (angles[1] + alpha) / Mathf.PI * 180;
        angles[2] = (angles[2] - alpha) / Mathf.PI * 180;
        return angles;
    }
}
