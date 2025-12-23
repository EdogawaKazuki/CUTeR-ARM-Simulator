using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using System;


[CreateAssetMenu(menuName = "Lesson/Group Step")]
public class GroupLessonStep : LessonStep
{
    public List<LessonStep> steps = new();

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
        var coroutines = new List<Coroutine>();
        var done = new bool[steps.Count];

        IEnumerator RunAndMark(LessonStep step, LessonContext ctx, Action markDone)
        {
            if (step == null)
            {
                markDone();
                yield break;
            }

            yield return ctx.runner.StartCoroutine(step.Execute(ctx));
            markDone();
        }

        for (int i = 0; i < steps.Count; i++)
        {
            var step = steps[i];
            if (step == null)
            {
                done[i] = true;
                continue;
            }

            int localIndex = i;
            coroutines.Add(ctx.runner.StartCoroutine(RunAndMark(step, ctx, () => done[localIndex] = true)));
        }

        foreach (var coroutine in coroutines)
            yield return coroutine;
        
        // Wait until all child coroutines have finished
        yield return new WaitUntil(() =>
        {
            for (int i = 0; i < done.Length; i++)
            {
                var step = steps[i];
                if (step != null && step.branch_index != -1) branch_index = step.branch_index;
                if (!done[i]) return false;
            }
            
            return true;
        });

    }


}