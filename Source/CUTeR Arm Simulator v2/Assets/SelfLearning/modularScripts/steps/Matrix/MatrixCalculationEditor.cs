using UnityEngine;
using UnityEditor;
using System.Linq;
#if UNITY_EDITOR

[CustomEditor(typeof(MatrixCalculation))]
public class MatrixCalculationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        MatrixCalculation calc = (MatrixCalculation)target;

        // Calculation mode dropdown
        SerializedProperty calculationProp = serializedObject.FindProperty("calculation");
        EditorGUILayout.PropertyField(calculationProp);

        // MatrixDictionary field
        SerializedProperty dictProp = serializedObject.FindProperty("dictionary");
        EditorGUILayout.PropertyField(dictProp);

        // Try to get the dictionary
        MatrixDictionary dict = dictProp.objectReferenceValue as MatrixDictionary;

        string[] matrixKeys = null;
        if (dict != null && dict.matrices != null && dict.matrices.Count > 0)
        {
            matrixKeys = dict.matrices
                .Select(m => string.IsNullOrEmpty(m.key) ? "<no key>" : m.key)
                .ToArray();
        }

        CalculationMode mode = (CalculationMode)calculationProp.enumValueIndex;

        // Matrix selection logic
        if (dict == null)
        {
            EditorGUILayout.HelpBox("Please assign a MatrixDictionary.", MessageType.Warning);
        }
        else if (matrixKeys == null || matrixKeys.Length == 0)
        {
            EditorGUILayout.HelpBox("The selected MatrixDictionary has no matrices.", MessageType.Warning);
        }
        else
        {
            // Matrix A selection
            int matrixAIndex = Mathf.Max(0, System.Array.IndexOf(matrixKeys, calc.matrixAKey));
            int newMatrixAIndex = matrixAIndex;

            // Matrix B selection (for binary operations)
            int matrixBIndex = Mathf.Max(0, System.Array.IndexOf(matrixKeys, calc.matrixBKey));
            int newMatrixBIndex = matrixBIndex;

            if (mode == CalculationMode.Addition || mode == CalculationMode.Multiplication)
            {
                EditorGUILayout.LabelField("Matrix A and Matrix B to use:");

                newMatrixAIndex = EditorGUILayout.Popup("Matrix A", matrixAIndex, matrixKeys);
                newMatrixBIndex = EditorGUILayout.Popup("Matrix B", matrixBIndex, matrixKeys);

                // Save changes
                calc.matrixAKey = matrixKeys[newMatrixAIndex];
                calc.matrixBKey = matrixKeys[newMatrixBIndex];
            }
            else // Transpose, Inverse, etc.
            {
                EditorGUILayout.LabelField("Matrix to use:");
                newMatrixAIndex = EditorGUILayout.Popup("Matrix", matrixAIndex, matrixKeys);
                calc.matrixAKey = matrixKeys[newMatrixAIndex];
                calc.matrixBKey = ""; // Clear B if not used
            }
        }

        // Store result and result key
        SerializedProperty storeProp = serializedObject.FindProperty("storeCalculatedMatrix");
        EditorGUILayout.PropertyField(storeProp);

        if (storeProp.boolValue)
        {
            SerializedProperty resultKeyProp = serializedObject.FindProperty("resultMatrixKey");
            EditorGUILayout.PropertyField(resultKeyProp);
            SerializedProperty displayProp = serializedObject.FindProperty("displayResultMatrix");
            EditorGUILayout.PropertyField(displayProp);
            if (displayProp.boolValue)
            {
                SerializedProperty Duration = serializedObject.FindProperty("Duration");
                EditorGUILayout.PropertyField(Duration);
            }
        }

        serializedObject.ApplyModifiedProperties();
    }
}

#endif