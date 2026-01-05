using UnityEngine;
using UnityEditor;
using System.Linq;

#if UNITY_EDITOR

[CustomEditor(typeof(MatrixDisplay))]
public class MatrixDisplayEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        MatrixDisplay display = (MatrixDisplay)target;

        // MatrixDictionary field
        SerializedProperty dictProp = serializedObject.FindProperty("matrixDictionary");
        EditorGUILayout.PropertyField(dictProp);

        MatrixDictionary dict = dictProp.objectReferenceValue as MatrixDictionary;

        string[] availableKeys = null;
        if (dict != null && dict.matrices != null && dict.matrices.Count > 0)
        {
            availableKeys = dict.matrices
                .Select(m => string.IsNullOrEmpty(m.key) ? "<no key>" : m.key)
                .ToArray();
        }

        // Customised keys: these are for matrices created/calculated at runtime or by code, not in the dictionary
        SerializedProperty customKeysProp = serializedObject.FindProperty("customisedKeys");

        // Normal matrix keys
        SerializedProperty keysProp = serializedObject.FindProperty("matrixKeys");
        // New lines and equal signs
        SerializedProperty newLinesProp = serializedObject.FindProperty("newLines");
        SerializedProperty equalSignsProp = serializedObject.FindProperty("equalSigns");
        SerializedProperty keepPreviousLatexProp = serializedObject.FindProperty("keepPreviousLatex");

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Matrices to Display", EditorStyles.boldLabel);

        // Draw as two columns
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical(GUILayout.Width(EditorGUIUtility.currentViewWidth / 2 - 10));
        EditorGUILayout.LabelField("From Dictionary", EditorStyles.miniBoldLabel);

        if (dict == null)
        {
            EditorGUILayout.HelpBox("Assign a MatrixDictionary to select matrices.", MessageType.Info);
        }
        else if (availableKeys == null || availableKeys.Length == 0)
        {
            EditorGUILayout.HelpBox("The MatrixDictionary has no matrices.", MessageType.Info);
        }
        else
        {
            keepPreviousLatexProp.boolValue = EditorGUILayout.Toggle("Keep Previous Latex", keepPreviousLatexProp.boolValue);
            for (int i = 0; i < keysProp.arraySize; i++)
            {
                EditorGUILayout.BeginHorizontal();
                SerializedProperty keyProp = keysProp.GetArrayElementAtIndex(i);
                SerializedProperty newLineProp = newLinesProp.GetArrayElementAtIndex(i);
                SerializedProperty equalSignProp = equalSignsProp.GetArrayElementAtIndex(i);
                
                int selectedIndex = Mathf.Max(0, System.Array.IndexOf(availableKeys, keyProp.stringValue));
                int newIndex = EditorGUILayout.Popup(selectedIndex, availableKeys);

                keyProp.stringValue = availableKeys[newIndex];

                newLineProp.boolValue = EditorGUILayout.Toggle("New Line", newLineProp.boolValue, GUILayout.Width(200));
                equalSignProp.boolValue = EditorGUILayout.Toggle("Equal Sign", equalSignProp.boolValue, GUILayout.Width(200));

                // Remove button
                if (GUILayout.Button("X", GUILayout.Width(20)))
                {
                    keysProp.DeleteArrayElementAtIndex(i);
                    newLinesProp.DeleteArrayElementAtIndex(i);
                    equalSignsProp.DeleteArrayElementAtIndex(i);
                }
                EditorGUILayout.EndHorizontal();
            }
            if (GUILayout.Button("Add Matrix from Dictionary"))
            {
                int defaultIndex = 0;
                int arraySize = keysProp.arraySize;
                keysProp.InsertArrayElementAtIndex(keysProp.arraySize);
                SerializedProperty newKeyProp = keysProp.GetArrayElementAtIndex(keysProp.arraySize - 1);
                newKeyProp.stringValue = availableKeys[defaultIndex];

                newLinesProp.InsertArrayElementAtIndex(arraySize);
                SerializedProperty newLineProp = newLinesProp.GetArrayElementAtIndex(arraySize);
                newLineProp.boolValue = false;

                equalSignsProp.InsertArrayElementAtIndex(arraySize);
                SerializedProperty equalSignProp = equalSignsProp.GetArrayElementAtIndex(arraySize);
                equalSignProp.boolValue = false;
            }
        }

        EditorGUILayout.EndVertical();

        // Customised matrices column
        EditorGUILayout.BeginVertical(GUILayout.Width(EditorGUIUtility.currentViewWidth / 2 - 10));
        EditorGUILayout.LabelField("Customised/Calculated", EditorStyles.miniBoldLabel);

        for (int i = 0; i < customKeysProp.arraySize; i++)
        {
            EditorGUILayout.BeginHorizontal();
            SerializedProperty customKeyProp = customKeysProp.GetArrayElementAtIndex(i);
            customKeyProp.stringValue = EditorGUILayout.TextField(customKeyProp.stringValue);

            // Remove button
            if (GUILayout.Button("X", GUILayout.Width(20)))
            {
                customKeysProp.DeleteArrayElementAtIndex(i);
            }
            EditorGUILayout.EndHorizontal();
        }
        if (GUILayout.Button("Add Customised Matrix"))
        {
            customKeysProp.InsertArrayElementAtIndex(customKeysProp.arraySize);
            SerializedProperty newCustomKeyProp = customKeysProp.GetArrayElementAtIndex(customKeysProp.arraySize - 1);
            newCustomKeyProp.stringValue = "";
        }

        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        SerializedProperty Duration = serializedObject.FindProperty("Duration");
        EditorGUILayout.PropertyField(Duration);

        serializedObject.ApplyModifiedProperties();


    }
}

#endif