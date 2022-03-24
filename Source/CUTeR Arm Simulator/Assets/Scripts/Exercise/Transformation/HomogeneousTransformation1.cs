using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomogeneousTransformation1 : MonoBehaviour
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
    float Angle3Sin;
    float Angle3Cos;
    float x1;
    float y1;
    float z1;
    float x2;
    float y2;
    float z2;


    // Start is called before the first frame update
    void Start()
    {
        RobotController.JointAngle[0] = 0;
        RobotController.JointAngle[1] = 0;
        RobotController.JointAngle[2] = 0;
        matrix1Text = new Text[9];
        for (int i = 0; i < 9; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/" + (i + 1)).GetComponent<Text>();
        }
        matrix2Text = new Text[3];
        for (int i = 0; i < 3; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line6/" + (i + 1)).GetComponent<Text>();
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
        UpdateTable();
    }
    public void UpdateTable()
    {
        matrix1Text[0].text = (Angle1Cos).ToString("F3");
        matrix1Text[1].text = (-Angle1Sin * Angle2Cos).ToString("F3");
        matrix1Text[2].text = (Angle1Sin * Angle2Sin).ToString("F3");
        matrix1Text[3].text = (Angle1Sin).ToString("F3");
        matrix1Text[4].text = (Angle1Cos * Angle2Cos).ToString("F3");
        matrix1Text[5].text = (-Angle1Cos * Angle2Sin).ToString("F3");
        matrix1Text[6].text = "0";
        matrix1Text[7].text = (Angle2Sin).ToString("F3");
        matrix1Text[8].text = (Angle2Cos).ToString("F3");

        matrix2Text[0].text = (x2 * Angle1Cos + y2 * -Angle1Sin * Angle2Cos + z2 * Angle1Sin * Angle2Sin + x1).ToString();
        Debug.Log((x2 +","+ Angle1Sin + "," + y2 +","+ Angle1Cos * Angle2Cos + "," + z2 + "," + Angle1Cos * Angle2Sin + "," + y1));
        matrix2Text[1].text = (x2 * Angle1Sin + y2 * Angle1Cos * Angle2Cos + z2 * -Angle1Cos * Angle2Sin + y1).ToString();
        matrix2Text[2].text = (x2 * 0 + y2 * Angle2Sin + z2 * Angle2Cos + z1).ToString();
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
        UpdateTable();
    }
    public void SetJoint1Angle(float value)
    {
        Angle3Sin = Mathf.Sin(Mathf.Deg2Rad * RobotController.JointAngle[2]);
        Angle3Cos = Mathf.Cos(Mathf.Deg2Rad * RobotController.JointAngle[2]);
        UpdateTable();
    }

    public void SetX1(string value)
    {
        float.TryParse(value, out x1);
        UpdateTable();
    }
    public void SetY1(string value)
    {
        float.TryParse(value, out y1);
        UpdateTable();
    }
    public void SetZ1(string value)
    {
        float.TryParse(value, out z1);
        UpdateTable();
    }
    public void SetX2(string value)
    {
        float.TryParse(value, out x2);
        UpdateTable();
    }
    public void SetY2(string value)
    {
        float.TryParse(value, out y2);
        UpdateTable();
    }
    public void SetZ2(string value)
    {
        float.TryParse(value, out z2);
        UpdateTable();
    }
}
