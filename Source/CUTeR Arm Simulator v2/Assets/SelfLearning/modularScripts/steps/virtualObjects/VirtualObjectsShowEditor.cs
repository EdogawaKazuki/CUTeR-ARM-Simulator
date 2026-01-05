using UnityEditor;
using UnityEngine;
using System.Linq;
#if UNITY_EDITOR
[CustomEditor(typeof(VirtualObjectsShow))]
public class VrtualObjectsShowEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(serializedObject.FindProperty("Description"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Group"), new GUIContent("Group"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("sceneObjectName"), new GUIContent("Scene Object Name"));
        string sceneObjectName = serializedObject.FindProperty("sceneObjectName").stringValue;
        if (!string.IsNullOrEmpty(sceneObjectName))
        {
            // Find all GameObjects (including inactive) in the scene(s) with the given name
            var allObjects = GameObject.FindObjectsOfType<GameObject>(true);
            var matches = allObjects.Where(go => go.name == sceneObjectName).ToArray();

            if (matches.Length > 1)
            {
                EditorGUILayout.HelpBox(
                    $"Warning: There are {matches.Length} GameObjects named \"{sceneObjectName}\" in the scene. Please ensure the name is unique!",
                    MessageType.Warning
                );
            }
            else if (matches.Length == 0)
            {
                EditorGUILayout.HelpBox(
                    $"No GameObject named \"{sceneObjectName}\" exists in the current scene(s).",
                    MessageType.Error
                );
            }
        }
        EditorGUILayout.PropertyField(serializedObject.FindProperty("showhidetype"), new GUIContent("Show/Hide Type"));

        // Position Field
        SerializedProperty choosePositionProp = serializedObject.FindProperty("chooseposition");
        EditorGUILayout.PropertyField(choosePositionProp, new GUIContent("Choose Position"));
        if (choosePositionProp.boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("position"), new GUIContent("Position"));
        }

        // Rotation Field
        SerializedProperty chooseRotationProp = serializedObject.FindProperty("chooserotation");
        EditorGUILayout.PropertyField(chooseRotationProp, new GUIContent("Choose Rotation"));
        if (chooseRotationProp.boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("rotation"), new GUIContent("Rotation"));
        }

        // Scale Field
        SerializedProperty chooseScaleProp = serializedObject.FindProperty("choosescale");
        EditorGUILayout.PropertyField(chooseScaleProp, new GUIContent("Choose Scale"));
        if (chooseScaleProp.boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("scale"), new GUIContent("Scale"));
        }

        serializedObject.ApplyModifiedProperties();
    }
}
#endif