using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum MovementType
{
    MoveAlongX,
    MoveAlongY,
    MoveAlongZ,
    RotateX,
    RotateY,
    RotateZ
}

[CreateAssetMenu(menuName = "LessonSteps/RobotArm/Movement")]
public class MovementStep : LessonStep
{
    [Header("Assign the direction of movement or rotation")]
    public MovementType movement = MovementType.MoveAlongX;
    public float amplitude;
    public Vector3 initialpos;

    public override IEnumerator Execute(LessonContext ctx)
    {
        int num_frames = Mathf.RoundToInt(Duration / Time.fixedDeltaTime);
        Debug.Log("Executing MovementStep with " + num_frames + " frames.");

        switch (movement)
        {
            case MovementType.MoveAlongX:
                {
                    List<List<float>> taskTraj = new List<List<float>>();
                    for (int i = 0; i < num_frames; i++)
                    {
                        float x = amplitude * Mathf.Sin(((i) * 2 * Mathf.PI) / (num_frames - 1)) + initialpos.x;
                        List<float> taskSpacePosition = new List<float> { x, initialpos.y, initialpos.z, -Mathf.PI / 2, 0, 0 };
                        taskTraj.Add(taskSpacePosition);
                    }

                        Debug.Log("Executing MoveAlongX trajectory with " + num_frames + " frames.");

                        var jointTraj = ctx.generalRobot.SolveTaskSpaceTrajectories(taskTraj);
                        Debug.Log("Executing MoveAlongX joint trajectory with " + jointTraj.Count + " frames.");
                        yield return ctx.visuals.DrawTrajectory(taskTraj);
                        Debug.Log("Drawing trajectory for MoveAlongX.");
                        yield return ctx.visuals.DisplayTraj();
                        Debug.Log("Executing MoveAlongX trajectory.");
                        yield return ctx.generalRobot.ExecuteTrajectory(jointTraj);
                        yield return ctx.visuals.ClearPoints();
                        break;
                    }
                

            case MovementType.MoveAlongY:
                        {
                            List<List<float>> taskTraj = new List<List<float>>();
                            for (int i = 0; i < num_frames; i++)
                            {
                                float y = amplitude * Mathf.Sin(((i) * 2 * Mathf.PI) / (num_frames - 1)) + initialpos.y;
                                List<float> taskSpacePosition = new List<float> { initialpos.x, y, initialpos.z, -Mathf.PI / 2, 0, 0 };
                                taskTraj.Add(taskSpacePosition);
                            }
                            var jointTraj = ctx.generalRobot.SolveTaskSpaceTrajectories(taskTraj);
                            yield return ctx.visuals.DrawTrajectory(taskTraj);
                            yield return ctx.visuals.DisplayTraj();
                            yield return ctx.generalRobot.ExecuteTrajectory(jointTraj);
                            yield return ctx.visuals.ClearPoints();
                            break;
                        }

                    case MovementType.MoveAlongZ:
                        {
                            List<List<float>> taskTraj = new List<List<float>>();
                            for (int i = 0; i < num_frames; i++)
                            {
                                float z = amplitude * Mathf.Sin(((i) * 2 * Mathf.PI) / (num_frames - 1)) + initialpos.z;
                                List<float> taskSpacePosition = new List<float> { initialpos.x, initialpos.y, z, -Mathf.PI / 2, 0, 0 };
                                taskTraj.Add(taskSpacePosition);
                            }
                            var jointTraj = ctx.generalRobot.SolveTaskSpaceTrajectories(taskTraj);
                            yield return ctx.visuals.DrawTrajectory(taskTraj);
                            yield return ctx.visuals.DisplayTraj();
                            yield return ctx.generalRobot.ExecuteTrajectory(jointTraj);
                            yield return ctx.visuals.ClearPoints();
                            break;
                        }

                    case MovementType.RotateX:
                        {
                            List<List<float>> taskTraj = new List<List<float>>();
                            for (int i = 0; i < num_frames; i++)
                            {
                                float angle = i * (2 * Mathf.PI) / (num_frames - 1);
                                float alpha = amplitude * Mathf.Sin(angle);
                                List<float> taskSpacePosition = new List<float> { initialpos.x, initialpos.y, initialpos.z, alpha - Mathf.PI / 2, 0, 0 };
                                taskTraj.Add(taskSpacePosition);
                            }
                            var jointTraj = ctx.generalRobot.SolveTaskSpaceTrajectories(taskTraj);
                            yield return ctx.generalRobot.ExecuteTrajectory(jointTraj);
                            break;
                        }

                    case MovementType.RotateY:
                        {
                            List<List<float>> taskTraj = new List<List<float>>();
                            for (int i = 0; i < num_frames; i++)
                            {
                                float angle = i * (2 * Mathf.PI) / (num_frames-1);
                                float alpha = amplitude * Mathf.Sin(angle);
                                List<float> taskSpacePosition = new List<float> { initialpos.x, initialpos.y, initialpos.z, -Mathf.PI / 2, alpha, 0 };
                                taskTraj.Add(taskSpacePosition);
                            }
                            var jointTraj = ctx.generalRobot.SolveTaskSpaceTrajectories(taskTraj);
                            yield return ctx.generalRobot.ExecuteTrajectory(jointTraj);
                            break;
                        }

                    case MovementType.RotateZ:
                        {
                            List<List<float>> taskTraj = new List<List<float>>();
                            for (int i = 0; i < num_frames; i++)
                            {
                                float angle = i * (2 * Mathf.PI) / (num_frames - 1);
                                float alpha = amplitude * Mathf.Sin(angle);
                                List<float> taskSpacePosition = new List<float> { initialpos.x, initialpos.y, initialpos.z, -Mathf.PI / 2, 0, alpha };
                                taskTraj.Add(taskSpacePosition);
                            }
                            var jointTraj = ctx.generalRobot.SolveTaskSpaceTrajectories(taskTraj);
                            yield return ctx.generalRobot.ExecuteTrajectory(jointTraj);
                            break;
                        }
                    }
                }
        }
    
