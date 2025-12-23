using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class LessonPointerView
{
    public LessonStep selectedStep { get; private set; }
    System.Action<LessonStep> onStepSelected;
    System.Action<int> onStepRemoveRequested;
    System.Action<LessonStep> onTapSelected;

    // For editor-only expand/collapse state
    Dictionary<string, bool> groupFoldouts = new Dictionary<string, bool>();

    public LessonPointerView(
        System.Action<LessonStep> onStepSelected,
        System.Action<int> onStepRemoveRequested,
        System.Action<LessonStep> onTapSelected
    )
    {
        this.onStepSelected = onStepSelected;
        this.onStepRemoveRequested = onStepRemoveRequested;
        this.onTapSelected = onTapSelected;
    }

    public void Draw(List<LessonStep> lessonStack)
    {
        

        GUILayout.Label("Steps:", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();

        // Draw tap for each step in stack
        foreach (var step in lessonStack)
        {
            GUIStyle stepStyle = (step == null) ? EditorStyles.whiteLabel : EditorStyles.label;
            var buttonText = $" > {step.Description}";
            var textSize = stepStyle.CalcSize(new GUIContent(buttonText));
            if (GUILayout.Button(buttonText, stepStyle, GUILayout.Width(textSize.x)))
            {
                onTapSelected?.Invoke(step);
                break;
            }
        }
        EditorGUILayout.EndHorizontal();

        
    }
}