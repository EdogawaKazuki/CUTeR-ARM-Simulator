using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/DHTable")]
public class DHTableStep : LessonStep
{

    public int jointIndex;

    public override IEnumerator Execute(LessonContext ctx)
    {
        ctx.interactive.SetDHTableStatus(true);
        ctx.generalRobot.LockSlider(false);
        branch_index = -1;
        ctx.interactive._DHTableUI.previous_selected_index = -1;
        // Poll efficiently every 0.1 seconds
        while (branch_index == -1)
        {
            branch_index = ctx.interactive._DHTableUI.previous_selected_index;
            if (branch_index != -1) break;
            yield return new WaitForSeconds(0.1f); // or Cache static WaitForSeconds
        }
    }

}