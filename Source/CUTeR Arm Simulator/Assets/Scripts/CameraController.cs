using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = new Vector3(45.21319f, 73.94116f, -45.21321f);
        Camera.main.transform.eulerAngles = new Vector3(45, -45, 0);
    }

    // Update is called once per frame
    void Update()
    {

        float _mouseX = Input.GetAxis("Mouse X");
        float _mouseY = Input.GetAxis("Mouse Y");
        float _mouseZ = Input.GetAxis("Mouse ScrollWheel");

        // check mouse
        if (!CheckClickGuiRaycastObjects())
        {

            if (Input.GetMouseButton(1))
            {
                Camera.main.transform.RotateAround(new Vector3(0, 10, 0), Vector3.up, _mouseX * 5);

                Camera.main.transform.RotateAround(new Vector3(0, 10, 0), -Camera.main.transform.right, _mouseY * 5);
            }
            if (Input.GetMouseButton(2))
            {
                Camera.main.transform.position += (_mouseX * -Camera.main.transform.right - _mouseY * Camera.main.transform.up);
            }
            if (_mouseZ != 0)
            {
                Camera.main.transform.position += Camera.main.transform.forward * _mouseZ * 10;
            }
        }
        
    }
    bool CheckClickGuiRaycastObjects()
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
