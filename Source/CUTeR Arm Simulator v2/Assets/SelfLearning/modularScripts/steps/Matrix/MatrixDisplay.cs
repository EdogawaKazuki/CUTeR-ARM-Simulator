using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[CreateAssetMenu(menuName = "LessonSteps/Matrix/MatrixDisplay")]
public class MatrixDisplay : LessonStep
{
    public MatrixDictionary matrixDictionary;
    public bool keepPreviousLatex = false;
    public List<string> matrixKeys = new List<string>();
    public List<string> customisedKeys = new List<string>();
    public List<bool> newLines = new List<bool>();
    public List<bool> equalSigns = new List<bool>();
    // public float displayDurations;
    private float updateInterval = 0.02f;

    public override IEnumerator Execute(LessonContext ctx)
    {
        yield return ctx.visuals.SetLatexStatus(true);
        string previousLatex = ctx.visuals.GetLatex();
        System.Text.StringBuilder latexBuilder = new System.Text.StringBuilder();

        float elapsedTime = 0f;
        while (elapsedTime < Duration)
        {
            latexBuilder.Clear();
            if (keepPreviousLatex)
            {
                latexBuilder.AppendLine(previousLatex);
                latexBuilder.AppendLine(); // Extra space between previous and new
            }
            int keyIndex = 0;
            latexBuilder.AppendLine(@"\[");

            foreach (var key in matrixKeys)
            {
                Debug.Log("Executing MatrixDisplay with matrix key: " + key);
                var matrix = matrixDictionary.GetMatrix(key);
                if (matrix == null)
                {
                    Debug.LogWarning($"Matrix key '{key}' not found in dictionary.");
                    continue;
                }

                // latexBuilder.AppendLine($@"\textbf{{{matrix.key}}}:\quad");
                if (newLines[keyIndex])
                    latexBuilder.AppendLine(@"\]\["); // Extra space between matrices
                if (equalSigns[keyIndex++])
                    latexBuilder.AppendLine(@"="); // Extra space between matrices

                latexBuilder.AppendLine(@"\begin{bmatrix}");

                for (int r = 0; r < matrix.rows; r++)
                {
                    for (int c = 0; c < matrix.cols; c++)
                    {
                        if (matrix.mode == MatrixType.Nuermical)
                        {
                            latexBuilder.Append(matrix.GetValue(r, c).ToString());
                        }
                        else if (matrix.mode == MatrixType.TaskSpace)
                        {
                            List<float> taskSpaceStatus = ctx.visuals.GetTaskSpaceStatus();
                            latexBuilder.Append(taskSpaceStatus[r].ToString());
                        }
                        else if (matrix.mode == MatrixType.TaskSpace)
                        {
                            List<float> jointSpaceStatus = ctx.visuals.GetJointSpaceStatus();
                            latexBuilder.Append(jointSpaceStatus[r].ToString());
                        }
                        else
                            latexBuilder.Append(matrix.GetString(r, c));
                        if (c < matrix.cols - 1)
                            latexBuilder.Append(" & "); // Separate columns
                    }
                    if (r < matrix.rows - 1)
                        latexBuilder.Append(@" \\"); // Separate rows
                    latexBuilder.AppendLine(); // Optional: newline for readability
                }

                latexBuilder.AppendLine(@"\end{bmatrix}");
            }
            latexBuilder.AppendLine(@"\]");

            foreach (var key in customisedKeys)
            {
                Debug.Log("Executing MatrixDisplay with matrix key: " + key);
                var matrix = matrixDictionary.GetMatrix(key);
                if (matrix == null)
                {
                    Debug.LogWarning($"Matrix key '{key}' not found in dictionary.");
                    continue;
                }

                latexBuilder.AppendLine($@"\textbf{{{matrix.key}}}:\quad");
                latexBuilder.AppendLine(@"\[");
                latexBuilder.AppendLine(@"\begin{bmatrix}");

                for (int r = 0; r < matrix.rows; r++)
                {
                    for (int c = 0; c < matrix.cols; c++)
                    {
                        if (matrix.mode == MatrixType.Nuermical)
                            latexBuilder.Append(matrix.GetValue(r, c).ToString());
                        else
                            latexBuilder.Append(matrix.GetString(r, c));
                        if (c < matrix.cols - 1)
                            latexBuilder.Append(" & "); // Separate columns
                    }
                    if (r < matrix.rows - 1)
                        latexBuilder.Append(@" \\"); // Separate rows
                    latexBuilder.AppendLine(); // Optional: newline for readability
                }

                latexBuilder.AppendLine(@"\end{bmatrix}");
                latexBuilder.AppendLine(@"\]");
                latexBuilder.AppendLine(); // Extra space between matrices
            }

            // Set the LaTeX for all matrices at once
            ctx.visuals.SetLatex(latexBuilder.ToString());
            // Wait for the update interval and increment elapsed time
            yield return new WaitForSeconds(updateInterval);
            elapsedTime += updateInterval;
        }


        // yield return new WaitForSeconds(Duration);
        yield return ctx.visuals.SetLatexStatus(false);
    }
}