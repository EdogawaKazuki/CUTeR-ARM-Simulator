using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public enum MatrixType
{
    Nuermical,
    Symbolic,
    JointSpace,
    TaskSpace
}

[CreateAssetMenu(menuName = "LessonSteps/Matrix/MatrixDictionary")]
public class MatrixDictionary : Libraries
{
    [System.Serializable]
    public class NamedMatrix
    {
        public string key;
        public int rows;
        public int cols;
        public float[] data;
        public string[] symbol;
        public MatrixType mode;
        public bool displayMatrix;
        public bool newLine;
        public float GetValue(int row, int col) => data[row * cols + col];
        public string GetString(int row, int col) => symbol[row * cols + col];
        public void SetValue(int row, int col, float value) => data[row * cols + col] = value;
        public void SetString(int row, int col, string value) => symbol[row * cols + col] = value;

    }

    public List<NamedMatrix> matrices = new List<NamedMatrix>();

    public NamedMatrix GetMatrix(string key) => matrices.Find(m => m.key == key);

    public void SetMatrix(string key, NamedMatrix newMatrix)
    {
        var entry = matrices.Find(m => m.key == key);
        if (entry != null)
        {
            entry.rows = newMatrix.rows;
            entry.cols = newMatrix.cols;
            entry.data = new float[newMatrix.data.Length];
            entry.symbol = new string[newMatrix.data.Length];
            newMatrix.data.CopyTo(entry.data, 0);
            newMatrix.symbol.CopyTo(entry.symbol, 0);
            
        }
        else
        {
            // Create a new NamedMatrix and add it
            NamedMatrix newEntry = new NamedMatrix
            {
                key = key,
                rows = newMatrix.rows,
                cols = newMatrix.cols,
                mode = 0,
                data = new float[newMatrix.data.Length],
                symbol = new string[newMatrix.data.Length]
            };
            newMatrix.data.CopyTo(newEntry.data, 0);
            newMatrix.symbol.CopyTo(newEntry.symbol, 0);
            matrices.Add(newEntry);
        }
    }
}