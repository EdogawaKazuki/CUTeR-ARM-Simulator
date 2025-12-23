using System.Collections;
using System.Collections.Generic;
using System.Numerics;
// using System.Windows.Forms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;


// using MathNet.Numerics.LinearAlgebra;


public class Interactive2RPlanarRobotArm : MonoBehaviour
{
    public GeneralRobotControl _generalRobotControl;
    public SphereTracker _sphereTracker;
    void Start()
    {
        // Initialization if needed
    }

    private float timer = 0f;
    private float interval = 2f;

    public IEnumerator ShowCaseFullSolution(float duration, UnityEngine.Vector3? offset = null)
    {
        if (offset == null)
            offset = new UnityEngine.Vector3(0, 0.0f, 0.1f);
        _sphereTracker.TranslateSphereByOffset((UnityEngine.Vector3)offset);
        transform.Find("/Interactable Objects").GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f); 
        
        var projectedPosition = _sphereTracker.getSphereProjectedPosition();
        var ikAngles = _generalRobotControl.InverseKinematicsOpenManipulatorPro2DOFFullSolution(
            new List<float> { 0, -projectedPosition.z * 100f, projectedPosition.y * 100f }
        );

        Debug.Log("Projected Position: " + projectedPosition.ToString("F4"));
        Debug.Log("IK Angles Solution: " + string.Join(", ", ikAngles[0].ConvertAll(angle => angle.ToString("F4"))));
        if (ikAngles.Count > 0)
        {
            // _generalRobotControl.actionQueue.Enqueue(() =>);
            // _generalRobotControl._currentState = GeneralRobotControl.State.ready;
            yield return _generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(ikAngles[0], (duration-4)/2);
            yield return new WaitForSeconds(2f); 
            yield return _generalRobotControl.MoveToTargetJointSpacePositionCubicTrajectory(ikAngles[1], (duration-4)/2);
            yield return new WaitForSeconds(2f); 
        }
        _sphereTracker.TranslateSphereByOffset(new UnityEngine.Vector3 (0, 0, 0));
        transform.Find("/Interactable Objects").GetChild(0).gameObject.SetActive(false);

    }
    void Update()
    {
        // timer += Time.deltaTime;
        // if (timer >= interval)
        // {
        //     timer = 0f;
            
        // }
    }
}