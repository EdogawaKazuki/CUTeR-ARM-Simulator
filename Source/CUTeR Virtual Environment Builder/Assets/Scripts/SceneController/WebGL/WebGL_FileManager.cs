using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class WebGL_FileManager : MonoBehaviour
{
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
        for(int i = 0; i < file.Length - 1; i++)
        {
            string[] kv = file[i].Split(',');
            Debug.Log("adding kv: " + kv[0] + "," + kv[1]);
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
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}
