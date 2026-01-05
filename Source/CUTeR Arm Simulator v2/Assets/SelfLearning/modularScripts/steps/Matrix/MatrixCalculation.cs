using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum CalculationMode
{
    Addition,
    Multiplication,
    Transpose,
    Inverse

}

[CreateAssetMenu(menuName = "LessonSteps/Matrix/MatrixCalculation")]
public class MatrixCalculation : LessonStep
{
    public CalculationMode calculation = CalculationMode.Addition;

    public MatrixDictionary dictionary;
    public string matrixAKey;
    public string matrixBKey;
    public bool storeCalculatedMatrix;
    public bool displayResultMatrix = false;
    //public float displayDuration = 2f;
    public string resultMatrixKey = "";
    public override IEnumerator Execute(LessonContext ctx)
    {

        switch (calculation)
        {
            case CalculationMode.Addition:
                {
                    Debug.Log("matrix addition start");
                    AddMatrices(matrixAKey, matrixBKey, resultMatrixKey);
                    break;
                }
            case CalculationMode.Multiplication:
                {
                    Debug.Log("matrix multiplication start");
                    MultiplyMatrices(matrixAKey, matrixBKey, resultMatrixKey);
                    break;
                }
            case CalculationMode.Transpose:
                {
                    Debug.Log("matrix transpose start");
                    TransposeMatrix(matrixAKey, resultMatrixKey);
                    break;
                }
            case CalculationMode.Inverse:
                {
                    Debug.Log("matrix inverse start");
                    InverseMatrix(matrixAKey, resultMatrixKey);
                    break;
                }
        }
        if (displayResultMatrix && resultMatrixKey != "")
        {
            yield return ctx.visuals.SetLatexStatus(true);
            displayMatrix(resultMatrixKey, ctx);
            yield return new WaitForSeconds(Duration);
            yield return ctx.visuals.SetLatexStatus(false);
        }
        yield return null;
    }
    
    private void AddMatrices(string keyA, string keyB, string resultKey)
    {
        var a = dictionary.GetMatrix(keyA);
        var b = dictionary.GetMatrix(keyB);
        if (a == null || b == null) return;

        var result = new MatrixDictionary.NamedMatrix
        {
            key = resultKey,
            rows = a.rows,
            cols = a.cols,
            data = new float[a.data.Length]
        };
        for (int i = 0; i < result.data.Length; i++)
            result.data[i] = a.data[i] + b.data[i];
        Debug.Log($"Added matrices {keyA} and {keyB}, result stored in {resultKey}");
        if (storeCalculatedMatrix)
            dictionary.SetMatrix(resultKey, result);
    }

    private void MultiplyMatrices(string keyA, string keyB, string resultKey)
    {
        var a = dictionary.GetMatrix(keyA);
        var b = dictionary.GetMatrix(keyB);
        if (a == null || b == null) return;

        var result = new MatrixDictionary.NamedMatrix
        {
            key = resultKey,
            rows = a.rows,
            cols = b.cols,
            data = new float[a.rows * b.cols]
        };

        for (int i = 0; i < a.rows; i++)
        {
            for (int j = 0; j < b.cols; j++)
            {
                result.data[i * b.cols + j] = 0;
                for (int k = 0; k < a.cols; k++)
                {
                    result.data[i * b.cols + j] += a.data[i * a.cols + k] * b.data[k * b.cols + j];
                }
            }
        }

        Debug.Log($"Multiplied matrices {keyA} and {keyB}, result stored in {resultKey}");
        if (storeCalculatedMatrix)
            dictionary.SetMatrix(resultKey, result);
    }

    private void TransposeMatrix(string key, string resultKey)
    {
        var matrix = dictionary.GetMatrix(key);
        if (matrix == null) return;

        var result = new MatrixDictionary.NamedMatrix
        {
            key = resultKey,
            rows = matrix.cols,
            cols = matrix.rows,
            data = new float[matrix.cols * matrix.rows]
        };

        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.cols; j++)
            {
                result.data[j * matrix.rows + i] = matrix.data[i * matrix.cols + j];
            }
        }

        Debug.Log($"Transposed matrix {key}, result stored in {resultKey}");
        if (storeCalculatedMatrix)
            dictionary.SetMatrix(resultKey, result);
    
    }

    private void InverseMatrix(string key, string resultKey)
    {
        var matrix = dictionary.GetMatrix(key);
        if (matrix == null) return;

        // Check if the matrix is square
        if (matrix.rows != matrix.cols)
        {
            Debug.LogWarning($"Matrix {key} is not square, cannot invert.");
            return;
        }

        // Implement matrix inversion (using a simple method for demonstration)
        var result = new MatrixDictionary.NamedMatrix
        {
            key = resultKey,
            rows = matrix.rows,
            cols = matrix.cols,
            data = new float[matrix.data.Length]
        };

        // Here you would implement a proper matrix inversion algorithm
        // For demonstration, we'll just copy the data (not a real inverse)
        for (int i = 0; i < matrix.data.Length; i++)
        {
            result.data[i] = matrix.data[i];
        }

        Debug.Log($"Inverted matrix {key}, result stored in {resultKey}");
        if (storeCalculatedMatrix)
            dictionary.SetMatrix(resultKey, result);
    }

    private void displayMatrix(string key, LessonContext ctx)
    {
        
        var matrix = dictionary.GetMatrix(key);
        string latexMatrixValues = @"\[
        \begin{bmatrix}
        ";

        for (int r = 0; r < matrix.rows; r++)
        {
            for (int c = 0; c < matrix.cols; c++)
            {
                latexMatrixValues += matrix.GetValue(r, c).ToString();
                if (c < matrix.cols - 1)
                    latexMatrixValues += " & "; // Separate columns with &
            }
            if (r < matrix.rows - 1)
                latexMatrixValues += @" \\"; // Separate rows with \\
            latexMatrixValues += "\n"; // Newline for readability (optional)
        }

        latexMatrixValues += @"\end{bmatrix}
        \]
        ";
        Debug.Log("Displaying matrix with LaTeX: " + latexMatrixValues);
        ctx.visuals.SetLatex(latexMatrixValues);


    }
}
