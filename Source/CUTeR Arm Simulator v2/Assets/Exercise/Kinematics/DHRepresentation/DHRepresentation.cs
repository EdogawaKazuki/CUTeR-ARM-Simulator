using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using Unity.VisualScripting;
using System;

public class DHRepresentation : MonoBehaviour
{
    RobotController _robotController;
    TMP_Text[] matrix1IndexText;
    TMP_Text[] matrix1Text;
    TMP_Text[] matrix15Text;
    TMP_Text[] matrix2Text;

    float s1;
    float c1;
    float s2;
    float c2;
    float s23;
    float c23;
    float s3;
    float c3;
    float s4;
    float c4;
    float s5;
    float c5;
    float s6;
    float c6;
    int RobotDoF;
    [SerializeField]
    List<GameObject> DHFrames = new List<GameObject>();


    private void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        matrix1IndexText = new TMP_Text[3];
        for (int i = 0; i < 3; i++)
        {
            matrix1IndexText[i] = transform.Find("Input/Line2/Values/i").GetComponent<TMP_Text>();
        }
        matrix1Text = new TMP_Text[12];
        for (int i = 0; i < 12; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix15Text = new TMP_Text[12];
        for (int i = 0; i < 12; i++)
        {
            matrix15Text[i] = transform.Find("Input/Line2.5/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix2Text = new TMP_Text[16];
        for (int i = 0; i < 16; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line4/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        transform.Find("Input/Line2/Values/one/Button").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.ShowJointDHFrame(0, value));
        transform.Find("Input/Line2/Values/two/Button").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.ShowJointDHFrame(1, value));
        transform.Find("Input/Line2/Values/three/Button").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.ShowJointDHFrame(2, value));
        transform.Find("Input/Line2.5/Values/one/Button").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.ShowJointDHFrame(3, value));
        transform.Find("Input/Line2.5/Values/two/Button").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.ShowJointDHFrame(4, value));
        transform.Find("Input/Line2.5/Values/three/Button").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.ShowJointDHFrame(5, value));
        if (_robotController.GetRobotDoF() == 3)
        {
            transform.Find("Input/Line2").gameObject.SetActive(true);
            transform.Find("Input/Line2.5").gameObject.SetActive(false);
            transform.Find("Input/Line3").gameObject.SetActive(false);
            transform.Find("Input/Line4").gameObject.SetActive(false);
        }
        else if (_robotController.GetRobotDoF() == 6)
        {
            transform.Find("Input/Line2").gameObject.SetActive(true);
            transform.Find("Input/Line2.5").gameObject.SetActive(true);
            transform.Find("Input/Line3").gameObject.SetActive(false);
            transform.Find("Input/Line4").gameObject.SetActive(false);
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
        if (_robotController.GetRobotDoF() == 3)
        {
            for (int i = 0; i < 3; i++)
            {
                matrix1IndexText[i].text = "" + (i + 1);
            }
            List<float> vs = _robotController.GetJointAngles();
            // for (int i = 0; i < 3; i++)
            // {
            //     _robotController.SetJointSign(i, "θ" + (i + 1) + " = " + vs[i].ToString("F1") + "°", "");
            // }
            s1 = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
            c1 = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
            s2 = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
            c2 = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
            s23 = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
            c23 = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
            s23 = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
            c23 = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));

            matrix1Text[0].text = "0°";
            matrix1Text[1].text = "0";
            matrix1Text[2].text = _robotController.A1.ToString("F1");
            matrix1Text[3].text = _robotController.GetJointAngle(0).ToString("F1") + "°";
            matrix1Text[4].text = "90°";
            matrix1Text[5].text = "0";
            matrix1Text[6].text = "0";
            matrix1Text[7].text = "-8.30°\n+" + _robotController.GetJointAngle(1).ToString("F1") + "°";
            matrix1Text[8].text = "0°";
            matrix1Text[9].text = _robotController.L1.ToString("F1");
            matrix1Text[10].text = "0";
            matrix1Text[11].text = "8.30°\n+" + _robotController.GetJointAngle(2).ToString("F1") + "°";

            matrix2Text[0].text = (c1 * c23 + 0.00001f).ToString("F2");
            matrix2Text[1].text = (-c1 * s23 + 0.00001f).ToString("F2");
            matrix2Text[2].text = (s1 + 0.00001f).ToString("F2");
            matrix2Text[3].text = (_robotController.L1 * c1 * Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f)) + 0.00001f).ToString("F2");
            matrix2Text[4].text = (s1 * c23 + 0.00001f).ToString("F2");
            matrix2Text[5].text = (-s1 * s23 + 0.00001f).ToString("F2");
            matrix2Text[6].text = (-c1 + 0.00001f).ToString("F2");
            matrix2Text[7].text = (_robotController.L1 * s1 * Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f)) + 0.00001f).ToString("F2");
            matrix2Text[8].text = (s23 + 0.00001f).ToString("F2");
            matrix2Text[9].text = (c23 + 0.00001f).ToString("F2");
            matrix2Text[10].text = "0";
            matrix2Text[11].text = (_robotController.L1 * Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f)) + _robotController.A1 + 0.00001f).ToString("F2");
        }
        else if (_robotController.GetRobotDoF() == 6)
        {
            for (int i = 0; i < 3; i++)
            {
                matrix1IndexText[i].text = "" + (3 + i + 1);
            }
            List<float> vs = _robotController.GetJointAngles();
            // for (int i = 0; i < 3; i++)
            // {
            //     _robotController.SetJointSign(i, "θ" + (i + 1) + " = " + vs[i].ToString("F1") + "°", "");
            // }
            s1 = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
            c1 = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
            s2 = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f));
            c2 = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) - 8.3f));
            s3 = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(2) + 8.3f + 90));
            c3 = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(2) + 8.3f + 90));
            s4 = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(3));
            c4 = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(3));
            s5 = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(4));
            c5 = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(4));
            s6 = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(5));
            c6 = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(5));

            matrix1Text[0].text = "0°";
            matrix1Text[1].text = "0";
            matrix1Text[2].text = _robotController.A1.ToString("F1");
            matrix1Text[3].text = _robotController.GetJointAngle(0).ToString("F1") + "°";
            matrix1Text[4].text = "90°";
            matrix1Text[5].text = "0";
            matrix1Text[6].text = "0";
            matrix1Text[7].text = "-8.30°\n+" + _robotController.GetJointAngle(1).ToString("F1") + "°";
            matrix1Text[8].text = "0°";
            matrix1Text[9].text = Math.Sqrt(_robotController.L1 * _robotController.L1 + _robotController.A2 * _robotController.A2).ToString("F1");
            matrix1Text[10].text = "0";
            matrix1Text[11].text = "8.30°\n+" + _robotController.GetJointAngle(2).ToString("F1") + "°";

            matrix15Text[0].text = "90°";
            matrix15Text[1].text = "0";
            matrix15Text[2].text = _robotController.L2.ToString("F1");
            matrix15Text[3].text = _robotController.GetJointAngle(3).ToString("F1") + "°";
            matrix15Text[4].text = "-90°";
            matrix15Text[5].text = "0";
            matrix15Text[6].text = "0";
            matrix15Text[7].text = _robotController.GetJointAngle(4).ToString("F1") + "°";
            matrix15Text[8].text = "90°";
            matrix15Text[9].text = "0";
            matrix15Text[10].text = "0";
            matrix15Text[11].text = _robotController.GetJointAngle(5).ToString("F1") + "°";
  matrix2Text[0].text = (s6*(c4*s1 - s4*(c1*c2*c3 - c1*s2*s3)) - c6*(s5*(c1*c2*s3 + c1*c3*s2) - c5*(s1*s4 + c4*(c1*c2*c3 - c1*s2*s3)))).ToString("F2");
  matrix2Text[1].text = ( s6*(s5*(c1*c2*s3 + c1*c3*s2) - c5*(s1*s4 + c4*(c1*c2*c3 - c1*s2*s3))) + c6*(c4*s1 - s4*(c1*c2*c3 - c1*s2*s3))).ToString("F2");
  matrix2Text[2].text = ( c5*(c1*c2*s3 + c1*c3*s2) + s5*(s1*s4 + c4*(c1*c2*c3 - c1*s2*s3))).ToString("F2");
  matrix2Text[3].text = ( (98*c1*c2)/5 + 25*c1*c2*s3 + 25*c1*c3*s2).ToString("F2");
  
matrix2Text[4].text = (- c6*(s5*(c2*s1*s3 + c3*s1*s2) + c5*(c1*s4 - c4*(c2*c3*s1 - s1*s2*s3))) - s6*(c1*c4 + s4*(c2*c3*s1 - s1*s2*s3))).ToString("F2");
matrix2Text[5].text = ( s6*(s5*(c2*s1*s3 + c3*s1*s2) + c5*(c1*s4 - c4*(c2*c3*s1 - s1*s2*s3))) - c6*(c1*c4 + s4*(c2*c3*s1 - s1*s2*s3))).ToString("F2");
matrix2Text[6].text = ( c5*(c2*s1*s3 + c3*s1*s2) - s5*(c1*s4 - c4*(c2*c3*s1 - s1*s2*s3))).ToString("F2");
matrix2Text[7].text = ( (98*c2*s1)/5 + 25*c2*s1*s3 + 25*c3*s1*s2).ToString("F2");

                                        matrix2Text[8].text = (c6*(s5*(c2*c3 - s2*s3) + c4*c5*(c2*s3 + c3*s2)) - s4*s6*(c2*s3 + c3*s2)).ToString("F2");
                                        matrix2Text[9].text = (                                     - s6*(s5*(c2*c3 - s2*s3) + c4*c5*(c2*s3 + c3*s2)) - c6*s4*(c2*s3 + c3*s2)).ToString("F2");
                                        matrix2Text[10].text = (                       c4*s5*(c2*s3 + c3*s2) - c5*(c2*c3 - s2*s3)).ToString("F2");
                                        matrix2Text[11].text = (   (98*s2)/5 - 25*c2*c3 + 25*s2*s3 + 54/5).ToString("F2");
        }

    }
    public void ToggleDHFrames(bool value)
    {
        _robotController.ShowJointsDHFrame(value);
    }
    public void ToggleDHTable(bool value)
    {
        if (value)
        {
            if (_robotController.GetRobotDoF() == 3)
            {
                transform.Find("Input/Line2").gameObject.SetActive(true);
                transform.Find("Input/Line2.5").gameObject.SetActive(false);
                transform.Find("Input/Line3").gameObject.SetActive(false);
                transform.Find("Input/Line4").gameObject.SetActive(false);
            }
            else if (_robotController.GetRobotDoF() == 6)
            {
                transform.Find("Input/Line2").gameObject.SetActive(true);
                transform.Find("Input/Line2.5").gameObject.SetActive(true);
                transform.Find("Input/Line3").gameObject.SetActive(false);
                transform.Find("Input/Line4").gameObject.SetActive(false);
            }
        }
        else
        {
            transform.Find("Input/Line2").gameObject.SetActive(false);
            transform.Find("Input/Line2.5").gameObject.SetActive(false);
            transform.Find("Input/Line3").gameObject.SetActive(true);
            transform.Find("Input/Line4").gameObject.SetActive(true);
        }
    }
}
