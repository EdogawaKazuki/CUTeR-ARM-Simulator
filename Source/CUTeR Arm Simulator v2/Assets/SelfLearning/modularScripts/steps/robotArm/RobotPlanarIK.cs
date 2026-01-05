using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/2R Planar IK ShowCase")]
public class RobotPlanarIK : LessonStep
{
    [Header("Planar Offset")]
    public UnityEngine.Vector3 offset = new UnityEngine.Vector3(0, 0.0f, 0.1f);

    public override IEnumerator Execute(LessonContext ctx)
    {
        yield return ctx.interactive._interactive2RPlanarRobotArm.ShowCaseFullSolution(Duration, offset);
    }
}
