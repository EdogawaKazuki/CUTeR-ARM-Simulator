using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchEvent : MonoBehaviour
{
    private EditorController _editorController;
    private HandleController _handleController;

    // get mouse position
    private Touch touch0;
    private Touch touch1;

    private float _initTouchDistance = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckGuiRaycastObjects()) return;
        if(Input.touchCount == 1 || Input.touchCount == 2) { MoveCamera (); }

    }
    private void MoveCamera()
    {
        if(Input.touchCount == 1)
        {
            touch0 = Input.GetTouch(0);
            Camera.main.transform.RotateAround(new Vector3(0, 0, 10), Vector3.up, touch0.deltaPosition.x * 0.1f);
            Camera.main.transform.RotateAround(new Vector3(0, 0, 10), -Camera.main.transform.right, touch0.deltaPosition.y * 0.05f);
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
                Camera.main.transform.position += Camera.main.transform.forward * (Vector3.Distance(touch0.position, touch1.position) - _initTouchDistance) * 0.1f;
            }
            _initTouchDistance = Vector3.Distance(touch0.position, touch1.position);
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
