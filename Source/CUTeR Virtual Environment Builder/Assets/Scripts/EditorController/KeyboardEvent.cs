using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class KeyboardEvent : MonoBehaviour
{
    private EditorController _editorController;
    private HandleController _handleController;
    private float _cameraDistance;
    private float _cameraView;
    //public Text DebugText;
    private Keyboard currentKeyboard;
    private string localKeyboardName;
    private bool keyPressed = false;
    private bool remoteKeyboard = false;
    private void Start()
    {
        _editorController = GetComponent<EditorController>();
        _handleController = _editorController.GetHandleController();
        _cameraDistance = 2.0f; // Constant factor
        _cameraView = 2.0f * Mathf.Tan(0.5f * Mathf.Deg2Rad * Camera.main.fieldOfView); // Visible height 1 meter in front
        currentKeyboard = Keyboard.current;
        localKeyboardName = Keyboard.current.name;

    }
    private void Update()
    {

        if (currentKeyboard != Keyboard.current)
        {
            Debug.Log("Old Keyboard: " + currentKeyboard.name + ". New Keyboard: " + Keyboard.current);
            currentKeyboard = Keyboard.current;
            if(Keyboard.current.name != localKeyboardName)
            {
                Debug.Log("Remote Keyboard");
                remoteKeyboard = true;
                Keyboard.current.onTextInput += OnTextInput;
            }
            else
            {
                remoteKeyboard = false;
                Debug.Log("Local keyboard");
            }
        }
        if (GetKeyDown("q"))
        {
           _handleController.SetHandle(HandleController.HandleType.view);
        }
        if (GetKeyDown("w"))
        {
            _handleController.SetHandle(HandleController.HandleType.position);
        }
        if (GetKeyDown("e"))
        {
            _handleController.SetHandle(HandleController.HandleType.rotation);
        }
        if (GetKeyDown("r"))
        {
            _handleController.SetHandle(HandleController.HandleType.scale);
        }
        if (GetKeyDown("f"))
        {
            Transform selectedObj = _editorController.GetSelectedObj();
            if (selectedObj != null)
            {
                Bounds bounds= selectedObj.gameObject.GetComponent<SceneObjectController>().GetBounds();
                Vector3 objectSizes = bounds.max - bounds.min;
                float objectSize = Mathf.Max(objectSizes.x, objectSizes.y, objectSizes.z);
                float distance = _cameraDistance * objectSize / _cameraView; // Combined wanted distance from the object
                distance += 0.5f * objectSize; // Estimated offset from the center to the outside of the object
                Camera.main.transform.position = bounds.center - distance * Camera.main.transform.forward;
            }
        }
        if (remoteKeyboard)
        {
            if (Keyboard.current.backspaceKey.isPressed)
            {
                //DebugText.text ="Backspace\n" + DebugText.text;
                if (!keyPressed)
                {
                    InputField current = EventSystem.current.currentSelectedGameObject.GetComponent<InputField>();
                    if (current != null && current.text.Length > 0)
                        current.text = current.text.Substring(0, current.text.Length - 1);
                    keyPressed = true;
                }
            }
            else
            {
                keyPressed = false;
            }
        }
    }
    void OnTextInput(char c)
    {
        InputField current = EventSystem.current.currentSelectedGameObject.GetComponent<InputField>();
        if (current != null)
            current.text += c.ToString();
        //DebugText.text = c.ToString() + "\n" + DebugText.text;
    }

    // Check if is currently focused on input field
    public static bool IsEditingInputField => EventSystem.current.currentSelectedGameObject?.TryGetComponent(out InputField _) ?? false;
    // conditional layers over UnityEngine.Input.GetKey methods
    public static bool GetKeyDown(string key) => IsEditingInputField ? false : Input.GetKeyDown(key);
    public static bool GetKeyUp(string key) => IsEditingInputField ? false : Input.GetKeyUp(key);
    public static bool GetKey(string key) => IsEditingInputField ? false : Input.GetKey(key);



}
