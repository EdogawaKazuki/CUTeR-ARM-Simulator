using System.Collections;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultipleCubicSpline : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    DrawGraph drawer;
    float t0 = 0;
    float t1 = 0;
    float tEnd = 0;
    float theta0 = 0;
    float theta1 = 0;
    float thetaEnd = 0;
    int Mode = 0;
    float a0, a1, a2, a3 = 0;
    float b0, b1, b2, b3 = 0;
    TMP_Text a0t, a1t, a2t, a3t;
    TMP_Text b0t, b1t, b2t, b3t;
    TMP_InputField t1Input;
    TMP_InputField tEndInput;
    TMP_InputField theta0Input;
    TMP_InputField theta1Input;
    TMP_InputField thetaEndInput;
    TMP_Dropdown modeDropdown;
    public List<float> joints = new List<float>{0, 0, 0};
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
        drawer = GetComponent<DrawGraph>();

        t1Input = transform.Find("Input/Line2/TI").GetComponent<TMP_InputField>();
        tEndInput = transform.Find("Input/Line2/TE").GetComponent<TMP_InputField>();

        t1Input.onValueChanged.AddListener(SetTimeInter);
        tEndInput.onValueChanged.AddListener(SetTimeEnd);

        theta0Input = transform.Find("Input/Line3/AS").GetComponent<TMP_InputField>();
        theta1Input = transform.Find("Input/Line3/AI").GetComponent<TMP_InputField>();
        thetaEndInput = transform.Find("Input/Line3/AE").GetComponent<TMP_InputField>();

        theta0Input.onValueChanged.AddListener(SetAngleStart);
        theta1Input.onValueChanged.AddListener(SetAngleInter);
        thetaEndInput.onValueChanged.AddListener(SetAngleEnd);

        modeDropdown = transform.Find("Input/Line4/Dropdown").GetComponent<TMP_Dropdown>();
        modeDropdown.onValueChanged.AddListener(SetMode);
        modeDropdown.ClearOptions();
        modeDropdown.options.Add(new TMP_Dropdown.OptionData { text = "Equal Vel and Accel" });
        modeDropdown.options.Add(new TMP_Dropdown.OptionData { text = "Zero Vel" });
        modeDropdown.options.Add(new TMP_Dropdown.OptionData { text = "Average Vel" });
        modeDropdown.value = 0;

        a0t = transform.Find("Input/Line5/a0").GetComponent<TMP_Text>();
        a1t = transform.Find("Input/Line5/a1").GetComponent<TMP_Text>();
        a2t = transform.Find("Input/Line5/a2").GetComponent<TMP_Text>();
        a3t = transform.Find("Input/Line5/a3").GetComponent<TMP_Text>();
       
        b0t = transform.Find("Input/Line6/b0").GetComponent<TMP_Text>();
        b1t = transform.Find("Input/Line6/b1").GetComponent<TMP_Text>();
        b2t = transform.Find("Input/Line6/b2").GetComponent<TMP_Text>();
        b3t = transform.Find("Input/Line6/b3").GetComponent<TMP_Text>();


    }

    void UpdateTrajectory()
    {
        List<float> JointAngleList = new List<float>();
        List<float> AngularVelocityList = new List<float>();
        List<float> AngularAccelerationList = new List<float>();
        List<float> LinearJointAngleList = new List<float>();
        
        if (!(tEnd > t1 && t1 > t0))
        {
            return;
        }

        Debug.Log("" + t0 + "," + t1 + "," + tEnd + "," + theta0 + "," + theta1 + "," + thetaEnd + ",");
        if (Mode == 0)
        {

            a0 = theta0;
            a1 = 0;

            Matrix coefficients = DenseMatrix.OfArray(new double[,] {
                { t1*t1, t1*t1*t1, 0, 0, 0, 0 },
                { 2*t1, 3*t1*t1, 0, -1, -2*t1, -3*t1*t1 },
                { 2, 6*t1, 0, 0, -2, -6*t1 },
                { 0, 0, 1, t1, t1*t1, t1*t1*t1},
                { 0, 0, 1, tEnd, tEnd*tEnd, tEnd*tEnd*tEnd },
                { 0, 0, 0, 1, 2*tEnd, 3*tEnd*tEnd } });

            DenseVector constants = new DenseVector(new double[] { theta1 - theta0, 0, 0, theta1, thetaEnd, 0 });
            var solution = coefficients.LU().Solve(constants);
            a2 = (float)solution.At(0);
            a3 = (float)solution.At(1);
            b0 = (float)solution.At(2);
            b1 = (float)solution.At(3);
            b2 = (float)solution.At(4);
            b3 = (float)solution.At(5);
        }
        else if (Mode == 1)
        {
            Matrix coefficientsA = DenseMatrix.OfArray(
                    new double[,] {
                            { 1, 0, 0, 0},
                            {0, 1, 0, 0},
                            {1, t1, t1*t1, t1*t1*t1},
                            {0, 1, 2*t1, 3*t1*t1}
                    });
            DenseVector constantsA = new DenseVector(new double[] { theta0, 0, theta1, 0 });
            var solutionA = coefficientsA.LU().Solve(constantsA);
            a0 = (float)solutionA.At(0);
            a1 = (float)solutionA.At(1);
            a2 = (float)solutionA.At(2);
            a3 = (float)solutionA.At(3);

            Matrix coefficientsB = DenseMatrix.OfArray(
                    new double[,] {
                            {1, t1, t1*t1, t1*t1*t1},
                            {0, 1, 2*t1, 3*t1*t1},
                            {1, tEnd, tEnd*tEnd, tEnd*tEnd*tEnd},
                            {0, 1, 2*tEnd, 3*tEnd*tEnd}
                    });
            DenseVector constantsB = new DenseVector(new double[] { theta1, 0, thetaEnd, 0 });
            var solutionB = coefficientsB.LU().Solve(constantsB);
            b0 = (float)solutionB.At(0);
            b1 = (float)solutionB.At(1);
            b2 = (float)solutionB.At(2);
            b3 = (float)solutionB.At(3);
        }
        else if (Mode == 2)
        {
            //calculate average velocity
            double ave = ((theta1 - theta0) / t1 + (thetaEnd - theta1) / (tEnd - t1)) / 2;

            Matrix coefficientsA = DenseMatrix.OfArray(
                    new double[,] {
                            { 1, 0, 0, 0},
                            {0, 1, 0, 0},
                            {1, t1, t1*t1, t1*t1*t1},
                            {0, 1, 2*t1, 3*t1*t1}
                    });
            DenseVector constantsA = new DenseVector(new double[] { theta0, 0, theta1, ave });
            var solutionA = coefficientsA.LU().Solve(constantsA);
            a0 = (float)solutionA.At(0);
            a1 = (float)solutionA.At(1);
            a2 = (float)solutionA.At(2);
            a3 = (float)solutionA.At(3);

            Matrix coefficientsB = DenseMatrix.OfArray(
                    new double[,] {
                            {1, t1, t1*t1, t1*t1*t1},
                            {0, 1, 2*t1, 3*t1*t1},
                            {1, tEnd, tEnd*tEnd, tEnd*tEnd*tEnd},
                            {0, 1, 2*tEnd, 3*tEnd*tEnd}
                    });
            DenseVector constantsB = new DenseVector(new double[] { theta1, ave, thetaEnd, 0 });
            var solutionB = coefficientsB.LU().Solve(constantsB);
            b0 = (float)solutionB.At(0);
            b1 = (float)solutionB.At(1);
            b2 = (float)solutionB.At(2);
            b3 = (float)solutionB.At(3);
        }
        a0t.text = a0.ToString("F2");
        a1t.text = a1.ToString("F2");
        a2t.text = a2.ToString("F2");
        a3t.text = a3.ToString("F2");
        b0t.text = b0.ToString("F2");
        b1t.text = b1.ToString("F2");
        b2t.text = b2.ToString("F2");
        b3t.text = b3.ToString("F2");
        _trajController.ResetTraj(3);
        for (int i = 0; i < 50 * t1 + 1; i++)
        {
            float _t = i / 50f;
            //Debug.Log(_t);
            float angle = a0 + a1 * _t + a2 * _t * _t + a3 * _t * _t * _t;
            JointAngleList.Add(angle);
            joints[0] = angle;
            _trajController.PushTrajPoints(joints);

            AngularVelocityList.Add(a1 + 2 * a2 * _t + 3 * a3 * _t * _t);

            AngularAccelerationList.Add(2 * a2 + 6 * a3 * _t);
            LinearJointAngleList.Add((theta1 - theta0) / (t1 - t0) * (_t - t0) + theta0);
        }
        for (int i = (int)t1 * 50; i < 50 * tEnd + 1; i++)
        {
            float _t = i / 50f;
            //Debug.Log(_t);
            float angle = b0 + b1 * _t + b2 * _t * _t + b3 * _t * _t * _t;
            JointAngleList.Add(angle);
            joints[0] = angle;
            _trajController.PushTrajPoints(joints);

            AngularVelocityList.Add(b1 + 2 * b2 * _t + 3 * b3 * _t * _t);
            LinearJointAngleList.Add((thetaEnd - theta1) / (tEnd - t1) * (_t - t1) + theta1);
            //Debug.Log((thetaEnd - theta1) / (tEnd - t1) * (_t - t1) + theta1);

            AngularAccelerationList.Add(2 * b2 + 6 * b3 * _t);
        }
        _trajController.SetStatus(StaticRobotTrajectoryController.State.ready);
        drawer.ClearGraph("JointAngle");
        drawer.ShowGraph(JointAngleList, "JointAngle");
        drawer.PlotPoints("JointAngle", LinearJointAngleList, new Color32(0, 255, 0, 255));

        drawer.ClearGraph("AngularVelocity");
        drawer.ShowGraph(AngularVelocityList, "AngularVelocity");

        drawer.ClearGraph("AngularAcceleration");
        drawer.ShowGraph(AngularAccelerationList, "AngularAcceleration");
    }

    public void SetTimeInter(string value)
    {
        float.TryParse(value, out t1);
        UpdateTrajectory();
    }
    public void SetTimeEnd(string value)
    {
        float.TryParse(value, out tEnd);
        UpdateTrajectory();
    }
    public void SetAngleStart(string value)
    {
        float.TryParse(value, out theta0);
        UpdateTrajectory();
    }
    public void SetAngleInter (string value)
    {
        float.TryParse(value, out theta1);
        UpdateTrajectory();
    }
    public void SetAngleEnd(string value)
    {
        float.TryParse(value, out thetaEnd);
        UpdateTrajectory();
    }
    public void SetMode(int value)
    {
        Mode = value;
        Debug.Log(value);
        UpdateTrajectory();
    }
    public void Clear()
    {
        foreach (var ele in transform.GetComponentsInChildren<InputField>())
        {
            ele.text = "";
        }
    }
}
