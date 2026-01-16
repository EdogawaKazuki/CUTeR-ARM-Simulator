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
    Toggle PageToggle;
    float Angle1Sin;
    float Angle1Cos;
    float Angle2Sin;
    float Angle2Cos;
    float Angle3Sin;
    float Angle3Cos;
    float Angle4Sin;
    float Angle4Cos;
    float Angle5Sin;
    float Angle5Cos;
    float Angle6Sin;
    float Angle6Cos;
    // Start is called before the first frame update
    void OnEnable()
    {
        _matrixText = new TMP_Text[6][];
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        for (int i = 0; i < 6; i++)
        {
            _matrixText[i] = new TMP_Text[9];
            for (int j = 0; j < 9; j++)
            {
                _matrixText[i][j] = transform.Find("Input/Line" + (i + 2) + "/Values/" + (j + 1)).GetComponent<TMP_Text>();
            }
        }
        JointSetBtn1 = transform.Find("Input/Line8/Set1").GetComponent<Button>();
        JointSetBtn1.onClick.AddListener(() => SetJointAngles(new(){ 90, 50, -130 }));
        PageToggle = transform.Find("Input/Line8/PageToggle").GetComponent<Toggle>();
        PageToggle.onValueChanged.AddListener((value) => TogglePage(value));
    }

    void TogglePage(bool isOn)
    {
        if(isOn){
            for(int i = 0; i < 3; i++)
            {
                transform.Find("Input/Line" + (i + 2)).gameObject.SetActive(false);
                transform.Find("Input/Line" + (i + 5)).gameObject.SetActive(true);
            }

        } else {
            for(int i = 0; i < 3; i++)
            {
                transform.Find("Input/Line" + (i + 2)).gameObject.SetActive(true);
                transform.Find("Input/Line" + (i + 5)).gameObject.SetActive(false);
            }
        }
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

        Angle4Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(3));
        Angle4Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(3));
        Angle5Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(4));
        Angle5Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(4));
        Angle6Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(5));
        Angle6Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(5));

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

        _matrixText[3][0].text = "1";
        _matrixText[3][1].text = "0";
        _matrixText[3][2].text = "0";
        _matrixText[3][3].text = "0";
        _matrixText[3][4].text = (Angle4Cos + 0.00001f).ToString("F3");
        _matrixText[3][5].text = (-Angle4Sin + 0.00001f).ToString("F3");
        _matrixText[3][6].text = "0";
        _matrixText[3][7].text = (Angle4Sin + 0.00001f).ToString("F3");
        _matrixText[3][8].text = (Angle4Cos + 0.00001f).ToString("F3");

        _matrixText[4][0].text = (Angle5Cos + 0.00001f).ToString("F3");
        _matrixText[4][1].text = "0";
        _matrixText[4][2].text = (Angle5Sin + 0.00001f).ToString("F3");
        _matrixText[4][3].text = "0";
        _matrixText[4][4].text = "1";
        _matrixText[4][5].text = "0";
        _matrixText[4][6].text = (-Angle5Sin + 0.00001f).ToString("F3");
        _matrixText[4][7].text = "0";
        _matrixText[4][8].text = (Angle5Cos + 0.00001f).ToString("F3");

        
        _matrixText[5][0].text = "1";
        _matrixText[5][1].text = "0";
        _matrixText[5][2].text = "0";
        _matrixText[5][3].text = "0";
        _matrixText[5][4].text = (Angle6Cos + 0.00001f).ToString("F3");
        _matrixText[5][5].text = (-Angle6Sin + 0.00001f).ToString("F3");
        _matrixText[5][6].text = "0";
        _matrixText[5][7].text = (Angle6Sin + 0.00001f).ToString("F3");
        _matrixText[5][8].text = (Angle6Cos + 0.00001f).ToString("F3");
    }

    public void SetJointAngles(List<float> joints)
    {
        _robotController.MoveJointsTo(joints);
    }
}
