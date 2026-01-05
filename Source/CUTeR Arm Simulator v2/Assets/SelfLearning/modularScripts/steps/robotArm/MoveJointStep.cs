using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/MoveJoint")]
public class MoveJointStep : LessonStep
{
    [Header("Choose Index from 0 to 5")]
    [Range(0, 5)]
    public int jointIndex;
    [Header("show arrows on robot to visualise the joint movement")]
    public bool showarrows = false;
    
    public float targetAngle;

    public override IEnumerator Execute(LessonContext ctx)
    {
        if (showarrows)
        {
            ctx.visuals.ShowArrow(jointIndex, true);
        }
        List<float> angleList = ctx.robot._robotJointController.GetJointAngles();
        angleList[jointIndex] = targetAngle;
        yield return ctx.generalRobot.MoveToTargetJointSpacePositionCubicTrajectory(angleList, Duration);
        ctx.visuals.ShowArrow(jointIndex, false);

        Debug.Log("MoveJointStep Execute called. Waiting for completion...");
        Debug.Log("MoveJointStep completed.");
        if (ctx.robot._enableTransparentRobot)
            ctx.robot.HideTransparentModel();
    }

}