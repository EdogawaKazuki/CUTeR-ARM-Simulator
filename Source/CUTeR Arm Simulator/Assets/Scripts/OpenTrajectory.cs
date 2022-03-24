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
            for (int i = 0; i < 3; i++)
            {
                RobotController.Trajs[i].Clear();
            }
            string[] trajsTextArray = trajText.Split(';');
            if (trajsTextArray[0].Equals("angle"))
            {
                for (int i = 1; i < 4; i++)
                {
                    string[] tmp = trajsTextArray[i].Split(',');
                    foreach (var point in tmp)
                    {
                        if (point.Equals("fire"))
                        {
                            RobotController.Trajs[i - 1].Add(1000);
                        }
                        else
                        {
                            RobotController.Trajs[i - 1].Add(float.Parse(point));
                        }
                    }
                }
            }
            else if (trajsTextArray[0].Equals("point"))
            {
                string[] pointX = trajsTextArray[1].Split(',');
                string[] pointY = trajsTextArray[2].Split(',');
                string[] pointZ = trajsTextArray[3].Split(',');
                for (int i = 0; i < pointX.Length; i++)
                {
                    Debug.Log(pointX[i] + "," + pointY[i] + "," + pointZ[i]);

                    if (pointX[i].Equals("fire"))
                    {
                        for (int j = 0; j < 3; j++)
                            RobotController.Trajs[j].Add(1000);
                    }
                    else
                    {
                        float[] angles = CartesianToAngle(float.Parse(pointX[i]), float.Parse(pointY[i]), float.Parse(pointZ[i]));
                        for (int j = 0; j < 3; j++)
                            RobotController.Trajs[j].Add(angles[j]);
                    }
                }
            }
            else
            {
                Result.text = "Load Failed...";
                return;
            }
            RobotController.trajLength = RobotController.Trajs[0].Count;
            Result.text = "Done!";
        }
        catch (Exception e)
        {
            Debug.Log(e);
            Result.text = "Load Failed...";
        }
    }

    float[] CartesianToAngle(float x, float y, float z)
    {
        x = -x;
        y = -y;
        float[] angles = new float[3];
        float l1 = 10.18f;
        float l2 = 19.41f;
        float l3 = 2.91f;
        float l23 = Mathf.Sqrt(l2 * l2 + l3 * l3);
        float l4 = 20.2f;
        float alpha = Mathf.Atan(l3 / l2);
        if (x == 0)
        {
            angles[0] = Mathf.PI / 2;
        }
        else
        {
            if (x > 0)
            {
                angles[0] = Mathf.Atan(-y / x);
            }
            else
            {
                angles[0] = Mathf.PI - Mathf.Atan(y / x);
            }
        }
        float A = -y * Mathf.Sin(angles[0]) + x * Mathf.Cos(angles[0]);
        float B = z - l1;
        float tmp = (A * A + B * B - (l23 * l23 + l4 * l4)) / (2 * l23 * l4);
        if (tmp < -1)
            tmp = -0.999999f;
        if (tmp > 1)
            tmp = 0.99999f;
        angles[2] = -Mathf.Acos(tmp);
        if ((A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])) > 0)
            angles[1] = Mathf.Atan((B * (l23 + l4 * Mathf.Cos(angles[2])) - A * l4 * Mathf.Sin(angles[2])) /
                                   (A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])));
        else
            angles[1] = Mathf.PI - Mathf.Atan((B * (l23 + l4 * Mathf.Cos(angles[2])) - A * l4 * Mathf.Sin(angles[2])) /
                                   -(A * (l23 + l4 * Mathf.Cos(angles[2])) + B * l4 * Mathf.Sin(angles[2])));

        angles[0] = angles[0] / Mathf.PI * 180 - 90;
        angles[1] = (angles[1] + alpha) / Mathf.PI * 180;
        angles[2] = (angles[2] - alpha) / Mathf.PI * 180;
        return angles;
    }
}
