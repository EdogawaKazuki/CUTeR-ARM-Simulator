using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gripper : EndEffector
{
    #region Variables

    // Dictionary of all objects in the grabbing point(cube)
    public Dictionary<Transform, int> colliderDict = new Dictionary<Transform, int>();
    // counter of number of objects that in grabbing point.
    public int _colliderCounter;

    private Color colorOff = new Color(0.2f, 0.2f, 0.2f, 0.5f);
    private Color colorOn = new Color(0.2f, 1f, 0.2f, 0.5f);
    private Material _material;

    // object that will be grabbed. The last object enters the grabbing point will be the target target.
    public GameObject targetObject = null;

    private Transform _leftPalm;
    private Transform _rightPalm;
    private Transform _detectCube;



    // states
    // released: the Gripper is open, ready to grab
    // grabbing: playing the grab animation 
    // grabbed: the Gripper is closed, ready to release
    // releasing: playing the release animation
    enum State
    {
        released,
        grabbing,
        grabbed,
        releasing
    }

    private State _currentState;


    private float _speed = 1f;

    #endregion

    #region MonoBehaviors
    // Start is called before the first frame update
    void Start()
    {
        _leftPalm = transform.Find("PartHand/Left");
        _rightPalm = transform.Find("PartHand/Right");
        _detectCube = transform.Find("DetectCube");
        _material = _detectCube.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (_currentState)
        {
            // play the grab animation, and try to grab when it ends
            case State.grabbing:
                _rightPalm.localRotation = Quaternion.Lerp(_rightPalm.localRotation, Quaternion.Euler(60, 0, 0), _speed);
                _leftPalm.localRotation = Quaternion.Lerp(_leftPalm.localRotation, Quaternion.Euler(-60, 0, 0), _speed);
                if (Mathf.Abs(_rightPalm.localEulerAngles.x - 60) < 0.1)
                {
                    _currentState = State.grabbed;
                    TryGrab();
                }
                break;

            // play the release animation, and release the object when it ends
            case State.releasing:
                _rightPalm.localRotation = Quaternion.Lerp(_rightPalm.localRotation, Quaternion.Euler(40, 0, 0), _speed);
                _leftPalm.localRotation = Quaternion.Lerp(_leftPalm.localRotation, Quaternion.Euler(-40, 0, 0), _speed);
                if (Mathf.Abs(_rightPalm.localEulerAngles.x - 40) < 0.1)
                {
                    _currentState= State.released;
                    Release();
                }
                break;
            default:
                return;

        }
        
        if (_colliderCounter == 0)
        {
            _material.color = colorOff;
        }else{
            _material.color = colorOn;
        }
        //Debug.Log("released: " + Released + " Gripper: " + Grabbed + " releasing: " + Releasing + " grabbing: " + Grabbing);
    }

    #endregion
    #region EndEffector Methods
    public override void Init()
    {
        base.Init();
        _name = "Gripper";
        _force = 0;
    }
    public override void Fire()
    {
        switch (_currentState)
        {
            case State.released:
                _currentState = State.grabbing;
                break;
            case State.grabbed:
                _currentState = State.releasing;
                break;
            default:
                return;
        }
    }
    public void TryGrab()
    {
        //Debug.Log("Try Grab");
        // check whether there is any objects in grabbing piont, then grab or release
        if(_colliderCounter != 0) {
            float min_dist = Mathf.Infinity;
            // find the closest object
            foreach (var ele in colliderDict)
            {
                if (ele.Value == 0)
                    continue;
                Transform collider = ele.Key;
                Debug.Log("Check " + collider.name);
                float distance = Vector3.Distance(collider.transform.position, transform.position);
                if (distance < min_dist)
                {
                    min_dist = distance;
                    targetObject = collider.gameObject;
                }
            }

             Debug.Log(targetObject.name);
            // Make the object static to the Gripper
            if(targetObject.GetComponent<SceneObjectTrajectoryController>())
                targetObject.GetComponent<SceneObjectTrajectoryController>().StartTraj();
            // disable the physical property
            Rigidbody rigidbody = targetObject.GetComponent<Rigidbody>();
            if (rigidbody)
            {
                rigidbody.isKinematic = true;
            }
            // change the state to grabbed
            _currentState = State.grabbed;
            targetObject.transform.SetParent(transform);
        }
        // if no object in grabbing point, release
        else
        {
            _currentState = State.releasing;
        }
    }
    public void Release()
    {
        //Debug.Log("Release");
        if (targetObject)
        {
            // set the parent back to the scene
            targetObject.transform.SetParent(GameObject.Find("VirtualScene/PlayingScene").transform);
            // enable the physical property
            Rigidbody rigidbody = targetObject.GetComponent<Rigidbody>();
            if (rigidbody)
            {
                rigidbody.isKinematic = false;
            }
        }
        // change the state to released
        _currentState = State.released;
    }
    public override void Reset()
    {
        _rightPalm.localRotation = Quaternion.Euler(40, 0, 0);
        _leftPalm.localRotation = Quaternion.Euler(-40, 0, 0);
        _currentState = State.released;
        _material.color = colorOff;
        colliderDict.Clear();
        _colliderCounter = 0;
        Destroy(targetObject);
        targetObject = null;
    }
    #endregion
}
