using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR

[CustomEditor(typeof(VideoPlayStep))]
public class Video_editor : Editor
{
    SerializedProperty videoLibrary;
    SerializedProperty videoIndex;
    SerializedProperty Duration;
    SerializedProperty aspectRatio;
    SerializedProperty videoMode;
    SerializedProperty endofvideoType;
    SerializedProperty volume;
    SerializedProperty horizontalposition;
    SerializedProperty verticalposition;
    void OnEnable()
    {
        videoLibrary = serializedObject.FindProperty("videoLibrary");
        videoIndex = serializedObject.FindProperty("videoIndex");
        Duration = serializedObject.FindProperty("Duration");
        aspectRatio = serializedObject.FindProperty("aspectRatio");
        videoMode = serializedObject.FindProperty("videoMode");
        endofvideoType = serializedObject.FindProperty("endofvideoType");
        volume = serializedObject.FindProperty("volume");
        horizontalposition = serializedObject.FindProperty("horizontalposition");
        verticalposition = serializedObject.FindProperty("verticalposition");
    }
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(videoLibrary);
        EditorGUILayout.PropertyField(videoIndex);
        EditorGUILayout.PropertyField(aspectRatio);
        EditorGUILayout.PropertyField(videoMode);
        EditorGUILayout.PropertyField(volume, new GUIContent("Volume"));
        EditorGUILayout.PropertyField(horizontalposition, new GUIContent("Horizontal Position"));
        EditorGUILayout.PropertyField(verticalposition, new GUIContent("Vertical Position"));
        serializedObject.ApplyModifiedProperties();


        VideoModeType videomode = (VideoModeType)videoMode.enumValueIndex;
        switch (videomode)
        {
            case VideoModeType.Play_duration:
                EditorGUILayout.PropertyField(endofvideoType, new GUIContent("Stop or Pause after the video"));
                EditorGUILayout.PropertyField(Duration, new GUIContent("Play Duration"));
                break;
            case VideoModeType.PlayFullVideo:
                break;
        }
        serializedObject.ApplyModifiedProperties();
    }
}

#endif