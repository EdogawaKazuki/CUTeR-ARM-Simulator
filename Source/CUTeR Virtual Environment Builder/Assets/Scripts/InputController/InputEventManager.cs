using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputEventManager : MonoBehaviour
{
    static public GameObject Axis;
    ArrayList AxisList;
    bool isSelectAxis;
    bool isSelectScene;
    static public Transform selectedObject;
    char movingAxis;
    int movineMode;
    Vector3 hitPoint;
    float cameraDistance;
    float cameraView;

    // Start is called before the first frame update
    void Start()
    {
        cameraDistance = 2.0f; // Constant factor
        cameraView = 2.0f * Mathf.Tan(0.5f * Mathf.Deg2Rad * Camera.main.fieldOfView); // Visible height 1 meter in front
        isSelectAxis = false;
        isSelectScene = false;
        Axis = ObjectManager.Axis;
        AxisList = new ArrayList();
        AxisList.Add(Axis.transform.GetChild(0).gameObject);
        AxisList.Add(Axis.transform.GetChild(1).gameObject);
        AxisList.Add(Axis.transform.GetChild(2).gameObject);
        SetAxis(0);
    }

    // Update is called once per frame
    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");
        float _mouseY = Input.GetAxis("Mouse Y");
        float _mouseZ = Input.GetAxis("Mouse ScrollWheel");

        // check mouse
        if (!CheckGuiRaycastObjects())
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (movineMode == -1)
                {
                    return;
                }
                RaycastHit hit;
                Ray ray;
                LayerMask layer;

                // check if hit axis objects
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                layer = 1 << LayerMask.NameToLayer("Axis");
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer))
                {
                    hitPoint = hit.point;
                    Debug.Log("axis: " + hit.transform.name);
                    isSelectAxis = true;
                    movingAxis = hit.transform.name[1];
                }

                // check if hit scene objects
                if (!isSelectAxis)
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    layer = 1 << LayerMask.NameToLayer("Scene");
                    if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer))
                    {
                        Debug.Log("scene: " + hit.transform.name);
                        isSelectScene = true;
                        selectedObject = hit.transform.gameObject.GetComponent<SceneObjectController>().parent;
                        SetAxis(movineMode);
                        Axis.SetActive(true);
#if UNITY_WEBGL && !UNITY_EDITOR
                        ObjectManager.GameAdmin.GetComponent<WebGL_SceneManager>().SelectedObj = selectedObject.gameObject;
#else
                        ObjectManager.GameAdmin.GetComponent<SceneManager>().SelectedObj = selectedObject.gameObject;
#endif
                        ObjectManager.DeletePanelName.text = selectedObject.name;
                        ObjectManager.AttributePanel.SetActive(true);
                        UpdateAttriPanel();
                    }

                }
                
                // check if hit empty
                if (!hit.transform)
                {
                    isSelectScene = false;
                    selectedObject = null;
                    Axis.SetActive(false);
                    ObjectManager.AttributePanel.SetActive(false);
                }
            }
            if (Input.GetMouseButton(0))
            {
                if (movineMode == -1)
                {
                    Camera.main.transform.position += (_mouseX * -Camera.main.transform.right - _mouseY * Camera.main.transform.up);
                }
                // if there is an object had already been selected
                if (isSelectScene)
                {
                    // if hit axis, move the object
                    if (isSelectAxis)
                    {
                        // move object
                        if (movineMode == 0)
                        {
                            if (movingAxis == 'x')
                                selectedObject.position = new Vector3(selectedObject.position.x + Vector3.Dot(Vector3.right, Camera.main.transform.right) * _mouseX + Vector3.Dot(Vector3.right, Camera.main.transform.up) * _mouseY, selectedObject.position.y, selectedObject.position.z);
                            if (movingAxis == 'z')
                                selectedObject.position = new Vector3(selectedObject.position.x, selectedObject.position.y + Vector3.Dot(Vector3.up, Camera.main.transform.right) * _mouseX + Vector3.Dot(Vector3.up, Camera.main.transform.up) * _mouseY, selectedObject.position.z);
                            if (movingAxis == 'y')
                                selectedObject.position = new Vector3(selectedObject.position.x, selectedObject.position.y, selectedObject.position.z + Vector3.Dot(Vector3.forward, Camera.main.transform.right) * _mouseX + Vector3.Dot(Vector3.forward, Camera.main.transform.up) * _mouseY);
                        }
                        // rotate object
                        if (movineMode == 1)
                        {
                            Vector3 tangent;
                            if (movingAxis == 'x')
                            {
                                tangent = Vector3.Cross(Vector3.right, hitPoint - Axis.transform.position);
                                selectedObject.RotateAround(selectedObject.transform.position, Vector3.right, Vector3.Dot(tangent, Camera.main.transform.right) * _mouseX + Vector3.Dot(tangent, Camera.main.transform.up) * _mouseY);

                            }
                            if (movingAxis == 'z')
                            {
                                tangent = Vector3.Cross(Vector3.up, hitPoint - Axis.transform.position);
                                selectedObject.RotateAround(selectedObject.transform.position, Vector3.up, Vector3.Dot(tangent, Camera.main.transform.right) * _mouseX + Vector3.Dot(tangent, Camera.main.transform.up) * _mouseY);

                            }
                            if (movingAxis == 'y')
                            {
                                tangent = Vector3.Cross(Vector3.forward, hitPoint - Axis.transform.position);
                                selectedObject.RotateAround(selectedObject.transform.position, Vector3.forward, Vector3.Dot(tangent, Camera.main.transform.right) * _mouseX + Vector3.Dot(tangent, Camera.main.transform.up) * _mouseY);

                            }
                        }
                        // scale object
                        if (movineMode == 2)
                        {
                            if (movingAxis == 'x')
                                selectedObject.localScale = new Vector3(selectedObject.localScale.x - Vector3.Dot(selectedObject.right, Camera.main.transform.right) * _mouseX - Vector3.Dot(selectedObject.right, Camera.main.transform.up) * _mouseY, selectedObject.localScale.y, selectedObject.localScale.z);
                            if (movingAxis == 'z')
                                selectedObject.localScale = new Vector3(selectedObject.localScale.x, selectedObject.localScale.y + Vector3.Dot(selectedObject.up, Camera.main.transform.right) * _mouseX + Vector3.Dot(selectedObject.up, Camera.main.transform.up) * _mouseY, selectedObject.localScale.z);
                            if (movingAxis == 'y')
                                selectedObject.localScale = new Vector3(selectedObject.localScale.x, selectedObject.localScale.y, selectedObject.localScale.z - Vector3.Dot(selectedObject.forward, Camera.main.transform.right) * _mouseX - Vector3.Dot(selectedObject.forward, Camera.main.transform.up) * _mouseY);
                        }
                        //selectedObject.transform.gameObject.GetComponent<MeshCollider>().convex = true;
                    }
                    UpdateAttriPanel();
                }

            }
            if (Input.GetMouseButtonUp(0))
            {
                // clear select
                isSelectAxis = false;
            }
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
        // check keyboard
        if (NonUIInput.GetKeyDown("q"))
        {
            SetAxis(-1);
        }
        if (NonUIInput.GetKeyDown("w"))
        {
            SetAxis(0);
        }
        if (NonUIInput.GetKeyDown("e"))
        {
            SetAxis(1);
        }
        if (NonUIInput.GetKeyDown("r"))
        {
            SetAxis(2);
        }
        if (selectedObject)
        {
            if (NonUIInput.GetKeyDown("f"))
            {
                Renderer renderer = selectedObject.gameObject.GetComponent<Renderer>();
                Vector3 objectSizes = renderer.bounds.max - renderer.bounds.min;
                float objectSize = Mathf.Max(objectSizes.x, objectSizes.y, objectSizes.z);
                float distance = cameraDistance * objectSize / cameraView; // Combined wanted distance from the object
                distance += 0.5f * objectSize; // Estimated offset from the center to the outside of the object
                Camera.main.transform.position = renderer.bounds.center - distance * Camera.main.transform.forward;
            }
            Axis.transform.position = Camera.main.transform.position - Vector3.Normalize(Camera.main.transform.position - selectedObject.position) * 50;
            if (movineMode == 1)
            {

                Axis.transform.GetChild(1).GetChild(0).eulerAngles = new Vector3(Camera.main.transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, Camera.main.transform.eulerAngles.z);
                //Axis.transform.GetChild(1).GetChild(1).eulerAngles = new Vector3(0, 180 + Camera.main.transform.localEulerAngles.y, 0);
                //Axis.transform.GetChild(1).GetChild(2).eulerAngles = new Vector3(-Camera.main.transform.localEulerAngles.y - 180, -90, 90);
            }
            if(SceneManager.isPlaying)
                UpdateAttriPanel();
        }
    }
    public void SetAxis(int mode)
    {
        for(int i = 0; i < ObjectManager.ToolToggleMarkArray.Length; i++)
        {
            ObjectManager.ToolToggleMarkArray[i].SetActive(false);
        }
        ObjectManager.ToolToggleMarkArray[mode + 1].SetActive(true);
        movineMode = mode;
        for (int i = 0; i < AxisList.Count; i++)
        {
            if(i != movineMode)
            {
                ((GameObject)AxisList[i]).SetActive(false);
            }
            else
            {
                if (selectedObject)
                    ((GameObject)AxisList[i]).SetActive(true);
            }
        }
        if (movineMode == 0)
        {
            Axis.transform.eulerAngles = new Vector3();
        }
        if (movineMode == 1)
        {
            Axis.transform.eulerAngles = new Vector3();
        }
        if (movineMode == 2)
        {
            if(selectedObject)
                Axis.transform.eulerAngles = selectedObject.transform.eulerAngles;
        }
    }
    public void UpdateAttriPanel()
    {
        ObjectManager.AttributePanel.transform.Find("Name/Options/InputField").GetComponent<InputField>().text = selectedObject.name;
        ObjectManager.AttributePanel.transform.Find("Position/Options/X/InputField").GetComponent<InputField>().text = (-selectedObject.transform.position.x).ToString();
        ObjectManager.AttributePanel.transform.Find("Position/Options/Z/InputField").GetComponent<InputField>().text = selectedObject.transform.position.y.ToString();
        ObjectManager.AttributePanel.transform.Find("Position/Options/Y/InputField").GetComponent<InputField>().text = (-selectedObject.transform.position.z).ToString();
        ObjectManager.AttributePanel.transform.Find("Rotation/Options/X/InputField").GetComponent<InputField>().text = selectedObject.transform.eulerAngles.x.ToString();
        ObjectManager.AttributePanel.transform.Find("Rotation/Options/Z/InputField").GetComponent<InputField>().text = selectedObject.transform.eulerAngles.y.ToString();
        ObjectManager.AttributePanel.transform.Find("Rotation/Options/Y/InputField").GetComponent<InputField>().text = selectedObject.transform.eulerAngles.z.ToString();
        ObjectManager.AttributePanel.transform.Find("Scale/Options/X/InputField").GetComponent<InputField>().text = selectedObject.transform.localScale.x.ToString();
        ObjectManager.AttributePanel.transform.Find("Scale/Options/Z/InputField").GetComponent<InputField>().text = selectedObject.transform.localScale.y.ToString();
        ObjectManager.AttributePanel.transform.Find("Scale/Options/Y/InputField").GetComponent<InputField>().text = selectedObject.transform.localScale.z.ToString();
        ObjectManager.AttributePanel.transform.Find("LoadTrajectory/Options/Switch/Toggle").GetComponent<Toggle>().isOn = selectedObject.GetComponent<ObjTrajectoryExecutor>().TrajSwitch;
        bool isRigidbody = ObjectManager.AttributePanel.transform.Find("IsRigidbody/Options/Toggle").GetComponent<Toggle>().isOn = selectedObject.GetComponent<Rigidbody>() != null;
        if (isRigidbody)
        {
            ObjectManager.AttributePanel.transform.Find("FixPosition/Options/X/Toggle").GetComponent<Toggle>().isOn = (selectedObject.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezePositionX) != RigidbodyConstraints.None;
            ObjectManager.AttributePanel.transform.Find("FixPosition/Options/Z/Toggle").GetComponent<Toggle>().isOn = (selectedObject.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezePositionY) != RigidbodyConstraints.None;
            ObjectManager.AttributePanel.transform.Find("FixPosition/Options/Y/Toggle").GetComponent<Toggle>().isOn = (selectedObject.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezePositionZ) != RigidbodyConstraints.None;
            ObjectManager.AttributePanel.transform.Find("FixRotation/Options/X/Toggle").GetComponent<Toggle>().isOn = (selectedObject.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezeRotationX) != RigidbodyConstraints.None;
            ObjectManager.AttributePanel.transform.Find("FixRotation/Options/Z/Toggle").GetComponent<Toggle>().isOn = (selectedObject.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezeRotationY) != RigidbodyConstraints.None;
            ObjectManager.AttributePanel.transform.Find("FixRotation/Options/Y/Toggle").GetComponent<Toggle>().isOn = (selectedObject.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezeRotationZ) != RigidbodyConstraints.None;

            ObjectManager.AttributePanel.transform.Find("UseGravity/Options/Toggle").GetComponent<Toggle>().isOn = selectedObject.GetComponent<Rigidbody>().useGravity;

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
