using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TexDrawLib;
using System.Runtime.CompilerServices;
using Meta.XR.MRUtilityKit.SceneDecorator;
public class Jacobian: MonoBehaviour
{
    private RobotKinematics _robotKinematics;
    private GeneralRobotControl _generalRobotControl; 
    private GeneralInteractiveControl _generalInteractiveControl;
    private RobotController _robotController;
    private RobotControllerUI _robotControllerUI;
    private TEXDraw _visualizer_latex;
    private List<float> LastJointAngle;
    private List<List<float>> TargetJointAngleList = new();
    private List<float> CommandedJointAngle;
    private Queue<List<float>> angleHistory = new Queue<List<float>>();
    private const int windowSize = 5;


    int index = 0;
    private static int quitBranchIndex = 3;


    void Start()
    {
        TargetJointAngleList = new List<List<float>>() { new List<float> { 0, 0, 45, 0, 0, 0 },
                                                        new List<float> { 0, 0, -45, 0, 0, 0 },
                                                         };
        CommandedJointAngle = new List<float> { 0, 0, 0, 0, 0, 0 };
    }
    public void SetButtonActive(bool status)
    {
        this.transform.Find("Canvas/Panel/Button").gameObject.SetActive(status);
    }

    public void ShowJacobian(List<float> current_angles)
    {
        var J = _robotKinematics?.ComputeJacobian(current_angles.ToArray());
        if (J == null) return;
        string jacobianLatex = "$$J = \\begin{bmatrix}";
        for (int row = 0; row < 6; row++)
        {
            for (int col = 0; col < 6; col++)
            {
                jacobianLatex += $"{J[row, col]:F1}";
                if (col < 5) jacobianLatex += " & ";
            }
            if (row < 5) jacobianLatex += " \\\\ ";
        }
        jacobianLatex += "\\end{bmatrix}";

        var jointVelocities = ComputeJointVelocity(current_angles.ToArray(), Time.deltaTime);

        jacobianLatex += "  \\dot{q} = \\begin{bmatrix}";
        for (int i = 0; i < jointVelocities.Length; i++)
        {
            jacobianLatex += $"{jointVelocities[i]:F1}";
            if (i < jointVelocities.Length - 1) jacobianLatex += " \\\\ ";
        }
        jacobianLatex += "\\end{bmatrix}$$";

        // Compute linear velocity
        // Convert jointVelocities (1D array) to a 2D column vector
        float[,] jointVelocities2D = new float[jointVelocities.Length, 1];
        for (int i = 0; i < jointVelocities.Length; i++)
        {
            jointVelocities2D[i, 0] = jointVelocities[i];
        }
        var linearVelocity = _generalRobotControl?.MatrixMultiply(J, jointVelocities2D);

        // Display linear velocity
        if (linearVelocity != null)
        {
            jacobianLatex += "$$v = \\begin{bmatrix}";
            for (int i = 0; i < 3; i++)
            {
                jacobianLatex += $"{linearVelocity[i, 0]:F1}";
                if (i < 2) jacobianLatex += " \\\\ ";
            }
            jacobianLatex += "\\end{bmatrix} \\quad \\omega = \\begin{bmatrix}";
            for (int i = 3; i < 6; i++)
            {
                jacobianLatex += $"{linearVelocity[i, 0]:F1}";
                if (i < 5) jacobianLatex += " \\\\ ";
            }
            jacobianLatex += "\\end{bmatrix}$$";
        }
        _visualizer_latex.text = jacobianLatex;
    }

    private float[] ComputeJointVelocity(float[] current_angles, float deltaTime=0.02f)
    {
        if (LastJointAngle == null || LastJointAngle.Count != current_angles.Length)
        {
            LastJointAngle = new List<float>(current_angles);
            return new float[current_angles.Length];
        }

        float[] jointVelocities = new float[current_angles.Length];
        for (int i = 0; i < current_angles.Length; i++)
        {
            jointVelocities[i] = (current_angles[i] - LastJointAngle[i]) * _robotKinematics.theta_sign[i] / Time.fixedDeltaTime;
            LastJointAngle[i] = current_angles[i];
        }
        return jointVelocities;
    }

    // Show Jacobian when component is enabled
    void OnEnable()
    {
        _generalInteractiveControl = transform.Find("../..").GetComponent<GeneralInteractiveControl>();
        _robotKinematics = transform.Find("../..").GetComponent<RobotKinematics>();
        _generalRobotControl = transform.Find("../..").GetComponent<GeneralRobotControl>();
        _robotController = transform.Find("/Robot").GetComponent<RobotController>();
        _robotControllerUI = transform.Find("/Robot").GetComponent<RobotControllerUI>();
        _visualizer_latex = transform.Find("Canvas/Panel/Latex").GetComponent<TEXDraw>();
        // ShowJacobian(_robotController.GetJointAngles());
        transform.Find("Canvas").gameObject.SetActive(true);
        transform.Find("Canvas/Panel/Button").GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() =>
        {
            this.enabled = false;
        });
        index = 0;
        CommandedJointAngle = new List<float> { 0, 0, 0, 0, 0, 0 };
    }
    void OnDisable()
    {
        transform.Find("Canvas").gameObject.SetActive(false);
        _generalInteractiveControl.branch_index = quitBranchIndex;
    }

    IEnumerator Check()
    {
        yield return new WaitForSeconds(4f); // wait for stability 
        var currentAngles =_robotController?.GetJointAngles();
        if (index < TargetJointAngleList.Count)
        {
            var TargetJointAngle = TargetJointAngleList[index];
            int diffIndex = FindMaxDifferenceIndex(CommandedJointAngle, TargetJointAngle);
            // Compute the Euclidean norm (L2 distance) between TargetJointAngle and currentAngles
            float currentNorm = ComputeNorm(TargetJointAngle, currentAngles);
            if (currentNorm < 5f)
            {
                index++;
                CommandedJointAngle = new List<float>(currentAngles);
                Debug.Log("Branch: Reached target position");
                _generalInteractiveControl.branch_index = index; // set branch index to indicate success
            }
            else
            {
                float previousNorm = ComputeNorm(TargetJointAngle, CommandedJointAngle);
                if (currentNorm < previousNorm)
                {
                    CommandedJointAngle = new List<float>(currentAngles);
                    Debug.Log("Branch: Robot moved closer to target position.");
                }
                else
                {
                    // Move one joint towards the target
                    // float step = Mathf.Sign(TargetJointAngle[diffIndex] - CommandedJointAngle[diffIndex]) * 1f; // 1 degree step
                    // CommandedJointAngle[diffIndex] += step;
                    _robotController.SetCmdJointAngles(CommandedJointAngle);
                    _robotController.SendCmdToRobot(2f);
                    Debug.Log($"Branch: Moving away from target, back to previous commanded angles.");
                    _generalInteractiveControl.branch_index = 0; // set branch index to indicate success
                }
            }
        }
    }
    
    float ComputeNorm(List<float> a, List<float> b)
    {
        float norm = 0f;
            for (int i = 0; i < a.Count && i < b.Count; i++)
            {
                float diff = a[i] - b[i];
                norm += diff * diff;
            }
            norm = Mathf.Sqrt(norm);
        return norm;
    }

    int FindMaxDifferenceIndex(List<float> a, List<float> b)
    {
        int maxIndex = -1;
        float maxDiff = 0f;
        for (int i = 0; i < a.Count; i++)
        {
            float diff = Mathf.Abs(a[i] - b[i]);
            if (diff > maxDiff)
            {
                maxDiff = diff;
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    List<float> ComputeAverageAngles(List<float> currentAngles, int windowSize)
    {
        // Add current angles to history
        angleHistory.Enqueue(new List<float>(currentAngles));
        if (angleHistory.Count > windowSize)
        angleHistory.Dequeue();

        // Compute moving average
        List<float> avgAngles = new List<float>(currentAngles.Count);
        for (int i = 0; i < currentAngles.Count; i++)
        {
        float sum = 0f;
        int count = 0;
        foreach (var angles in angleHistory)
        {
            sum += angles[i];
            count++;
        }
        avgAngles.Add(sum / count);
        }
        return avgAngles;
    }

    void FixedUpdate()
    {
        // Get current joint angles (avoid null propagation for Unity objects)
        List<float> currentAngles = null;
        if (_robotController != null)
            currentAngles = _robotController.GetJointAngles();

        // Apply moving average filter to currentAngles
        List<float> avgAngles = ComputeAverageAngles(currentAngles, windowSize);
        ShowJacobian(avgAngles);
        
        if (_robotControllerUI.sliderChanged)
        {
            StartCoroutine(Check());
            _robotControllerUI.sliderChanged = false;  
        }
    }
}