using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARController : MonoBehaviour
{
    LineRenderer HeadLine;
    LineRenderer PathLine;
    Transform Base;
    Transform LastJoint;
    Transform PointHead;
    int pathPointCount = 0;
    bool isRecording = false;
    // Start is called before the first frame update
    void Start()
    {
        PathLine = GameObject.Find("RobotArm/PathLine").GetComponent<LineRenderer>();
        HeadLine = GameObject.Find("RobotArm/HeadLine").GetComponent<LineRenderer>();
        HeadLine.SetPosition(0, new Vector3(0, 0, 0));
        if(GetComponent<RobotController>() != null)
        {
            Base = RobotController.RobotArm;
            LastJoint = RobotController.Joints[3];
            PointHead = RobotController.RobotArm.Find("PointHead").transform;
        }
        else
        {
            Base = RobotController6DoF.RobotArm;
            LastJoint = RobotController6DoF.Joints[5];
            PointHead = RobotController6DoF.RobotArm.Find("PointHead").transform;
        }
        HeadLine.gameObject.SetActive(false);
        PointHead.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = Base.position;
        Vector3 end = LastJoint.position;
        Vector3 subEnd = end - Vector3.Normalize(end - origin) * 0.015f;
        HeadLine.SetPosition(0, origin);
        HeadLine.SetPosition(1, subEnd);
        PointHead.transform.SetPositionAndRotation(end, Quaternion.LookRotation(end - origin));
        if (isRecording)
        {
            PathLine.positionCount = pathPointCount + 1;
            PathLine.SetPosition(pathPointCount, end);
            pathPointCount++;
        }
    }
    public void StartRecording()
    {
        isRecording = !isRecording;
    }
    public void ClearRecording()
    {
        PathLine.positionCount = 0;
        pathPointCount = 0;
    }


}
