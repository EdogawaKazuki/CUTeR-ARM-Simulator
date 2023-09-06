using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SingleAxisRotation : MonoBehaviour
{
    RobotController _robotController;
    TMP_Text[][] _matrixText;
    Button JointSetBtn1;
    float Angle1Sin;
    float Angle1Cos;
    float Angle2Sin;
    float Angle2Cos;
    float Angle3Sin;
    float Angle3Cos;
    // Start is called before the first frame update
    void OnEnable()
    {
        _matrixText = new TMP_Text[3][];
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        for (int i = 0; i < 3; i++)
        {
            _matrixText[i] = new TMP_Text[9];
            for (int j = 0; j < 9; j++)
            {
                _matrixText[i][j] = transform.Find("Input/Line" + (i + 2) + "/Values/" + (j + 1)).GetComponent<TMP_Text>();
            }
        }
        JointSetBtn1 = transform.Find("Input/Line5/Set1").GetComponent<Button>();
        JointSetBtn1.onClick.AddListener(() => SetJointAngles(new(){ 90, 50, -130 }));
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
        Angle3Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(2));
        Angle3Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(2));

        _matrixText[0][0].text = (Angle1Cos + 0.00001f).ToString("F3");
        _matrixText[0][1].text = (-Angle1Sin + 0.00001f).ToString("F3");
        _matrixText[0][2].text = "0";
        _matrixText[0][3].text = (Angle1Sin + 0.00001f).ToString("F3");
        _matrixText[0][4].text = (Angle1Cos + 0.00001f).ToString("F3");
        _matrixText[0][5].text = "0";
        _matrixText[0][6].text = "0";
        _matrixText[0][7].text = "0";
        _matrixText[0][8].text = "1";


        _matrixText[1][0].text = "1";
        _matrixText[1][1].text = "0";
        _matrixText[1][2].text = "0";
        _matrixText[1][3].text = "0";
        _matrixText[1][4].text = (Angle2Cos + 0.00001f).ToString("F3");
        _matrixText[1][5].text = (-Angle2Sin + 0.00001f).ToString("F3");
        _matrixText[1][6].text = "0";
        _matrixText[1][7].text = (Angle2Sin + 0.00001f).ToString("F3");
        _matrixText[1][8].text = (Angle2Cos + 0.00001f).ToString("F3");

        _matrixText[2][0].text = "1";
        _matrixText[2][1].text = "0";
        _matrixText[2][2].text = "0";
        _matrixText[2][3].text = "0";
        _matrixText[2][4].text = (Angle3Cos + 0.00001f).ToString("F3");
        _matrixText[2][5].text = (-Angle3Sin + 0.00001f).ToString("F3");
        _matrixText[2][6].text = "0";
        _matrixText[2][7].text = (Angle3Sin + 0.00001f).ToString("F3");
        _matrixText[2][8].text = (Angle3Cos + 0.00001f).ToString("F3");
    }

    public void SetJointAngles(List<float> joints)
    {
        _robotController.MoveJointsTo(joints);
    }
}
