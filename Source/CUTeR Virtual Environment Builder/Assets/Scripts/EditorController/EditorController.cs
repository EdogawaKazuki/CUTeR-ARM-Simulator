using Dummiesman;
using Newtonsoft.Json;
using SFB;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class EditorController : MonoBehaviour
{
#if UNITY_WEBGL
    private bool _isWebGL=true;
#else 
    private bool _isWebGL = false;
#endif

    private SceneManager _sceneManager;
    [SerializeField]
    private HandleController _handleController;
    private SceneObjectAttrPanelController _sceneObjectAttrPanelController;
    [SerializeField]
    private RobotController _robotController;
    [SerializeField]
    private GameObject _ExerciseCanvas;
    [SerializeField]
    private GameObject _BuilderCanvas;
    [SerializeField]
    private Camera _mainCamera;
    [SerializeField]
    private Camera _arCamera;
    [SerializeField]
    private Transform _mainCameraContainer;
    [SerializeField]
    private Transform _arCameraContainer;
    [SerializeField]
    private GameObject _groundPlane;
    [SerializeField]
    private Transform _imageTarget;
    [SerializeField]
    public Text debugText;
    [SerializeField]
    private int _intialCanvasIndex = 0;
    private Dropdown _currentEndEffectorDropDown;

    private string _objectFolder = "";
    private Transform _selectedObject;
    private Transform _currentCanvas;
    private int _objectCounter = 0;
    public enum CanvasName
    {
        ExerciseCanvas,
        BuilderCanvas
    }
    // Start is called before the first frame update
    void Start()
    {
        _objectFolder = Application.dataPath + "/Resources/objects";
        _sceneObjectAttrPanelController = _BuilderCanvas.transform.Find("AttributePanel").GetComponent<SceneObjectAttrPanelController>();
        SetCanvasByIndex(_intialCanvasIndex);
        ResetCamera();
        Physics.gravity = new Vector3(0, -100.0F, 0);
    }

    private void OnEnable()
    {
        _sceneManager = GetComponent<SceneManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddObjByDict(Dictionary<string, object> objDict)
    {
        if (_sceneManager.GetPlayingScene() != null)
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
        newObj.GetComponent<SceneObjectController>().SetPropByDict(objDict, _sceneManager.GetSceneContainer());
        //newObj.GetComponent<SceneObjectController>().SetPropByJsonString(jsonString, _sceneManager.GetSceneContainer());
    }
    public void AddObjByJson(string jsonString)
    {
        AddObjByDict(JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString));
    }
    public GameObject AddObjByPath(string path)
    {
        if (_sceneManager.GetPlayingScene() != null)
            return null;
        GameObject newObj = new GameObject();
        newObj.transform.parent = _sceneManager.GetSceneContainer();
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
        if (_sceneManager.GetPlayingScene() != null)
            return null;
        GameObject newObj = new GameObject();
        newObj.transform.parent = _sceneManager.GetSceneContainer();
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
    public void AddObjBySelect()
    {

        var paths = StandaloneFileBrowser.OpenFilePanel("Open OBJ File", _objectFolder, "obj", false);
        if (paths.Length > 0) Debug.Log(paths[0]);
        string[] tmp = paths[0].Split('\\');
        tmp = tmp[tmp.Length - 1].Split('/');
        tmp = tmp[tmp.Length - 1].Split('.');
        AddObjByPath(tmp[0]);
    }
    public void SelectObj(Transform obj)
    {
        _selectedObject = obj;
        _sceneObjectAttrPanelController.SelectObject(obj);
    }
    public Transform GetSelectedObj() { return _selectedObject; }
    public void SetAxisByIndex(int index)
    {
        _handleController.SetHandle((HandleController.HandleType)index);
    }
    public SceneManager GetSceneManager() { return _sceneManager; }
    public HandleController GetHandleController() { return _handleController; }
    public SceneObjectAttrPanelController GetSceneObjectAttrPanelController() { return _sceneObjectAttrPanelController; }
    public RobotController GetRobotController() { return _robotController; }
    public void LoopTraj()
    {
        _robotController.GetTrajController().LoopTraj();
    }
    public void StartTraj()
    {
        _robotController.GetTrajController().StartTraj();
        //Debug.Log(_sceneManager.GetPlayingScene() != null);
    }
    public void StartObjectTraj()
    {
        if (_sceneManager.GetPlayingScene() != null)
        {
            for (int i = 0; i < _sceneManager.GetPlayingScene().childCount; i++)
            {
                _sceneManager.GetPlayingScene().GetChild(i).GetComponent<SceneObjectTrajectoryController>().StartTraj();
            }
        }
    }
    public void StopTraj()
    {
        _robotController.GetTrajController().StopTraj();
        if (_sceneManager.GetPlayingScene() != null)
        {
            for (int i = 0; i < _sceneManager.GetPlayingScene().childCount; i++)
            {
                _sceneManager.GetPlayingScene().GetChild(i).GetComponent<SceneObjectTrajectoryController>().StopTraj();
            }
        }
    }
    public void SetCanvas(CanvasName canvasName)
    {
        switch (canvasName)
        {
            case CanvasName.ExerciseCanvas:
                _ExerciseCanvas.SetActive(true);
                _BuilderCanvas.SetActive(false);
                break;
            case CanvasName.BuilderCanvas:
                _ExerciseCanvas.SetActive(false);
                _BuilderCanvas.SetActive(true);
                break;
        }
    }
    public void SetCanvasByIndex(int canvasName)
    {
        switch (canvasName)
        {
            case 0:
                _ExerciseCanvas.SetActive(true);
                _BuilderCanvas.SetActive(false);
                break;
            case 1:
                _ExerciseCanvas.SetActive(false);
                _BuilderCanvas.SetActive(true);
                break;
        }
    }
    public Transform GetBuilderCanvas()
    {
        return _BuilderCanvas.transform;
    }
    public void SetARMode(bool value)
    {
        if (value)
        {
            /*
            _imageTarget.gameObject.SetActive(true);
            _robotController.transform.SetParent(_imageTarget);
            _robotController.transform.localEulerAngles = new Vector3(0, 180, 0);
            _robotController.transform.localPosition = new Vector3(0, -4.301f, 11.9f);
            _robotController.transform.localScale = new Vector3(100, 100, 100);
            _sceneManager.GetSceneContainer().SetParent(_imageTarget);
            _sceneManager.GetSceneContainer().localPosition = _robotController.transform.localPosition;
            _sceneManager.GetSceneContainer().localEulerAngles = _robotController.transform.localEulerAngles;
            _sceneManager.GetSceneContainer().localScale = _robotController.transform.localScale * 0.01f;
            if (_sceneManager.GetPlayingScene())
            {
                _sceneManager.GetPlayingScene().SetParent(_imageTarget);
                _sceneManager.GetPlayingScene().localPosition = _robotController.transform.localPosition;
                _sceneManager.GetPlayingScene().localEulerAngles = Vector3.zero;
                _sceneManager.GetSceneContainer().localScale = _robotController.transform.localScale * 0.01f;
            }
            
            _robotController.HideJointLink(0);
            _robotController.HideJointLink(1);
            _robotController.HideJointLink(2);
            */
            _groundPlane.SetActive(false);
            _mainCameraContainer.gameObject.SetActive(false);
            _arCameraContainer.gameObject.SetActive(true);
            //_imageTarget.gameObject.SetActive(true);
        }
        else
        {
            /*
            _imageTarget.gameObject.SetActive(false);
            _sceneManager.GetSceneContainer().SetParent(transform.parent);
            _sceneManager.GetSceneContainer().localPosition = Vector3.zero;
            _sceneManager.GetSceneContainer().localEulerAngles = Vector3.zero;
            _sceneManager.GetSceneContainer().localScale = Vector3.one;
            if (_sceneManager.GetPlayingScene())
            {
                _sceneManager.GetPlayingScene().SetParent(transform.parent);
                _sceneManager.GetPlayingScene().localPosition = Vector3.zero;
                _sceneManager.GetPlayingScene().localEulerAngles = Vector3.zero;
                _sceneManager.GetPlayingScene().localScale = Vector3.one;
            }
            _robotController.transform.SetParent(transform.parent);
            _robotController.transform.localEulerAngles = Vector3.zero;
            _robotController.transform.localPosition = Vector3.zero;
            _robotController.transform.localScale = new Vector3(100, 100, 100);
            _robotController.ShowJointLink(0);
            _robotController.ShowJointLink(1);
            _robotController.ShowJointLink(2);
            ShowRobot();
            ShowScene();
            */
            _groundPlane.SetActive(true);
            _mainCameraContainer.gameObject.SetActive(true);
            _arCameraContainer.gameObject.SetActive(false);
            //_imageTarget.gameObject.SetActive(false);
        }
    }
    public void ShowRobot()
    {
        var rendererComponents = _robotController.GetComponentsInChildren<Renderer>(true);
        var colliderComponents = _robotController.GetComponentsInChildren<Collider>(true);
        var canvasComponents = _robotController.GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;


    }
    public void ShowScene()
    {
        var rendererComponents = _sceneManager.GetSceneContainer().GetComponentsInChildren<Renderer>(true);
        var colliderComponents = _sceneManager.GetSceneContainer().GetComponentsInChildren<Collider>(true);
        var canvasComponents = _sceneManager.GetSceneContainer().GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;
        if (_sceneManager.GetPlayingScene())
        {

            rendererComponents = _sceneManager.GetPlayingScene().GetComponentsInChildren<Renderer>(true);
            colliderComponents = _sceneManager.GetPlayingScene().GetComponentsInChildren<Collider>(true);
            canvasComponents = _sceneManager.GetPlayingScene().GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;
        }


    }
    public void ExitApplication()
    {
        Application.Quit();
    }
    public void ResetCamera()
    {
        Camera.main.transform.position = new Vector3(40f, 45f, -12f);
        Camera.main.transform.LookAt(new Vector3(0, 0, 10));
    }
    public Camera GetARCamera()
    {
        return _arCamera;
    }
    public Camera GetMainCamera()
    {
        return _mainCamera;
    }
}
