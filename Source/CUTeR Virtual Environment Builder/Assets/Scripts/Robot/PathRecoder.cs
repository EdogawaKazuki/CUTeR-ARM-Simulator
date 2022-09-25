using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathRecoder : MonoBehaviour
{   [SerializeField]
    LineRenderer HeadLine;
    [SerializeField]
    LineRenderer PathLine;
    [SerializeField]
    Transform Base;
    Transform LastJoint;
    [SerializeField]
    Transform PointHead;
    [SerializeField]
    RobotJointController robotJointController;
    [SerializeField]
    RobotController RobotController;
    int pathPointCount = 0;
    bool isRecording = false;
    // Start is called before the first frame update
    void Start()
    {
        HeadLine.SetPosition(0, new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 origin = robotJointController.GetJointTransformByIndex(0).position;
        Vector3 end = robotJointController.GetJointTransformByIndex(RobotController.GetRobotDoF()).position;
        Vector3 subEnd = end - Vector3.Normalize(end - origin) * 0.015f;
        HeadLine.SetPosition(0, origin);
        HeadLine.SetPosition(1, subEnd);
        PointHead.transform.SetPositionAndRotation(end, Quaternion.LookRotation(end - origin));
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
    public void setRobotDoF(int value)
    {

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
