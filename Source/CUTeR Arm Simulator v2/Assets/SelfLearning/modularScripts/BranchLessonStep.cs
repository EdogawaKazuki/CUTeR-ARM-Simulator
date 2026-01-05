using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using System;


[CreateAssetMenu(menuName = "Lesson/Branch Step")]
public class BranchLessonStep : LessonStep
{
    public List<LessonStep> steps = new();
    public int end_branch_index = 0;
    private int output_branch_index = -1; 

    private void OnValidate()
    {
        Duration = 0;
        if (steps == null || steps.Count == 0)
            return;
        foreach (var step in steps)
        {
            if (step == null)
                continue;
            Duration = Mathf.Max(Duration, step.Duration);
        }
    }

    public override IEnumerator Execute(LessonContext ctx)
    {
        output_branch_index = 0;

        var branch_step = steps[0];
        yield return branch_step.Execute(ctx);
        output_branch_index = branch_step.branch_index + 1;
        Debug.Log("Branch Output:" + output_branch_index);

        if ( output_branch_index >= 1 && output_branch_index < steps.Count)
            yield return steps[output_branch_index].Execute(ctx);


        // if (output_branch_index >= 1 && output_branch_index < steps.Count)
        //     branch_index = steps[output_branch_index].branch_index;
        // else 
        branch_index = output_branch_index - 1;

        
    }


}