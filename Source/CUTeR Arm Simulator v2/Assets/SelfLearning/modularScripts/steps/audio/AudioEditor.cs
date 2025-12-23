using UnityEditor;
using UnityEngine;
using System.Linq;

#if UNITY_EDITOR
[CustomEditor(typeof(PlayAudioStep))]
public class PlayAudioStepEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update(); // Sync serialized data

        // Draw fields using SerializedProperty (Undo handled automatically)
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Description"), new GUIContent("Description"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Duration"), new GUIContent("Duration"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Group"), new GUIContent("Group"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("audioLibrary"), new GUIContent("Audio Library"));

        // Handle audio clip selection
        SerializedProperty audioLibraryProp = serializedObject.FindProperty("audioLibrary");
        SerializedProperty audioClipIndexProp = serializedObject.FindProperty("audioClipIndex");
        SerializedProperty audioStartPositionProp = serializedObject.FindProperty("audioStartPosition");
        SerializedProperty audioEndPositionProp = serializedObject.FindProperty("audioEndPosition");
        SerializedProperty durationProp = serializedObject.FindProperty("Duration");

        AudioClipLibrary lib = audioLibraryProp.objectReferenceValue as AudioClipLibrary;

        if (lib != null && lib.audioClips != null && lib.audioClips.Length > 0)
        {
            // Create popup options from audio clips
            string[] options = lib.audioClips
                .Select(c => c != null ? c.name : "<missing>")
                .ToArray();

            int currentIndex = Mathf.Clamp(audioClipIndexProp.intValue, 0, options.Length - 1);
            EditorGUI.BeginChangeCheck(); // Track changes for Undo
            int selected = EditorGUILayout.Popup("Audio Clip", currentIndex, options);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(target, "Change Audio Clip"); // Explicit Undo for popup
                audioClipIndexProp.intValue = selected;
                audioEndPositionProp.floatValue = 0;
                EditorUtility.SetDirty(target); // Mark dirty to ensure persistence
            }
        }
        else
        {
            EditorGUILayout.HelpBox("Assign an AudioClipLibrary with at least one clip.", MessageType.Warning);
            if (audioClipIndexProp.intValue != 0)
            {
                Undo.RecordObject(target, "Reset Audio Clip Index"); // Undo for reset
                audioClipIndexProp.intValue = 0;
                EditorUtility.SetDirty(target);
            }
        }

        // Draw remaining fields
        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("audioStartPosition"), new GUIContent("Start Position (seconds)"));
        EditorGUILayout.PropertyField(serializedObject.FindProperty("audioEndPosition"), new GUIContent("End Position (seconds)"));
        if (EditorGUI.EndChangeCheck() || audioStartPositionProp.floatValue >= audioEndPositionProp.floatValue)
        {
            if (audioStartPositionProp.floatValue >= audioEndPositionProp.floatValue && lib?.audioClips != null && lib.audioClips.Length > 0)
            {
                audioEndPositionProp.floatValue = lib.audioClips[audioClipIndexProp.intValue].length;
                audioStartPositionProp.floatValue = 0;
            }
            durationProp.floatValue = audioEndPositionProp.floatValue - audioStartPositionProp.floatValue;
        }
        EditorGUILayout.PropertyField(serializedObject.FindProperty("volume"), new GUIContent("Volume"));
        EditorGUILayout.HelpBox("Volume will be applied when playing the audio clip.", MessageType.Info);

        // Apply all serialized changes and mark dirty if modified
        if (serializedObject.ApplyModifiedProperties())
        {
            EditorUtility.SetDirty(target); // Ensure changes save to disk
        }
    }
}
#endif