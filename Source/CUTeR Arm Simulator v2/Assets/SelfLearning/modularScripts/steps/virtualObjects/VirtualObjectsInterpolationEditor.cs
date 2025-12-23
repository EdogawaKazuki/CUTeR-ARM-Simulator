using UnityEditor;
using UnityEngine;
using System.Linq;
#if UNITY_EDITOR

[CustomEditor(typeof(VirtualObjectsInterpolation))]
public class VirtualObjectsInterpolationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        // Draw the description field
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Description"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Duration"), new GUIContent("Duration"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Group"), new GUIContent("Group"));
        //EditorGUILayout.PropertyField(serializedObject.FindProperty("setparentobjectactivebeforeinterpolation"), new GUIContent("Set Parent Active Before Interpolation"));
        // Draw prefab field
        EditorGUILayout.PropertyField(serializedObject.FindProperty("sceneObjectName"), new GUIContent("Scene Object Name"));
        // Check if the Object name is unique
        string objectName = serializedObject.FindProperty("sceneObjectName").stringValue;
        if (!string.IsNullOrEmpty(objectName))
        {
            // Find all GameObjects (including inactive) in the scene(s) with the given name
            var allObjects = GameObject.FindObjectsOfType<GameObject>(true);
            var matches = allObjects.Where(go => go.name == objectName).ToArray();

            if (matches.Length > 1)
            {
                EditorGUILayout.HelpBox(
                    $"Warning: There are {matches.Length} GameObjects named \"{objectName}\" in the scene. Please ensure the name is unique!",
                    MessageType.Warning
                );
            }
            else if (matches.Length == 0)
            {
                EditorGUILayout.HelpBox(
                    $"No GameObject named \"{objectName}\" exists in the current scene(s).",
                    MessageType.Error
                );
            }
        }
       // SerializedProperty setparentobjectactivebeforeinterpolation  = serializedObject.FindProperty("setparentobjectactivebeforeinterpolation");
        //EditorGUILayout.PropertyField(setparentobjectactivebeforeinterpolation , new GUIContent("Set Parent Active Before Interpolation"));
        
        // Position
        SerializedProperty usePosition = serializedObject.FindProperty("usePosition");
        EditorGUILayout.PropertyField(usePosition);

        if (usePosition.boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("targetPosition"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("globalPosition"));
        }

        // Rotation
        SerializedProperty useRotation = serializedObject.FindProperty("useRotation");
        EditorGUILayout.PropertyField(useRotation);

        if (useRotation.boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("targetRotation"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("globalRotation"));
        }

        // Scale
        SerializedProperty useScale = serializedObject.FindProperty("useScale");
        EditorGUILayout.PropertyField(useScale);

        if (useScale.boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("targetScale"));
        }

        EditorGUILayout.PropertyField(serializedObject.FindProperty("smoothInterpolation"));
        if (serializedObject.FindProperty("smoothInterpolation").boolValue)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("Duration"));
        }

        serializedObject.ApplyModifiedProperties();
    }
}
#endif