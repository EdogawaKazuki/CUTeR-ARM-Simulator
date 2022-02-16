using SFB;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoadObj : MonoBehaviour, IPointerDownHandler
{
#if UNITY_WEBGL && !UNITY_EDITOR
    //
    // WebGL
    //
    void Start()
    {
        StartCommon();
    }
    [DllImport("__Internal")]
    private static extern void UploadFile(string gameObjectName, string methodName, string filter, bool multiple);

    public void OnPointerDown(PointerEventData eventData) {
        UploadFile(gameObject.name, "OnFileUpload", ".obj", false);
    }

    // Called from browser
    public void OnFileUpload(string url) {
        StartCoroutine("Load", url);
    }
#else
    //
    // Standalone platforms & editor
    //
    public void OnPointerDown(PointerEventData eventData) { }

    void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        StartCommon();
    }

    private void OnClick()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Open OBJ File", ObjectManager.ObjectFolder, "obj", false);
        if (paths.Length > 0)
        {
            StartCoroutine("Load", paths[0]);
        }
    }
#endif
    SceneManager SceneManager;
    void StartCommon()
    {
        SceneManager = GameObject.Find("GameAdmin").GetComponent<SceneManager>();
    }
    void Load(string path)
    {
        SceneManager.CreateObjectFromFile(path, true);
        transform.parent.parent.Find("Trigger").GetComponent<UIEventManager>().TurnOffToggle();
        
    }
}
