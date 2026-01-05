using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class LessonOutlinerView
{
    public LessonStep selectedStep { get; private set; }
    System.Action<LessonStep> onStepSelected;
    System.Action<int> onStepRemoveRequested;

    // For editor-only expand/collapse state
    Dictionary<string, bool> groupFoldouts = new Dictionary<string, bool>();

    public LessonOutlinerView(
        System.Action<LessonStep> onStepSelected,
        System.Action<int> onStepRemoveRequested
    )
    {
        this.onStepSelected = onStepSelected;
        this.onStepRemoveRequested = onStepRemoveRequested;
    }

    public void Draw(ScriptableObject lesson, LessonStep currentSelected)
    {
        List<LessonStep> lesson_steps = null;
        if (lesson is LessonSO lessonSO)
        {
            lesson_steps = lessonSO.steps;
            if (lesson_steps == null)
                lessonSO.steps = new List<LessonStep>();
        }
        else if (lesson is LessonStep lessonstep)
        {
            // checkif lessonstep has a field called steps of type List<LessonStep>
            var stepsField = lessonstep.GetType().GetField("steps");
            if (stepsField == null || stepsField.FieldType != typeof(List<LessonStep>))
            {
                EditorGUILayout.HelpBox("Assigned LessonStep does not contain a valid 'steps' field of type List<LessonStep>.", MessageType.Error);
                return;
            }
            lesson_steps = stepsField.GetValue(lessonstep) as List<LessonStep>;
            
            // assign empty list if null
            if (lesson_steps == null)
            {
                stepsField.SetValue(lessonstep, new List<LessonStep>());
                lesson_steps = stepsField.GetValue(lessonstep) as List<LessonStep>;
            }
        }
        else
        {
            EditorGUILayout.HelpBox("Assigned object is not a valid LessonSO or LessonSubsequence.", MessageType.Error);
            return;
        }

        if (lesson_steps == null)
            lesson_steps = new List<LessonStep>();

        GUILayout.Label("Steps:", EditorStyles.boldLabel);

        // 1. Group steps by their Group label
        var groups = new Dictionary<string, List<(LessonStep step, int index)>>();
        for (int i = 0; i < lesson_steps.Count; i++)
        {
            var step = lesson_steps[i];
            string group = "";

            // Try to get group label from step
            var groupField = step.GetType().GetField("Group");
            if (groupField != null)
                group = (string)groupField.GetValue(step);

            if (!groups.ContainsKey(group))
                groups[group] = new List<(LessonStep, int)>();
            groups[group].Add((step, i));
        }

        int stepToRemove = -1;

        foreach (var group in groups)
        {
            string groupName = string.IsNullOrEmpty(group.Key) ? "(Ungrouped)" : group.Key;

            // Draw group header with foldout
            if (!groupFoldouts.ContainsKey(groupName))
                groupFoldouts[groupName] = true;

            groupFoldouts[groupName] = EditorGUILayout.Foldout(groupFoldouts[groupName], groupName, true);

            if (groupFoldouts[groupName])
            {
                EditorGUI.indentLevel++;
                foreach (var (step, index) in group.Value)
                {
                    EditorGUILayout.BeginHorizontal();

                    GUIStyle stepStyle = (step == currentSelected) ? EditorStyles.whiteLabel : EditorStyles.label;
                    if (GUILayout.Button($"{index + 1}. {step.GetType().Name}: {step.Description}", stepStyle, GUILayout.Width(320)))
                    {
                        onStepSelected?.Invoke(step);
                    }

                    if (GUILayout.Button("Delete", GUILayout.Width(60)))
                    {
                        stepToRemove = index;
                    }
                    EditorGUILayout.EndHorizontal();
                }
                EditorGUI.indentLevel--;
            }
        }

        if (stepToRemove != -1)
        {
            onStepRemoveRequested?.Invoke(stepToRemove);
        }
    }
}