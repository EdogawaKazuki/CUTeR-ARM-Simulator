using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/ShowJointLink")]
public class ShowJointLink : LessonStep
{
    [Header("Choose Index from 0 to 5")]
    [Range(0, 6)]
    public int jointIndex;
    [Header("Show frame on robot joint")]
    public bool showlink = false;
    
    public override IEnumerator Execute(LessonContext ctx)
    {
        if (jointIndex == 0)
            ctx.robot.transform.Find(ctx.robot._robotJointController.GetPathRoot() + "/Part")?.gameObject.SetActive(showlink);
        else
        {
            if (showlink)
                ctx.robot._robotJointController.ShowJointLink(jointIndex - 1);
            else
                ctx.robot._robotJointController.HideJointLink(jointIndex - 1);

        }
        yield break;
    }

}