using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class DurationManager
{
    public float RetrieveDuration(ScriptableObject targetObject)
    {
        float Duration = 0f;
        if (targetObject is LessonStep lessonstep)
        {
            Duration = lessonstep.Duration;
        }
        return Duration;
    }

    public float AssignDuration(ScriptableObject targetObject, float Duration)
    {
        if (targetObject is LessonStep lessonstep)
        {
            lessonstep.Duration = Duration;
        }
        return Duration;
    }

    public float UpdateDurationRecursive(ScriptableObject currentObject)
    {
        List<LessonStep> lesson_steps;
        float Duration = 0f;
        var stepsField = currentObject?.GetType().GetField("steps");
        // direct retrieve object duration if no steps field (leaf node)
        if (stepsField == null || stepsField.FieldType != typeof(List<LessonStep>))
        {
            return RetrieveDuration(currentObject);
        }

        lesson_steps = stepsField.GetValue(currentObject) as List<LessonStep>;
        if (lesson_steps == null) return RetrieveDuration(currentObject);
        if (currentObject is GroupLessonStep)
        {
            // Find max duration among children for group step
            foreach (var step in lesson_steps)
            {
                float tmp_duration = UpdateDurationRecursive(step);
                Duration = Mathf.Max(Duration, tmp_duration);
            }
        }
        else
        {
            // Sum durations of children for sequential/loop steps
            foreach (var step in lesson_steps)
            {
                if (step == null) continue;
                float tmp_duration = UpdateDurationRecursive(step);
                Duration += tmp_duration;
            }
        }
        AssignDuration(currentObject, Duration);
        return Duration;

    }
}