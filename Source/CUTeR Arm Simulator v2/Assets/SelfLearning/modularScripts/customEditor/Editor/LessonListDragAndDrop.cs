using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class LessonListDragAndDrop
{
    System.Action<LessonStep, int> onStepSelected;
    System.Action<int> onStepRemoveRequested;
    Vector2 scroll;
    int dragFromIndex = -1;
    int dragToIndex = -1;
    bool dragInsertAfter = false;

    public LessonListDragAndDrop(
        System.Action<LessonStep, int> onStepSelected,
        System.Action<int> onStepRemoveRequested
    )
    {
        this.onStepSelected = onStepSelected;
        this.onStepRemoveRequested = onStepRemoveRequested;
    }

    public void Draw(ScriptableObject lesson, LessonStep currentSelected, Rect windowRect)
    {
        List<LessonStep> lesson_steps = null;
        var stepsField = lesson?.GetType().GetField("steps");
        if (stepsField == null || stepsField.FieldType != typeof(List<LessonStep>))
        {
            EditorGUILayout.HelpBox("Assigned LessonStep does not contain a valid 'steps' field of type List<LessonStep>.", MessageType.Error);
            return;
        }
        lesson_steps = stepsField.GetValue(lesson) as List<LessonStep>;
        // assign empty list if null
        if (lesson_steps == null) return;

        float rowHeight = 20f;
        int stepToRemove = -1;
        Event evt = Event.current;

        scroll = EditorGUILayout.BeginScrollView(scroll);

        Rect scrollRect = GUILayoutUtility.GetRect(0, lesson_steps.Count * rowHeight, GUILayout.ExpandWidth(true));
        float y = scrollRect.y;

        int insertIndex = -1;

        for (int i = 0; i < lesson_steps.Count; i++)
        {
            var step = lesson_steps[i];
            Rect rowRect = new Rect(scrollRect.x, y, scrollRect.width, rowHeight);
            const float checkW = 18f;
            Rect checkRect = new Rect(rowRect.x + 2, rowRect.y + 2, checkW, rowRect.height - 4);
            bool newActive = GUI.Toggle(checkRect, step.isActive, GUIContent.none);
            if (newActive != step.isActive)
            {
                // allow Undo/Redo
                Undo.RecordObject(step, "Toggle Step Active");
                // actually apply the change
                step.isActive = newActive;
                // mark the step dirty so Unity saves it
                EditorUtility.SetDirty(step);
            }

            // Drag highlight (yellow) when dragging this row
            if (dragFromIndex == i && DragAndDrop.GetGenericData("LessonStep") != null)
                EditorGUI.DrawRect(rowRect, new Color(0.2f, 0.7f, 1f, 1f)); // yellow
            // Selection highlight (blue) for selected row
            else if (step == currentSelected)
                EditorGUI.DrawRect(rowRect, new Color(0.3f, 0.6f, 1f, 0.33f)); // visible blue

            // Draw drop indicator (blue line) if this is the drop target
            if (DragAndDrop.GetGenericData("LessonStep") != null && rowRect.Contains(evt.mousePosition))
            {
                float relY = evt.mousePosition.y - rowRect.y;
                dragInsertAfter = relY > rowRect.height / 2f;
                if (!dragInsertAfter)
                    EditorGUI.DrawRect(new Rect(rowRect.x, rowRect.y, rowRect.width, 2), new Color(0.2f, 0.7f, 1f, 1f));
                else
                    EditorGUI.DrawRect(new Rect(rowRect.x, rowRect.yMax - 2, rowRect.width, 2), new Color(0.2f, 0.7f, 1f, 1f));
                insertIndex = dragInsertAfter ? i + 1 : i;
            }

            // Draw Remove 'X' button (right side)
            Rect xRect = new Rect(rowRect.xMax - 26, rowRect.y + 2, 22, rowRect.height - 4);
            if (GUI.Button(xRect, "X"))
                stepToRemove = i;

            // Draw the label manually
            Rect labelRect = new Rect(rowRect.x + 4 + checkW, rowRect.y, rowRect.width - (checkW + 30), rowRect.height);

            GUIStyle labelStyle = EditorStyles.label;
            //EditorGUI.LabelField(labelRect, $"{step.GetType().Name}: {step.Description}  ⏱ {step.Duration:F2}s", labelStyle);

            // DIM ONLY THE LABEL when inactive
            var prevColor = GUI.contentColor;
            // inside the for-loop, right where you draw the label

            if (!step.isActive)
                GUI.contentColor = new Color(1f, 1f, 1f, 0.15f); // very dim

            try
            {
                EditorGUI.LabelField(
                    labelRect,
                    $"{step.GetType().Name}: {step.Description}  ⏱ {step.Duration:F2}s",
                    EditorStyles.label
                );
            }
            finally
            {
                GUI.contentColor = prevColor; // ALWAYS restore, even if something early-exits
            }


            // --- Manual event handling for select and drag ---
            bool inX = xRect.Contains(evt.mousePosition);
            bool inCheck = checkRect.Contains(evt.mousePosition);

            // Selection (single click)
            if (evt.type == EventType.MouseUp && rowRect.Contains(evt.mousePosition) && !inX && !inCheck)
            {
                onStepSelected?.Invoke(step, i);
                Selection.activeObject = step; // Show in Inspector
                evt.Use();
            }

            // Start drag (not on X)
            if (evt.type == EventType.MouseDown && rowRect.Contains(evt.mousePosition) && !inX && !inCheck)
            {
                dragFromIndex = i;
            }
            if (dragFromIndex == i && evt.type == EventType.MouseDrag)
            {
                DragAndDrop.PrepareStartDrag();
                DragAndDrop.objectReferences = new Object[0];
                DragAndDrop.SetGenericData("LessonStep", dragFromIndex);
                DragAndDrop.StartDrag("Move Step");
                evt.Use();
            }

            y += rowHeight;
        }

        // Special case: allow drop at end of list
        if (DragAndDrop.GetGenericData("LessonStep") != null && lesson_steps.Count > 0)
        {
            Rect lastRect = new Rect(scrollRect.x, y - rowHeight, scrollRect.width, rowHeight);
            if (evt.mousePosition.y > lastRect.yMax)
            {
                // Draw blue line at the end
                EditorGUI.DrawRect(new Rect(lastRect.x, lastRect.yMax, lastRect.width, 2), new Color(0.2f, 0.7f, 1f, 1f));
                insertIndex = lesson_steps.Count;
                dragInsertAfter = true;
            }
        }

        // Handle drag events (move on drop)
        if (DragAndDrop.GetGenericData("LessonStep") != null && insertIndex != -1)
        {
            if (evt.type == EventType.DragUpdated)
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                evt.Use();
            }
            if (evt.type == EventType.DragPerform)
            {
                int fromIdx = (int)DragAndDrop.GetGenericData("LessonStep");
                int toIdx = insertIndex;
                if (fromIdx != toIdx && fromIdx + 1 != toIdx)
                {
                    Undo.RecordObject(lesson, "Perform Drag & Drop");
                    var temp = lesson_steps[fromIdx];
                    lesson_steps.RemoveAt(fromIdx);
                    if (fromIdx < toIdx) toIdx--;
                    lesson_steps.Insert(toIdx, temp);
                    EditorUtility.SetDirty(lesson);
                }
                DragAndDrop.AcceptDrag();
                DragAndDrop.SetGenericData("LessonStep", null);
                dragFromIndex = -1;
                dragToIndex = -1;
                evt.Use();
            }
        }

        // Reset dragFromIndex if mouse released or left window
        if (evt.type == EventType.MouseUp || evt.type == EventType.MouseLeaveWindow)
        {
            dragFromIndex = -1;
        }

        EditorGUILayout.EndScrollView();

        // Remove step if requested after layout
        if (stepToRemove != -1)
            onStepRemoveRequested?.Invoke(stepToRemove);
    }
}