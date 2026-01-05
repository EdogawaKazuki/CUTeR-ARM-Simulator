using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

// public enum JointFrameMode
// {
//     Normal,
//     NormalAll,
//     DHTable,
//     DHTableAll
// }
public enum SelectAxis
{
    X,
    Y,
    Z,
    All
}

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/ShowJointFrame")]
public class ShowJointFrame : LessonStep
{
    [Header("Choose Index from 0 to 5")]
    [Range(0, 7)]
    public int jointIndex;
    [Header("Select All")]
    public bool selectAllJoints = false;
    [Header("Select Axis to be shown")]
    public SelectAxis axis = SelectAxis.All;
    [Header("Show frame on robot joint")]
    public bool show = false;
    public JointFrameMode mode = JointFrameMode.Normal;
    private List<int> jointIndices = new();
    
    public override IEnumerator Execute(LessonContext ctx)
    {
        if (selectAllJoints)
            jointIndices = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
        else
            jointIndices = new List<int> { jointIndex };
        
        foreach (var jointIndex in jointIndices)
        {
            if (jointIndex == 0)
            {
                if(axis == SelectAxis.All)
                {
                    ctx.robot._robotJointController.ShowJointBaseFrame(show, mode);
                }
                else
                {
                    ctx.robot._robotJointController.ShowJointBaseFrameAxis((int)axis, show, mode);
                }

            }
            else
            {
                if(axis == SelectAxis.All)
                {
                    ctx.robot._robotJointController.ShowJointFrame(jointIndex-1, show, mode);
                }
                else
                {
                    ctx.robot._robotJointController.ShowJointFrameAxis(jointIndex-1, (int)axis, show, mode);
                }

            }
        }

        yield break;
    }

}