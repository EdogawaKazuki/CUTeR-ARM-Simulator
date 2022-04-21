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

public class WebGL_FileUploader : MonoBehaviour, IPointerDownHandler
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
        //StartCoroutine("UploadFile", url);
        print(url);
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
        var paths = StandaloneFileBrowser.OpenFilePanel("Load Files", ObjectManager.ObjectFolder, "", true);
        foreach (var path in paths)
        {
            UploadFile(path+";");
        }
    }
#endif
    WebGL_SceneManager SceneManager;
    Stream stream;
    void StartCommon()
    {
        SceneManager = GameObject.Find("GameAdmin").GetComponent<WebGL_SceneManager>();
    }
    void UploadFile(string fileUrl)
    {
        Debug.Log(fileUrl);
        string fileName = Path.GetFileName(fileUrl);
        string filePath = fileUrl.Replace(Path.GetFileName(fileUrl), "");
        ObjectManager.WebGL_FileManager.AddFile(fileUrl);
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
