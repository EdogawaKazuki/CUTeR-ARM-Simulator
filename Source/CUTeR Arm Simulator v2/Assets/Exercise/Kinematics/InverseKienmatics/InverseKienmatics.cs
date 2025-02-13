using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InverseKienmatics : MonoBehaviour
{
    RobotController _robotController;
    TMP_Text[] matrix1Text;

    float x = 0, y = 0, z = 0;

    float angle1 = 0;
    float[] angle2_deg;
    float[] angle3_deg;
    Button button1;
    Button button2;
    Color black = new Color(0, 0, 0);
    Color red = new Color(0.8f, 0, 0);

    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        matrix1Text = new TMP_Text[6];
        for (int i = 0; i < 3; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line3/Values1/" + (i + 1)).GetComponent<TMP_Text>();
        }
        for (int i = 0; i < 3; i++)
        {
            matrix1Text[i + 3] = transform.Find("Input/Line3/Values2/" + (i + 1)).GetComponent<TMP_Text>();
        }
        button1 = transform.Find("Input/Line4/Select1").GetComponent<Button>();
        button2 = transform.Find("Input/Line4/Select2").GetComponent<Button>();
        button1.onClick.AddListener(() => SetJointAngles(0));
        button2.onClick.AddListener(() => SetJointAngles(1));
        transform.Find("Input/Line1/setx/xInput").GetComponent<TMP_InputField>().onValueChanged.AddListener(SetX);
        transform.Find("Input/Line1/sety/yInput").GetComponent<TMP_InputField>().onValueChanged.AddListener(SetY);
        transform.Find("Input/Line1/setz/zInput").GetComponent<TMP_InputField>().onValueChanged.AddListener(SetZ);
        //UpdateTable();
    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    public void UpdateTable()
    {
        button1.interactable = true;
        button2.interactable = true;
        /////////////calculate angle 1/////////////
        float angle1_rad = -Mathf.Atan2(x, y);
        angle1 = Mathf.Rad2Deg * angle1_rad;
        matrix1Text[0].text = (angle1 + 0.00001f).ToString("F1") + "°";
        matrix1Text[3].text = (angle1 + 0.00001f).ToString("F1") + "°";
        if (angle1 > _robotController.GetJointAngleMax(0)|| angle1 < _robotController.GetJointAngleMin(0))
        {
            matrix1Text[0].color = red;
            matrix1Text[3].color = red;
            button1.interactable = false;
            button2.interactable = false;
        }
        else
        {
            matrix1Text[0].color = black;
            matrix1Text[3].color = black;
        }

        //////////make variables for ease of calculation//////////
        float A1 = _robotController.A1;  //length properties of the teaching robot arm (in cm)
        float A2 = _robotController.A2; //length properties of the teaching robot arm (in cm)
        float L1 = _robotController.L1; //length properties of the teaching robot arm (in cm)
        float L2 = _robotController.L2;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap

        float a = -x * Mathf.Sin(angle1_rad) + y * Mathf.Cos(angle1_rad);
        float b = z - A1;
        float d = L1 * L1 + A2 * A2 + L2 * L2 - a * a - b * b;
        float qA = 4 * L1 * L1 * L2 * L2 + 4 * L2 * L2 * A2 * A2;
        float qB = 4 * L1 * L2 * d;
        float qC = d * d - 4 * L2 * L2 * A2 * A2;
        /////////////calculate angle 3 candidates/////////////
        float[] angle3_rad_candidates = new float[4];
        angle3_rad_candidates[0] = Mathf.Acos((-qB + Mathf.Sqrt(qB * qB - 4 * qA * qC)) / (2 * qA));
        angle3_rad_candidates[1] = Mathf.Acos((-qB - Mathf.Sqrt(qB * qB - 4 * qA * qC)) / (2 * qA));
        angle3_rad_candidates[2] = -Mathf.Acos((-qB + Mathf.Sqrt(qB * qB - 4 * qA * qC)) / (2 * qA));
        angle3_rad_candidates[3] = -Mathf.Acos((-qB - Mathf.Sqrt(qB * qB - 4 * qA * qC)) / (2 * qA));

        /////////////select and display real angle 3 solution(s)/////////////
        float[] angle3_rad = new float[2];  //to store real solutions
        angle3_deg = new float[2];
        int n = 0;         //to count the number of real solutions
        for (int i = 0; i < 4; i++)
        {
            if (!float.IsNaN(angle3_rad_candidates[i]) && (d + 2 * L1 * L2 * Mathf.Cos(angle3_rad_candidates[i])) * (2 * L2 * A2 * Mathf.Sin(angle3_rad_candidates[i])) >= 0)
            {  //if it's a real solution
                angle3_rad[n] = angle3_rad_candidates[i];
                angle3_deg[n] = Mathf.Rad2Deg * angle3_rad[n];
                if (n == 0)
                {
                    matrix1Text[2].text = angle3_deg[0].ToString("F1") + "°";

                    if (angle3_deg[0] > _robotController.GetJointAngleMax(2) || angle3_deg[0] < _robotController.GetJointAngleMin(2))
                    {
                        matrix1Text[2].color = red;
                        button1.interactable = false;
                    }
                    else
                    {
                        matrix1Text[2].color = black;
                    }
                }
                else if (n == 1)
                {
                    matrix1Text[5].text = angle3_deg[1].ToString("F1") + "°";

                    if (angle3_deg[1] > _robotController.GetJointAngleMax(2) || angle3_deg[1] < _robotController.GetJointAngleMin(2))
                    {
                        matrix1Text[5].color = red;
                        button2.interactable = false;
                    }
                    else
                    {
                        matrix1Text[5].color = black;
                    }
                }
                n++;
            }
        }
        //Debug.Log("n:" + n);
        if (n == 0)
        { //no solution
            matrix1Text[1].text = "---";
            matrix1Text[2].text = "---";
            matrix1Text[4].text = "---";
            matrix1Text[5].text = "---";
            return;  //nothing else to calculate, so we quit.
        }
        else if (n == 1)
        { //only 1 solution
            matrix1Text[4].text = "---";
            matrix1Text[5].text = "---";
        }

        /////////////calculate and display angle 2/////////////
        float[] angle2_rad = new float[n];
        angle2_deg = new float[n];
        for (int i = 0; i < n; i++)
        {
            angle2_rad[i] = Mathf.Atan2(b * (L1 + L2 * Mathf.Cos(angle3_rad[i])) - a * (L2 * Mathf.Sin(angle3_rad[i]) - A2), a * (L1 + L2 * Mathf.Cos(angle3_rad[i])) + b * (L2 * Mathf.Sin(angle3_rad[i]) - A2));
            angle2_deg[i] = Mathf.Rad2Deg * angle2_rad[i];
            if (i == 0)
            {
                matrix1Text[1].text = angle2_deg[0].ToString("F1") + "°";

                if (angle2_deg[0] > _robotController.GetJointAngleMax(1) || angle2_deg[0] < _robotController.GetJointAngleMin(1))
                {
                    matrix1Text[1].color = red;
                    button1.interactable = false;
                }
                else
                {
                    matrix1Text[1].color = black;
                }
            }
            else if(i == 1)
            {
                matrix1Text[4].text = angle2_deg[1].ToString("F1") + "°";

                if (angle2_deg[1] > _robotController.GetJointAngleMax(1) || angle2_deg[1] < _robotController.GetJointAngleMin(1))
                {
                    matrix1Text[4].color = red;
                    button2.interactable = false;
                }
                else
                {
                    matrix1Text[4].color = black;
                }
            }
        }
    }

    public void SetX(string value)
    {
        float.TryParse(value, out x);
        UpdateTable();

    }
    public void SetY(string value)
    {
        float.TryParse(value, out y);
        UpdateTable();
    }
    public void SetZ(string value)
    {
        float.TryParse(value, out z);
        UpdateTable();
    }
    
    public void SetJointAngles(int index)
    {
        _robotController.MoveJointsTo(new List<float> { angle1, angle2_deg[index], angle3_deg[index] });
    }
}
