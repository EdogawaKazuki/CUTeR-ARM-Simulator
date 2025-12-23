using UnityEngine;
using UnityEditor;
using System.Collections.Generic;


public class GroupStepMenu

{
    
    private LessonEditorWindow _window;

    public GroupStepMenu(LessonEditorWindow window)
    {
        _window = window;
    }
    public void GroupStepmenu()
    {
        EditorGUILayout.BeginVertical(LessonEditorStyles.StepBox);
        EditorGUILayout.LabelField("Group existing steps into one container", EditorStyles.boldLabel);

        // Choose container type
        _window.groupAs = (LessonEditorWindow.GroupTarget) EditorGUILayout.EnumPopup("Group As", _window.groupAs);

        // Quick toggles
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Select All", GUILayout.Width(100)))
        {
            var keys = new List<LessonStep>(_window.groupSelection.Keys);
            foreach (var k in keys) _window.groupSelection[k] = true;
        }
        if (GUILayout.Button("Select None", GUILayout.Width(100)))
        {
            var keys = new List<LessonStep>(_window.groupSelection.Keys);
            foreach (var k in keys) _window.groupSelection[k] = false;
        }
        EditorGUILayout.EndHorizontal();
        //GUI.contentColor = prevContentColor2;

        EditorGUILayout.Space(4);

        // Existing steps with checkboxes
        if (_window.currentSteps == null || _window.currentSteps.Count == 0)
        {
            EditorGUILayout.HelpBox("No steps to group.", MessageType.Info);
        }
        else
        {
            for (int i = 0; i < _window.currentSteps.Count; i++)
            {
                var s = _window.currentSteps[i];
                if (s == null) continue;

                EditorGUILayout.BeginHorizontal();
                bool selected = _window.groupSelection.TryGetValue(s, out var v) ? v : false;
                bool newSelected = GUILayout.Toggle(selected, GUIContent.none, GUILayout.Width(18));
                if (newSelected != selected) _window.groupSelection[s] = newSelected;

                GUILayout.Label($"{i + 1}. {s.GetType().Name}: {s.Description}", GUILayout.ExpandWidth(true));
                EditorGUILayout.EndHorizontal();
            }
        }

        EditorGUILayout.Space(6);

        // Enable Create only if at least one selected
        bool anySelected = false;
        foreach (var kv in _window.groupSelection) { if (kv.Value) { anySelected = true; break; } }

        using (new EditorGUI.DisabledScope(!anySelected))
        {
            if (GUILayout.Button("Create Group Container", GUILayout.Height(24)))
            {
                // Convert based on the chosen container type
                switch (_window.groupAs)
                {
                    case LessonEditorWindow.GroupTarget.Parallel: ConvertSelectionToContainer(typeof(GroupLessonStep), "Group Step"); break;
                    case LessonEditorWindow.GroupTarget.Loop: ConvertSelectionToContainer(typeof(LoopStep), "Loop Step"); break;
                    case LessonEditorWindow.GroupTarget.Sequential: ConvertSelectionToContainer(typeof(LessonSubsequence), "Lesson Subsequence"); break;
                }
            }
        }

        if (GUILayout.Button("Close", GUILayout.Width(80)))
            _window.showGroupingPanel = false;

        EditorGUILayout.EndVertical();
    }
    private void ConvertSelectionToContainer(System.Type containerType, string defaultDescription)
    {
        if (_window.currentLessonObject == null || _window.currentSteps == null) return;

        // 1) Collect selected indices (in order)
        List<int> selectedIndices = new List<int>();
        for (int i = 0; i < _window.currentSteps.Count; i++)
        {
            var s = _window.currentSteps[i];
            if (s != null && _window.groupSelection.TryGetValue(s, out var sel) && sel)
                selectedIndices.Add(i);
        }
        if (selectedIndices.Count == 0) return;

        int insertIndex = selectedIndices[0]; // Replace starting at the earliest selected

        // 2) Create the container step (SO)
        var container = ScriptableObject.CreateInstance(containerType) as LessonStep;
        if (container == null) return;

        container.name = containerType.Name + "_" + _window.currentSteps.Count;
        container.Description = defaultDescription;

        AssetDatabase.AddObjectToAsset(container, _window.currentLessonObject);
        AssetDatabase.SaveAssets();

        // 3) Get the container's public List<LessonStep> steps via reflection
        var stepsField = containerType.GetField("steps");
        if (stepsField == null || stepsField.FieldType != typeof(List<LessonStep>))
        {
            Debug.LogError($"{containerType.Name} must expose 'public List<LessonStep> steps'.");
            Object.DestroyImmediate(container, true);
            return;
        }

        var subSteps = stepsField.GetValue(container) as List<LessonStep>;
        if (subSteps == null)
        {
            subSteps = new List<LessonStep>();
            stepsField.SetValue(container, subSteps);
        }

        // 4) Move selected steps into the container (keep order; no cloning)
        foreach (int idx in selectedIndices)
            subSteps.Add(_window.currentSteps[idx]);

        // 5) Remove originals from the top list (descending so indices don't shift)
        for (int i = selectedIndices.Count - 1; i >= 0; i--)
            _window.currentSteps.RemoveAt(selectedIndices[i]);

        // 6) Insert the one container at the earliest position
        if (insertIndex < 0 || insertIndex > _window.currentSteps.Count) insertIndex = _window.currentSteps.Count;
        _window.currentSteps.Insert(insertIndex, container);

        // 7) Persist + select the new container
        EditorUtility.SetDirty(_window.currentLessonObject);
        EditorUtility.SetDirty(container);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        _window.SelectStep(container, insertIndex);

        // 8) Close the panel
        _window.showGroupingPanel = false;
    }


}