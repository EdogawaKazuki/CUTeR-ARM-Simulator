using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class WebGL_FileManager : MonoBehaviour
{
    int fileCount;
    int uploadedFileCount;
    string sceneFile;
    static public Dictionary<string, string> fileDict;
    static public Dictionary<string, Stream> streamDict;
    // Start is called before the first frame update
    void Start()
    {
        fileDict = new Dictionary<string, string>();
        streamDict = new Dictionary<string, Stream>();
    }
    public void AddFile(string urls)
    {
        Debug.Log("adding url: " + urls);
        string[] file = urls.Split(';');
        fileCount = 0;
        uploadedFileCount = 0;
        for(int i = 0; i < file.Length - 1; i++)
        {
            string[] kv = file[i].Split(',');
            string[] tmp = kv[0].Split('.');
            if (tmp[tmp.Length - 1].Equals("meta"))
                continue;
            if (tmp[tmp.Length - 1].Equals("json"))
                sceneFile = kv[0];
            Debug.Log("adding kv: " + kv[0] + "," + kv[1]);
            fileCount++;
            if (fileDict.ContainsKey(kv[0]))
            {
                fileDict[kv[0]] = kv[1];
            }
            else
            {
                fileDict.Add(kv[0], kv[1]);
            }
            StartCoroutine(OutputRoutine(kv));
        }
    }
    public void Clear()
    {
        fileDict.Clear();
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
            Stream stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(request.downloadHandler.text);
            writer.Flush();
            stream.Position = 0;
            if (streamDict.ContainsKey(kv[0]))
            {
                streamDict[kv[0]] = stream;
            }
            else
            {
                streamDict.Add(kv[0], stream);
            }
            uploadedFileCount++;
            Debug.Log(uploadedFileCount + "," + fileCount);
            if(fileCount == uploadedFileCount)
            {
                ObjectManager.GameAdmin.gameObject.GetComponent<WebGL_SceneManager>().LoadScene(sceneFile, true);
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}
