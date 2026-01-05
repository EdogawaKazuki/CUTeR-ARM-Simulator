using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

[CreateAssetMenu(menuName = "LessonSteps/Chess/BishopValidMove")]
public class BishopValidMove : LessonStep
{
    GameObject bishop;
   IEnumerator bishopmove(string direction, int boxes)
    {
        float moveddistance = 0f;
        float distancestep = 0f;
        float totalDistance = (0.346f / 8f) * boxes;
        int frameCount = Mathf.RoundToInt(Duration * boxes / Time.fixedDeltaTime); // Calculate number of frames
        float distancePerFrame = totalDistance / frameCount;
        for (int frame = 0; frame < frameCount; frame++)
        {
                if (direction == "upright")
        {
            bishop.transform.localPosition += new Vector3(distancePerFrame, 0f, distancePerFrame); // Move up and to the right
        }
        else if (direction == "upleft")
        {
            bishop.transform.localPosition += new Vector3(-distancePerFrame, 0f, distancePerFrame); // Move up and to the left
        }
        else if (direction == "downright")
        {
            bishop.transform.localPosition += new Vector3(distancePerFrame, 0f, -distancePerFrame); // Move down and to the right
        }
        else if (direction == "downleft")
        {
            bishop.transform.localPosition += new Vector3(-distancePerFrame, 0f, -distancePerFrame); // Move down and to the left
        }
        else if (direction == "up")
        {
            bishop.transform.localPosition += new Vector3(0f, 0f, distancePerFrame); // Move straight up
        }
        else if (direction == "down")
        {
            bishop.transform.localPosition += new Vector3(0f, 0f, -distancePerFrame); // Move straight down
        }
        else if (direction == "left")
        {
            bishop.transform.localPosition += new Vector3(-distancePerFrame, 0f, 0f); // Move straight left
        }
        else if (direction == "right")
        {
            bishop.transform.localPosition += new Vector3(distancePerFrame, 0f, 0f); // Move straight right
        }

            moveddistance += distancePerFrame;
            yield return null;
        }
    }
    public override IEnumerator Execute(LessonContext ctx)
    {
        bishop = SceneUtils.FindInScene("bishop");
        bishop.SetActive(true);
        yield return bishopmove("downright", 5);
        yield return new WaitForSeconds(1f);
        yield return bishopmove("upright", 2);
        yield return new WaitForSeconds(1f);
        yield return bishopmove("upleft", 3);
        yield return new WaitForSeconds(1f);
        yield return bishopmove("downleft", 3);
        bishop.SetActive(false);

    }
    
}