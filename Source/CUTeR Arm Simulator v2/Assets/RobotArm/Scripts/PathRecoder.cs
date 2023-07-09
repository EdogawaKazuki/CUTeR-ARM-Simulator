using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathRecoder : MonoBehaviour
{   
    LineRenderer PathLine;
    [SerializeField]
    Transform LastJoint;
    //RobotJointController robotJointController;
    //RobotController RobotController;
    int pathPointCount = 0;
    public bool isRecording = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        PathLine = transform.Find("PathLine").GetComponent<LineRenderer>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        AddPoint(LastJoint.position);
    }
    public void SetLastJoint(Transform joint)
    {
        LastJoint = joint;
    }
    public void AddPoint(Vector3 point)
    {
        try
        {
            if (isRecording)
            {
                PathLine.positionCount = pathPointCount + 1;
                PathLine.SetPosition(pathPointCount, point);
                pathPointCount++;
            }
        }
        catch
        {
            ClearRecording();
        }
    }
    public void SetRecording(bool value)
    {
        isRecording = value;
    }
    public void ClearRecording()
    {
        PathLine.positionCount = 0;
        pathPointCount = 0;
    }
}
