using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class WorldFrameSynchronizer : MonoBehaviour
{
    private SpatialAnchorManager _spatialAnchorManager;
    private Toggle toggle;
    [SerializeField] GameObject trackingframe;
    private GameObject joints, jointsTransparent, workingspace;
    public List<GameObject> anchorObjects;
    private Matrix4x4 JointToMarkerMatrix, OffsetMatrix;
    private Vector3 trackerStaticPosition = new Vector3(0.4872f, 0.6327f, -0.0053f);
    // private Quaternion trackerStaticOrientation = new Quaternion(0.2252f, 0.2382f, 0.4863f, 0.8100f);
    private Quaternion trackerStaticOrientation = new Quaternion(0.2021f, 0.2086f, 0.4937f, 0.8197f);

    bool isSyncing = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
    {
        Quaternion q = new Quaternion();
        q.w = Mathf.Sqrt( Mathf.Max( 0, 1 + m[0,0] + m[1,1] + m[2,2] ) ) / 2;
        q.x = Mathf.Sqrt( Mathf.Max( 0, 1 + m[0,0] - m[1,1] - m[2,2] ) ) / 2;
        q.y = Mathf.Sqrt( Mathf.Max( 0, 1 - m[0,0] + m[1,1] - m[2,2] ) ) / 2;
        q.z = Mathf.Sqrt( Mathf.Max( 0, 1 - m[0,0] - m[1,1] + m[2,2] ) ) / 2;
        q.x *= Mathf.Sign( q.x * ( m[2,1] - m[1,2] ) );
        q.y *= Mathf.Sign( q.y * ( m[0,2] - m[2,0] ) );
        q.z *= Mathf.Sign( q.z * ( m[1,0] - m[0,1] ) );
        return q;
    }

    void Start()
    {
        _spatialAnchorManager = this.GetComponent<SpatialAnchorManager>();
        joints = GameObject.Find("Robot/Joints");
        jointsTransparent = GameObject.Find("Robot/Joints Transparent");
        workingspace = GameObject.Find("Robot/VisiualContent/Workingspace");
        JointToMarkerMatrix = Matrix4x4.TRS(new Vector3(0.05f, -0.05f, 0.37f), Quaternion.AngleAxis(-90f, Vector3.up), Vector3.one);
        OffsetMatrix = Matrix4x4.TRS(new Vector3(0.0f, -0.0f, 0.4f), Quaternion.AngleAxis(-20f, Vector3.up), Vector3.one);

        // button.onClick.AddListener(() => ToggleSyncState());
        GameObject.Find("Robot/RobotCanvas/ARTrackingGroup/FrameSynchronizer").GetComponent<Toggle>().onValueChanged.AddListener((value) => ToggleSyncState(value));
        anchorObjects = new List<GameObject>{joints, jointsTransparent, workingspace};
    }

    private async void ToggleSyncState(bool value)
    {
        isSyncing = value;
        trackingframe.SetActive(isSyncing);
        if (!isSyncing)
        {
            await _spatialAnchorManager.EraseLastCreatedAnchor();
            // var lastAnchor = _spatialAnchorManager.GetlastAnchor()?.gameObject;
            // while (lastAnchor != null)
            // {
            //     yield return new WaitForSeconds(0.1f);
            //     lastAnchor = _spatialAnchorManager.GetlastAnchor()?.gameObject;
            // }
            await _spatialAnchorManager.PlaceAnchor();
            // while (lastAnchor == null)
            // {
            //     yield return new WaitForSeconds(0.1f);
            //     lastAnchor = _spatialAnchorManager.GetlastAnchor()?.gameObject;
            // }

            // lastAnchor.transform.rotation = trackingframe.transform.rotation;
            var lastAnchor = _spatialAnchorManager.GetlastAnchor()?.gameObject;
            SynchAnchorToJoints(lastAnchor);
            _spatialAnchorManager.SaveLastCreatedAnchor();

        }
        
    }

    public void SynchAnchorToJoints(GameObject lastAnchor)
    {
        var jointslocalToWorldMatrix = lastAnchor.transform.localToWorldMatrix * JointToMarkerMatrix;
            var position = jointslocalToWorldMatrix.GetColumn(3);
            var rotation = QuaternionFromMatrix(jointslocalToWorldMatrix);

            joints.transform.position = position;
            joints.transform.rotation = rotation;
            jointsTransparent.transform.position = position;
            jointsTransparent.transform.rotation = rotation;

            var workingspace = GameObject.Find("Robot/VisiualContent/Workingspace");
            workingspace.transform.position = joints.transform.position;
            workingspace.transform.rotation = joints.transform.rotation;
    }
    public void UpdateTrackingFrame()
    {
        var ctrLeftPose = OVRPlugin.GetNodePoseStateImmediate(OVRPlugin.Node.ControllerLeft).Pose.ToOVRPose();
        Debug.Log("ctrLeftPose: " + ctrLeftPose.position.ToString("F4") + ", " + ctrLeftPose.orientation.ToString("F4"));
        trackingframe.transform.position = ctrLeftPose.position;
        trackingframe.transform.rotation = Quaternion.AngleAxis(15f, Vector3.up) * ctrLeftPose.orientation * Quaternion.Inverse(trackerStaticOrientation);
    }

    public void ComputeOrientation(GameObject obj)
    {
        obj.transform.rotation = Quaternion.AngleAxis(15f, Vector3.up) * obj.transform.rotation * Quaternion.Inverse(trackerStaticOrientation);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSyncing)
            UpdateTrackingFrame();
    }
}
