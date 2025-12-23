using UnityEngine;
using UnityEditor;

public class LessonInspectorView
{
    System.Func<LessonStep> getSelectedStep;
    System.Action onChanged;
    Vector2 scroll;

    public LessonInspectorView(System.Func<LessonStep> getSelectedStep, System.Action onChanged)
    {
        this.getSelectedStep = getSelectedStep;
        this.onChanged = onChanged;
    }

    public void Draw()
    {
        var step = getSelectedStep();
        GUILayout.Label("Inspector", EditorStyles.boldLabel);
        scroll = EditorGUILayout.BeginScrollView(scroll);

        if (step == null)
        {
            EditorGUILayout.LabelField("No step selected.");
            EditorGUILayout.EndScrollView();
            return;
        }

        EditorGUI.BeginChangeCheck();
        step.Description = EditorGUILayout.TextField("Description", step.Description);
        // Add fields for other step properties, or use Editor.CreateEditor for ScriptableObjects

        if (EditorGUI.EndChangeCheck())
        {
            EditorUtility.SetDirty(step);
            onChanged?.Invoke();
        }
        EditorGUILayout.EndScrollView();
    }
}