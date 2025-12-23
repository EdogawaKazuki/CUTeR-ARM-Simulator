using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;

// using System.Windows.Forms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using System.Linq;
using MathNet.Numerics.Statistics;


// using MathNet.Numerics.LinearAlgebra;


public class Interactive3DOFRobotArm : MonoBehaviour
{
    public GeneralRobotControl _generalRobotControl;
    public SphereTracker _sphereTracker;

    private float timer = 0f;
    private float interval = 0.01f;
    private float threshold = 10f;
    private List<float> lastAngles = new List<float> {0, 0, 0, 0, 0, 0};
    
    void Start()
    {
        // Initialization if needed
    }

    void OnEnable()
    {
        lastAngles = _generalRobotControl._robotController.GetJointAngles();
        Debug.Log($"last Angles: [{string.Join(", ", lastAngles.Select(a => a.ToString("F4")))}],");
        
    }

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer >= interval &&  _sphereTracker.IsSphereEnabled())
        {
            timer = 0f;
            var projectedPosition = _sphereTracker.getSphereLocalPosition();

            
            var ikAngles = _generalRobotControl.SimulationInverseKinematicsOpenManipulatorPro3DOF(
                new List<float> { -projectedPosition.x * 100f, -projectedPosition.z * 100f, projectedPosition.y * 100f }
            );
            var currentAngles = _generalRobotControl._robotController.GetJointAngles();
            currentAngles.RemoveAt(currentAngles.Count - 1); // Remove the last element for comparison

            float maxAbsDiff = Mathf.Max(0f, Mathf.Max(ikAngles.Zip(lastAngles, (ik, cur) => Mathf.Abs(ik - cur)).ToArray()));
            Debug.Log("Max Absolute Difference: " + maxAbsDiff);

            Debug.Log("Projected Position: " + projectedPosition.ToString("F4"));
            Debug.Log("IK Angles Solution: " + string.Join(", ", ikAngles.ConvertAll(angle => angle.ToString("F4"))));
            if (ikAngles.Count > 0 && maxAbsDiff < threshold && ikAngles.All(angle => !float.IsNaN(angle)))
            {

                // _generalRobotControl.actionQueue.Enqueue(() =>_generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(ikAngles, 1f));
                // _generalRobotControl._currentState = GeneralRobotControl.State.ready;
                _generalRobotControl._robotController.SetCmdJointAngles(ikAngles);
                _generalRobotControl._robotController.SendCmdToRobot(interval);
                lastAngles = new List<float>(ikAngles);
            }
        }
    }
}