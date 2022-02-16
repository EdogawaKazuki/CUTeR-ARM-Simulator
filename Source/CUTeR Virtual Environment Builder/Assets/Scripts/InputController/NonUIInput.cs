using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public static class NonUIInput
{
    // Check if is currently focused on input field
    public static bool IsEditingInputField => EventSystem.current.currentSelectedGameObject?.TryGetComponent(out InputField _) ?? false;
    // conditional layers over UnityEngine.Input.GetKey methods
    public static bool GetKeyDown(string key) => IsEditingInputField ? false : Input.GetKeyDown(key);
    public static bool GetKeyUp(string key) => IsEditingInputField ? false : Input.GetKeyUp(key);
    public static bool GetKey(string key) => IsEditingInputField ? false : Input.GetKey(key);
}