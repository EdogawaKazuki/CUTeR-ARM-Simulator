using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DHRepresentation : MonoBehaviour
{
    Text[] matrix1Text;
    Text[] matrix2Text;
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
        matrix1Text = new Text[12];
        for (int i = 0; i < 12; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/" + (i + 1)).GetComponent<Text>();
        }
        matrix2Text = new Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line4/" + (i + 1)).GetComponent<Text>();
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
        matrix1Text[3].text = RobotController.JointAngle[0].ToString();
        matrix1Text[7].text = "-8.30бу+" + RobotController.JointAngle[1].ToString() + "бу";
        matrix1Text[11].text = "8.30бу+" + RobotController.JointAngle[2].ToString() + "бу";

        matrix2Text[0].text = (Angle1Cos * Angle23Cos + 0.00001f).ToString("F3");
        matrix2Text[1].text = (-Angle1Cos * Angle23Sin + 0.00001f).ToString("F3");
        matrix2Text[2].text = (Angle1Sin + 0.00001f).ToString("F3");
        matrix2Text[3].text = (19.403 * Angle1Cos * Mathf.Cos(Mathf.Deg2Rad * (RobotController.JointAngle[1] - 8.3f)) + 0.00001f).ToString("F3");
        matrix2Text[4].text = (Angle1Sin * Angle23Cos + 0.00001f).ToString("F3");
        matrix2Text[5].text = (-Angle1Sin * Angle23Sin + 0.00001f).ToString("F3");
        matrix2Text[6].text = (-Angle1Cos + 0.00001f).ToString("F3");
        matrix2Text[7].text = (19.403 * Angle1Sin * Mathf.Cos(Mathf.Deg2Rad * (RobotController.JointAngle[1] - 8.3f)) + 0.00001f).ToString("F3");
        matrix2Text[8].text = (Angle23Sin + 0.00001f).ToString("F3");
        matrix2Text[9].text = (Angle23Cos + 0.00001f).ToString("F3");
        matrix2Text[10].text = "0";
        matrix2Text[11].text = (19.403 * Mathf.Sin(Mathf.Deg2Rad * (RobotController.JointAngle[1] - 8.3f)) + 10.00001f).ToString("F3");

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
