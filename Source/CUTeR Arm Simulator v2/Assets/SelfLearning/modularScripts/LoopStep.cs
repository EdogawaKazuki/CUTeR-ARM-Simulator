using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LoopMode
{
    Count,
    Branch
}


[CreateAssetMenu(menuName = "Lesson/Loop Step")]
public class LoopStep : LessonStep
{
    public LoopMode loopMode = LoopMode.Count;
    public int LoopCount;
    public int TargetBranchIndex;
    public List<LessonStep> steps;

    public override IEnumerator Execute(LessonContext ctx)
    {
        if (loopMode == LoopMode.Count)
        {
            for (int i = 0; i < LoopCount; i++)
            {
                foreach (var step in steps)
                { yield return step.Execute(ctx); }
            }
        }
        else if (loopMode == LoopMode.Branch)
        {
            int selected_branch = TargetBranchIndex-1;
            while(selected_branch != TargetBranchIndex)
            {
                foreach (var step in steps)
                { yield return step.Execute(ctx); selected_branch = step.branch_index;}
            }
        }

    }
}