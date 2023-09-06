using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HomogeneousTransformation3 : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    TMP_Text[] matrix1Text;
    TMP_Text[] matrix2Text;

    float Angle1Sin;
    float Angle1Cos;
    float Angle2Sin;
    float Angle2Cos;
    float Angle23Sin;
    float Angle23Cos;
    List<List<float>> _JointSetList = new List<List<float>> { new List<float> { -60, 60, -120 } };

    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        matrix1Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix2Text = new TMP_Text[3];
        for (int i = 0; i < 3; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line6/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        transform.Find("Input/Line7/Set1").GetComponent<Button>().onClick.AddListener(() => SetJointAngles(new() { -60, 60, -120 }));

    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    public void UpdateTable()
    {
        float a1 = _robotController.GetJointAngle(0);
        float a2 = _robotController.GetJointAngle(1);
        float a3 = _robotController.GetJointAngle(2);

        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));

        matrix1Text[0].text = "cos(" +a1.ToString("F0") + "°)";
        matrix1Text[1].text = "-sin(" + a1.ToString("F0") + "°)cos(" + a2.ToString("F0") + "°" + (a3 > 0 ? " + ": " - ") + Mathf.Abs(a3).ToString("F0") + "°)";
        matrix1Text[2].text = "sin(" + a1.ToString("F0") + "°)sin(" + a2.ToString("F0") + "°" + (a3 > 0 ? " + " : " - ") + Mathf.Abs(a3).ToString("F0") + "°)";
        matrix1Text[3].text = "-19.2sin(" + a1.ToString("F0") + "°)cos(" + a2.ToString("F0") + "°" + ")\n- 2.8sin(" + a1.ToString("F0") + "°)sin(" + a2.ToString("F0") + "°)";
        matrix1Text[4].text = "sin(" + a1.ToString("F0") + "°)";
        matrix1Text[5].text = "cos(" + a1.ToString("F0") + "°)cos(" + a2.ToString("F0") + "°" + (a3 > 0 ? " + " : " - ") + Mathf.Abs(a3).ToString("F0") + "°)";
        matrix1Text[6].text = "-cos(" + a1.ToString("F0") + "°)sin(" + a2.ToString("F0") + "°" + (a3 > 0 ? " + " : " - ") + Mathf.Abs(a3).ToString("F0") + "°)";
        matrix1Text[7].text = "19.2cos(" + a1.ToString("F0") + "°)cos(" + a2.ToString("F0") + "°" + ")\n+ 2.8cos(" + a1.ToString("F0") + "°)sin(" + a2.ToString("F0") + "°)";
        matrix1Text[8].text = "0";
        matrix1Text[9].text = "sin(" + a2.ToString("F0") + "°" + (a3 > 0 ? " + " : " - ") + Mathf.Abs(a3).ToString("F0") + "°)";
        matrix1Text[10].text = "cos(" + a2.ToString("F0") + "°" + (a3 > 0 ? " + " : " - ") + Mathf.Abs(a3).ToString("F0") + "°)";
        matrix1Text[11].text = "19.2sin(" + a2.ToString("F0") + "°)\n- 2.8cos(" + a2.ToString("F0") + "°) + 10";
        matrix1Text[12].text = "0";
        matrix1Text[13].text = "0";
        matrix1Text[14].text = "0";
        matrix1Text[15].text = "1";

        matrix2Text[0].text = (-Angle1Sin * Angle23Cos * 21 + (-19.2 * Angle1Sin * Angle2Cos - 2.8 * Angle1Sin * Angle2Sin) + 0.001).ToString("F2") + " cm";
        matrix2Text[1].text = (Angle1Cos * Angle23Cos * 21 + (19.2 * Angle1Cos * Angle2Cos + 2.8 * Angle1Cos * Angle2Sin) + 0.001).ToString("F2") + " cm";
        matrix2Text[2].text = (Angle23Sin * 21 + (19.2 * Angle2Sin - 2.8 * Angle2Cos) + 10.001).ToString("F2") + " cm";

    }
    public void SetJointAngles(List<float> joints)
    {
        _robotController.MoveJointsTo(joints);
    }
}
