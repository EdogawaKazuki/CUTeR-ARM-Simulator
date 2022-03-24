using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForwardKinematics : MonoBehaviour
{
    Text[] matrix1Text;
    Text[] matrix2Text;
    Text[] matrix3Text;
    Slider BaseSlider;
    Slider Joint0Slider;
    Slider Joint1Slider;

    float Angle1Sin;
    float Angle1Cos;
    float Angle2Sin;
    float Angle2Cos;
    float Angle23Sin;
    float Angle23Cos;


    // Start is called before the first frame update
    void Start()
    {
        RobotController.JointAngle[0] = 0;
        RobotController.JointAngle[1] = 0;
        RobotController.JointAngle[2] = 0;
        matrix1Text = new Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/" + (i + 1)).GetComponent<Text>();
        }
        matrix2Text = new Text[3];
        for (int i = 0; i < 3; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line4/" + (i + 1)).GetComponent<Text>();
        }
        matrix3Text = new Text[4];
        for (int i = 0; i < 4; i++)
        {
            matrix3Text[i] = transform.Find("Input/Line6/" + (i + 1)).GetComponent<Text>();
        }
        BaseSlider = GameObject.Find("Canvas/Joystick/Panel/Joint0").GetComponent<Slider>();
        BaseSlider.onValueChanged.AddListener(SetBaseAngle);
        Joint0Slider = GameObject.Find("Canvas/Joystick/Panel/Joint1").GetComponent<Slider>();
        Joint0Slider.onValueChanged.AddListener(SetJoint0Angle);
        Joint1Slider = GameObject.Find("Canvas/Joystick/Panel/Joint2").GetComponent<Slider>();
        Joint1Slider.onValueChanged.AddListener(SetJoint1Angle);

        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * RobotController.JointAngle[1]);
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * RobotController.JointAngle[1]);
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        UpdateTable();
    }
    public void UpdateTable()
    {
        matrix1Text[0].text = (Angle1Cos + 0.00001f).ToString("F3");
        matrix1Text[1].text = (-Angle1Sin * Angle23Cos + 0.00001f).ToString("F3");
        matrix1Text[2].text = (Angle1Sin * Angle23Sin + 0.00001f).ToString("F3");
        matrix1Text[3].text = (-19.2 * Angle1Sin * Angle2Cos - 2.8 * Angle1Sin * Angle2Sin + 0.00001f).ToString("F3");
        matrix1Text[4].text = (Angle1Sin + 0.00001f).ToString("F3");
        matrix1Text[5].text = (Angle1Cos * Angle23Cos + 0.00001f).ToString("F3");
        matrix1Text[6].text = (Angle1Cos * Angle23Sin + 0.00001f).ToString("F3");
        matrix1Text[7].text = (19.2 * Angle1Cos * Angle2Cos + 2.8 * Angle1Cos * Angle2Sin + 0.00001f).ToString("F3");
        matrix1Text[8].text = "0";
        matrix1Text[9].text = (Angle23Sin + 0.00001f).ToString("F3");
        matrix1Text[10].text = (Angle23Cos + 0.00001f).ToString("F3");
        matrix1Text[11].text = (19.2 * Angle2Sin - 2.8 * Angle2Cos + 10.00001f).ToString("F3");
        matrix1Text[12].text = "0";
        matrix1Text[13].text = "0";
        matrix1Text[14].text = "0";
        matrix1Text[15].text = "1";

        matrix2Text[0].text = (-Angle1Sin * Angle23Cos * 21 + (-19.2 * Angle1Sin * Angle2Cos - 2.8 * Angle1Sin * Angle2Sin) + 0.001).ToString("F2") + " cm";
        matrix2Text[1].text = (Angle1Cos * Angle23Cos * 21 + (19.2 * Angle1Cos * Angle2Cos + 2.8 * Angle1Cos * Angle2Sin) + 0.001).ToString("F2") + " cm";
        matrix2Text[2].text = (Angle23Sin * 21 + (19.2 * Angle2Sin - 2.8 * Angle2Cos) + 10.001).ToString("F2") + " cm";

        float[][] m = new float[3][];
        m[0] = new float[] { Angle1Cos, -Angle1Sin * Angle23Cos, Angle1Sin * Angle23Sin };
        m[1] = new float[] { Angle1Sin, Angle1Cos * Angle23Cos, -Angle1Cos * Angle23Sin };
        m[2] = new float[] { 0, Angle23Sin, Angle23Cos };

        float[] axisAngle = toAxisAngle(m);

        matrix3Text[0].text = axisAngle[1].ToString("F2");
        matrix3Text[1].text = axisAngle[2].ToString("F2");
        matrix3Text[2].text = axisAngle[3].ToString("F2");
        matrix3Text[3].text = (axisAngle[0] * Mathf.Rad2Deg).ToString("F2") + "бу";
    }

    private float[] toAxisAngle(float[][] m)
    {
        float angle, x, y, z; // variables for result
        float epsilon = 0.01f; // margin to allow for rounding errors
        float epsilon2 = 0.1f; // margin to distinguish between 0 and 180 degrees
        if ((Mathf.Abs(m[0][1] - m[1][0]) < epsilon)
                && (Mathf.Abs(m[0][2] - m[2][0]) < epsilon)
                && (Mathf.Abs(m[1][2] - m[2][1]) < epsilon))
        {
            // singularity found
            // first check for identity matrix which must have +1 for all terms
            //  in leading diagonal and zero in other terms
            if ((Mathf.Abs(m[0][1] + m[1][0]) < epsilon2)
                    && (Mathf.Abs(m[0][2] + m[2][0]) < epsilon2)
                    && (Mathf.Abs(m[1][2] + m[2][1]) < epsilon2)
                    && (Mathf.Abs(m[0][0] + m[1][1] + m[2][2] - 3) < epsilon2))
            {
                // this singularity is identity matrix so angle = 0
                return new float[] { 0, 1, 0, 0 }; // zero angle, arbitrary axis
            }
            // otherwise this singularity is angle = 180
            angle = Mathf.PI;
            float xx = (m[0][0] + 1) / 2;
            float yy = (m[1][1] + 1) / 2;
            float zz = (m[2][2] + 1) / 2;
            float xy = (m[0][1] + m[1][0]) / 4;
            float xz = (m[0][2] + m[2][0]) / 4;
            float yz = (m[1][2] + m[2][1]) / 4;
            if ((xx > yy) && (xx > zz))
            { // m[0][0] is the largest diagonal term
                if (xx < epsilon)
                {
                    x = 0;
                    y = 0.7071f;
                    z = 0.7071f;
                }
                else
                {
                    x = Mathf.Sqrt(xx);
                    y = xy / x;
                    z = xz / x;
                }
            }
            else if (yy > zz)
            { // m[1][1] is the largest diagonal term
                if (yy < epsilon)
                {
                    x = 0.7071f;
                    y = 0;
                    z = 0.7071f;
                }
                else
                {
                    y = Mathf.Sqrt(yy);
                    x = xy / y;
                    z = yz / y;
                }
            }
            else
            { // m[2][2] is the largest diagonal term so base result on this
                if (zz < epsilon)
                {
                    x = 0.7071f;
                    y = 0.7071f;
                    z = 0;
                }
                else
                {
                    z = Mathf.Sqrt(zz);
                    x = xz / z;
                    y = yz / z;
                }
            }
            return new float[] { angle, x, y, z }; // return 180 deg rotation
        }
        // as we have reached here there are no singularities so we can handle normally
        float s = Mathf.Sqrt((m[2][1] - m[1][2]) * (m[2][1] - m[1][2])
                + (m[0][2] - m[2][0]) * (m[0][2] - m[2][0])
                + (m[1][0] - m[0][1]) * (m[1][0] - m[0][1])); // used to normalise
        if (Mathf.Abs(s) < 0.001) s = 1;
        // prevent divide by zero, should not happen if matrix is orthogonal and should be
        // caught by singularity test above, but I've left it in just in case
        angle = Mathf.Acos((m[0][0] + m[1][1] + m[2][2] - 1) / 2);
        x = (m[2][1] - m[1][2]) / s;
        y = (m[0][2] - m[2][0]) / s;
        z = (m[1][0] - m[0][1]) / s;
        return new float[] { angle, x, y, z };
    }
    public void SetBaseAngle(float value)
    {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        UpdateTable();

    }
    public void SetJoint0Angle(float value)
    {
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * RobotController.JointAngle[1]);
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * RobotController.JointAngle[1]);
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        UpdateTable();
    }
    public void SetJoint1Angle(float value)
    {
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (RobotController.JointAngle[1] + RobotController.JointAngle[2]));
        UpdateTable();
    }
}
