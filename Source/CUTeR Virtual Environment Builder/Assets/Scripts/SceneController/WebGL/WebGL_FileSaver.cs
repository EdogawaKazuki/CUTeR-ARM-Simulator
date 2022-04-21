using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;

[RequireComponent(typeof(Button))]
public class WebGL_FileSaver : MonoBehaviour, IPointerDownHandler
{
    public Text output;

    // Sample text data
    private string _data = "Example text created by StandaloneFileBrowser";

    WebGL_SceneManager WebGL_SceneManager;

#if UNITY_WEBGL && !UNITY_EDITOR
    //
    // WebGL
    //
    [DllImport("__Internal")]
    private static extern void DownloadFile(string gameObjectName, string methodName, string filename, byte[] byteArray, int byteArraySize);
    void Start()
    {
        WebGL_SceneManager = ObjectManager.GameAdmin.GetComponent<WebGL_SceneManager>();
    }
    // Broser plugin should be called in OnPointerDown.
    public void OnPointerDown(PointerEventData eventData) {
        GetSceneString();
        var bytes = Encoding.UTF8.GetBytes(_data);
        DownloadFile(gameObject.name, "OnFileDownload", WebGL_SceneManager.SceneName + ".json", bytes, bytes.Length);
    }

    // Called from browser
    public void OnFileDownload() {
        //output.text = "File Successfully Downloaded";
    }
#else
    //
    // Standalone platforms & editor
    //
    public void OnPointerDown(PointerEventData eventData) { }

    // Listen OnClick event in standlone builds
    void Start()
    {
        WebGL_SceneManager = ObjectManager.GameAdmin.GetComponent<WebGL_SceneManager>();
        var button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        GetSceneString();
        var path = StandaloneFileBrowser.SaveFilePanel("Title", "", WebGL_SceneManager.SceneName, "json");
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, _data);
        }
    }
#endif
    void GetSceneString()
    {
        _data = WebGL_SceneManager.GetSceneString();
    }
}