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
    UnityEngine.Vector3 localOffset = new UnityEngine.Vector3(0.0f, 0.0f, 0.1f);

    private float maxLength = 0.65f;
    private bool followJoyStick = false;
    private UnityEngine.Vector3 lastJoyStickPosition;
    private UnityEngine.Vector3 deltaPosition = UnityEngine.Vector3.zero;

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
        //     // Check if both right controller triggers are pressed
        //     bool rightIndexTrigger = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        //     bool rightHandTrigger = OVRInput.Get(OVRInput.RawButton.RHandTrigger);

        //     if (rightIndexTrigger && rightHandTrigger)
        //     {
        //     var ctrRightPose = OVRPlugin.GetNodePoseStateImmediate(OVRPlugin.Node.ControllerRight).Pose.ToOVRPose();

        //     // Apply local offset first, then transform by right pose
        //     var currentPosition = ctrRightPose.position + ctrRightPose.orientation * localOffset;
        //     sphereTransform.position = currentPosition;
        //     sphereTransform.rotation = ctrRightPose.orientation;
        //     }
        // }


        bool rightIndexTrigger = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        bool rightHandTrigger = OVRInput.Get(OVRInput.RawButton.RHandTrigger);
        bool rightHandButtonOne = OVRInput.Get(OVRInput.Button.One);
        bool rightHandButtonTwo = OVRInput.Get(OVRInput.Button.Two);

        if (rightIndexTrigger && rightHandTrigger)
        {
            if (!followJoyStick)
            {
                Debug.Log("Start following joystick");
            }
            // get the delta position of the controller since last frame
            var currentPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            deltaPosition = currentPosition - lastJoyStickPosition;
            float scaleFactor = 1.5f; // Adjust this factor to control the sensitivity of the movement
            if(rightHandButtonOne && rightHandButtonTwo)
                deltaPosition *= scaleFactor;
            if(deltaPosition.magnitude > 0.02f) // Add a threshold to prevent jitter
            {
                lastJoyStickPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            
                return;
            }
            transform.position += deltaPosition;
            lastJoyStickPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            
        }
        followJoyStick = rightIndexTrigger && rightHandTrigger;

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