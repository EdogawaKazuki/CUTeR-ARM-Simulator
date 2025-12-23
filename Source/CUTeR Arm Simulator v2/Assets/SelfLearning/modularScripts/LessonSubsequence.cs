using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Lesson/Lesson Subsequence")]
public class LessonSubsequence : LessonStep
{

    public List<LessonStep> steps = new();

    public override IEnumerator Execute(LessonContext ctx)
    {
        
        foreach (var step in steps)
            { yield return step.Execute(ctx); branch_index = step.branch_index; }
        
    }
}