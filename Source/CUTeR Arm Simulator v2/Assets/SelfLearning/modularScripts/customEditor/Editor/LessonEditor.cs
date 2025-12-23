using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

// Defines an abstract base class named LessonStep that inherits from Unity's ScriptableObject.

// [CreateAssetMenu(menuName = "Lesson/LessonSequence")]
public class LessonEditor : ScriptableObject
{

    public List<LessonStep> lessonStack = new List<LessonStep>();
    public LessonSO lessonSO;
    public ScriptableObject currentLessonObject;
    public List<LessonStep> currentSteps;

    public LessonStep selectedStep;
    public int selectedIndex = -1;
    public bool stackSelectedStep = false;
    public bool stackOnChange = false;

    public void UpdateStack()
    {
        if (stackSelectedStep)
        {
            string context = $"Enter {selectedStep.Description}";
            Undo.IncrementCurrentGroup();
            Undo.SetCurrentGroupName(context);
            Undo.RecordObject(this, context);
            lessonStack.Add(selectedStep);
            selectedStep = null;
            selectedIndex = -1;
            stackSelectedStep = false;
        }

        if (lessonStack.Count > 1)
        {
            if (!stackSelectedStep)
            {
                string context = $"Change in Lesson Stack";
                Undo.IncrementCurrentGroup();
                Undo.SetCurrentGroupName(context);
                Undo.RecordObject(this, context);
            }
            currentLessonObject = lessonStack[lessonStack.Count - 1];
            var stepsField = currentLessonObject?.GetType().GetField("steps");
            currentSteps = stepsField?.GetValue(currentLessonObject) as List<LessonStep>;
            if (currentSteps == null)
            {
                stepsField.SetValue(currentLessonObject, new List<LessonStep>());
                currentSteps = stepsField.GetValue(currentLessonObject) as List<LessonStep>;
            }
            Debug.Log($"Current Lesson Object: {currentLessonObject}");
            EditorUtility.SetDirty(this);

        }


        if (lessonStack.Count == 1)
        {
            currentLessonObject = lessonSO;
            currentSteps = lessonSO != null ? lessonSO.steps : null;

        }
    }

    public void SelectTab(LessonStep step)
    {
        selectedStep = null;
        selectedIndex = -1;
        int count = 0;
        while (lessonStack.Count > 1 && lessonStack[lessonStack.Count - 1] != step)
        {
            lessonStack.RemoveAt(lessonStack.Count - 1);
            count += 1;
        }
    }

}