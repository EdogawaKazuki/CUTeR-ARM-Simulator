#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using XNode;
using XNodeEditor;
using System;
using System.Linq;


[CustomNodeGraphEditor(typeof(LessonGraph))]
public class LessonGraphEditor : NodeGraphEditor
{
    private LessonSO lessonSO;

    // List your concrete step types here
    private Type[] stepTypes = new Type[] { typeof(PlayAudioStep), typeof(ShowImageStep), typeof(VideoPlayStep) };
    private int stepTypeIndex = 0;

    public override void OnOpen()
    {
        base.OnOpen();
        var graph = target as LessonGraph;
        lessonSO = graph != null ? graph.lessonSO : null;
    }

    public override void OnGUI()
    {
        DrawCustomToolbar();
        base.OnGUI();
    }

    private void DrawCustomToolbar()
    {
        GUILayout.BeginHorizontal(EditorStyles.toolbar);

        // Dropdown for step type
        stepTypeIndex = EditorGUILayout.Popup(stepTypeIndex, stepTypes.Select(t => t.Name).ToArray(), GUILayout.Width(120));

        if (GUILayout.Button("Add New Step Node", EditorStyles.toolbarButton))
        {
            AddNewStepNode();
        }

        if (GUILayout.Button("Export Selected as Steps", EditorStyles.toolbarButton))
        {
            ExportSelectedAsSteps();
        }

        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    private void AddNewStepNode()
    {
        if (lessonSO == null)
        {
            EditorUtility.DisplayDialog("No LessonSO", "Assign a LessonSO to the graph before adding steps.", "OK");
            return;
        }


        Type stepType = stepTypes[stepTypeIndex];

        // Create a new Step Asset of the selected type
        LessonStep step = ScriptableObject.CreateInstance(stepType) as LessonStep;
        if (step == null)
        {
            Debug.LogError("Failed to create lesson step of type: " + stepType.Name);
            return;
        }
        step.name = stepType.Name + "_" + lessonSO.steps.Count;
        step.Description = "New Step";

        AssetDatabase.AddObjectToAsset(step, lessonSO);
        AssetDatabase.SaveAssets();
        lessonSO.steps.Add(step);

        EditorUtility.SetDirty(lessonSO);
        AssetDatabase.Refresh();

        // Add node to graph and link to step
        var graph = target as LessonGraph;
        if (graph != null)
        {
            var newNode = graph.AddNode<LessonStepNode>();
            newNode.step = step;
            newNode.position = NodeEditorWindow.current != null
                ? NodeEditorWindow.current.panOffset + NodeEditorWindow.current.position.size / 2
                : Vector2.zero;
            EditorUtility.SetDirty(graph);
            NodeEditorWindow.current.Repaint();
        }
    }

    private void ExportSelectedAsSteps()
    {
        var graph = target as NodeGraph;
        if (graph == null || lessonSO == null)
        {
            EditorUtility.DisplayDialog("Missing Reference", "No graph or LessonSO assigned.", "OK");
            return;
        }

        // Get selected nodes of type LessonStepNode
        var selectedNodes = Selection.objects.OfType<LessonStepNode>().ToList();
        if (selectedNodes.Count == 0)
        {
            EditorUtility.DisplayDialog("No Selection", "Select one or more LessonStepNode(s) to export as steps.", "OK");
            return;
        }

        Type stepType = stepTypes[stepTypeIndex];

        foreach (var node in selectedNodes)
        {
            // Create new LessonStep asset and assign to node
            LessonStep step = ScriptableObject.CreateInstance(stepType) as LessonStep;
            if (step == null)
            {
                Debug.LogError("Failed to create lesson step of type: " + stepType.Name);
                continue;
            }
            step.name = stepType.Name + "_" + lessonSO.steps.Count;
            step.Description = $"Exported step from node {node.name}";

            AssetDatabase.AddObjectToAsset(step, lessonSO);
            AssetDatabase.SaveAssets();
            lessonSO.steps.Add(step);
            node.step = step;
            EditorUtility.SetDirty(node);
        }

        EditorUtility.SetDirty(graph);
        EditorUtility.SetDirty(lessonSO);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log($"Exported {selectedNodes.Count} steps from selected nodes to LessonSO.");
    }
}
#endif