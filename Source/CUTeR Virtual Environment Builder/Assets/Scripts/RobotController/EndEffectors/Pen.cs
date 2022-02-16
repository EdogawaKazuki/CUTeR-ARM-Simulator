using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{
    GameObject lineObj;
    LineRenderer currentLine;
    Color selfColor;
    Material selfMaterial;
    // Start is called before the first frame update
    void Start()
    {
        selfMaterial = GetComponent<MeshRenderer>().material;
        selfColor = selfMaterial.color;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        currentLine = NewLine(collider.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position), ObjectManager.Scene.transform);
    }
    void OnTriggerStay(Collider collider)
    {
        currentLine.positionCount++;
        currentLine.SetPosition(currentLine.positionCount - 1, collider.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position));
    }

    private void OnTriggerExit(Collider collider)
    {
        selfMaterial.color = selfColor;
    }

    LineRenderer NewLine(Vector3 startPoint, Transform parent)
    {
        lineObj = new GameObject("Line " + (parent.childCount + 1));
        lineObj.transform.SetParent(parent);
        lineObj.transform.localPosition = Vector3.zero;
        LineRenderer line = lineObj.gameObject.AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Standard"));
        line.material.color = Color.red;
        line.material.color = Color.red;
        line.startWidth = 1f;
        line.endWidth = 1f;
        line.positionCount = 1;
        line.SetPosition(line.positionCount - 1, (startPoint));
        return line;
    }
}
