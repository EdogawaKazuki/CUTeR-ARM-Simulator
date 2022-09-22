using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleAxisRotation : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
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
    float Angle3Sin;
    float Angle3Cos;
    // Start is called before the first frame update
    void Start()
    {
        _robotController.SetJointAngles(new List<float> { 0, 0, 0 });
        matrix1Text = new Text[9];
        for (int i = 0; i < 9; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/" + (i + 1)).GetComponent<Text>();
        }
        matrix2Text = new Text[9];
        for (int i = 0; i < 9; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line3/" + (i + 1)).GetComponent<Text>();
        }
        matrix3Text = new Text[9];
        for (int i = 0; i < 9; i++)
        {
            matrix3Text[i] = transform.Find("Input/Line4/" + (i + 1)).GetComponent<Text>();
        }
        BaseSlider = GameObject.Find("Canvas/Joystick/Panel/Joint0").GetComponent<Slider>();
        BaseSlider.onValueChanged.AddListener(SetBaseAngle);
        Joint0Slider = GameObject.Find("Canvas/Joystick/Panel/Joint1").GetComponent<Slider>();
        Joint0Slider.onValueChanged.AddListener(SetJoint0Angle);
        Joint1Slider = GameObject.Find("Canvas/Joystick/Panel/Joint2").GetComponent<Slider>();
        Joint1Slider.onValueChanged.AddListener(SetJoint1Angle);

        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        UpdateTable();

    }
    public void UpdateTable()
    {
        matrix1Text[0].text = (Angle1Cos + 0.00001f).ToString("F3");
        matrix1Text[1].text = (-Angle1Sin + 0.00001f).ToString("F3");
        matrix1Text[2].text = "0";
        matrix1Text[3].text = (Angle1Sin + 0.00001f).ToString("F3");
        matrix1Text[4].text = (Angle1Cos + 0.00001f).ToString("F3");
        matrix1Text[5].text = "0";
        matrix1Text[6].text = "0";
        matrix1Text[7].text = "0";
        matrix1Text[8].text = "1";

        matrix2Text[0].text = "1";
        matrix2Text[1].text = "0";
        matrix2Text[2].text = "0";
        matrix2Text[3].text = "0";
        matrix2Text[4].text = (Angle2Cos + 0.00001f).ToString("F3");
        matrix2Text[5].text = (-Angle2Sin + 0.00001f).ToString("F3");
        matrix2Text[6].text = "0";
        matrix2Text[7].text = (Angle2Sin + 0.00001f).ToString("F3");
        matrix2Text[8].text = (Angle2Cos + 0.00001f).ToString("F3");

        matrix3Text[0].text = "1";
        matrix3Text[1].text = "0";
        matrix3Text[2].text = "0";
        matrix3Text[3].text = "0";
        matrix3Text[4].text = (Angle3Cos + 0.00001f).ToString("F3");
        matrix3Text[5].text = (-Angle3Sin + 0.00001f).ToString("F3");
        matrix3Text[6].text = "0";
        matrix3Text[7].text = (Angle3Sin + 0.00001f).ToString("F3");
        matrix3Text[8].text = (Angle3Cos + 0.00001f).ToString("F3");
    }
    public void SetBaseAngle(float value)
    {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        UpdateTable();

    }
    public void SetJoint0Angle(float value)
    {
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        UpdateTable();
    }
    public void SetJoint1Angle(float value)
    {
        Angle3Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(2));
        Angle3Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(2));
        UpdateTable();
    }
}
