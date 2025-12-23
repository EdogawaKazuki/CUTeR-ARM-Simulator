using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TrajectoryType
{
    Linear,
    Quadratic,
    Cubic
    
}

public enum PathType
{
    Straight,
    Quadratic,
    Circular
}


[CreateAssetMenu(menuName = "LessonSteps/RobotArm/MovementTrajectory")]
public class Movement_Trajectory : LessonStep
{
    public TrajectoryType trajectoryType = TrajectoryType.Linear;
    public PathType pathType = PathType.Straight;
    public Vector3 CenterPoint;
    public float radius;
    public Vector3 initialpos;
    public Vector3 targetPosition;
    public Vector3 quadraticControlPoint = new Vector3(0, 1, 0);
    public bool displayVectors = true;
    public float targetlerp = 1.0f;
    private float lerp = 0.0f;

    public bool showGraph = true;

    private static Vector3 GetQuadraticBezierPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
    {
        return Mathf.Pow(1 - t, 2) * p0 + 2 * (1 - t) * t * p1 + Mathf.Pow(t, 2) * p2;
    }

    private static Vector3 GetCircularPoint(Vector3 center, Vector3 startPoint, Vector3 EndPoint, float t)
    {
        Vector3 u = (startPoint - center).normalized;
        Vector3 v = (EndPoint - center).normalized;

        // find the angle betweeen the 2 vectors 

        float angle = Mathf.Acos(Mathf.Clamp(Vector3.Dot(u, v), -1f, 1f));

        // find the unit vector n normal to the plane rotation

        Vector3 n = Vector3.Cross(u, v).normalized;

        // caluclate theta with the lerp t and angle 

        float theta = angle * t;

        // calculate the rotation around the normal vector n by theta degree

        Quaternion rotated = Quaternion.AngleAxis(theta * Mathf.Rad2Deg, n);

        // keep the radius

        float radius = (startPoint - center).magnitude;

        // return the new point 
        
        return center + rotated * (radius * u);

    }

    public override IEnumerator Execute(LessonContext ctx)
    {
        int num_frames = Mathf.RoundToInt(Duration / Time.fixedDeltaTime);
        List<List<float>> taskTraj = new List<List<float>>();

        for (int i = 0; i < num_frames; i++)
        {
            float t = i / (float)num_frames;
            Vector3 position = initialpos;
            switch (trajectoryType)
            {
                case TrajectoryType.Linear:
                    {
                        Debug.Log("Linear trajectory selected.");
                        lerp = targetlerp / (num_frames - 1) * i;
                        break;
                    }


                case TrajectoryType.Quadratic:
                    {
                        lerp = targetlerp / ((num_frames - 1) * (num_frames - 1)) * i * i;
                        break;
                    }


                case TrajectoryType.Cubic:
                    {
                        Debug.Log("Cubic trajectory selected.");
                        lerp = ((3.0f * targetlerp * i * i) / ( (num_frames - 1) * (num_frames - 1))) * (1.0f - ((2.0f * i) / (3.0f * (num_frames - 1))));
                        break;
                    }



            }
            float x = position.x;
            float y = position.y;
            float z = position.z;

            switch (pathType)
            {
                case PathType.Straight:
                    Debug.Log("Straight path selected.");
                    Debug.Log($"initialpos: {initialpos}, targetPosition: {targetPosition}, lerp: {lerp}");
                    x = Mathf.Lerp(initialpos.x, targetPosition.x, lerp);
                    y = Mathf.Lerp(initialpos.y, targetPosition.y, lerp);
                    z = Mathf.Lerp(initialpos.z, targetPosition.z, lerp);
                    break;
                case PathType.Quadratic:
                    Vector3 QuadPos = GetQuadraticBezierPoint(initialpos, quadraticControlPoint, targetPosition, lerp);
                    Debug.Log($"initialpos: {initialpos}, targetPosition: {targetPosition}, lerp: {lerp}");
                    x = QuadPos.x;
                    y = QuadPos.y;
                    z = QuadPos.z;
                    break;
                case PathType.Circular:
                    Vector3 CircularPos = GetCircularPoint(CenterPoint, initialpos, targetPosition, lerp);
                    x = CircularPos.x;
                    y = CircularPos.y;
                    z = CircularPos.z;
                    break;
            }

            List<float> taskSpacePosition = new List<float> { x, y, z, -Mathf.PI / 2, 0, 0 };
            taskTraj.Add(taskSpacePosition);
            Debug.Log($"Frame {i}: Position = {taskSpacePosition[0]}, {taskSpacePosition[1]}, {taskSpacePosition[2]}");


        }
        Debug.Log("Task Trajectory: " + taskTraj.Count + " frames");
        var jointTraj = ctx.generalRobot.SolveTaskSpaceTrajectories(taskTraj);
        Debug.Log("Joint Trajectory: " + jointTraj.Count + " frames");
        yield return ctx.visuals.DrawTrajectory(taskTraj);
        Debug.Log("Drawing trajectory");
        yield return ctx.visuals.DisplayTraj();
        Debug.Log("Executing trajectory");
        yield return ctx.generalRobot.ExecuteTrajectory(jointTraj);
        yield return ctx.visuals.ClearPoints();

    }


}
