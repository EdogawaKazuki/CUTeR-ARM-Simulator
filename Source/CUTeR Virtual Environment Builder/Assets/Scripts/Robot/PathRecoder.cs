using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathRecoder : MonoBehaviour
{   
    LineRenderer HeadLine;
    LineRenderer PathLine;
    //Transform Base;
    //Transform LastJoint;
    Transform PointHead;
    RobotJointController robotJointController;
    RobotController RobotController;
    int pathPointCount = 0;
    public bool isRecording = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        HeadLine = transform.Find("HeadLine").GetComponent<LineRenderer>();
        PathLine = transform.Find("PathLine").GetComponent<LineRenderer>();
        PointHead = transform.Find("PointHead");
        RobotController = GetComponent<RobotController>();
        robotJointController = transform.Find("Joints").GetComponent<RobotJointController>();
        HeadLine.SetPosition(0, new Vector3(0, 0, 0));
        //Base = robotJointController.GetJointTransformByIndex(0);
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
