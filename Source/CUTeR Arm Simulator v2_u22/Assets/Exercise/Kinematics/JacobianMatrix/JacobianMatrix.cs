using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JacobianMatrix : MonoBehaviour
{
    RobotController _robotController;
    TMP_Text[] matrix1Text;
    TMP_Text[] matrix2Text;

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
    MovingAverage avgAngularVelocity1 = new MovingAverage(8);
    MovingAverage avgAngularVelocity2 = new MovingAverage(8);
    MovingAverage avgAngularVelocity3 = new MovingAverage(8);
    MovingAverage avglinearVelocityX = new MovingAverage(8);
    MovingAverage avglinearVelocityY = new MovingAverage(8);
    MovingAverage avglinearVelocityZ = new MovingAverage(8);

    int thisFeedback = 0;
    int NTH_FEEDBACK_TO_DISPLAY = 3;
    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        LastJointAngle = new List<float>();
        for (int i = 0; i < 3; i++)
        {
            LastJointAngle.Add(_robotController.GetJointAngle(i));
            //_robotController.SetJointAngle(i, 0);
        }
        matrix1Text = new TMP_Text[9];
        for (int i = 0; i < 9; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/Values/" + (i + 1)).GetComponent<TMP_Text>();
        }
        matrix2Text = new TMP_Text[6];
        for (int i = 0; i < 3; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line4/Values1/" + (i + 1)).GetComponent<TMP_Text>();
        }
        for (int i = 3; i < 6; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line4/Values2/" + (i - 2)).GetComponent<TMP_Text>();
        }
    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    private void UpdateTable() {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle23Sin = Mathf.Sin(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        Angle23Cos = Mathf.Cos(Mathf.Deg2Rad * (_robotController.GetJointAngle(1) + _robotController.GetJointAngle(2)));
        float A1 = _robotController.A1;  //length properties of the teaching robot arm (in cm)
        float A2 = _robotController.A2; //length properties of the teaching robot arm (in cm)
        float L1 = _robotController.L1; //length properties of the teaching robot arm (in cm)
        float L2 = _robotController.L2;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap

        float[][] J = new float[3][];
        J[0] = new float[] { -Angle1Cos * (A2 * Angle2Sin + L1 * Angle2Cos + L2 * Angle23Cos), -Angle1Sin * (A2 * Angle2Cos - L1 * Angle2Sin + L2 * Angle23Sin), Angle1Sin * (L2 * Angle23Sin) };
        J[1] = new float[] { -Angle1Sin * (A2 * Angle2Sin + L1 * Angle2Cos + L2 * Angle23Cos), Angle1Cos * (A2 * Angle2Cos - L1 * Angle2Sin + L2 * Angle23Sin), -Angle1Cos * (L2 * Angle23Sin) };
        J[2] = new float[] { 0, L1 * Angle2Cos + L2 * Angle23Cos + A2 * Angle2Sin, L2 * Angle23Cos };

        //////////calculate the angular velocity of joints//////////
        float timeInterval = 0.02f; //the arduino is programmed to give feedback every 40ms 
        angularVelocity1_d = (_robotController.GetJointAngle(0) - LastJointAngle[0]) / timeInterval;
        angularVelocity2_d = (_robotController.GetJointAngle(1) - LastJointAngle[1]) / timeInterval;
        angularVelocity3_d = (_robotController.GetJointAngle(2) - LastJointAngle[2]) / timeInterval;

        //////////smooth out angular velocity with a moving average filter//////////
        angularVelocity1_d = avgAngularVelocity1.addValue(angularVelocity1_d);
        angularVelocity2_d = avgAngularVelocity2.addValue(angularVelocity2_d);
        angularVelocity3_d = avgAngularVelocity3.addValue(angularVelocity3_d);
        LastJointAngle[0] = _robotController.GetJointAngle(0);
        LastJointAngle[1] = _robotController.GetJointAngle(1);
        LastJointAngle[2] = _robotController.GetJointAngle(2);

        //////////calculate the linear velocity of end-effector//////////
        float linearVelocityX = J[0][0] * Mathf.Deg2Rad * (angularVelocity1_d) + J[0][1] * Mathf.Deg2Rad * (angularVelocity2_d) + J[0][2] * Mathf.Deg2Rad * (angularVelocity3_d);
        float linearVelocityY = J[1][0] * Mathf.Deg2Rad * (angularVelocity1_d) + J[1][1] * Mathf.Deg2Rad * (angularVelocity2_d) + J[1][2] * Mathf.Deg2Rad * (angularVelocity3_d);
        float linearVelocityZ = J[2][0] * Mathf.Deg2Rad * (angularVelocity1_d) + J[2][1] * Mathf.Deg2Rad * (angularVelocity2_d) + J[2][2] * Mathf.Deg2Rad * (angularVelocity3_d);

        //////////smooth out linear velocity with a moving average filter//////////
        linearVelocityX = avglinearVelocityX.addValue(linearVelocityX);
        linearVelocityY = avglinearVelocityY.addValue(linearVelocityY);
        linearVelocityZ = avglinearVelocityZ.addValue(linearVelocityZ);

        //////////quit the function if this feedback should be skipped//////////
        //Toss the 1st, 2nd, 3rd ... feedback and display the Nth. This lower the refresh rate of the numbers on screen,
        //making them easier to read.
        if (thisFeedback >= NTH_FEEDBACK_TO_DISPLAY)
        {
            thisFeedback = 0;
            //run the following code and display the results
        }
        else
        {
            thisFeedback++;
            return; //don't display the results
        }

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

        matrix2Text[3].text = angularVelocity1_d.ToString("F2") + "°/s";
        matrix2Text[4].text = angularVelocity2_d.ToString("F2") + "°/s";
        matrix2Text[5].text = angularVelocity3_d.ToString("F2") + "°/s";
        matrix2Text[0].text = linearVelocityX.ToString("F2") + "cm/s";
        matrix2Text[1].text = linearVelocityY.ToString("F2") + "cm/s";
        matrix2Text[2].text = linearVelocityZ.ToString("F2") + "cm/s";
    }

    class MovingAverage
    {
        LinkedList<float> queue;
        int windowSize;
        float sum = 0; // sum of all values in queue

        public MovingAverage(int size)
        {
            this.queue = new LinkedList<float>();
            this.windowSize = size;
        }

        int getWindowSize()
        {
            return this.windowSize;
        }

        public float addValue(float val)
        {
            queue.AddLast(val);
            sum += val;
            if (queue.Count > this.windowSize)
            {
                sum -= queue.First.Value;
                queue.RemoveFirst();
            }

            return sum / queue.Count;
        }
    }
}
