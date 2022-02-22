using SFB;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;


public class WebGL_LoadScene : MonoBehaviour, IPointerDownHandler
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
    private static extern void UploadFileWithName(string gameObjectName, string methodName, string filter, bool multiple);

    public void OnPointerDown(PointerEventData eventData) {
        UploadFileWithName(gameObject.name, "OnPathFind", "", true);
    }
    
    // Called from browser
    public void OnPathFind(string url) {
        //StartCoroutine("Load", url);
        Load(url);
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
        //ObjectManager.GameAdmin.GetComponent<UIEventManager>().ScanSceneFolder();
        //ObjectManager.LoadScenePanel.SetActive(true);
        var paths = StandaloneFileBrowser.OpenFilePanel("Open Scene File", ObjectManager.SceneFolder, "", true);
        for(int i = 0; i < paths.Length; i++)
        {
            paths[i] = System.IO.Path.GetFileName(paths[i]) + "," + paths[i];
        }
        if (paths.Length > 0)
        {
            //StartCoroutine(OutputRoutine(paths[0]));
            Load(string.Join(";", paths));
        }
    }
#endif
    WebGL_SceneManager SceneManager;
    void StartCommon()
    {
        SceneManager = GameObject.Find("GameAdmin").GetComponent<WebGL_SceneManager>();
    }
    void Load(string path)
    {
        ObjectManager.WebGL_FileManager.Clear();
        ObjectManager.WebGL_FileManager.AddFile(path);
    }
}
