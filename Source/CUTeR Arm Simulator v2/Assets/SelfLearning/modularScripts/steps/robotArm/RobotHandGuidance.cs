using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/RobotHandGuidance")]
public class RobotHandGuidance : LessonStep
{

    public int mode;

    public override IEnumerator Execute(LessonContext ctx)
    {
        branch_index = -1;
        ctx.interactive._interactiveRobotArmUI.gameObject.SetActive(true);
        // Poll efficiently every 0.1 seconds
        while (branch_index == -1)
        {
            branch_index = ctx.interactive._interactiveRobotArmUI.branchIndex;
            if (branch_index != -1) break;
            yield return new WaitForSeconds(0.1f); // or Cache static WaitForSeconds
        }
    }

}