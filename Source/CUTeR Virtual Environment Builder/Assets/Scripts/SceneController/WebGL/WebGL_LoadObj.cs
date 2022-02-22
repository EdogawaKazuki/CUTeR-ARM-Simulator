using Dummiesman;
using SFB;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebGL_LoadObj : MonoBehaviour, IPointerDownHandler
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
        ObjectManager.WebGL_FileManager.AddFile(url);
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
        var paths = StandaloneFileBrowser.OpenFilePanel("Open OBJ File", ObjectManager.ObjectFolder, "", true);
        if (paths.Length > 0)
        {
            //StartCoroutine("Load", paths[0]);
            //Load(paths[0]);
        }
    }
#endif
    WebGL_SceneManager SceneManager;
    Stream stream;
    void StartCommon()
    {
        SceneManager = GameObject.Find("GameAdmin").GetComponent<WebGL_SceneManager>();
    }
    void Load(string objUrl)
    {
        Debug.Log(objUrl);
        string objName = Path.GetFileName(objUrl).Split('.')[0];
        string objPath = objUrl.Replace(Path.GetFileName(objUrl), "");
        
        SceneManager.CreateObjectFromFile(objName, true) ;
    }
    IEnumerator Load_Old(string objUrl)
    {
        var request = UnityWebRequest.Get(objUrl);
        yield return request.SendWebRequest();
        switch (request.result)
        {
            case UnityWebRequest.Result.ConnectionError:
            case UnityWebRequest.Result.DataProcessingError:
                Debug.LogError("Error: " + request.error);
                break;
            case UnityWebRequest.Result.ProtocolError:
                Debug.LogError("HTTP Error: " + request.error);
                break;
            case UnityWebRequest.Result.Success:
                Debug.Log("Received Success");
                break;
        }
        Debug.Log(request.downloadHandler.text);
    }
}
