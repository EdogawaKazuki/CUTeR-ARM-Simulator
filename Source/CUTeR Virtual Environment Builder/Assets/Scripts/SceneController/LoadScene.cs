using SFB;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;


public class LoadScene : MonoBehaviour, IPointerDownHandler
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
        UploadFile(gameObject.name, "OnFileUpload", ".json", false);
    }

    // Called from browser
    public void OnFileUpload(string url) {
        StartCoroutine(OutputRoutine(url));
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
        var paths = StandaloneFileBrowser.OpenFilePanel("Open Scene File", ObjectManager.SceneFolder, "json", false);
        if (paths.Length > 0)
        {
            StartCoroutine(OutputRoutine(paths[0]));
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
        SceneManager.LoadScene(path, true);
        transform.parent.parent.Find("Trigger").GetComponent<UIEventManager>().TurnOffToggle();
    }
    private IEnumerator OutputRoutine(string url)
    {
        var request = UnityWebRequest.Get(url);
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
                Debug.Log("Success");
                break;
        }
        SceneManager.LoadScene(url, false, request.downloadHandler.text);
    }
}
