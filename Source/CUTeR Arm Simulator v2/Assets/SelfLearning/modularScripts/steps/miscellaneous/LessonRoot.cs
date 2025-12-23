using UnityEngine;
using System.Collections;

// Defines an abstract base class named LessonStep that inherits from Unity's ScriptableObject.
public class LessonRoot : LessonStep
{
    public override IEnumerator Execute(LessonContext ctx)
    {
        yield break;
    }
}