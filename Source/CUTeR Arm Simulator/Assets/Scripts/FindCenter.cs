using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCenter : MonoBehaviour
{
    float x = 0;
    float y = 0;
    float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0;i<transform.childCount; i++)
        {
            x += transform.GetChild(i).GetComponent<Renderer>().bounds.center.x;
            y += transform.GetChild(i).GetComponent<Renderer>().bounds.center.y;
            z += transform.GetChild(i).GetComponent<Renderer>().bounds.center.z;
        }
        Debug.Log(name + ", " + x / transform.childCount + ", " + y / transform.childCount + ", " + z / transform.childCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
