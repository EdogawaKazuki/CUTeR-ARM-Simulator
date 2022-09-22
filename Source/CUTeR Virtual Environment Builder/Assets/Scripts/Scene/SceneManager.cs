using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private Transform _sceneContainer;
    [SerializeField]
    private Text _sceneStatusText;
    [SerializeField]
    private Image _sceneStatusBackground;
    [SerializeField]
    private Transform _saveScenePanel;
    [SerializeField]
    private InputField _sceneNameIF;
    [SerializeField]
    private InputField _sceneDescriptionIF;
    [SerializeField]
    private EditorController _editorController;
    [SerializeField]
    private StaticRobotTrajectoryController _robotTrajectoryController;
    private string _sceneFolder = "";

    public string sceneName;
    public string description;
    private Transform _playingScene = null;
    // Start is called before the first frame update
    void Start()
    {
        _sceneFolder = Application.dataPath + "/Resources/scenes";
    }

    // Update is called once per frame
    void Update()
    {
        
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
        _sceneNameIF.text = sceneName;
        _sceneDescriptionIF.text = description;
        _robotTrajectoryController.ProcessTraj(sceneDict["robotTraj"].ToString());

        // load objects
        Dictionary<string, object>[] objDataStrList = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(sceneDict["objectInfo"].ToString());


        // Load Objects
        for (int i = 0; i < objDataStrList.Length; i++)
        {
            _editorController.AddObjByDict(objDataStrList[i]);
        }

        UpdateUI();
    }
    public void LoadSceneByPath(string path)
    {
        Debug.Log(path);
        _editorController.debugText.text = path + "\n" + _editorController.debugText.text;
        LoadScene(File.ReadAllText(path));
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
        Dictionary<string, object> jsonDict = new Dictionary<string, object>();
        jsonDict.Add("name", sceneName);
        jsonDict.Add("description", description);
        jsonDict.Add("date", DateTime.Now);
        jsonDict.Add("robotTraj", _robotTrajectoryController.GetTrajString());
        Debug.Log(jsonDict["robotTraj"]);

        List<Dictionary<string, object>> objList = new List<Dictionary<string, object>>();
        for (int i = 0; i < _sceneContainer.childCount; i++)
        {
            objList.Add(_sceneContainer.GetChild(i).GetComponent<SceneObjectController>().GetPropDict());
        }
        jsonDict.Add("objectInfo", objList);

        return JsonConvert.SerializeObject(jsonDict);
    }
    public void StartScene(bool value)
    {
        if(_playingScene != null)
        {
            if (!value)
            {
                _sceneStatusText.text = "Pause";
                _sceneStatusBackground.color = new Color32(255, 255, 100, 160);
                Time.timeScale = 0;
            }
            else
            {
                _sceneStatusText.text = "Playing";
                _sceneStatusBackground.color = new Color32(100, 255, 100, 160);
                Time.timeScale = 1;
            }
        }
        else
        {
            _playingScene = Instantiate(_sceneContainer).transform;
            _playingScene.SetParent(_sceneContainer.parent);
            _playingScene.localPosition = _editorController.GetRobotController().transform.localPosition;
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
            if (_editorController.GetSelectedObj() != null)
                for (int j = 0; j < _playingScene.transform.childCount; j++)
                {
                    if (_playingScene.transform.GetChild(j).gameObject.GetComponent<SceneObjectController>().ID == _editorController.GetSelectedObj().GetComponent<SceneObjectController>().ID)
                        _editorController.SelectObj(_playingScene.transform.GetChild(j));
                }
            _sceneStatusText.text = "Playing";
            _sceneStatusBackground.color = new Color32(100, 255, 100, 160);
            _editorController.GetSelectedObj();
            Time.timeScale = 1;
        }
    }
    public void StopScene()
    {
        Destroy(_playingScene.gameObject);
        _playingScene = null;
        _sceneContainer.gameObject.SetActive(true);

        if (_editorController.GetSelectedObj() != null)
            for (int j = 0; j < _sceneContainer.transform.childCount; j++)
            {
                if (_sceneContainer.transform.GetChild(j).gameObject.GetComponent<SceneObjectController>().ID == _editorController.GetSelectedObj().GetComponent<SceneObjectController>().ID)
                    _editorController.SelectObj(_sceneContainer.transform.GetChild(j));
            }
        _sceneStatusText.text = "Editing";
        _sceneStatusBackground.color = new Color32(255, 255, 255, 78);
        _editorController.GetRobotController().ResetEndEffector();
        Time.timeScale = 1;
    }
    public void SetName(string name) { this.sceneName = name; }
    public void SetDescription(string description) { this.description = description; }
    public Transform GetPlayingScene() { return _playingScene ; }
}
