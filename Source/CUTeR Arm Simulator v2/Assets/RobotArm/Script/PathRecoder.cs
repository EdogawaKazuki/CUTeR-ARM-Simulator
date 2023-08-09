using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PathRecoder : MonoBehaviour
{   
    LineRenderer PathLine;
    //Transform Base;
    //Transform LastJoint;
    RobotJointController robotJointController;
    RobotController _robotController;
    int pathPointCount = 0;
    public bool isRecording = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        _robotController = GetComponent<RobotController>();

        // set up path recording button
        Transform robotCtrlBtnGroup = _robotController.GetRobotCanvas().transform.Find("PathCtrlBtnGroup");
        robotCtrlBtnGroup.Find("erase").GetComponent<Button>().onClick.AddListener(() => _robotController.GetPathRecoder().ClearRecording());
        robotCtrlBtnGroup.Find("draw").GetComponent<Toggle>().onValueChanged.AddListener((value) => _robotController.GetPathRecoder().SetRecording(value));
    
        PathLine = transform.Find("VisiualContent/PathLine").GetComponent<LineRenderer>();
        robotJointController = transform.Find("Joints").GetComponent<RobotJointController>();
        //Base = robotJointController.GetJointTransformByIndex(0);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Debug.Log(RobotController);
        // Debug.Log(robotJointController);
        AddPoint(robotJointController.GetJointTransform(_robotController.GetRobotDoF()).position);
    }
    public void AddPoint(Vector3 point)
    {
        try
        {
            if (isRecording && Vector3.Distance(point, PathLine.GetPosition(PathLine.positionCount - 1)) > 0.0005)
            {
                PathLine.positionCount = pathPointCount + 1;
                PathLine.SetPosition(pathPointCount, point);
                pathPointCount++;
            }
        }
        catch(Exception e)
        {
            Debug.LogError(e.Message);
            ClearRecording();
        }
    }
    public void SetRecording(bool value)
    {
        isRecording = value;
        PathLine.gameObject.SetActive(value);
    }
    public void ClearRecording()
    {
        PathLine.positionCount = 0;
        pathPointCount = 0;
    }
}
