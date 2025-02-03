using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointCanvas : MonoBehaviour
{
    private Camera _arCamera;
    private Camera _mainCamera;
    [SerializeField]
    bool _move = true;
    [SerializeField]
    bool _rotate = true;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        //_arCamera = GameObject.Find("EditorAdmin").GetComponent<EditorController>().GetARCamera();
        //_mainCamera = GameObject.Find("EditorAdmin").GetComponent<EditorController>().GetMainCamera();
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (_rotate)
            transform.LookAt(transform.parent.position);
        if (_move)
        {
            if (_mainCamera.isActiveAndEnabled)
                transform.position = transform.parent.position - _mainCamera.transform.forward * .08f;
            else if (_arCamera.isActiveAndEnabled)
                transform.position = transform.parent.position - _arCamera.transform.forward * .08f;
        }
        else
        {
            if (_mainCamera.isActiveAndEnabled)
                transform.position = transform.parent.position - _mainCamera.transform.forward * .01f;
            else if (_arCamera.isActiveAndEnabled)
                transform.position = transform.parent.position - _arCamera.transform.forward * .01f;
        }
    }
}
