using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DHRepresentation : MonoBehaviour
{
    RobotController _robotController;
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
    [SerializeField]
    List<GameObject> DHFrames = new List<GameObject>();


    private void OnEnable()
    {
        _robotController = GameObject.Find("EditorAdmin").GetComponent<EditorController>().GetRobotController();
        _robotController.SetJointAngles(new List<float> { 0, 0, 0 });
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
    }
    private void OnDisable()
    {
        _robotController.SetLinkSignActivate(false);
        _robotController.SetJointSignActivate(false);
    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    public void ShowRow(string index)
    {
        switch (index)
        {
            case "1":
                _robotController.SetLinkSignActivate(false);
                _robotController.SetJointSignActivate(false);
                _robotController.SetJointSignActivate(0, true);
                _robotController.SetLinkSignActivate(0, true);
                break;
            case "2":
                _robotController.SetLinkSignActivate(false);
                _robotController.SetJointSignActivate(false);
                _robotController.SetJointSignActivate(1, true);
                break;
            case "3":
                _robotController.SetLinkSignActivate(false);
                _robotController.SetJointSignActivate(false);
                _robotController.SetJointSignActivate(1, true);
                _robotController.SetLinkSignActivate(1, true);
                break;
            default:
                break;
        }
    }
    public void UpdateTable()
    {
        List<float> vs = _robotController.GetJointAngles();
        for (int i = 0; i < 3; i++)
        {
            _robotController.SetJointSign(i, "θ" + (i + 1) + " = " + vs[i].ToString("F2") + "°", "");
        }
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        matrix1Text[3].text = _robotController.GetJointAngle(0).ToString("F2") + "°";
        matrix1Text[7].text = "-8.30°+" + _robotController.GetJointAngle(1).ToString("F2") + "°";
        matrix1Text[11].text = "8.30°+" + _robotController.GetJointAngle(1).ToString("F2") + "°";

        matrix2Text[0].text = (Angle1Cos * Angle23Cos + 0.00001f).ToString("F3");
        matrix2Text[1].text = (-Angle1Cos * Angle23Sin + 0.00001f).ToString("F3");
        matrix2Text[2].text = (Angle1Sin + 0.00001f).ToString("F3");
        matrix2Text[3].text = (RobotController.A1 * Angle1Cos * Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f)) + 0.00001f).ToString("F3");
        matrix2Text[4].text = (Angle1Sin * Angle23Cos + 0.00001f).ToString("F3");
        matrix2Text[5].text = (-Angle1Sin * Angle23Sin + 0.00001f).ToString("F3");
        matrix2Text[6].text = (-Angle1Cos + 0.00001f).ToString("F3");
        matrix2Text[7].text = (RobotController.L1 * Angle1Sin * Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f)) + 0.00001f).ToString("F3");
        matrix2Text[8].text = (Angle23Sin + 0.00001f).ToString("F3");
        matrix2Text[9].text = (Angle23Cos + 0.00001f).ToString("F3");
        matrix2Text[10].text = "0";
        matrix2Text[11].text = (RobotController.L1 * Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f)) + 10.00001f).ToString("F3");

    }
    public void ToggleDHFrames(bool value)
    {
        foreach(var ele in DHFrames)
        {
            ele.SetActive(value);
        }
    }
}
