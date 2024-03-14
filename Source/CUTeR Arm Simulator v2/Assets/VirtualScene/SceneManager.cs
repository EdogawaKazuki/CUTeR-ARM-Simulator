using Dummiesman;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private Transform _sceneContainer;
    private Text _sceneStatusText;
    private Image _sceneStatusBackground;
    private InputField _sceneNameIF;
    private InputField _sceneDescriptionIF;
    private StaticRobotTrajectoryController _robotTrajectoryController;
    private string _sceneFolder = "";
    // private TMP_Text _debugText;

    private int _objectCounter = 0;
    private string _objectFolder = "";

    public string sceneName;
    public string description;
    private Transform _playingScene = null;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        // Transform _saveScenePanel = transform.Find("VirtualSceneCanvas/SaveScenePanel");
        Transform _sceneCtrlBtnGroup = transform.Find("VirtualSceneCanvas/SceneCtrlBtnGroup");

        _robotTrajectoryController = GameObject.Find("Robot").GetComponent<RobotController>().GetTrajController();
        _sceneFolder = Application.dataPath + "/Resources/scenes";
        _objectFolder = Application.dataPath + "/Resources/objects";
        // _debugText = transform.Find("VirtualSceneCanvas/DebugText").GetComponent<TMP_Text>();
        
        // _sceneNameIF = _saveScenePanel.Find("Window/Name/InputField").GetComponent<InputField>();
        // _sceneDescriptionIF = _saveScenePanel.Find("Window/Description/InputField").GetComponent<InputField>();

        SetupControlBar(_sceneCtrlBtnGroup);
        GameObject.Find("Robot").GetComponent<RobotController>()._enableTransparentRobot = false;
    }
    private void OnDisable()
    {
        if (_playingScene != null)
        {
            Destroy(_playingScene.gameObject);
            _playingScene = null;
        }
        GameObject.Find("Robot").GetComponent<RobotController>()._enableTransparentRobot = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void SetupControlBar(Transform robotCtrlBtnGroup)
    {
        robotCtrlBtnGroup.Find("PlayToggle").GetComponent<Toggle>().onValueChanged.AddListener((value) => StartScene(value));
        robotCtrlBtnGroup.Find("ResetButton").GetComponent<Button>().onClick.AddListener(() => StopScene());
        _sceneStatusText = robotCtrlBtnGroup.Find("status/Text").GetComponent<Text>();
        _sceneStatusBackground = robotCtrlBtnGroup.Find("status/Image").GetComponent<Image>();
    }
    public Transform GetSceneContainer()
    {
        return _sceneContainer;
    }
    public void UpdateUI()
    {
        // todo
    }
    public void NewScene()
    {
        sceneName = "New Scene";
        description = "New Scene";
        for (int i = 0; i < _sceneContainer.childCount; i++)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Destroy(_sceneContainer.GetChild(i).gameObject);
        }
        UpdateUI();
    }
    public void LoadScene(string sceneString)
    {
        NewScene();

        Dictionary<string, object> sceneDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(sceneString);

        // load basic info
        sceneName = sceneDict["name"].ToString();
        description = sceneDict["description"].ToString();
        // _sceneNameIF.text = sceneName;
        // _sceneDescriptionIF.text = description;
        _robotTrajectoryController.ProcessTraj(sceneDict["robotTraj"].ToString());

        // load objects
        Dictionary<string, object>[] objDataStrList = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(sceneDict["objectInfo"].ToString());


        // Load Objects
        for (int i = 0; i < objDataStrList.Length; i++)
        {
            AddObjByDict(objDataStrList[i]);
        }

        UpdateUI();
    }
    public void LoadSceneByPath(string path)
    {
        Debug.Log(path);
        // _debugText.text = path + "\n" + _debugText.text;
        LoadScene(File.ReadAllText(path));
    }
    
    public void StartScene(bool value)
    {
        if (_playingScene != null)
        {
            if (!value)
            {
                _sceneStatusText.text = "Pause";
                _sceneStatusBackground.color = new Color32(255, 255, 100, 255);
                Time.timeScale = 0;
            }
            else
            {
                _sceneStatusText.text = "Playing";
                _sceneStatusBackground.color = new Color32(100, 255, 100, 255);
                Time.timeScale = 1;
            }
        }
        else
        {
            _playingScene = Instantiate(_sceneContainer).transform;
            _playingScene.SetParent(_sceneContainer.parent);
            _playingScene.localPosition = transform.position;
            _playingScene.localEulerAngles = _sceneContainer.localEulerAngles;
            Debug.Log(_playingScene.transform.childCount);
            for (int i = 0; i < _playingScene.transform.childCount; i++)
            {
                SceneObjectController sceneObjectController = _playingScene.transform.GetChild(i).GetComponent<SceneObjectController>();
                if (sceneObjectController.isRigidbody)
                {
                    Rigidbody rigidbody = sceneObjectController.AddRigidbody();
                    rigidbody.isKinematic = false;
                    rigidbody.centerOfMass = Vector3.zero;
                    rigidbody.inertiaTensorRotation = Quaternion.identity;
                    rigidbody.useGravity = sceneObjectController.useGravity;
                    if (sceneObjectController.fixPositionX)
                        rigidbody.constraints |= RigidbodyConstraints.FreezePositionX;
                    if (sceneObjectController.fixPositionY)
                        rigidbody.constraints |= RigidbodyConstraints.FreezePositionY;
                    if (sceneObjectController.fixPositionZ)
                        rigidbody.constraints |= RigidbodyConstraints.FreezePositionZ;
                    if (sceneObjectController.fixRotationX)
                        rigidbody.constraints |= RigidbodyConstraints.FreezeRotationX;
                    if (sceneObjectController.fixRotationY)
                        rigidbody.constraints |= RigidbodyConstraints.FreezeRotationY;
                    if (sceneObjectController.fixRotationZ)
                        rigidbody.constraints |= RigidbodyConstraints.FreezeRotationZ;
                }
                else
                {
                    if (_playingScene.transform.GetChild(i).gameObject.GetComponent<BoxCollider>())
                    {
                        Destroy(_playingScene.transform.GetChild(i).gameObject.GetComponent<BoxCollider>());
                    }
                    else if (_playingScene.transform.GetChild(i).gameObject.GetComponent<CapsuleCollider>())
                    {
                        Destroy(_playingScene.transform.GetChild(i).gameObject.GetComponent<CapsuleCollider>());
                    }
                    else if (_playingScene.transform.GetChild(i).gameObject.GetComponent<SphereCollider>())
                    {
                        Destroy(_playingScene.transform.GetChild(i).gameObject.GetComponent<SphereCollider>());
                    }
                    else
                    {
                        for (int j = 0; j < _playingScene.transform.GetChild(i).childCount; j++)
                        {
                            if (_playingScene.transform.GetChild(i).GetChild(j).gameObject.GetComponent<MeshCollider>())
                            {
                                Destroy(_playingScene.transform.GetChild(i).GetChild(j).gameObject.GetComponent<MeshCollider>());
                            }
                        }

                    }
                }
            }

            _sceneContainer.gameObject.SetActive(false);
            _sceneStatusText.text = "Playing";
            _sceneStatusBackground.color = new Color32(100, 255, 100, 255);
            Time.timeScale = 1;
            _robotTrajectoryController.StartTraj();
        }
    }
    public void StopScene()
    {
        if (_playingScene == null)
            return;
        Destroy(_playingScene.gameObject);
        _playingScene = null;
        _sceneContainer.gameObject.SetActive(true);
        _sceneStatusText.text = "Ready";
        _sceneStatusBackground.color = new Color32(255, 255, 255, 255);
        _robotTrajectoryController.gameObject.GetComponent<RobotController>().ResetEndEffector();
        _robotTrajectoryController.StopTraj();
        transform.Find("VirtualSceneCanvas/SceneCtrlBtnGroup/PlayToggle").GetComponent<Toggle>().onValueChanged.RemoveAllListeners();
        transform.Find("VirtualSceneCanvas/SceneCtrlBtnGroup/PlayToggle").GetComponent<Toggle>().isOn = false;
        transform.Find("VirtualSceneCanvas/SceneCtrlBtnGroup/PlayToggle").GetComponent<Toggle>().onValueChanged.AddListener((value) => StartScene(value));
        Time.timeScale = 1;
    }
    public void StartObjectTrajectory()
    {
        for (int i = 0; i < _playingScene.childCount; i++)
        {
            _playingScene.GetChild(i).GetComponent<SceneObjectController>().StartTraj();
        }
    }
    public void StopObjectTrajectory()
    {
        for (int i = 0; i < _playingScene.childCount; i++)
        {
            _playingScene.GetChild(i).GetComponent<SceneObjectController>().StopTraj();
        }
    }

    public void SaveScene()
    {
        string sceneString = GetSceneJsonString();
        // Save to file
        Debug.Log("saving to json " + _sceneFolder + "/" + sceneName + ".json");
        File.WriteAllText(_sceneFolder + "/" + sceneName + ".json", sceneString);
        //Debug.Log("saving to png " + _sceneFolder + "/" + _name + ".png");
        ScreenCapture.CaptureScreenshot(_sceneFolder + "/" + sceneName + ".png");
        //ObjectManager.InformationText.text = "Scene: " + _name + ". IP: " + ObjectManager.ipAddress + " Server " + ObjectManager.serverStatus;
    }
    public string GetSceneJsonString()
    {
        Dictionary<string, object> jsonDict = new Dictionary<string, object>
        {
            { "name", sceneName },
            { "description", description },
            { "date", DateTime.Now },
            { "robotTraj", _robotTrajectoryController.GetTrajString() }
        };
        Debug.Log(jsonDict["robotTraj"]);

        List<Dictionary<string, object>> objList = new List<Dictionary<string, object>>();
        for (int i = 0; i < _sceneContainer.childCount; i++)
        {
            objList.Add(_sceneContainer.GetChild(i).GetComponent<SceneObjectController>().GetPropDict());
        }
        jsonDict.Add("objectInfo", objList);

        return JsonConvert.SerializeObject(jsonDict);
    }
    public void SetName(string name) { this.sceneName = name; } 
    public void SetDescription(string description) { this.description = description; }
    
    public void AddObjByDict(Dictionary<string, object> objDict)
    {
        if (GetPlayingScene() != null)
            return;
        GameObject newObj;
        //Debug.Log(objDict["filename"].ToString());
        if ((SceneObjectController.Type)int.Parse(objDict["type"].ToString()) == SceneObjectController.Type.obj)
        {
            newObj = AddObjByPath(objDict["filename"].ToString());
        }
        else
        {
            newObj = AddPrimitiveObj((SceneObjectController.Type)int.Parse(objDict["type"].ToString()));
        }
        newObj.GetComponent<SceneObjectController>().SetPropByDict(objDict, GetSceneContainer());
        //newObj.GetComponent<SceneObjectController>().SetPropByJsonString(jsonString, _sceneManager.GetSceneContainer());
    }
    public GameObject AddObjByPath(string path)
    {
        if (GetPlayingScene() != null)
            return null;
        GameObject newObj = new GameObject();
        newObj.transform.parent = GetSceneContainer();
        newObj.transform.localPosition = new Vector3(0, 5, -20);
        newObj.AddComponent<SceneObjectController>().SetSceneObjectTrajectoryController(newObj.AddComponent<SceneObjectTrajectoryController>());
        newObj.GetComponent<SceneObjectController>().ID = _objectCounter;
        newObj.GetComponent<SceneObjectController>().filename = Path.GetFileName(path);
        newObj.GetComponent<SceneObjectController>().type = SceneObjectController.Type.obj;
        _objectCounter++;

        Transform newPart = new OBJLoader().Load(_objectFolder + "/" + path + ".obj").transform;
        Debug.Log(newPart.transform.childCount);
        int totalObj = newPart.transform.childCount;
        for (int i = 0; i < totalObj; i++)
        {
            newPart.transform.GetChild(0).gameObject.AddComponent<SceneObjectPart>().SetParent(newObj.transform);
            Debug.Log(newPart.transform.GetChild(0).gameObject.GetComponent<SceneObjectPart>().GetParent());
            newPart.transform.GetChild(0).gameObject.layer = LayerMask.NameToLayer("Scene");
            newPart.transform.GetChild(0).gameObject.AddComponent<MeshCollider>().convex = true;
            newPart.transform.GetChild(0).SetParent(newObj.transform);
            newObj.transform.GetChild(i).localPosition = new Vector3(0, 0, 0);
            newObj.transform.GetChild(i).localRotation = Quaternion.identity;
            newObj.transform.GetChild(i).localScale = Vector3.one;
        }
        Destroy(newPart.gameObject);
        return newObj;
    }
    public void AddPrimitiveObjByIndex(int index)
    {
        AddPrimitiveObj((SceneObjectController.Type) index);
    }
    public GameObject AddPrimitiveObj(SceneObjectController.Type type)
    {
        if (GetPlayingScene() != null)
            return null;
        GameObject newObj = new GameObject();
        newObj.transform.parent = GetSceneContainer();
        newObj.transform.localPosition = new Vector3(0, 5, -20);
        newObj.AddComponent<SceneObjectController>().SetSceneObjectTrajectoryController(newObj.AddComponent<SceneObjectTrajectoryController>());
        newObj.GetComponent<SceneObjectController>().ID = _objectCounter;
        newObj.GetComponent<SceneObjectController>().type = type;
        _objectCounter++;

        Transform newPart;
        switch (type)
        {
            case SceneObjectController.Type.cube:
                newPart = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
                break;
            case SceneObjectController.Type.sphere:
                newPart = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
                break;
            case SceneObjectController.Type.cylinder:
                newPart = GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform;
                break;
            case SceneObjectController.Type.capsule:
                newPart = GameObject.CreatePrimitive(PrimitiveType.Capsule).transform;
                break;
            default:
                newPart = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
                break;
        }
        newPart.SetParent(newObj.transform);
        newPart.localPosition = new Vector3(0, 0, 0);
        newPart.localRotation = Quaternion.identity;
        newPart.localScale = Vector3.one;
        newPart.gameObject.AddComponent<SceneObjectPart>().SetParent(newObj.transform);
        newPart.gameObject.layer = LayerMask.NameToLayer("Scene");
        newObj.transform.localScale = Vector3.one * 5;
        return newObj;
    }
    
    public Transform GetPlayingScene() { return _playingScene ; }
}
