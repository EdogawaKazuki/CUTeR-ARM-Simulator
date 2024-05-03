using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HomogeneousTransformation2 : MonoBehaviour
{
    RobotController _robotController;
    TMP_Text[] matrix1Text;
    TMP_Text[] matrix2Text;
    TMP_Text[] matrix3Text;

    float Angle1Sin;
    float Angle1Cos;
    float Angle2Sin;
    float Angle2Cos;
    float Angle23Sin;
    float Angle23Cos;
    List<List<float>> _JointSetList = new List<List<float>> { new List<float> { -60, 60, -120 }};

    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        matrix1Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix2Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line3/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix3Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix3Text[i] = transform.Find("Input/Line4/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        transform.Find("Input/Line5/Set1").GetComponent<Button>().onClick.AddListener(() => SetJointAngles(new(){ -60, 60, -120 }));
    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    public void UpdateTable()
    {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));

        matrix1Text[0].text = (Angle1Cos + 0.00001f).ToString("F2");
        matrix1Text[1].text = (-Angle1Sin + 0.00001f).ToString("F2");
        matrix1Text[2].text = "0";
        matrix1Text[3].text = "0";
        matrix1Text[4].text = (Angle1Sin + 0.00001f).ToString("F2");
        matrix1Text[5].text = (Angle1Cos + 0.00001f).ToString("F2");
        matrix1Text[6].text = "0";
        matrix1Text[7].text = "0";
        matrix1Text[8].text = "0";
        matrix1Text[9].text = "0";
        matrix1Text[10].text = "1";
        matrix1Text[11].text = _robotController.A1.ToString("F1");
        matrix1Text[12].text = "0";
        matrix1Text[13].text = "0";
        matrix1Text[14].text = "0";
        matrix1Text[15].text = "1";

        matrix2Text[0].text = (Angle1Cos + 0.00001f).ToString("F2");
        matrix2Text[1].text = (-Angle1Sin * Angle2Cos + 0.00001f).ToString("F2");
        matrix2Text[2].text = (Angle1Sin * Angle2Sin + 0.00001f).ToString("F2");
        matrix2Text[3].text = "0";
        matrix2Text[4].text = (Angle1Sin + 0.00001f).ToString("F2");
        matrix2Text[5].text = (Angle1Cos * Angle2Cos + 0.00001f).ToString("F2");
        matrix2Text[6].text = (-Angle1Cos * Angle2Sin + 0.00001f).ToString("F2");
        matrix2Text[7].text = "0";
        matrix2Text[8].text = "0";
        matrix2Text[9].text = (Angle2Sin + 0.00001f).ToString("F2");
        matrix2Text[10].text = (Angle2Cos + 0.00001f).ToString("F2");
        matrix2Text[11].text = _robotController.A1.ToString("F1");
        matrix2Text[12].text = "0";
        matrix2Text[13].text = "0";
        matrix2Text[14].text = "0";
        matrix2Text[15].text = "1";

        matrix3Text[0].text = (Angle1Cos + 0.00001f).ToString("F2");
        matrix3Text[1].text = (-Angle1Sin * Angle23Cos + 0.00001f).ToString("F2");
        matrix3Text[2].text = (Angle1Sin * Angle23Sin + 0.00001f).ToString("F2");
        matrix3Text[3].text = (-_robotController.L1 * Angle1Sin * Angle2Cos - _robotController.A2 * Angle1Sin * Angle2Sin + 0.00001f).ToString("F2");
        matrix3Text[4].text = (Angle1Sin + 0.00001f).ToString("F2");
        matrix3Text[5].text = (Angle1Cos * Angle23Cos + 0.00001f).ToString("F2");
        matrix3Text[6].text = (Angle1Cos * Angle23Sin + 0.00001f).ToString("F2");
        matrix3Text[7].text = (_robotController.L1 * Angle1Cos * Angle2Cos + _robotController.A2 * Angle1Cos * Angle2Sin + 0.00001f).ToString("F2");
        matrix3Text[8].text = "0";
        matrix3Text[9].text = (Angle23Sin + 0.00001f).ToString("F2");
        matrix3Text[10].text = (Angle23Cos + 0.00001f).ToString("F2");
        matrix3Text[11].text = (_robotController.L1 * Angle2Sin - _robotController.A2 * Angle2Cos + + _robotController.L1 + 0.00001f).ToString("F2");
        matrix3Text[12].text = "0";
        matrix3Text[13].text = "0";
        matrix3Text[14].text = "0";
        matrix3Text[15].text = "1";

    }

    public void SetJointAngles(List<float> joints)
    {
        _robotController.MoveJointsTo(joints);
    }
}
