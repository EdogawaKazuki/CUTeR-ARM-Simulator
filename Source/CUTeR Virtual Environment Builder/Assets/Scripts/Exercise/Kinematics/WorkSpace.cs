using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkSpace : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
    private void Start()
    {

        _trajController = _robotController.GetTrajController();
    }
    public void VerticalPlane()
    {
        float[][] jointList = {
            new float[] { -90, -90, -90, -90, -90, -90, -90 },
            new float[] { 165, 165, 35, -10, 165, 165, 165 },
            new float[] { -165, -165, -155, 5, 0, 15, -165 } };
        float[] timeList = { 1, 0.5f, 1, 1, 2, 0.2f, 1 };
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
            new float[] { -90, -90, -90, -90, -90, -90, 0, 0, 0, 0, 0, 90, 90, 90, 90, 90 },
            new float[] { 165, 165, 35, -10, 165, 165, 165, 35, -10, 165, 165, 165, 35, -10, 165, 165 },
            new float[] { -165, -165, -155, 5, 0, -165, -165, -155, 5, 0, -165, -165, -155, 5, 0, -165 } };
        float[] timeList = { 1, 0.5f, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 1 };
        _trajController.ResetTraj(3);
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < 3; i++)
        {
            List<float> traj = new List<float>();

            for (int j = 1; j < jointList[0].Length; j++)
            {
                traj.AddRange(GenerateTraj(jointList[i][j - 1], jointList[i][j], timeList[j]));
            }
        }
        _trajController.SetTraj(trajList);
    }
    public void SwipeALL()
    {
        float[][] jointList = {
            new float[] { -90, -90, 90, 90, -90, -90, 90,90,-90,-90 },
            new float[] { 165, 165, 165, 35, 35, -10, -10, 165, 165, 165 },
            new float[] { -165, -165, -165, -155, -155, 5, 5, 0, 0, -165 } };
        float[] timeList = { 1, 0.5f, 1, 1, 1, 1, 2, 2, 2, 1 };
        _trajController.ResetTraj(3);
        List<List<float>> trajList = new List<List<float>>();
        for (int i = 0; i < 3; i++)
        {
            List<float> traj = new List<float>();

            for (int j = 1; j < jointList[0].Length; j++)
            {
                traj.AddRange(GenerateTraj(jointList[i][j - 1], jointList[i][j], timeList[j]));
            }
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