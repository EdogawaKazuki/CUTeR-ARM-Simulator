using UnityEngine;

public class Wheelrotation : MonoBehaviour
{
    public float rotationspeed = 100f;
    public Vector3 rotationaxis;
    void Start()
    {
        rotationaxis = new Vector3(1, 0, 0);// Start is called once before the first execution of Update after the MonoBehaviour is created
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Rotate(rotationaxis, rotationspeed * Time.deltaTime); 
    }
}
