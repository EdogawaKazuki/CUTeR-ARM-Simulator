using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TestingScript : MonoBehaviour
{
    bool isTesting = true;
    string objFolder;
    string objPath;
    ArrayList objFiles;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name + "," + GetComponent<Renderer>().bounds.center);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTesting)
        {
        }

    }
}
