using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEvent : MonoBehaviour
{
    private EditorController _editorController;
    private HandleController _handleController;

    // get mouse position
    private float _mouseX = 0;
    private float _mouseY = 0;
    private float _mouseZ = 0;
    private bool _isDragging = false;

    private Transform _handleContainer;
    private Transform _selectedObject;
    char movingAxis;
    Vector3 hitPoint;
    // Start is called before the first frame update
    void Start()
    {
        _editorController = GetComponent<EditorController>();
        _handleContainer = GetComponent<EditorController>().GetHandleController().transform;
        _handleController = _editorController.GetHandleController();
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
        if (Input.anyKey)
        {

            if (_isDragging)
            {
                // move object
                if (_handleController.CheckCurrentHandleType(HandleController.HandleType.position))
                {
                    if (movingAxis == 'y')
                        _selectedObject.position = new Vector3(_selectedObject.position.x + Vector3.Dot(Vector3.right, Camera.main.transform.right) * _mouseX + Vector3.Dot(Vector3.right, Camera.main.transform.up) * _mouseY, _selectedObject.position.y, _selectedObject.position.z);
                    if (movingAxis == 'x')
                        _selectedObject.position = new Vector3(_selectedObject.position.x, _selectedObject.position.y + Vector3.Dot(Vector3.up, Camera.main.transform.right) * _mouseX + Vector3.Dot(Vector3.up, Camera.main.transform.up) * _mouseY, _selectedObject.position.z);
                    if (movingAxis == 'z')
                        _selectedObject.position = new Vector3(_selectedObject.position.x, _selectedObject.position.y, _selectedObject.position.z + Vector3.Dot(Vector3.forward, Camera.main.transform.right) * _mouseX + Vector3.Dot(Vector3.forward, Camera.main.transform.up) * _mouseY);
                }
                // rotate object
                else if (_handleController.CheckCurrentHandleType(HandleController.HandleType.rotation))
                {
                    Vector3 tangent;
                    if (movingAxis == 'y')
                    {
                        tangent = Vector3.Cross(Vector3.right, hitPoint - _handleContainer.position);
                        _selectedObject.RotateAround(_selectedObject.transform.position, -Vector3.right, Vector3.Dot(tangent, Camera.main.transform.right) * _mouseX + Vector3.Dot(tangent, Camera.main.transform.up) * _mouseY);

                    }
                    if (movingAxis == 'x')
                    {
                        tangent = Vector3.Cross(Vector3.up, hitPoint - _handleContainer.position);
                        _selectedObject.RotateAround(_selectedObject.transform.position, -Vector3.up, Vector3.Dot(tangent, Camera.main.transform.right) * _mouseX + Vector3.Dot(tangent, Camera.main.transform.up) * _mouseY);

                    }
                    if (movingAxis == 'z')
                    {
                        tangent = Vector3.Cross(Vector3.forward, hitPoint - _handleContainer.position);
                        _selectedObject.RotateAround(_selectedObject.transform.position, -Vector3.forward, Vector3.Dot(tangent, Camera.main.transform.right) * _mouseX + Vector3.Dot(tangent, Camera.main.transform.up) * _mouseY);

                    }
                }
                // scale object
                else if (_handleController.CheckCurrentHandleType(HandleController.HandleType.scale))
                {
                    if (movingAxis == 'y')
                        _selectedObject.localScale = new Vector3(_selectedObject.localScale.x - Vector3.Dot(_selectedObject.right, Camera.main.transform.right) * _mouseX - Vector3.Dot(_selectedObject.right, Camera.main.transform.up) * _mouseY, _selectedObject.localScale.y, _selectedObject.localScale.z);
                    if (movingAxis == 'x')
                        _selectedObject.localScale = new Vector3(_selectedObject.localScale.x, _selectedObject.localScale.y + Vector3.Dot(_selectedObject.up, Camera.main.transform.right) * _mouseX + Vector3.Dot(_selectedObject.up, Camera.main.transform.up) * _mouseY, _selectedObject.localScale.z);
                    if (movingAxis == 'z')
                        _selectedObject.localScale = new Vector3(_selectedObject.localScale.x, _selectedObject.localScale.y, _selectedObject.localScale.z - Vector3.Dot(_selectedObject.forward, Camera.main.transform.right) * _mouseX - Vector3.Dot(_selectedObject.forward, Camera.main.transform.up) * _mouseY);
                }

                return;
            }

            // check mouse hit
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Axis")))
            {
                //Debug.Log(hit.transform.name);
                HitHandle(hit);
            }
            else if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << LayerMask.NameToLayer("Scene")))
            {
                //Debug.Log(hit.transform.name);
                HitSceneObj(hit);
                _handleController.ShowHandle();
            }
            else
            {
                ClearSelect();
            }
        }
        else
        {
            _isDragging = false;
        }
    }
    private void ClearSelect()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("clear");
            _editorController.SelectObj(null);
            _handleController.HideHandle();
        }
    }
    private void MoveCamera()
    {
        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.RotateAround(Camera.main.transform.position, Vector3.up, _mouseX * 5);
            Camera.main.transform.RotateAround(Camera.main.transform.position, -Camera.main.transform.right, _mouseY * 5);
        }
        if (Input.GetMouseButton(2))
        {
            Camera.main.transform.position += (_mouseX * -Camera.main.transform.right * 5 - _mouseY * Camera.main.transform.up * 5);
        }
        if (_mouseZ != 0)
        {
            Camera.main.transform.position += Camera.main.transform.forward * _mouseZ * 50;
        }
    }
    private void HitHandle(RaycastHit hit)
    {
        _selectedObject = _editorController.GetSelectedObj();
        if (Input.GetMouseButtonDown(0))
        {
            // todo change moving scale
            _isDragging = true;
            movingAxis = hit.transform.name[1];

        }
    }
    private void HitSceneObj(RaycastHit hit)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_editorController.GetSceneManager().GetPlayingScene() != null)
            {
                Debug.Log(hit.transform.name);
                _editorController.SelectObj(hit.transform);
            }
            else
            {
                Debug.Log(hit.transform.GetComponent<SceneObjectPart>().name);
                _editorController.SelectObj(hit.transform.GetComponent<SceneObjectPart>().GetParent());
            }
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
