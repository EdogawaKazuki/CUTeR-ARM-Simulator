// LessonGraphBridge.cs
using UnityEngine;
using XNode;
#if UNITY_EDITOR
using UnityEditor;
using XNodeEditor;
#endif
using System.Linq;
using System.Collections.Generic;

public static class LessonGraphBridge
{

    public static void OpenNodeGraphWindow(NodeGraph graph)
    {
#if UNITY_EDITOR
        if (graph != null)
        {
            NodeEditorWindow.Open(graph);

        }
#endif
    }

#if UNITY_EDITOR
    public static T AddStep<T>(LessonSO lessonSO, string defaultDescription) where T : LessonStep
    {
        T step = ScriptableObject.CreateInstance<T>();
        step.name = typeof(T).Name + "_" + lessonSO.steps.Count;
        step.Description = defaultDescription;

        AssetDatabase.AddObjectToAsset(step, lessonSO);
        AssetDatabase.SaveAssets();
        lessonSO.steps.Add(step);

        EditorUtility.SetDirty(lessonSO);
        AssetDatabase.Refresh();

        return step;
    }
#endif


public static void SyncStepsAndNodes(LessonSO lessonSO, NodeGraph graph)
{
    if (lessonSO == null || graph == null)
    {
        UnityEngine.Debug.LogWarning("SyncStepsAndNodes: lessonSO or graph is null!");
        return;
    }

    // 1. Remove destroyed steps from lessonSO.steps before doing anything else
    int removed = lessonSO.steps.RemoveAll(step => step == null || step.Equals(null));
    if (removed > 0)
        UnityEngine.Debug.Log($"[Sync] Removed {removed} destroyed steps from LessonSO.");

    // 2. Clean up destroyed or unlinked step references in nodes
    var allStepNodes = graph.nodes.OfType<LessonStepNode>().ToList();
    foreach (var node in allStepNodes)
    {
        if (node == null) continue;
        if (node.step == null || node.step.Equals(null) || !lessonSO.steps.Contains(node.step))
        {
            node.step = null;
#if UNITY_EDITOR
            EditorUtility.SetDirty(node);
#endif
        }
    }

    // 3. Remove nodes whose .step is null or not in lessonSO.steps
    var toDestroy = allStepNodes.Where(n => n == null || n.step == null || !lessonSO.steps.Contains(n.step)).ToList();
#if UNITY_EDITOR
    foreach (var node in toDestroy)
    {
        if (node != null)
        {
            UnityEngine.Debug.Log($"[Sync] Destroying node for missing step.");
            Undo.DestroyObjectImmediate(node);
        }
    }
#endif

    // 4. Add missing step nodes for each step in lessonSO.steps
    var currentNodes = graph.nodes.OfType<LessonStepNode>().Where(n => n != null && n.step != null).ToList();
    foreach (var step in lessonSO.steps)
    {
        if (!currentNodes.Any(n => n.step == step))
        {
#if UNITY_EDITOR
            var newNode = graph.AddNode<LessonStepNode>();
            newNode.step = step;
            UnityEngine.Debug.Log($"[Sync] Created node for step: {step?.name}");
            EditorUtility.SetDirty(graph);
#endif
        }
    }

    // 5. Gather and sort step nodes again for proper ordering
    var orderedNodes = graph.nodes.OfType<LessonStepNode>()
        .Where(n => n != null && n.step != null && lessonSO.steps.Contains(n.step))
        .OrderBy(n => lessonSO.steps.IndexOf(n.step))
        .ToList();

    // 6. Ensure StartNode and EndNode exist
    var startNode = graph.nodes.OfType<StartNode>().FirstOrDefault();
    var endNode = graph.nodes.OfType<EndNode>().FirstOrDefault();
#if UNITY_EDITOR
    if (startNode == null)
    {
        startNode = graph.AddNode<StartNode>();
        UnityEngine.Debug.Log("[Sync] Created StartNode");
    }
    if (endNode == null)
    {
        endNode = graph.AddNode<EndNode>();
        UnityEngine.Debug.Log("[Sync] Created EndNode");
    }
#endif

    // 7. Link StartNode -> first step node
    if (orderedNodes.Count > 0 && startNode != null)
    {
        var firstStep = orderedNodes[0];
        var startOut = startNode.GetOutputPort("next");
        var firstIn = firstStep.GetInputPort("prev");
        if (startOut != null && firstIn != null)
        {
            foreach (var conn in startOut.GetConnections().ToList())
                startOut.Disconnect(conn);
            startOut.Connect(firstIn);
            UnityEngine.Debug.Log($"[Sync] Connected: StartNode [next] -> {firstStep.step?.name} [prev]");
        }
        else
        {
            UnityEngine.Debug.LogWarning("[Sync] Missing port on StartNode or first step node!");
        }
    }

    // 8. Link step nodes in order
    for (int i = 0; i < orderedNodes.Count - 1; i++)
    {
        var current = orderedNodes[i];
        var next = orderedNodes[i + 1];
        var outPort = current.GetOutputPort("next");
        var inPort = next.GetInputPort("prev");
        if (outPort != null && inPort != null)
        {
            foreach (var conn in outPort.GetConnections().ToList())
                outPort.Disconnect(conn);
            outPort.Connect(inPort);
            UnityEngine.Debug.Log($"[Sync] Connected: {current.step?.name} [next] -> {next.step?.name} [prev]");
        }
        else
        {
            UnityEngine.Debug.LogWarning($"[Sync] Missing port on {current.step?.name} or {next.step?.name}!");
        }
    }

    // 9. Link last step node -> EndNode
    if (orderedNodes.Count > 0 && endNode != null)
    {
        var lastStep = orderedNodes[orderedNodes.Count - 1];
        var lastOut = lastStep.GetOutputPort("next");
        var endIn = endNode.GetInputPort("prev");
        if (lastOut != null && endIn != null)
        {
            foreach (var conn in lastOut.GetConnections().ToList())
                lastOut.Disconnect(conn);
            lastOut.Connect(endIn);
            UnityEngine.Debug.Log($"[Sync] Connected: {lastStep.step?.name} [next] -> EndNode [prev]");
        }
        else
        {
            UnityEngine.Debug.LogWarning("[Sync] Missing port on last step node or EndNode!");
        }
    }

#if UNITY_EDITOR
    NodeEditorWindow.current?.Repaint();
#endif
}
public static void ExportGraphToLessonSteps(LessonSO lessonSO, NodeGraph graph)
{
#if UNITY_EDITOR
    if (lessonSO == null || graph == null)
    {
        Debug.LogWarning("ExportGraphToLessonSteps: lessonSO or graph is null!");
        return;
    }

    // 1. Find all LessonStepNodes
    var stepNodes = graph.nodes.OfType<LessonStepNode>().Where(n => n != null && n.step != null).ToList();

    // 2. Try to determine the order by traversing from StartNode
    var startNode = graph.nodes.OfType<StartNode>().FirstOrDefault();
    if (startNode == null)
    {
        Debug.LogWarning("ExportGraphToLessonSteps: No StartNode found!");
        return;
    }

    List<LessonStep> newSteps = new List<LessonStep>();

    // Traverse from StartNode via "next" ports
    Node currentNode = startNode;
    HashSet<Node> visited = new HashSet<Node>();
    while (true)
    {
        var nextPort = currentNode.GetOutputPort("next");
        if (nextPort == null || !nextPort.IsConnected)
            break;

        var conn = nextPort.GetConnections().FirstOrDefault();
        if (conn == null)
            break;

        var nextNode = conn.node;
        if (nextNode is LessonStepNode stepNode && stepNode.step != null)
        {
            if (visited.Contains(nextNode))
            {
                Debug.LogWarning("ExportGraphToLessonSteps: Detected loop in lesson graph.");
                break;
            }
            visited.Add(nextNode);
            newSteps.Add(stepNode.step);
            currentNode = nextNode;
        }
        else if (nextNode is EndNode)
        {
            // End of sequence
            break;
        }
        else
        {
            Debug.LogWarning($"ExportGraphToLessonSteps: Unexpected node type: {nextNode?.GetType().Name}");
            break;
        }
    }

    // 3. Replace lessonSO.steps with this new list
    lessonSO.steps.Clear();
    lessonSO.steps.AddRange(newSteps);

    EditorUtility.SetDirty(lessonSO);
    AssetDatabase.SaveAssets();
    Debug.Log($"[ExportGraphToLessonSteps] Exported {newSteps.Count} steps from graph to LessonSO.");
#endif
}

}