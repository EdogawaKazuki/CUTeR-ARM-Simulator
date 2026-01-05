#if UNITY_EDITOR

using UnityEditor;
using XNodeEditor;
using UnityEngine;
using System;
using System.Linq;


[CustomNodeEditor(typeof(LessonStepNode))]
public class LessonStepNodeEditor : NodeEditor
{
    private Editor stepEditor;

    public override void OnBodyGUI()
    {
        var node = target as LessonStepNode;
        serializedObject.Update();

        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("prev"));
        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("next"));

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Step", EditorStyles.boldLabel);

        // Show step inspector inline
        if (node.step != null)
        {
            // Create or reuse Editor for step
            if (stepEditor == null || stepEditor.target != node.step)
            {
                if (stepEditor != null) UnityEngine.Object.DestroyImmediate(stepEditor);
                stepEditor = Editor.CreateEditor(node.step);
            }

            if (stepEditor != null)
            {
                EditorGUI.BeginChangeCheck();
                stepEditor.OnInspectorGUI();
                if (EditorGUI.EndChangeCheck())
                {
                    EditorUtility.SetDirty(node.step);
                }
            }

            // Optionally, remove button
            if (GUILayout.Button("Remove Step"))
            {
                // Optionally destroy asset here (or just unassign)
                node.step = null;
                if (stepEditor != null) UnityEngine.Object.DestroyImmediate(stepEditor);
            }
        }
        else
        {
            EditorGUILayout.HelpBox("No step assigned.", MessageType.Info);
            if (GUILayout.Button("Add Step"))
            {
                ShowAddStepMenu(node);
            }
        }

        serializedObject.ApplyModifiedProperties();
    }

    private void ShowAddStepMenu(LessonStepNode node)
    {
        var menu = new GenericMenu();
        var baseType = typeof(LessonStep);

        // Find all non-abstract, non-generic subtypes of LessonStep in the project
        var stepTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .Where(t => baseType.IsAssignableFrom(t) && t != baseType && !t.IsAbstract && !t.IsGenericType)
            .OrderBy(t => t.Name);

        foreach (var type in stepTypes)
        {
            var typeName = ObjectNames.NicifyVariableName(type.Name);
            menu.AddItem(new GUIContent(typeName), false, () => AddStep(node, type));
        }
        menu.ShowAsContext();
    }

    private void AddStep(LessonStepNode node, Type stepType)
    {
        // Create as standalone asset in project (change as needed: sub-asset, etc.)
        var newStep = ScriptableObject.CreateInstance(stepType) as LessonStep;
        newStep.name = stepType.Name + "_" + Guid.NewGuid().ToString().Substring(0, 8);
        newStep.Description = ObjectNames.NicifyVariableName(stepType.Name);

        string path = "Assets/LessonSteps";
        if (!AssetDatabase.IsValidFolder(path))
            AssetDatabase.CreateFolder("Assets", "LessonSteps");

        string assetPath = AssetDatabase.GenerateUniqueAssetPath($"{path}/{newStep.name}.asset");
        AssetDatabase.CreateAsset(newStep, assetPath);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        node.step = newStep;
        EditorUtility.SetDirty(node);

        // No need to open in Inspector—fields will show inline
    }

    // Clean up Editor on disable
    ~LessonStepNodeEditor()
    {
        if (stepEditor != null) UnityEngine.Object.DestroyImmediate(stepEditor);
    }
}

#endif