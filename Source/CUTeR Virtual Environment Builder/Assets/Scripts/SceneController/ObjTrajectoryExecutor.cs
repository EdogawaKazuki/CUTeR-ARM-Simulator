using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjTrajectoryExecutor : MonoBehaviour
{
    public string TrajString;
    public List<Vector3> TrajPosition = new List<Vector3>();
    public List<Vector3> TrajRotation = new List<Vector3>();
    public bool runTraj = false;
    public int currentTrajIndex = 0;
    public int trajLength = 0;
    public bool TrajSwitch = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (runTraj)
        {
            if (currentTrajIndex < trajLength)
            {
                transform.localPosition = TrajPosition[currentTrajIndex];
                transform.localEulerAngles = TrajRotation[currentTrajIndex];
                currentTrajIndex++;
            }
            else
            {
                runTraj = false;
                currentTrajIndex = 0;
            }
        }
    }

    public void StartTraj()
    {
        if (!RobotClient.isRecvingMode && TrajSwitch)
        {
            if (!runTraj && (TrajRotation.Count != 0))
            {
                runTraj = true;
                if(GetComponent<Rigidbody>())
                    GetComponent<Rigidbody>().isKinematic = true;
            }
            else
            {
                runTraj = false;
            }
        }

    }
    public void StopTraj()
    {

        if (TrajRotation.Count != 0)
        {
            runTraj = false;
            currentTrajIndex = 0;
            transform.localPosition = TrajPosition[currentTrajIndex];
            transform.localEulerAngles = TrajRotation[currentTrajIndex];
        }
    }
}
