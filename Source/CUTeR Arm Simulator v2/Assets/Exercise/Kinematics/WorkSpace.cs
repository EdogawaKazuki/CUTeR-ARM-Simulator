using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkSpace : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _trajController = GameObject.Find("Robot").GetComponent<StaticRobotTrajectoryController>();
    }
    public void VerticalPlane()
    {
        float[][] jointList = {
            new float[] {    0,    0,    0,    0,    0,    0,    0,    0,    0 },
            new float[] {  180,  180,  180,    0,    0,  180,  180,  125,  180 },
            new float[] { -140,  -60, -140, -140,    0,    0,   45,   45, -140 } };
        float[] timeList = { 0,    2,    2,    4,    4,    4,    2,    4,    4 };
        _trajController.ResetTraj(3);
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < 3; i++)
        {
            List<float> traj = new List<float>();

            for (int j = 1; j < jointList[0].Length; j++)
            {
                traj.AddRange(GenerateTraj(jointList[i][j - 1], jointList[i][j], timeList[j]));
            }
            trajList.Add(traj);
        }
        _trajController.SetTraj(trajList);
    }
    public void ThreeBaseAngle()
    {
        float[][] jointList = {
            new float[] {  -90,  -90,  -90,  -90,  -90,  -90,  -90,  -90,  -90,    0,    0,    0,    0,    0,    0,    0,    0,    0,   90,   90,   90,   90,   90,   90,   90,   90,   90 },
            new float[] {  180,  180,  180,    0,    0,  180,  180,  125,  180,  180,  180,  180,    0,    0,  180,  180,  125,  180,  180,  180,  180,    0,    0,  180,  180,  125,  180 },
            new float[] { -140,  -60, -140, -140,    0,    0,   45,   45, -140, -140,  -60, -140, -140,    0,    0,   45,   45, -140, -140,  -60, -140, -140,    0,    0,   45,   45, -140 } };
        float[] timeList = { 0,    2,    2,    4,    4,    4,    2,    4,    4,    4,    2,    2,    4,    4,    4,    2,    4,    4,    4,    2,    2,    4,    4,    4,    2,    4,    4 };
        _trajController.ResetTraj(3);
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < 3; i++)
        {
            List<float> traj = new List<float>();

            for (int j = 1; j < jointList[0].Length; j++)
            {
                traj.AddRange(GenerateTraj(jointList[i][j - 1], jointList[i][j], timeList[j]));
            }
            trajList.Add(traj);
        }
        _trajController.SetTraj(trajList);
    }
    
    List<float> GenerateTraj(float start, float end, float duration)
    {
        List<float> result = new List<float>();
        int step_number = (int)(duration * 20);
        float step_size = (end - start) / step_number;
        for(int i = 0; i < step_number; i++)
        {
            result.Add(start + step_size * i);
        }
        return result;
    }
}
