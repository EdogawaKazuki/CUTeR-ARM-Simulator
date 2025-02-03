using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : EndEffector
{
    #region variables
    LineRenderer _currentLine;
    Vector3 _lastPosition;

    enum State
    {
        on,
        off
    }
    State _currentState;
    // Color when no object is in grabbing point
    Color colorOff = new Color(0.2f, 0.2f, 0.2f, 0.5f);

    // Color when any object is in grabbing point
    Color colorOn = new Color(0.2f, 0.2f, 0.2f, 0.5f);

    Material _selfMaterial;

    // counter of number of objects that in grabbing point.
    int _colliderCounter;
    // Start is called before the first frame update
    #endregion
    #region MonoBehaviour
    void Start()
    {
        _selfMaterial = GetComponent<MeshRenderer>().material;
        _selfMaterial.color = colorOff;
    }

    void OnTriggerEnter(Collider collider)
    {
        // create a new line when new object enters the drawing point
        if (_currentState == State.on)
        {
            if (_colliderCounter == 0)
            {
                _currentLine = NewLine(collider.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position), collider.transform);
                _lastPosition = transform.position;
            }
            _colliderCounter++;
        }
    }
    void OnTriggerStay(Collider collider)
    {
        if (_currentState == State.on)
        {
            // add a new point when the pen moves a certen distance
            if(Vector3.Distance(_lastPosition, collider.transform.position) < 0.01f)
            {
                _currentLine.positionCount++;
                _currentLine.SetPosition(_currentLine.positionCount - 1, collider.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position));
            }
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (_currentState == State.on)
        {
            _colliderCounter--;
        }
    }
    #endregion
    #region Methods
    LineRenderer NewLine(Vector3 startPoint, Transform parent)
    {
        GameObject lineObj;
        lineObj = new GameObject("Line " + (parent.childCount + 1));
        lineObj.transform.SetParent(parent);
        lineObj.transform.localPosition = Vector3.zero;
        LineRenderer line = lineObj.gameObject.AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Standard"));
        line.material.color = Color.red;
        line.startWidth = 1f;
        line.endWidth = 1f;
        line.positionCount = 1;
        line.SetPosition(line.positionCount - 1, (startPoint));
        return line;
    }
    #endregion
    #region EndEffector Methods
    public override void Init()
    {
        base.Init();
        _name = "Pen";
        _force = 0;
    }
    public override void Fire() {
        switch (_currentState)
        {
            case State.off:
                _currentState = State.on;
                _selfMaterial.color = colorOn;
                break;
            case State.on:
                _currentState = State.off;
                _selfMaterial.color = colorOff;
                break;
        }
    }
    #endregion
}
