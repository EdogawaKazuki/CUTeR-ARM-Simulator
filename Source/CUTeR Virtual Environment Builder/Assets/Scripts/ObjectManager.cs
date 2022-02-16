using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class ObjectManager : MonoBehaviour
{
    static public WebGL_FileManager WebGL_FileManager;

    static public GameObject GameAdmin;
    static public GameObject Scene;
    static public GameObject Marker;
    static public GameObject Axis;
    static public GameObject WorkingSpace;
    static public GameObject DeleteObjPanel;
    static public GameObject SaveScenePanel;
    static public GameObject AttributePanel;
    static public GameObject LoadScenePanel;

    static public GameObject HandToolToggleMark;
    static public GameObject MoveToolToggleMark;
    static public GameObject RotateToolToggleMark;
    static public GameObject ScaleToolToggleMark;

    static public GameObject[] ToolToggleMarkArray = new GameObject[4];

    static public Transform SceneListContiner;
    static public Transform SceneListEle;

    static public Camera EditorCamera;
    static public Camera AxisCamera;

    static public Dropdown ObjectDropdown;
    static public Dropdown SceneDropdown;

    static public InputField SceneName;
    static public InputField SceneDescription;

    static public Text DebugMsg;
    static public Text InformationText;
    static public Text DeletePanelName;

    static public ArrayList ObjectList;
    static public ArrayList SceneList;

    static public string SceneFolder;
    static public string ObjectFolder;
    static public string ipAddress;
    static public string serverStatus;
    // Start is called before the first frame update
    void Start()
    {
        // init  
        ObjectFolder = Application.dataPath + "/Resources/objects";
        SceneFolder = Application.dataPath + "/Resources/scenes";
        serverStatus = "Not Start";

        ObjectList = new ArrayList();
        SceneList = new ArrayList();

        // find objects
        GameAdmin = GameObject.Find("GameAdmin");
        Scene = GameObject.Find("Scene");
        Marker = GameObject.Find("Marker");
        Axis = GameObject.Find("moveAxis");
        WorkingSpace = GameObject.Find("Marker/Environment/WorkingSpace");
        SaveScenePanel = GameObject.Find("Canvas/SaveScenePanel");
        DeleteObjPanel = GameObject.Find("Canvas/DeleteObjPanel");
        AttributePanel = GameObject.Find("Canvas/AttributePanel");
        LoadScenePanel = GameObject.Find("Canvas/LoadScenePanel");
        SceneListContiner = LoadScenePanel.transform.Find("Window/SceneList/Viewport/Content");
        SceneListEle = SceneListContiner.transform.GetChild(0);

        WebGL_FileManager = GameAdmin.GetComponent<WebGL_FileManager>();

        EditorCamera = GameObject.Find("Main Camera/EditorCamera").GetComponent<Camera>();
        AxisCamera = GameObject.Find("Main Camera/AxisCamera").GetComponent<Camera>();

        SceneName = GameObject.Find("Canvas/SaveScenePanel/Window/Name/InputField").GetComponent<InputField>();
        SceneDescription = GameObject.Find("Canvas/SaveScenePanel/Window/Description/InputField").GetComponent<InputField>();

        ToolToggleMarkArray[0] = HandToolToggleMark = GameObject.Find("Canvas/ToolBtnGroup/HandTool/Background/Checkmark");
        ToolToggleMarkArray[1] = MoveToolToggleMark = GameObject.Find("Canvas/ToolBtnGroup/MoveTool/Background/Checkmark");
        ToolToggleMarkArray[2] = RotateToolToggleMark = GameObject.Find("Canvas/ToolBtnGroup/RotateTool/Background/Checkmark");
        ToolToggleMarkArray[3] = ScaleToolToggleMark = GameObject.Find("Canvas/ToolBtnGroup/ScaleTool/Background/Checkmark");

        DebugMsg = GameObject.Find("Canvas/DebugMsg").GetComponent<Text>();
        InformationText = GameObject.Find("Canvas/InformationText").GetComponent<Text>();
        DeletePanelName = GameObject.Find("Canvas/DeleteObjPanel/Window/Name").GetComponent<Text>();

        // hide objects
        Axis.SetActive(false);
        SaveScenePanel.SetActive(false);
        DeleteObjPanel.SetActive(false);
        AttributePanel.SetActive(false);
        LoadScenePanel.SetActive(false);
        SceneListEle.gameObject.SetActive(false);
        DebugMsg.gameObject.SetActive(false);


#if UNITY_WEBGL && !UNITY_EDITOR
        InformationText.text = "Scene: New Scene.";
#else
        // check scene/object folder
        if (!Directory.Exists(SceneFolder))
        {
            Debug.Log("Creating folder: " + SceneFolder);
            Directory.CreateDirectory(SceneFolder);
        }
        if (!Directory.Exists(ObjectFolder))
        {
            Debug.Log("Creating folder: " + ObjectFolder);
            Directory.CreateDirectory(ObjectFolder);
        }
        // get ip address
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                ipAddress = ip.ToString();
            }
        }
        InformationText.text = "Scene: New Scene. IP: " + ipAddress + " Server " + serverStatus;
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
