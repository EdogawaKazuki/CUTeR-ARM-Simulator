using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointCanvas : MonoBehaviour
{
    [SerializeField]
    private Camera _arCamera;
    [SerializeField]
    private Camera _mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_arCamera.isActiveAndEnabled)
            transform.position = transform.parent.position - _arCamera.transform.forward * 8f;
        if(_mainCamera.isActiveAndEnabled)
            transform.position = transform.parent.position - _mainCamera.transform.forward * 8f;
        transform.LookAt(transform.parent.position);
    }
}
