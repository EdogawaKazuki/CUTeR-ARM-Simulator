using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViewportController : MonoBehaviour
{
    
    Transform robotTransform;
    // get mouse position
    private float _mouseX = 0;
    private float _mouseY = 0;
    private float _mouseZ = 0;

    // get mouse position
    private Touch touch0;
    private Touch touch1;
    private float _initTouchDistance = 0;
    // Start is called before the first frame update
    void Start()
    {
        robotTransform = transform.Find("/Robot");
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckGuiRaycastObjects()) return;
        if (Input.touchCount > 0){
            MoveCameraTouch ();
            return;
        }
        // get mouse position
        _mouseX = Input.GetAxis("Mouse X");
        _mouseY = Input.GetAxis("Mouse Y");
        _mouseZ = Input.GetAxis("Mouse ScrollWheel");
        MoveCamera();
    }
    private void MoveCamera()
    {
        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.RotateAround(robotTransform.position, Vector3.up, _mouseX * 3);
            Camera.main.transform.RotateAround(robotTransform.position, -Camera.main.transform.right, _mouseY * 3);
        }
        if (Input.GetMouseButton(2))
        {
            Camera.main.transform.position += _mouseX * -Camera.main.transform.right * 0.1f - _mouseY * Camera.main.transform.up * 0.1f;
        }
        if (_mouseZ != 0)
        {
            Camera.main.transform.position += Camera.main.transform.forward * _mouseZ;
        }
    }
    private void MoveCameraTouch()
    {
        if(Input.touchCount == 1)
        {
            touch0 = Input.GetTouch(0);
            if (touch0.deltaPosition.magnitude > 100f) return;
            Camera.main.transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, -touch0.deltaPosition.x * 0.1f);
            Camera.main.transform.RotateAround(new Vector3(0, 0, 0), -Camera.main.transform.right, -touch0.deltaPosition.y * 0.05f);
        }
        if (Input.touchCount == 2)
        {
            touch0 = Input.GetTouch(0);
            touch1 = Input.GetTouch(1);
            //Camera.main.transform.position += (touch0.deltaPosition.x * 0.1f * -Camera.main.transform.right - touch0.deltaPosition.y * 0.1f * Camera.main.transform.up);
            if (touch1.phase == TouchPhase.Began)
            {
                _initTouchDistance = Vector3.Distance(touch0.position, touch1.position);
            }
            else
            {
                Camera.main.transform.position += Camera.main.transform.forward * (Vector3.Distance(touch0.position, touch1.position) - _initTouchDistance) * 0.01f;
            }
            _initTouchDistance = Vector3.Distance(touch0.position, touch1.position);
        }
    }
    bool CheckGuiRaycastObjects()
    {
        // PointerEventData eventData = new PointerEventData(Main.Instance.eventSystem);

        PointerEventData eventData = new PointerEventData(EventSystem.current)
        {
            pressPosition = Input.mousePosition,
            position = Input.mousePosition
        };

        List<RaycastResult> list = new List<RaycastResult>();
        // Main.Instance.graphicRaycaster.Raycast(eventData, list);
        EventSystem.current.RaycastAll(eventData, list);
        //Debug.Log(list.Count);
        return list.Count > 0;
    }
    public void SetText(string text)
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<TMP_InputField>().text = text;
        Debug.Log("Unity Received:" + text);
    }
}
