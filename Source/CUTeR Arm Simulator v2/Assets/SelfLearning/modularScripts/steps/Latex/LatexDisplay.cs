using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[CreateAssetMenu(menuName = "LessonSteps/Latex/LatexDisplay")]
public class LatexDisplay : LessonStep
{
    public bool clear = false;
    public string text = @"";
    private float updateInterval = 0.02f;

    public override IEnumerator Execute(LessonContext ctx)
    {
        yield return ctx.visuals.SetLatexStatus(true);
        System.Text.StringBuilder latexBuilder = new System.Text.StringBuilder();
        string existingLatex = ctx.visuals.GetLatex();
        float elapsedTime = 0f;
        while (elapsedTime < Duration)
        {
            latexBuilder.Clear();
            if (!clear)
                latexBuilder.AppendLine(existingLatex);
            latexBuilder.AppendLine(text);
            
            ctx.visuals.SetLatex(latexBuilder.ToString());
            // Wait for the update interval and increment elapsed time
            yield return new WaitForSeconds(updateInterval);
            elapsedTime += updateInterval;
        } 


        // yield return new WaitForSeconds(Duration);
        yield return ctx.visuals.SetLatexStatus(false);
    }
}