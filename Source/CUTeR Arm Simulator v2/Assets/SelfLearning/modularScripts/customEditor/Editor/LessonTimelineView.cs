using UnityEngine;
using UnityEditor;
using System.Collections.Generic;


public class LessonTimelineView
{
    System.Action<LessonStep, int> onStepSelected;
    System.Action<int> onStepRemoveRequested;
    Vector2 scroll;
    DurationManager _durationManager = new DurationManager();

    // Drag-and-drop state
    int dragFromIndex = -1;
    int dragToIndex = -1;
    float dragHoverTime = 0f;
    int block_pixel_size = 260;
    int full_width = 0;

    public LessonTimelineView(
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
        if (lesson_steps == null)
        {
            stepsField.SetValue(lesson, new List<LessonStep>());
            lesson_steps = stepsField.GetValue(lesson) as List<LessonStep>;
        }


        EditorGUILayout.LabelField("Timeline", EditorStyles.boldLabel);

        // Show total duration
        float totalDuration = _durationManager.UpdateDurationRecursive(lesson);

        EditorGUILayout.LabelField($"Total Duration: {totalDuration:F2} sec");
        scroll = EditorGUILayout.BeginScrollView(scroll, GUILayout.Height(110));

        if (lesson is not GroupLessonStep)
        {
            full_width = lesson_steps.Count * block_pixel_size - (int) windowRect.width;
            EditorGUILayout.BeginHorizontal(GUILayout.MinWidth(full_width));

        }
        else
        {
            full_width = lesson_steps.Count * block_pixel_size - (int) windowRect.height;
            EditorGUILayout.BeginVertical(GUILayout.MinHeight(full_width));
        }
            


        int stepToRemove = -1;

        // Handle drag-and-drop index logic
        Rect[] stepRects = new Rect[lesson_steps.Count];
        Event evt = Event.current;

        GUIStyle customLabelStyle = new GUIStyle(EditorStyles.label);
        customLabelStyle.fontSize = 10;  // Set your desired size (pixels)
        for (int i = 0; i < lesson_steps.Count; i++)
        {
            var step = lesson_steps[i];
            GUIStyle style = new GUIStyle(EditorStyles.helpBox);
            if (step == currentSelected)
            {
                style.normal.background = MakeTex(2, 2, new Color(0.5f, 0.8f, 1f, 1f));
            }

            GUILayout.BeginVertical(style, GUILayout.Width(120), GUILayout.Height(60));
            Rect rect = GUILayoutUtility.GetRect(120, 60, GUILayout.ExpandHeight(false));
            stepRects[i] = rect;

            // Drag handle (visual)
            EditorGUI.LabelField(new Rect(rect.x + 2, rect.y + 2, 16, 16), EditorGUIUtility.IconContent("d_Grid.MoveTool"));

            Rect textRect = new Rect(rect.x + 20, rect.y + 2, rect.width - 24, 36);
            EditorGUI.LabelField(textRect, $"{step.Description}", customLabelStyle);

            // // Step Button
            // if (GUI.Button(new Rect(rect.x + 20, rect.y + 2, rect.width - 24, 36), $"{step.GetType().Name}\n{step.Description}"))
            // {
            //     Debug.Log($"Selected step {i}: {step.Description}");
            //     onStepSelected?.Invoke(step);
            // }

            // Duration field
            EditorGUI.LabelField(new Rect(rect.x + 20, rect.y + 38, rect.width - 24, 18), $"⏱ {step.Duration:F2}s", EditorStyles.miniLabel);

            // Remove Button
            if (GUI.Button(new Rect(rect.x + rect.width - 20, rect.y + 2, 18, 18), "X"))
            {
                stepToRemove = i;
            }

            // Drag events
            if (evt.type == EventType.MouseDown && rect.Contains(evt.mousePosition))
            {
                dragFromIndex = i;
                dragHoverTime = (float)EditorApplication.timeSinceStartup;
                evt.Use();
            }
            if (evt.type == EventType.MouseUp && dragFromIndex == i)
            {
                Debug.Log("Selected step " + i);
                onStepSelected?.Invoke(step, i);

            }
            // Auto-scroll logic during drag
            if (dragFromIndex != -1 && (evt.type == EventType.MouseDrag || evt.type == EventType.DragUpdated))
            {
                Debug.Log("mouse drag at " + evt.mousePosition + " scroll " + scroll + " rect " + windowRect);
                // Get ScrollView bounds
                float edgeThreshold = 100f; // Pixels from edge to trigger auto-scroll
                float scrollSpeed = 20f; // Pixels per second
                float scrollDelta = scrollSpeed * Time.deltaTime; // Smooth scroll based on time

                // Check if mouse is near left or right edge
                if (evt.mousePosition.x - scroll.x < edgeThreshold)
                {
                    // Scroll left
                    scroll.x = Mathf.Max(0, scroll.x - scrollDelta);
                }
                else if (evt.mousePosition.x - scroll.x > windowRect.width - edgeThreshold)
                {
                    // Scroll right
                    float maxScrollX = full_width; // Estimate max scroll
                    scroll.x = Mathf.Min(scroll.x + scrollDelta, maxScrollX);
                }
            }

            if (dragFromIndex == i && evt.type == EventType.MouseDrag)
            {
                // Start drag
                DragAndDrop.PrepareStartDrag();
                DragAndDrop.objectReferences = new Object[0];
                DragAndDrop.SetGenericData("LessonStep", i);
                DragAndDrop.StartDrag("Move Step");
                evt.Use();
            }
            // Visual for drag target
            if (DragAndDrop.GetGenericData("LessonStep") != null && rect.Contains(evt.mousePosition) && dragFromIndex != -1)
            {
                dragToIndex = i;
                EditorGUI.DrawRect(new Rect(rect.x, rect.y, rect.width, rect.height), new Color(0.2f, 0.7f, 1f, 0.2f));
                if (evt.type == EventType.DragUpdated)
                {
                    DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                    evt.Use();
                }
                if (evt.type == EventType.DragPerform)
                {
                    int fromIdx = (int)DragAndDrop.GetGenericData("LessonStep");
                    int toIdx = i;

                    if (fromIdx != toIdx)
                    {
                        // Move step
                        var temp = lesson_steps[fromIdx];
                        lesson_steps.RemoveAt(fromIdx);
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
            GUILayout.EndVertical();
            GUILayout.Space(6);
        }
        if (lesson is not GroupLessonStep)
            EditorGUILayout.EndHorizontal();
        else
            EditorGUILayout.EndVertical();
        
        EditorGUILayout.EndScrollView();

        // GUI.EndScrollView();

        // Timeline Bar (duration proportional)
        if (lesson_steps.Count > 0)
        {
            Rect timelineRect = GUILayoutUtility.GetRect(lesson_steps.Count * 120, 18, GUILayout.ExpandWidth(true));
            EditorGUI.DrawRect(timelineRect, new Color(0.8f, 0.8f, 0.8f, 1f));
            float x = timelineRect.x;
            float width = timelineRect.width;
            float accum = 0f;
            for (int i = 0; i < lesson_steps.Count; i++)
            {
                float norm = totalDuration > 0f ? Mathf.Max(0, lesson_steps[i].Duration) / totalDuration : 1f / lesson_steps.Count;
                float segWidth = width * norm;
                EditorGUI.DrawRect(new Rect(x, timelineRect.y, segWidth, timelineRect.height),
                    (i == dragToIndex) ? new Color(0.2f, 0.7f, 1f, 0.7f) :
                    ((lesson_steps[i] == currentSelected) ? new Color(0.2f, 0.5f, 1f, 0.4f) : new Color(0.4f, 0.7f, 0.9f, 0.3f))
                );
                // Draw step index
                EditorGUI.LabelField(new Rect(x + 2, timelineRect.y, segWidth - 4, timelineRect.height), $"{i + 1}", EditorStyles.centeredGreyMiniLabel);
                x += segWidth;
                accum += lesson_steps[i].Duration;
            }
            // Draw total duration label
            EditorGUI.LabelField(new Rect(timelineRect.xMax - 64, timelineRect.y, 60, timelineRect.height), $"{totalDuration:F2}s", EditorStyles.centeredGreyMiniLabel);
        }

        // Remove step if requested
        if (stepToRemove != -1)
            onStepRemoveRequested?.Invoke(stepToRemove);
    }

    // Helper: Solid color for selection
    Texture2D MakeTex(int w, int h, Color col)
    {
        Color[] pix = new Color[w * h];
        for (int i = 0; i < pix.Length; ++i) pix[i] = col;
        var result = new Texture2D(w, h);
        result.SetPixels(pix);
        result.Apply();
        return result;
    }
}