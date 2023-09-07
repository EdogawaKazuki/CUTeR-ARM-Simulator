using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViewportController : MonoBehaviour
{

    // get mouse position
    private float _mouseX = 0;
    private float _mouseY = 0;
    private float _mouseZ = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
            return;
        // get mouse position
        _mouseX = Input.GetAxis("Mouse X");
        _mouseY = Input.GetAxis("Mouse Y");
        _mouseZ = Input.GetAxis("Mouse ScrollWheel");
        if (CheckGuiRaycastObjects()) return;
        if (Input.GetMouseButton(1) || Input.GetMouseButton(2) || _mouseZ != 0) { MoveCamera(); return; }
    }
    private void ClearSelect()
    {
    }
    private void MoveCamera()
    {
        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.RotateAround(Camera.main.transform.position, Vector3.up, _mouseX * 3);
            Camera.main.transform.RotateAround(Camera.main.transform.position, -Camera.main.transform.right, _mouseY * 3);
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
    bool CheckGuiRaycastObjects()
    {
        // PointerEventData eventData = new PointerEventData(Main.Instance.eventSystem);

        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.pressPosition = Input.mousePosition;
        eventData.position = Input.mousePosition;

        List<RaycastResult> list = new List<RaycastResult>();
        // Main.Instance.graphicRaycaster.Raycast(eventData, list);
        EventSystem.current.RaycastAll(eventData, list);
        //Debug.Log(list.Count);
        return list.Count > 0;
    }
}
