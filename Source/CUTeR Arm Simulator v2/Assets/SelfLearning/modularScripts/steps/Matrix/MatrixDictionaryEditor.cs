using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
#if UNITY_EDITOR

[CustomEditor(typeof(MatrixDictionary))]
public class MatrixDictionaryEditor : Editor
{
    private MatrixDictionary matrixDict;

    private List<bool> foldouts = new List<bool>();

    private void OnEnable()
    {
        matrixDict = (MatrixDictionary)target;
        // Ensure foldouts list matches matrix count
        while (foldouts.Count < matrixDict.matrices.Count) foldouts.Add(false);
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(serializedObject.FindProperty("Description"), new GUIContent("Description"));

        EditorGUILayout.LabelField("Matrix Dictionary", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        // Add Matrix Button
        if (GUILayout.Button("Add Matrix"))
        {
            matrixDict.matrices.Add(new MatrixDictionary.NamedMatrix()
            {
                key = "Matrix_" + matrixDict.matrices.Count,
                rows = 2,
                cols = 2,
                mode = 0,
                data = new float[4],
                symbol = new string[4]
            });
            foldouts.Add(true);
        }

        for (int i = 0; i < matrixDict.matrices.Count; i++)
        {
            var matrix = matrixDict.matrices[i];

            // Ensure foldouts list is synced
            while (foldouts.Count <= i) foldouts.Add(false);

            EditorGUILayout.BeginVertical("box");

            // Foldout for each matrix
            foldouts[i] = EditorGUILayout.Foldout(foldouts[i], matrix.key, true);

            if (foldouts[i])
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Key", GUILayout.Width(40));
                matrix.key = EditorGUILayout.TextField(matrix.key);
                if (GUILayout.Button("Remove", GUILayout.Width(60)))
                {
                    matrixDict.matrices.RemoveAt(i);
                    foldouts.RemoveAt(i);
                    EditorGUILayout.EndHorizontal();
                    EditorGUILayout.EndVertical();
                    break;
                }
                EditorGUILayout.EndHorizontal();

                // Matrix Size Controls
                int oldRows = matrix.rows;
                int oldCols = matrix.cols;

                EditorGUILayout.BeginHorizontal();
                matrix.rows = Mathf.Max(1, EditorGUILayout.IntField("Rows", matrix.rows));
                matrix.cols = Mathf.Max(1, EditorGUILayout.IntField("Cols", matrix.cols));
                EditorGUI.BeginChangeCheck();
                matrix.mode = (MatrixType) EditorGUILayout.EnumPopup("Matrix Type", matrix.mode);
                if (EditorGUI.EndChangeCheck())
                {
                    if (matrix.mode == MatrixType.JointSpace || matrix.mode == MatrixType.TaskSpace)
                    {
                        matrix.rows = 6;
                        matrix.cols = 1;
                    }
                }
                matrix.newLine = EditorGUILayout.Toggle("New Line", matrix.newLine);

                EditorGUILayout.EndHorizontal();

                // Resize data array if necessary
                if (matrix.rows != oldRows || matrix.cols != oldCols || matrix.data == null)
                {
                    float[] newData = new float[matrix.rows * matrix.cols];
                    string[] newSymbol = new string[matrix.rows * matrix.cols];
                    for (int r = 0; r < Mathf.Min(matrix.rows, oldRows); r++)
                        for (int c = 0; c < Mathf.Min(matrix.cols, oldCols); c++)
                        {
                            newData[r * matrix.cols + c] = matrix.data[r * oldCols + c];
                            newSymbol[r * matrix.cols + c] = matrix.symbol[r * oldCols + c];

                        }
                    matrix.data = newData;
                    matrix.symbol = newSymbol;
                }

                // Draw Matrix Grid
                EditorGUILayout.LabelField("Values:");
                for (int r = 0; r < matrix.rows; r++)
                {
                    EditorGUILayout.BeginHorizontal();
                    for (int c = 0; c < matrix.cols; c++)
                    {
                        int dataIndex = r * matrix.cols + c;
                        if (matrix.data.Length > dataIndex)
                        {
                            if (matrix.mode == 0)
                                matrix.data[dataIndex] = EditorGUILayout.FloatField(matrix.data[dataIndex], GUILayout.MaxWidth(60));
                            else
                                matrix.symbol[dataIndex] = EditorGUILayout.TextField(matrix.symbol[dataIndex], GUILayout.MaxWidth(60));
                        }
                    }
                    EditorGUILayout.EndHorizontal();
                }
            }

            EditorGUILayout.EndVertical();
            EditorGUILayout.Space();
        }

        // Save changes
        if (GUI.changed)
        {
            EditorUtility.SetDirty(matrixDict);
        }

        serializedObject.ApplyModifiedProperties();
    }
}

#endif