using UnityEngine;


/// <summary>
/// Snaps the GameObject's pose to match a target end-effector when activated.
/// Useful for tools, weapons, or objects that need to jump into the hand on pickup/use.
/// </summary>
public class EndEffectorPoseSync : MonoBehaviour
{
    [Header("End Effector Reference")]
    [Tooltip("The Transform of the end-effector (hand, gripper, controller, etc.)")]
    private RobotJointController _robotJointController;

    [Header("Sync Settings")]
    [Tooltip("Sync position?")]
    public bool syncPosition = true;
    
    [Tooltip("Sync rotation?")]
    public bool syncRotation = true;

    [Tooltip("Optional local offset relative to the end-effector")]
    public Vector3 positionOffset = Vector3.zero;
    public Vector3 rotationOffsetEuler = Vector3.zero;

    [Header("Activation")]
    [Tooltip("Call SyncToEndEffector() manually or use triggers below")]
    public bool activateOnStart = false;
    public bool activateOnEnable = true;

    public bool isSynced = false;

    void Start()
    {
        _robotJointController = GameObject.Find("/Robot").GetComponent<RobotController>()._robotJointController;
        if (activateOnStart)
            SyncToEndEffector();
        this.gameObject.SetActive(activateOnStart);
    }

    void OnEnable()
    {
        if (activateOnEnable)
            SyncToEndEffector();
        isSynced = true;
    }

    void OnDisable()
    {
        Debug.Log("EndEffectorPoseSync: Disabled on " + gameObject.name);
        isSynced = false;
    }

    /// <summary>
    /// Public method you can call from anywhere (e.g. button press, pickup event, animation event, etc.)
    /// </summary>
    public void SyncToEndEffector()
    {
        if (_robotJointController == null)
        {
            Debug.LogWarning("EndEffectorPoseSync: No end-effector assigned on " + gameObject.name);
            return;
        }
        Transform endEffector = _robotJointController.GetJointTransform(6);
        // Position
        if (syncPosition)
        {
            Debug.Log("Offset: " + positionOffset.ToString("F4"));
            Vector3 worldOffset = endEffector.rotation * positionOffset;
            transform.position = endEffector.position + worldOffset;
        }

        // Rotation
        if (syncRotation)
        {
            transform.rotation = endEffector.rotation * Quaternion.Euler(rotationOffsetEuler);
        }
    }

    // Optional: visual helper in Scene view
    void OnValidate()
    {
        if (_robotJointController == null)
            Debug.LogWarning("Assign an end-effector Transform in the inspector!", this);
    }
}