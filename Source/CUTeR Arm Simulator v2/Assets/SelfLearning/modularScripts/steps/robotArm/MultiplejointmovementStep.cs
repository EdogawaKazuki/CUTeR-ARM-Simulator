using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/MultipleJointMovement")]
public class MultipleJointMovement : LessonStep
{
    [Header("Choose Indexes from 0 to 5")]
    [Range(0, 5)]
    public List<int> jointIndexes = new List<int>();
    
    [Header("Make sure the number of target angles matches the number of joint indexes")]
    public List<float> targetAngles;
    [Header("show arrows on robot to visualise the joint movement")]
    
    public bool showarrows = false;
    public override IEnumerator Execute(LessonContext ctx)
    {
        if (showarrows)
        {
            foreach (int index in jointIndexes)
            {
                ctx.visuals.ShowArrow(index, true);
            }
        }
        List<float> angleList = ctx.robot.GetJointAngles();
        // List<float> initialAngles = new List<float>(new float [] {0,0,0,0,0,0});
        if (jointIndexes.Count == targetAngles.Count)
        {
            for (int i = 0; i < jointIndexes.Count; i++)
            { angleList[jointIndexes[i]] = targetAngles[i]; }
        }


        yield return ctx.generalRobot.MoveToTargetJointSpacePositionCubicTrajectory(angleList, Duration);
        foreach (int index in jointIndexes)
        {
            ctx.visuals.ShowArrow(index, false);
        }

        Debug.Log("MoveJointStep Execute called. Waiting for completion...");
        //yield return new WaitForSeconds(duration);
        Debug.Log("MoveJointStep completed.");
        if (ctx.robot._enableTransparentRobot)
            ctx.robot.HideTransparentModel();
    }
}

