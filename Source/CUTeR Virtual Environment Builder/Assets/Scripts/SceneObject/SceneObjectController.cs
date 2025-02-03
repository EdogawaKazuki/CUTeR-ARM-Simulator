using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectController : MonoBehaviour
{
    #region Variables
    private SceneObjectTrajectoryController _trajectoryController;
    public enum Type
    {
        cube,
        sphere,
        cylinder,
        capsule,
        obj,
        none
    }
    public Type type = Type.none;
    public int ID;
    public string filename = "";
    public bool isRigidbody = false;
    public bool useGravity = false;
    public bool fixPositionX = false;
    public bool fixPositionY = false;
    public bool fixPositionZ = false;
    public bool fixRotationX = false;
    public bool fixRotationY = false;
    public bool fixRotationZ = false;
    private Rigidbody _rigidbody;
    #endregion

    #region MonoBehaviour
    private void Start()
    {
        _trajectoryController = GetComponent<SceneObjectTrajectoryController>();
    }
    private void FixedUpdate()
    {
    }
    #endregion

    #region Methods

    public Rigidbody AddRigidbody() { _rigidbody = gameObject.AddComponent<Rigidbody>(); return _rigidbody; }
    public void RemoveRigidbody() { Destroy(_rigidbody); }
    /// <summary>
    /// 
    /// create serializable dictionary
    /// </summary>
    /// <returns></returns>
    public string GetPropDictJsonString()
    {
        return JsonConvert.SerializeObject(GetPropDict());
    }
    public void SetPropByJsonString(string jsonString, Transform parent)
    {
        SetPropByDict(JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString), parent);
    }
    public Dictionary<string, object> GetPropDict() {

        Dictionary<string, object> serializableDict = new Dictionary<string, object>();
        serializableDict.Add("type", type);
        serializableDict.Add("name", name);
        serializableDict.Add("filename", filename);
        serializableDict.Add("position", transform.localPosition.ToString("F8"));
        serializableDict.Add("eulerAngles", transform.localEulerAngles.ToString("F8"));
        serializableDict.Add("scale", transform.localScale.ToString("F8"));
        serializableDict.Add("isRigidbody", isRigidbody);
        serializableDict.Add("useGravity", useGravity);
        serializableDict.Add("fixPositionX", fixPositionX);
        serializableDict.Add("fixPositionY", fixPositionY);
        serializableDict.Add("fixPositionZ", fixPositionZ);
        serializableDict.Add("fixRotationX", fixRotationX);
        serializableDict.Add("fixRotationY", fixRotationY);
        serializableDict.Add("fixRotationZ", fixRotationZ);
        serializableDict.Add("useTrajectory", _trajectoryController.GetIsUseTraj());
        serializableDict.Add("trajectoryText", _trajectoryController.GetTrajText());
        return serializableDict;
    }
    public void SetPropByDict(Dictionary<string, object> objDict, Transform parent)
    {

        // Recovery transform
        type = (Type)int.Parse(objDict["type"].ToString());
        name = objDict["name"].ToString();
        filename = objDict["filename"].ToString();
        transform.SetParent(parent);
        string[] v3StrArray = objDict["position"].ToString().Trim(new char[] { '(', ')' }).Split(',');
        transform.localPosition = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
        v3StrArray = objDict["eulerAngles"].ToString().Trim(new char[] { '(', ')' }).Split(',');
        transform.localEulerAngles = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
        v3StrArray = objDict["scale"].ToString().Trim(new char[] { '(', ')' }).Split(',');
        transform.localScale = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
        isRigidbody = bool.Parse(objDict["isRigidbody"].ToString());
        useGravity = bool.Parse(objDict["useGravity"].ToString());
        fixPositionX = bool.Parse(objDict["fixPositionX"].ToString());
        fixPositionY = bool.Parse(objDict["fixPositionY"].ToString());
        fixPositionZ = bool.Parse(objDict["fixPositionZ"].ToString());
        fixRotationX = bool.Parse(objDict["fixRotationX"].ToString());
        fixRotationY = bool.Parse(objDict["fixRotationX"].ToString());
        fixRotationZ = bool.Parse(objDict["fixRotationX"].ToString());
        //gameObject.AddComponent<SceneObjectTrajectoryController>();
        _trajectoryController.SetIsUseTraj(bool.Parse(objDict["useTrajectory"].ToString()));
        //Debug.Log(objDict["useTrajectory"].ToString());
        _trajectoryController.SetTrajByText(objDict["trajectoryText"].ToString());
    }
    public Bounds GetBounds()
    {
        Bounds bounds = new Bounds();
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        if (renderers.Length > 0)
        {
            //Find first enabled renderer to start encapsulate from it
            foreach (Renderer renderer in renderers)
            {
                if (renderer.enabled)
                {
                    bounds = renderer.bounds;
                    break;
                }
            }                        
            //Encapsulate for all renderers
            foreach (Renderer renderer in renderers)
            {
                if (renderer.enabled)
                {
                    bounds.Encapsulate(renderer.bounds);
                }
            }
        }
        return bounds;
    }
    public void SetSceneObjectTrajectoryController(SceneObjectTrajectoryController sceneObjectTrajectoryController) { _trajectoryController = sceneObjectTrajectoryController; }
    #endregion
}
