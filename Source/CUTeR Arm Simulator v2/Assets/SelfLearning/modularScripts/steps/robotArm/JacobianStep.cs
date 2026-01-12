using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/Jacobian")]
public class JacobianStep : LessonStep
{

    public int jointIndex;

    public override IEnumerator Execute(LessonContext ctx)
    {
        ctx.interactive._jacobianVisualizer.enabled = true;
        ctx.interactive._jacobianVisualizer.SetButtonActive(true);
        ctx.generalRobot.LockSlider(false);
        branch_index = -1;
        ctx.interactive.branch_index = -1;
        // Poll efficiently every 0.1 seconds
        while (branch_index == -1)
        {
            branch_index = ctx.interactive.branch_index;
            if (branch_index != -1) break;
            yield return new WaitForSeconds(0.1f); // or Cache static WaitForSeconds
        }
        ctx.interactive._jacobianVisualizer.SetButtonActive(false);
    }

}