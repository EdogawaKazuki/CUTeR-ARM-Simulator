using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCanvasWithWrist : MonoBehaviour
{
    public Transform wrist;
    public Vector3 offset = new Vector3(0, 0, 0);
    public float scale = 0.0002f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = wrist.position + wrist.forward * offset.z + wrist.right * offset.x + wrist.up * offset.y;
        transform.rotation = wrist.rotation;
    }
}
