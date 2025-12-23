using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using Dummiesman;
using UnityEngine.UI;



public class EndEffectorController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private List<EndEffector> _endEffectors = new List<EndEffector>();
    [SerializeField]
    private RobotController _robotController;

    private int _currentEndEffectorIndex;
    private EndEffector _currentEndEffector;
    private List<string> _endEffectorNames = new List<string>();
    public int _currentCustomEEIndex = 0;
    private Transform _currentCustomEE;
    public bool _useCustomEE = false;
    private List<Transform> _customEETypeList = new List<Transform>();
    public Dropdown eeDropdown;
    private int _builtInEECount = 0;
    #endregion
    #region MonoBehaviour
    private void Start()
    {
        for(int i = 0; i < _endEffectors.Count; i++)
        {
            _endEffectors[i].Init();
            _endEffectorNames.Add(_endEffectors[i].GetEndEffectorName());
            _endEffectors[i].SetRobotController(_robotController);
            //Debug.Log(_endEffectorNames[i]);
        }
        _builtInEECount = _endEffectors.Count;
        SetEndEffector(0);
        ScanCustomEE();
    }
    #endregion
    #region Methods
    public void SetEndEffector(int index)
    {
        for(int i = 0; i < _endEffectors.Count; i++)
        {
            _endEffectors[i].GetGameObject().SetActive(false);
        }
        for(int i = 0; i < _customEETypeList.Count; i++){
            _customEETypeList[i].gameObject.SetActive(false);
        }
        if(index < _builtInEECount){
            _currentEndEffectorIndex = index;
            _currentEndEffector = _endEffectors[_currentEndEffectorIndex];
            _currentEndEffector.GetGameObject().SetActive(true);
            _useCustomEE = false;
        }else{
            _currentCustomEEIndex = index - _builtInEECount;
            // Debug.Log("index: " + index + " _builtInEECount: " + _builtInEECount);
            Debug.Log(_currentCustomEEIndex);
            Debug.Log(_customEETypeList.Count);
            _currentCustomEE = _customEETypeList[_currentCustomEEIndex];
            _currentCustomEE.gameObject.SetActive(true);
            _useCustomEE = true;
        }
    }
    public void SetCustomEEType(int index)
    {
        Debug.Log(index);
        SetEndEffector(index + _builtInEECount + 1);
    }
    public void ScanCustomEE(){
        if(_customEETypeList.Count > 0){
            foreach(var ee in _customEETypeList){
                Destroy(ee.gameObject);
                // eeDropdown.removeOption(0);
                eeDropdown.options.RemoveAt(eeDropdown.options.Count - 1);
            }
            _customEETypeList.Clear();
        }
        
        string eeFolder = Application.dataPath + "/Resources/endEffector";
        List<string> eeFileList = new List<string>();
        if (Directory.Exists(eeFolder))
        {
            Debug.Log("EE folder exists");
            foreach (string file in Directory.GetFiles(eeFolder, "*.json"))
            {
                Debug.Log(file);
                string[] splitedPath = file.Split('.');
                Debug.Log(splitedPath[splitedPath.Length - 1]);
                if (splitedPath[splitedPath.Length - 1].Equals("json"))
                {
                    splitedPath = file.Split('/');
                    splitedPath = splitedPath[splitedPath.Length - 1].Split('\\');
                    string name = splitedPath[splitedPath.Length - 1].Split('.')[0];

                    Debug.Log("parsing " + file);
                    eeFileList.Add(file);
                    // read ee model and set parent to ee root
                    Transform newEle = AddCustomEEByPath(eeFolder, name);
                    for (int i = 0; i < newEle.transform.childCount; i++)   
                    {
                        MeshCollider meshCollider = newEle.transform.GetChild(i).gameObject.GetComponent<MeshCollider>();
                        meshCollider.convex = false;
                        Rigidbody rigidbody = newEle.transform.GetChild(i).gameObject.AddComponent<Rigidbody>();
                        rigidbody.isKinematic = true;
                    }
                    _customEETypeList.Add(newEle);
                    // read ee position info
                    string sceneDictString = File.ReadAllText(file);
                    Dictionary<string, object> eeDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(sceneDictString);
                    SetPropByDict(eeDict, newEle, transform);
                    newEle.gameObject.SetActive(false);
                    eeDropdown.options.Add(new Dropdown.OptionData("Custom EE " + name));
                }
            }
            // eeDropdown.addOption("custom ee 1");
        }
        else
        {
            Debug.Log("EE folder doesn't exist");
        }

    }
    private Transform AddCustomEEByPath(string folder, string path){

        GameObject newObj = new GameObject();
        newObj.transform.parent = transform;
        newObj.transform.name = path;
        Debug.Log(folder + "/" + path + ".obj");
        Transform newPart = new OBJLoader().Load(folder + "/" + path + ".obj").transform;
        Debug.Log(newPart.transform.childCount);
        int totalObj = newPart.transform.childCount;
        for (int i = 0; i < totalObj; i++)
        {
            newPart.transform.GetChild(i).gameObject.AddComponent<MeshCollider>().convex = true;
            newPart.transform.GetChild(i).SetParent(newObj.transform);
            // newObj.transform.GetChild(i).localPosition = new Vector3(0, 0, 0);
            newObj.transform.GetChild(i).localRotation = Quaternion.identity;
            newObj.transform.GetChild(i).localScale = Vector3.one;
            Mesh mesh = newObj.transform.GetChild(i).GetComponent<MeshFilter>().mesh;
            Vector3[] vertices = mesh.vertices;

            // Calculate the average position of all vertices
            Vector3 meshCenter = Vector3.zero;
            foreach (Vector3 vertex in vertices)
            {
                meshCenter += vertex;
            }
            meshCenter /= vertices.Length;

            // Convert the local center to world space if needed
            // meshCenter = transform.TransformPoint(meshCenter);
            newObj.transform.GetChild(i).localPosition = -meshCenter;
        }
        Destroy(newPart.gameObject);
        return newObj.transform;
    }
    public void SetPropByDict(Dictionary<string, object> objDict, Transform ee, Transform parent)
    {
        // Recovery transform
        ee.SetParent(parent);
        string[] v3StrArray = objDict["position"].ToString().Trim(new char[] { '(', ')' }).Split(',');
        ee.localPosition = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
        v3StrArray = objDict["eulerAngles"].ToString().Trim(new char[] { '(', ')' }).Split(',');
        ee.localEulerAngles = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
        v3StrArray = objDict["scale"].ToString().Trim(new char[] { '(', ')' }).Split(',');
        ee.localScale = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
    }
    public int GetEndEffector() { return _currentEndEffectorIndex; }
    public void Fire()
    {
        if (_robotController.GetEditorController().GetSceneManager().GetPlayingScene() != null){
            _currentEndEffector?.Fire();
            Debug.Log("Fire" + _currentEndEffector.GetEndEffectorName());
        }
    }
    public void SetForce(float force)
    {
        _currentEndEffector?.SetForce(force);
    }
    public List<string> GetEndEffectorList()
    {
        return _endEffectorNames;
    }

    public void ResetEndEffector()
    {
        _currentEndEffector.Reset();
    }
    #endregion
}
