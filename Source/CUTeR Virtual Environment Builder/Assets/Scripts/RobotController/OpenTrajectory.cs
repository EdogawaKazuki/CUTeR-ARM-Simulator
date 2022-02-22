using SFB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class OpenTrajectory : MonoBehaviour, IPointerDownHandler
{
    public Text Result;
    string trajText;
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
        UploadFile(gameObject.name, "OnFileUpload", ".txt", false);
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
        var paths = StandaloneFileBrowser.OpenFilePanel("Open Trajectory", Application.dataPath + "/../", "txt", false);
        if (paths.Length > 0)
        {
            StartCoroutine(OutputRoutine(new System.Uri(paths[0]).AbsoluteUri));
        }
    }
#endif
    void StartCommon()
    {
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
                Debug.Log("Received: " + request.downloadHandler.text);
                break;
        }

        trajText = request.downloadHandler.text;
        ProcessTraj();
        /*
        if (thread!= null && thread.IsAlive)
        {
            Debug.Log("abort");
            thread.Abort();
        }
        else
        {
            Debug.Log("new thread");
            thread = new Thread(ProcessTraj);
            Debug.Log("new thread");
            thread.Start();
            Debug.Log("new thread");
        }
        */
    }
    void ProcessTraj()
    {
        try
        {
            string[] trajsTextArray = trajText.Split(';');
            for (int i = 0; i < 3; i++)
            {
                RobotController.Trajs[i].Clear();
                string[] tmp = trajsTextArray[i].Split(',');
                foreach (var point in tmp)
                {
                    if (point.Equals("fire"))
                    {
                        RobotController.Trajs[i].Add(1000);
                    }
                    else
                    {
                        RobotController.Trajs[i].Add(float.Parse(point));
                    }
                }
            }
            RobotController.trajLength = RobotController.Trajs[0].Count;
            Result.text = "Done!";
            ObjectManager.TrajectoryStatus.text = "Ready to play";
            ObjectManager.TrajectoryBG.color = new Color32(255, 255, 255, 78);
        }
        catch(Exception e)
        {
            Debug.Log(e);
            Result.text = "Load Failed...";
        }
    }

}
