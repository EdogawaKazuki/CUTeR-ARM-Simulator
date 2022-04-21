using SFB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ObjTrajectoryLoader: MonoBehaviour, IPointerDownHandler
{
    public Text Result;
    string trajText;
    List<Vector3> TrajPosition;
    List<Vector3> TrajRotation;
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
            StartCoroutine(OutputRoutine(new Uri(paths[0]).AbsoluteUri));
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
            string[] gestureTextArray = trajText.Split(';');
            string[] xPositionArray = gestureTextArray[0].Split(',');
            string[] yPositionArray = gestureTextArray[1].Split(',');
            string[] zPositionArray = gestureTextArray[2].Split(',');
            string[] xRotationArray = gestureTextArray[3].Split(',');
            string[] yRotationArray = gestureTextArray[4].Split(',');
            string[] zRotationArray = gestureTextArray[5].Split(',');
            List<Vector3> TrajPosition = InputEventManager.selectedObject.GetComponent<ObjTrajectoryExecutor>().TrajPosition;
            List<Vector3> TrajRotation = InputEventManager.selectedObject.GetComponent<ObjTrajectoryExecutor>().TrajRotation;
            InputEventManager.selectedObject.GetComponent<ObjTrajectoryExecutor>().trajLength = zRotationArray.Length;
            TrajPosition.Clear();
            TrajRotation.Clear();
            for (int i = 0;i< xPositionArray.Length; i++)
            {
                TrajPosition.Add(new Vector3(float.Parse(xPositionArray[i]), float.Parse(yPositionArray[i]), float.Parse(zPositionArray[i])));
                TrajRotation.Add(new Vector3(float.Parse(xRotationArray[i]), float.Parse(yRotationArray[i]), float.Parse(zRotationArray[i])));
            }
            InputEventManager.selectedObject.transform.localPosition = TrajPosition[0];
            InputEventManager.selectedObject.transform.localEulerAngles = TrajRotation[0];

        }
        catch (Exception e)
        {
            Debug.Log(e);
            Result.text = "Load Failed...";
        }
    }

}
