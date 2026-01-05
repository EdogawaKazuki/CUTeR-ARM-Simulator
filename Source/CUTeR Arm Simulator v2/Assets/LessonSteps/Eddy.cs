using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// add more using statements here if more packages needed
[CreateAssetMenu(menuName = "LessonSteps/Eddy", fileName = "Eddy")]
public class Eddy : LessonStep
{
    public override IEnumerator Execute(LessonContext ctx)
    {
        // write what the step does here
        // Example: yield return ctx.SomeOperation();
        yield break;
    }
}
