using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singularity : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
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
    float angularVelocity1_d;
    float angularVelocity2_d;
    float angularVelocity3_d;
    List<float> LastJointAngle;
    List<float> avgAngularVelocity1;
    List<float> avgAngularVelocity2;
    List<float> avgAngularVelocity3;
    List<float> avglinearVelocityX;
    List<float> avglinearVelocityY;
    List<float> avglinearVelocityZ;
    List<List<float>> _JointSetList = new List<List<float>> { new List<float> { 0, 8.297f, -8.297f }, new List<float> { 0, 165, -133.062f } };

    //int thisFeedback = 0;
    //int NTH_FEEDBACK_TO_DISPLAY = 3;
    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("EditorAdmin").GetComponent<EditorController>().GetRobotController();
        LastJointAngle = new List<float>();
        avgAngularVelocity1 = new List<float>();
        avgAngularVelocity2 = new List<float>();
        avgAngularVelocity3 = new List<float>();
        avglinearVelocityX = new List<float>();
        avglinearVelocityY = new List<float>();
        avglinearVelocityZ = new List<float>();
        for (int i = 0; i < 3; i++)
        {
            LastJointAngle.Add(0);
            _robotController.SetJointAngle(i, 0);
        }
        matrix1Text = new Text[9];
        for (int i = 0; i < 9; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/" + (i + 1)).GetComponent<Text>();
        }
        matrix2Text = new Text[1];
        for (int i = 0; i < 1; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line4/" + (i + 1)).GetComponent<Text>();
        }
        //UpdateTable();
    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    private void UpdateTable()
    {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        float A1 = RobotController.A1;  //length properties of the teaching robot arm (in cm)
        float A2 = RobotController.A2; //length properties of the teaching robot arm (in cm)
        float L1 = RobotController.L1; //length properties of the teaching robot arm (in cm)
        float L2 = RobotController.L2;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap

        float[][] J = new float[3][];
        J[0] = new float[] { -Angle1Cos * (A2 * Angle2Sin + L1 * Angle2Cos + L2 * Angle23Cos), -Angle1Sin * (A2 * Angle2Cos - L1 * Angle2Sin + L2 * Angle23Sin), Angle1Sin * (L2 * Angle23Sin) };
        J[1] = new float[] { -Angle1Sin * (A2 * Angle2Sin + L1 * Angle2Cos + L2 * Angle23Cos), Angle1Cos * (A2 * Angle2Cos - L1 * Angle2Sin + L2 * Angle23Sin), -Angle1Cos * (L2 * Angle23Sin) };
        J[2] = new float[] { 0, L1 * Angle2Cos + L2 * Angle23Cos + A2 * Angle2Sin, L2 * Angle23Cos };

        matrix1Text[0].text = J[0][0].ToString("F3");
        matrix1Text[1].text = J[0][1].ToString("F3");
        matrix1Text[2].text = J[0][2].ToString("F3");
        matrix1Text[3].text = J[1][0].ToString("F3");
        matrix1Text[4].text = J[1][1].ToString("F3");
        matrix1Text[5].text = J[1][2].ToString("F3");
        matrix1Text[6].text = J[2][0].ToString("F3");
        matrix1Text[7].text = J[2][1].ToString("F3");
        matrix1Text[8].text = J[2][2].ToString("F3");

        if (J[0][0] > -1 && J[0][0] < 1)
        {
            matrix1Text[0].color = Color.gray;
        }
        else
        {
            matrix1Text[0].color = Color.black;
        }
        if (J[0][1] > -1 && J[0][1] < 1)
        {
            matrix1Text[1].color = Color.gray;
        }
        else
        {
            matrix1Text[1].color = Color.black;
        }
        if (J[0][2] > -1 && J[0][2] < 1)
        {
            matrix1Text[2].color = Color.gray;
        }
        else
        {
            matrix1Text[2].color = Color.black;
        }
        if (J[1][0] > -1 && J[1][0] < 1)
        {
            matrix1Text[3].color = Color.gray;
        }
        else
        {
            matrix1Text[3].color = Color.black;
        }
        if (J[1][1] > -1 && J[1][1] < 1)
        {
            matrix1Text[4].color = Color.gray;
        }
        else
        {
            matrix1Text[4].color = Color.black;
        }
        if (J[1][2] > -1 && J[1][2] < 1)
        {
            matrix1Text[5].color = Color.gray;
        }
        else
        {
            matrix1Text[5].color = Color.black;
        }
        if (J[2][0] > -1 && J[2][0] < 1)
        {
            matrix1Text[6].color = Color.gray;
        }
        else
        {
            matrix1Text[6].color = Color.black;
        }
        if (J[2][1] > -1 && J[2][1] < 1)
        {
            matrix1Text[7].color = Color.gray;
        }
        else
        {
            matrix1Text[7].color = Color.black;
        }
        if (J[2][2] > -1 && J[2][2] < 1)
        {
            matrix1Text[8].color = Color.gray;
        }
        else
        {
            matrix1Text[8].color = Color.black;
        }
        float det = J[0][0] * (J[1][1] * J[2][2] - J[1][2] * J[2][1]) + J[0][1] * (J[1][2] * J[2][0] - J[1][0] * J[2][2]) + J[0][2] * (J[1][0] * J[2][1] - J[1][1] * J[2][0]);
        matrix2Text[0].text = det.ToString("F1");
        if (Mathf.Abs(det)> 1500)
        {
            matrix2Text[0].color = new Color(0, 0.5f, 0);
        }
        else if (Mathf.Abs(det) < 500)
        {
            matrix2Text[0].color = Color.red;
        }
        else
        {
            matrix2Text[0].color = Color.black;
        }
    }

    public void SetPose1()
    {

        _robotController.MoveJointsTo(_JointSetList[0]);
    }
    public void SetPose2()
    {
        _robotController.MoveJointsTo(_JointSetList[1]);
    }
}
