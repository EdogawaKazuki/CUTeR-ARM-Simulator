using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoDRotation : MonoBehaviour
{
    Text matrix1aText;
    Text matrix1bText;
    Text matrix1cText;
    Text matrix1dText;
    Slider BaseSlider;
    float Angle1Sin;
    float Angle1Cos;
    // Start is called before the first frame update
    void Start()
    {
        BaseSlider = GameObject.Find("Canvas/Joystick/Panel/Joint0").GetComponent<Slider>();
        BaseSlider.onValueChanged.AddListener(SetBaseAngle);
        matrix1aText = transform.Find("Input/Line2/a").GetComponent<Text>();
        matrix1bText = transform.Find("Input/Line2/b").GetComponent<Text>();
        matrix1cText = transform.Find("Input/Line2/c").GetComponent<Text>();
        matrix1dText = transform.Find("Input/Line2/d").GetComponent<Text>();
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        UpdateTable();
    }
    void UpdateTable()
    {
        matrix1aText.text = (Angle1Cos + 0.00001f).ToString("F3");
        matrix1bText.text = (-Angle1Sin + 0.00001f).ToString("F3");
        matrix1cText.text = (Angle1Sin + 0.00001f).ToString("F3");
        matrix1dText.text = (Angle1Cos + 0.00001f).ToString("F3");
    }
    public void SetBaseAngle(float value)
    {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * RobotController.JointAngle[0]);
        UpdateTable();
    }
}
