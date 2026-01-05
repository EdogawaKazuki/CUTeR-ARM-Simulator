using UnityEngine;
using System.Collections;

// Defines a step that waits for a specified duration before proceeding to the next step in the lesson sequence.
// This class inherits from LessonStep and implements the Execute method to handle the waiting logic.

[CreateAssetMenu(menuName = "LessonSteps/Wait")]
public class WaitStep : LessonStep
{

    public override IEnumerator Execute(LessonContext ctx)
    {
        Debug.Log("Waiting for " + Duration + " seconds.");
        yield return new WaitForSeconds(Duration);
    }
}