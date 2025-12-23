using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

[CreateAssetMenu(menuName = "LessonSteps/Chess/KnightValidMove")]
public class KnightValidMove : LessonStep
{
    GameObject knight;
    IEnumerator knightmove(string direction1, string direction2)
{
    
    float distancestep = 0f;
    string[] directions = { direction1, direction2 };
    float[] distancetargets = { (float)((0.346 / 8) * 2), (float)(0.346 / 8) };
    int[] num_boxes = { 2, 1 };
    
    for (int i = 0; i < directions.Length && i < distancetargets.Length; i++)
        {
            float moveddistance = 0f;
            float totalDistance = distancetargets[i];
            int frameCount = Mathf.RoundToInt(Duration * num_boxes[i] / Time.fixedDeltaTime); // Calculate number of frames
            float distancePerFrame = totalDistance / frameCount; // Distance to move per frame

            for (int frame = 0; frame < frameCount; frame++)
            {
                if (directions[i] == "up")
                {
                    knight.transform.localPosition += new Vector3(0f, 0f, distancePerFrame);
                }
                else if (directions[i] == "down")
                {
                    knight.transform.localPosition += new Vector3(0f, 0f, -distancePerFrame);
                }
                else if (directions[i] == "right")
                {
                    knight.transform.localPosition += new Vector3(distancePerFrame, 0f, 0f);
                }
                else if (directions[i] == "left")
                {
                    knight.transform.localPosition += new Vector3(-distancePerFrame, 0f, 0f);
                }

                moveddistance += Math.Abs(distancePerFrame);
                yield return new WaitForFixedUpdate(); // Wait for the next fixed frame
            }
        }
}
    public override IEnumerator Execute(LessonContext ctx)
    {
        knight = SceneUtils.FindInScene("knight");
        knight.SetActive(true);
        yield return null;
        yield return knightmove("down", "right");
        yield return new WaitForSeconds(1f);
        yield return knightmove("right", "down");
        yield return new WaitForSeconds(1f);
        yield return knightmove("left", "down");
        yield return new WaitForSeconds(1f);
        yield return knightmove("down", "left");
        knight.SetActive(false);

    }
}