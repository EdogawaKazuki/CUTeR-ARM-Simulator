using SFB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class OpenTrajectory6DoF : MonoBehaviour, IPointerDownHandler
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
            RobotController6DoF.trajString = trajText;
            int jointsLength = 0;
            for (int i = 0; i < 6; i++)
            {
                RobotController6DoF.Trajs[i].Clear();
            }
            string[] trajsTextArray = trajText.Split(';');
            if (trajsTextArray[0].Equals("angle"))
            {
                for (int i = 1; i < 7; i++)
                {
                    if (i < trajsTextArray.Length - 1)
                    {
                        string[] tmp = trajsTextArray[i].Split(',');
                        if (jointsLength != 0 && jointsLength != tmp.Length)
                        {
                            Debug.Log(jointsLength + ", " + tmp.Length + ", " + i);
                            Result.text = "Load Failed, lists' length are not identical.";
                            return;
                        }
                        jointsLength = tmp.Length;
                        foreach (var point in tmp)
                        {
                            if (point.Equals("fire"))
                            {
                                RobotController6DoF.Trajs[i - 1].Add(1000);
                            }
                            else
                            {
                                RobotController6DoF.Trajs[i - 1].Add(float.Parse(point));
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < jointsLength; j++)
                            RobotController6DoF.Trajs[i - 1].Add(0);
                    }
                }
            }
            else
            {
                Result.text = "Load Failed...";
                return;
            }
            RobotController6DoF.trajLength = RobotController6DoF.Trajs[0].Count;
            Result.text = "Done! Loaded " + (trajsTextArray.Length - 2) + " joints.";
        }
        catch (Exception e)
        {
            Debug.Log(e);
            Result.text = "Load Failed...";
        }
    }
}

