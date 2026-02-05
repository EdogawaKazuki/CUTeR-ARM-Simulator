using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/SetRobotArmSlider")]
public class SetRobotArmSlider : LessonStep
{
    [Header("Choose Index from 0 to 5")]
    [Range(0, 6)]
    public int jointIndex;
    [Header("Enable Sliders")]
    public bool enableSliders = false;
    
    public override IEnumerator Execute(LessonContext ctx)
    {
        ctx.generalRobot.LockSlider(!enableSliders);
        yield break;
    }

}