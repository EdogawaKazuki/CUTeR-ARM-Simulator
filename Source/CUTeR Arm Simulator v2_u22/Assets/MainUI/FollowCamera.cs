using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform Camera;
    public Vector3 Offset;
    public Transform RobotCanvas;
    public Transform ExerciseCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RobotCanvas.position = Camera.position - Offset;
        RobotCanvas.rotation = Camera.rotation;
        ExerciseCanvas.position = Camera.position - Offset;
        ExerciseCanvas.rotation = Camera.rotation;
    }
}
