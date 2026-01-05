using System;
using System.Collections;
using System.IO; // For Path and Directory
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.Events;



public class SphereTracker : MonoBehaviour
{
    public GeneralRobotControl _generalRobotControl;
    private Transform sphereTransform;
    private Transform jointTransform;
    private UnityEngine.Vector3 lastPosition, projectedPosition, localPosition;
    private UnityEngine.Vector3 velocity;
    private UnityEngine.Vector3 planeNormal = new UnityEngine.Vector3(1, 0, 0);
    private UnityEngine.Vector3 baseOffsetVector = new UnityEngine.Vector3(0.0f, 0.12f, 0.0f);
    UnityEngine.Vector3 localOffset = new UnityEngine.Vector3(0.0f, 0.0f, 0.05f);

    private float maxLength = 0.65f;

    void Start()
    {
        sphereTransform = transform.Find("Grabbable Sphere");
        jointTransform = transform.root.Find("/Robot/Joints");
        if (sphereTransform == null)
        {
            Debug.LogError("Sphere Transform is not assigned.");
            return;
        }
        lastPosition = sphereTransform.position;
    }

    public void TranslateSphereByOffset(UnityEngine.Vector3 offset)
    {
        if (sphereTransform != null)
        {
            sphereTransform.GetComponent<EndEffectorPoseSync>().positionOffset = offset;
        }
    }

    public void EnableSphere(bool enable)
    {
        if (sphereTransform != null || true)
        {
            Debug.Log("Setting sphere active: " + sphereTransform.gameObject.name + " " + enable);
            sphereTransform.gameObject.SetActive(enable);
        }
    }
    public bool IsSphereEnabled()
    {
        return sphereTransform != null && sphereTransform.GetComponent<EndEffectorPoseSync>().isSynced;
    }

    UnityEngine.Vector3 ProjectVectorOntoPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal)
    {
        UnityEngine.Vector3 projectedVector;
        projectedVector = vector - UnityEngine.Vector3.Dot(vector, planeNormal) * planeNormal;
        return projectedVector;
    }

    UnityEngine.Vector3 ClipVectorLength(UnityEngine.Vector3 vector, float maxLength)
    {
        // Use ClampMagnitude to ensure the vector's length does not exceed maxLength due to floating-point errors
        return UnityEngine.Vector3.ClampMagnitude(vector, maxLength);
    }

    public UnityEngine.Vector3 getSphereProjectedPosition()
    {
        return projectedPosition;
    }

        public UnityEngine.Vector3 getSphereLocalPosition()
    {
        return localPosition;
    }

    void Update()
    {
        if (sphereTransform == null) return;
        // if (_generalRobotControl._robotClient.IsConnected())
        // {
        //     var ctrRightPose = OVRPlugin.GetNodePoseStateImmediate(OVRPlugin.Node.ControllerRight).Pose.ToOVRPose();

        //     // Apply local offset first, then transform by right pose
        //     var offsetPosition = ctrRightPose.position + ctrRightPose.orientation * localOffset;
        //     sphereTransform.position = offsetPosition;
        //     sphereTransform.rotation = ctrRightPose.orientation;
        // }

        UnityEngine.Vector3 worldPosition = sphereTransform.position;
        UnityEngine.Vector3 localPos = jointTransform.InverseTransformPoint(worldPosition);
        var tmpPosition = ProjectVectorOntoPlane(localPos, planeNormal);
        projectedPosition = ClipVectorLength(tmpPosition-baseOffsetVector, maxLength) + baseOffsetVector;
        projectedPosition = tmpPosition;
        localPosition = ClipVectorLength(localPos-baseOffsetVector, maxLength) + baseOffsetVector;
        // Calculate velocity
        velocity = (localPosition - lastPosition) / Time.deltaTime;
        lastPosition = localPosition;

    }
}