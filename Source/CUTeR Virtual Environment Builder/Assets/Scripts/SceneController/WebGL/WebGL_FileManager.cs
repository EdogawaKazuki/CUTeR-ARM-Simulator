using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebGL_FileManager : MonoBehaviour
{
    Transform FileListContiner;
    Transform FileListEle;
    int fileCount;
    int uploadedFileCount;
    string sceneFile;
    WebGL_SceneManager SceneManager;
    static public Dictionary<string, string> filePathDict;
    static public Dictionary<string, string> fileDataDict;
    static public Dictionary<string, Stream> streamDict;
    static public List<string> objList;
    static public List<string> sceneList;
    static public List<string> fileList;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager = GameObject.Find("GameAdmin").GetComponent<WebGL_SceneManager>();
        FileListContiner = ObjectManager.FileListContiner;
        FileListEle = ObjectManager.FileListEle;
        filePathDict = new Dictionary<string, string>();
        fileDataDict = new Dictionary<string, string>();
        streamDict = new Dictionary<string, Stream>();
        objList = new List<string>();
        sceneList = new List<string>();
        fileList = new List<string>();
    }
    public void AddFile(string urls)
    {
        Debug.Log("adding url: " + urls);
        string[] file = urls.Split(';');
        fileCount = 0;
        uploadedFileCount = 0;
        print(file.Length);
        for(int i = 0; i < file.Length - 1; i++)
        {

#if UNITY_WEBGL && !UNITY_EDITOR
            string[] kv = file[i].Split(',');
#else
            string[] tmp = file[i].Split('/');
            tmp = tmp[tmp.Length - 1].Split('\\');
            string[] kv = { tmp[tmp.Length - 1], file[i] };
#endif
            fileCount++;
            if (filePathDict.ContainsKey(kv[0]))
            {
                filePathDict[kv[0]] = kv[1];
            }
            else
            {
                filePathDict.Add(kv[0], kv[1]);
                fileList.Add(kv[0]);
                if (Path.GetExtension(kv[0]).Equals(".json"))
                    sceneList.Add(kv[0]);
                else if (Path.GetExtension(kv[0]).Equals(".obj"))
                    objList.Add(kv[0]);
            }
            StartCoroutine(OutputRoutine(kv));
        }
    }
    public void Clear()
    {
        filePathDict.Clear();
        streamDict.Clear();
    }
    private IEnumerator OutputRoutine(string[] kv)
    {
        var request = UnityWebRequest.Get(kv[1]);
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
                Debug.Log("Received Success: " + kv[0]);
                break;
        }
        try
        {
            print(kv[0]);

            if (fileDataDict.ContainsKey(kv[0]))
            {
                fileDataDict[kv[0]] = request.downloadHandler.text;
            }
            else
            {
                fileDataDict.Add(kv[0], request.downloadHandler.text);
            }
            uploadedFileCount++;
            Debug.Log("uploaded: " + uploadedFileCount + ",total needed: " + fileCount);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
    public void ShowFileList()
    {
        for (int i = 1; i < FileListContiner.childCount; i++)
        {
            Destroy(FileListContiner.GetChild(i).gameObject);
        }
        foreach (var file in fileList)
        {
            Transform newEle = Instantiate(FileListEle);
            newEle.SetParent(FileListContiner);
            newEle.gameObject.SetActive(true);
            newEle.name = file;
            // modify the scene card
            newEle.Find("Name").GetComponent<Text>().text = file;
            RectTransform rect = newEle.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(Screen.width * 400 / 1920, Screen.height * 50 / 1080);
        }
        Debug.Log(Screen.width + "," + Screen.height);
    }
    public void ShowSceneList()
    {
        for (int i = 1; i < FileListContiner.childCount; i++)
        {
            Destroy(FileListContiner.GetChild(i).gameObject);
        }
        foreach (var file in sceneList)
        {
            Transform newEle = Instantiate(FileListEle);
            newEle.SetParent(FileListContiner);
            newEle.gameObject.SetActive(true);
            newEle.name = file;
            // modify the scene card
            newEle.Find("Name").GetComponent<Text>().text = file;
            newEle.GetComponent<Button>().onClick.AddListener(delegate { LoadScene(file); ObjectManager.LoadScenePanel.SetActive(false); });
            RectTransform rect = newEle.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(Screen.width * 400 / 1920, Screen.height * 50 / 1080);
        }
    }
    public void ShowObjList()
    {
        for (int i = 1; i < FileListContiner.childCount; i++)
        {
            Destroy(FileListContiner.GetChild(i).gameObject);
        }
        foreach (var file in objList)
        {
            Transform newEle = Instantiate(FileListEle);
            newEle.SetParent(FileListContiner);
            newEle.gameObject.SetActive(true);
            newEle.name = file;
            // modify the scene card
            newEle.Find("Name").GetComponent<Text>().text = file;
            newEle.GetComponent<Button>().onClick.AddListener(delegate { LoadObj(file); ObjectManager.LoadScenePanel.SetActive(false); });
            RectTransform rect = newEle.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(Screen.width * 400 / 1920, Screen.height * 50 / 1080);
        }
    }

    public void LoadScene(string value)
    {
        SceneManager.LoadScene(value, true);
    }
    public void LoadObj(string value)
    {
        SceneManager.CreateObjectFromFile(value, true);
    }
}
