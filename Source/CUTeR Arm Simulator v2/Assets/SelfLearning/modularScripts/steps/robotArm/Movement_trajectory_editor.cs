using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR

[CustomEditor(typeof(Movement_Trajectory))]
public class Movement_Trajectory_Editor : Editor
{
    SerializedProperty trajectoryType;
    SerializedProperty pathType;
    SerializedProperty Duration;
    SerializedProperty amplitude;
    SerializedProperty radius;
    SerializedProperty initialpos;
    SerializedProperty targetPosition;
    SerializedProperty quadraticControlPoint;
    SerializedProperty displayVectors;
    SerializedProperty targetlerp;
    SerializedProperty CenterPoint;


    void OnEnable()
    {
        trajectoryType = serializedObject.FindProperty("trajectoryType");
        pathType = serializedObject.FindProperty("pathType");
        Duration = serializedObject.FindProperty("Duration");
        radius = serializedObject.FindProperty("radius");
        initialpos = serializedObject.FindProperty("initialpos");
        targetPosition = serializedObject.FindProperty("targetPosition");
        quadraticControlPoint = serializedObject.FindProperty("quadraticControlPoint");
        displayVectors = serializedObject.FindProperty("displayVectors");
        targetlerp = serializedObject.FindProperty("targetlerp");
        CenterPoint = serializedObject.FindProperty("CenterPoint");

    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(trajectoryType);
        EditorGUILayout.PropertyField(pathType);
        EditorGUILayout.PropertyField(Duration);
        EditorGUILayout.PropertyField(initialpos);
        EditorGUILayout.PropertyField(targetPosition);
        EditorGUILayout.PropertyField(targetlerp);

        // Show/hide fields based on PathType
        PathType pType = (PathType)pathType.enumValueIndex;
        switch (pType)
        {
            case PathType.Quadratic:
                EditorGUILayout.PropertyField(quadraticControlPoint, new GUIContent("Quadratic Control Point"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("showGraph"), new GUIContent("Show Curve Graph"));
                if (serializedObject.FindProperty("showGraph").boolValue)
                    DrawBezierGraph();
                break;
            case PathType.Circular:
                EditorGUILayout.PropertyField(CenterPoint, new GUIContent("CenterPoint"));
                EditorGUILayout.PropertyField(radius);
                break;
            case PathType.Straight:
                // No extra fields
                break;
        }

        // Show/hide fields based on TrajectoryType
        TrajectoryType tType = (TrajectoryType)trajectoryType.enumValueIndex;


        EditorGUILayout.PropertyField(displayVectors);

        serializedObject.ApplyModifiedProperties();
    }

    void DrawBezierGraph()
    {
        // Draw a 2D preview of the quadratic Bézier curve (X vs Y)
        Movement_Trajectory traj = (Movement_Trajectory)target;

        Rect rect = GUILayoutUtility.GetRect(240, 180);
        EditorGUI.DrawRect(rect, new Color(0.94f, 0.96f, 1f, 1f));
        Handles.BeginGUI();

        // Get points
        Vector3 p0 = traj.initialpos;
        Vector3 p1 = traj.quadraticControlPoint;
        Vector3 p2 = traj.targetPosition;

        // Determine bounds for mapping
        float minX = Mathf.Min(p0.x, p1.x, p2.x);
        float maxX = Mathf.Max(p0.x, p1.x, p2.x);
        float minY = Mathf.Min(p0.y, p1.y, p2.y);
        float maxY = Mathf.Max(p0.y, p1.y, p2.y);

        // Pad bounds for visual space
        float padX = (maxX - minX) * 0.15f + 0.01f;
        float padY = (maxY - minY) * 0.15f + 0.01f;
        minX -= padX; maxX += padX;
        minY -= padY; maxY += padY;

        // Bézier curve
        Vector2 prev = MapToRect(p0, minX, maxX, minY, maxY, rect);
        for (int i = 1; i <= 64; i++)
        {
            float t = i / 64f;
            Vector3 pt = Mathf.Pow(1 - t, 2) * p0 + 2 * (1 - t) * t * p1 + Mathf.Pow(t, 2) * p2;
            Vector2 curr = MapToRect(pt, minX, maxX, minY, maxY, rect);
            Handles.color = Color.blue;
            Handles.DrawLine(prev, curr);
            prev = curr;
        }

        // Draw control polygon
        Handles.color = Color.gray;
        Handles.DrawLine(MapToRect(p0, minX, maxX, minY, maxY, rect), MapToRect(p1, minX, maxX, minY, maxY, rect));
        Handles.DrawLine(MapToRect(p1, minX, maxX, minY, maxY, rect), MapToRect(p2, minX, maxX, minY, maxY, rect));

        // Draw points
        Handles.color = Color.green;
        Handles.DrawSolidDisc(MapToRect(p0, minX, maxX, minY, maxY, rect), Vector3.forward, 4);
        Handles.color = Color.red;
        Handles.DrawSolidDisc(MapToRect(p1, minX, maxX, minY, maxY, rect), Vector3.forward, 4);
        Handles.color = Color.green;
        Handles.DrawSolidDisc(MapToRect(p2, minX, maxX, minY, maxY, rect), Vector3.forward, 4);

        // Labels
        Handles.Label(MapToRect(p0, minX, maxX, minY, maxY, rect) + Vector2.down * 12, "Start");
        Handles.Label(MapToRect(p1, minX, maxX, minY, maxY, rect) + Vector2.up * 12, "Control");
        Handles.Label(MapToRect(p2, minX, maxX, minY, maxY, rect) + Vector2.down * 12, "End");

        Handles.EndGUI();
    }

    // Helper for mapping world position to graph rect
    Vector2 MapToRect(Vector3 pt, float minX, float maxX, float minY, float maxY, Rect rect)
    {
        float fx = Mathf.InverseLerp(minX, maxX, pt.x);
        float fy = Mathf.InverseLerp(minY, maxY, pt.y);
        return new Vector2(
            Mathf.Lerp(rect.xMin, rect.xMax, fx),
            Mathf.Lerp(rect.yMax, rect.yMin, fy) // y-flip for GUI
        );
    }

    // Scene view curve visualization (optional)
    void OnSceneGUI()
    {
        Movement_Trajectory traj = (Movement_Trajectory)target;
        if (traj.pathType == PathType.Quadratic)
        {
            Vector3 p0 = traj.initialpos;
            Vector3 p1 = traj.quadraticControlPoint;
            Vector3 p2 = traj.targetPosition;

            Handles.color = Color.cyan;
            Vector3 prev = p0;
            for (int i = 1; i <= 32; i++)
            {
                float t = i / 32f;
                Vector3 pt = Mathf.Pow(1 - t, 2) * p0 + 2 * (1 - t) * t * p1 + Mathf.Pow(t, 2) * p2;
                Handles.DrawLine(prev, pt);
                prev = pt;
            }
            Handles.color = Color.gray;
            Handles.DrawLine(p0, p1);
            Handles.DrawLine(p1, p2);
            Handles.SphereHandleCap(0, p0, Quaternion.identity, 0.05f, EventType.Repaint);
            Handles.SphereHandleCap(0, p1, Quaternion.identity, 0.05f, EventType.Repaint);
            Handles.SphereHandleCap(0, p2, Quaternion.identity, 0.05f, EventType.Repaint);
        }
    }
}
#endif