using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dummiesman;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Linq;

public class SceneManager : MonoBehaviour
{
    GameObject Scene;
    ArrayList sceneObjList;
    string SceneFolder;
    public string SceneName;
    public string SceneDescription;
    public GameObject SelectedObj;
    public static GameObject PlayingScene;
    public static bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        SceneFolder = ObjectManager.SceneFolder;
        sceneObjList = new ArrayList();
        Scene = ObjectManager.Scene;
        //Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject CreatePrimitiveObject(int i)
    {
        GameObject newObj;
        switch (i)
        {
            case 0:
                newObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                break;
            case 1:
                newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                break;
            case 2:
                newObj = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                break;
            case 3:
                newObj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                break;
            default:
                newObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                break;
        }
        //newObj.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 10;
        newObj.AddComponent<SceneObjectController>().parent = newObj.transform;
        newObj.transform.position = new Vector3(20, 0, 0);
        newObj.transform.SetParent(Scene.transform);
        newObj.layer = LayerMask.NameToLayer("Scene");
        Dictionary<string, object> objDict = new Dictionary<string, object>();
        objDict.Add("type", i);
        objDict.Add("name", newObj.name);
        objDict.Add("trans", newObj.transform);
        sceneObjList.Add(objDict);
        return newObj;
    }
    public GameObject CreateObjectFromFile(int objIndex)
    {
        if (objIndex != 0 && objIndex < ObjectManager.ObjectList.Count)
        {
            Debug.Log(ObjectManager.ObjectList[objIndex]);
            return CreateObjectFromFile(ObjectManager.ObjectList[objIndex].ToString().Split('\\')[1].Split('.')[0], false);
        }
        else
        {
            return null;
        }
    }
    public GameObject CreateObjectFromFile(string name, bool isWebGL)
    {
        // read obj from file
        GameObject newObj;
        if (isWebGL)
        {
            newObj = new OBJLoader().Load(name);
            newObj.name = GetFileName(name);
        }
        else
        {
            newObj = new OBJLoader().Load(ObjectManager.ObjectFolder + "/" + GetFileName(name) + ".obj");
            newObj.name = name;
        }
        for(int i = 0; i < newObj.transform.childCount; i++)
        {
            newObj.transform.GetChild(i).gameObject.AddComponent<SceneObjectController>().parent = newObj.transform;
            newObj.transform.GetChild(i).gameObject.layer = LayerMask.NameToLayer("Scene");
            newObj.transform.GetChild(i).gameObject.AddComponent<MeshCollider>().convex = true;
        }
        // init the obj
        newObj.transform.SetParent(Scene.transform);
        newObj.transform.position = new Vector3(20, 5, 0);
        newObj.transform.gameObject.AddComponent<SceneObjectController>().parent = newObj.transform;
        // newObj.GetComponent<MeshCollider>().convex = true;
        // newObj.layer = LayerMask.NameToLayer("Scene");
        // add the obj to the objlist
        Dictionary<string, object> objDict = new Dictionary<string, object>();
        objDict.Add("type", 4);
        objDict.Add("name", newObj.name);
        objDict.Add("trans", newObj.transform);
        sceneObjList.Add(objDict);
        return newObj;
    }
    public void SaveScene()
    {
        Debug.Log("save scene " + SceneName);
        // Check Name
        if (SceneName.Length == 0)
        {
            return;
        }
        
        // Init Dict
        Dictionary<string, object> sceneDict = new Dictionary<string, object>();
        HashSet<string> objFileList = new HashSet<string>();
        sceneDict.Add("name", SceneName);
        sceneDict.Add("description", SceneDescription);
        sceneDict.Add("date", DateTime.Now);
        string[] objDataStrList = new string[sceneObjList.Count];

        // Get all objects
        for (int i = 0; i < sceneObjList.Count; i++)
        {
            Dictionary<string, object> objDict = (Dictionary<string, object>)sceneObjList[i];
            //Debug.Log(objDict["name"]);
            //Debug.Log(objDict["trans"]);

            // create serializable dictionary
            Transform trans = (Transform)objDict["trans"];
            Dictionary<string, object> serializableDict = new Dictionary<string, object>();
            if(int.Parse(objDict["type"].ToString()) == 4)
            {
                objFileList.Add(objDict["name"].ToString());
            }
            serializableDict.Add("type", objDict["type"]);
            serializableDict.Add("name", objDict["name"]);
            serializableDict.Add("position", trans.localPosition.ToString("F8"));
            serializableDict.Add("eulerAngles", trans.localEulerAngles.ToString("F8"));
            serializableDict.Add("scale", trans.localScale.ToString("F8"));
            Rigidbody rigidbody = trans.gameObject.GetComponent<Rigidbody>();
            serializableDict.Add("isRigidbody", rigidbody != null);
            if (rigidbody)
            {
                serializableDict.Add("fixPositionX", (rigidbody.constraints & RigidbodyConstraints.FreezePositionX) != RigidbodyConstraints.None);
                serializableDict.Add("fixPositionY", (rigidbody.constraints & RigidbodyConstraints.FreezePositionY) != RigidbodyConstraints.None);
                serializableDict.Add("fixPositionZ", (rigidbody.constraints & RigidbodyConstraints.FreezePositionZ) != RigidbodyConstraints.None);
                serializableDict.Add("fixRotationX", (rigidbody.constraints & RigidbodyConstraints.FreezeRotationX) != RigidbodyConstraints.None);
                serializableDict.Add("fixRotationY", (rigidbody.constraints & RigidbodyConstraints.FreezeRotationY) != RigidbodyConstraints.None);
                serializableDict.Add("fixRotationZ", (rigidbody.constraints & RigidbodyConstraints.FreezeRotationZ) != RigidbodyConstraints.None);
                serializableDict.Add("useGravity", rigidbody.useGravity);
            }
            objDataStrList[i] = JsonConvert.SerializeObject(serializableDict);
            //Debug.Log(objDataStrList[i]);
        }
        sceneDict.Add("objFileList", objFileList);
        sceneDict.Add("data", objDataStrList);

        // Serialize Dict to Json string
        string objDictJsonString = JsonConvert.SerializeObject(sceneDict);
        //Debug.Log(objDictJsonString);

        // Save to file
        Debug.Log("saving to json " + SceneFolder + "/" + SceneName + ".json");
        File.WriteAllText(SceneFolder + "/" + SceneName + ".json", objDictJsonString);
        Debug.Log("saving to png " + SceneFolder + "/" + SceneName + ".png");
        ScreenCapture.CaptureScreenshot(SceneFolder + "/" + SceneName + ".png");
        ObjectManager.InformationText.text = "Scene: " + SceneName + ". IP: " + ObjectManager.ipAddress + " Server " + ObjectManager.serverStatus;
    }
    public void LoadScene(string path, bool isWebGL, string content=null)
    {
        NewScene();
            // Deserialize Json String
            string sceneDictString;
            if (isWebGL)
                sceneDictString = content;
            else
                sceneDictString = File.ReadAllText(path);
            Debug.Log("loading " + path);
            Dictionary<string, object> sceneDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(sceneDictString);
            SceneName = sceneDict["name"].ToString();
            SceneDescription = sceneDict["description"].ToString();
            ObjectManager.SceneName.text = SceneName;
            ObjectManager.SceneDescription.text = SceneDescription;
            string[] objFileList = JsonConvert.DeserializeObject<string[]>(sceneDict["objFileList"].ToString());
            string[] objDataStrList = JsonConvert.DeserializeObject<string[]>(sceneDict["data"].ToString());

            ObjectManager.DebugMsg.text += "loading " + path + "\n";
            // Check existance of obj files
            foreach (string objFile in objFileList)
            {
                if (!File.Exists(ObjectManager.ObjectFolder + "/" + objFile + ".obj"))
                {
                    Debug.Log(ObjectManager.ObjectFolder + "/" + objFile + ".obj Not Exists! Cannot Load Scene!");
                    return;
                }
            }

            // Load Objects
            for (int i = 0; i < objDataStrList.Length; i++)
            {
                Dictionary<string, object> objDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(objDataStrList[i]);
                //Debug.Log(objDataStrList[i]);
                //Debug.Log(objDict["name"]);

                // Create object
                int type = int.Parse(objDict["type"].ToString());
                GameObject newObj;
                if (type != 4)
                {
                    newObj = CreatePrimitiveObject(type);
                }
                else
                {
                    if (isWebGL)
                    {
                        string[] tmp = path.Split('/');
                        string url = string.Join("/", tmp.Take(tmp.Length - 2).ToArray());
                        url += "/objects/" + objDict["name"].ToString() + ".obj";
                        newObj = CreateObjectFromFile(url, true);
                    }
                    else
                        newObj = CreateObjectFromFile(objDict["name"].ToString(), false);
                }

                // Recovery transform
                string[] v3StrArray = objDict["position"].ToString().Trim(new char[] { '(', ')' }).Split(',');
                newObj.transform.position = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
                v3StrArray = objDict["eulerAngles"].ToString().Trim(new char[] { '(', ')' }).Split(',');
                newObj.transform.eulerAngles = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
                v3StrArray = objDict["scale"].ToString().Trim(new char[] { '(', ')' }).Split(',');
                newObj.transform.localScale = new Vector3(float.Parse(v3StrArray[0]), float.Parse(v3StrArray[1]), float.Parse(v3StrArray[2]));
                newObj.transform.SetParent(Scene.transform);
                if (bool.Parse(objDict["isRigidbody"].ToString()))
                {
                    Rigidbody rigidbody = newObj.AddComponent<Rigidbody>();
                    rigidbody.isKinematic = true;
                    if (bool.Parse(objDict["fixPositionX"].ToString()))
                    {
                        rigidbody.constraints |= RigidbodyConstraints.FreezePositionX;
                    }
                    if (bool.Parse(objDict["fixPositionY"].ToString()))
                    {
                        rigidbody.constraints |= RigidbodyConstraints.FreezePositionY;
                    }
                    if (bool.Parse(objDict["fixPositionZ"].ToString()))
                    {
                        rigidbody.constraints |= RigidbodyConstraints.FreezePositionZ;
                    }
                    if (bool.Parse(objDict["fixRotationX"].ToString()))
                    {
                        rigidbody.constraints |= RigidbodyConstraints.FreezeRotationX;
                    }
                    if (bool.Parse(objDict["fixRotationY"].ToString()))
                    {
                        rigidbody.constraints |= RigidbodyConstraints.FreezeRotationY;
                    }
                    if (bool.Parse(objDict["fixRotationZ"].ToString()))
                    {
                        rigidbody.constraints |= RigidbodyConstraints.FreezeRotationZ;
                    }
                    rigidbody.useGravity = bool.Parse(objDict["useGravity"].ToString());
                }
            }
            ObjectManager.InformationText.text = "Scene: " + SceneName + ". IP: " + ObjectManager.ipAddress + " Server " + ObjectManager.serverStatus;

    }
    public void NewScene()
    {
        for(int i = 0; i < Scene.transform.childCount; i++)
        {
            Destroy(Scene.transform.GetChild(i).gameObject);
        }
        sceneObjList.Clear();
    }
    public void QuitEditor()
    {
        Application.Quit();
    }
    public void DeleteObject()
    {
        foreach(Dictionary<string, object> objDict in sceneObjList)
        {
            if((Transform)objDict["trans"] == SelectedObj.transform)
            {
                Debug.Log(objDict["name"]);
                sceneObjList.Remove(objDict);
                Destroy(SelectedObj);
                return;
            }
        }
    }
    public void StartScene()
    {
        InputEventManager.selectedObject = null;
        ObjectManager.Axis.SetActive(false);
        ObjectManager.AttributePanel.SetActive(false);
        if (isPlaying)
        {
            return;
        }
        isPlaying = true;
        PlayingScene = Instantiate(ObjectManager.Scene);
        for (int i = 0; i < PlayingScene.transform.childCount; i++)
        {
            Rigidbody rigidbody = PlayingScene.transform.GetChild(i).gameObject.GetComponent<Rigidbody>();
            if (rigidbody)
            {
                rigidbody.isKinematic = false;
                rigidbody.centerOfMass = Vector3.zero;
                rigidbody.inertiaTensorRotation = Quaternion.identity;
            }
            else
            {
                if (PlayingScene.transform.GetChild(i).gameObject.GetComponent<BoxCollider>())
                {
                    Destroy(PlayingScene.transform.GetChild(i).gameObject.GetComponent<BoxCollider>());
                }
                else if (PlayingScene.transform.GetChild(i).gameObject.GetComponent<CapsuleCollider>())
                {
                    Destroy(PlayingScene.transform.GetChild(i).gameObject.GetComponent<CapsuleCollider>());
                }
                else if (PlayingScene.transform.GetChild(i).gameObject.GetComponent<SphereCollider>())
                {
                    Destroy(PlayingScene.transform.GetChild(i).gameObject.GetComponent<SphereCollider>());
                }
                else if (PlayingScene.transform.GetChild(i).gameObject.GetComponent<MeshCollider>())
                {
                    Destroy(PlayingScene.transform.GetChild(i).gameObject.GetComponent<MeshCollider>());
                }
            }
        }
        ObjectManager.Scene.SetActive(false);
    }
    public void ResetScene()
    {
        InputEventManager.selectedObject = null;
        ObjectManager.Axis.SetActive(false);
        ObjectManager.AttributePanel.SetActive(false);
        Destroy(PlayingScene);
        ObjectManager.Scene.SetActive(true);
        isPlaying = false;
    }
    string GetFileName(string str)
    {
        Debug.Log(str);
        string[] splitedPath = str.Split('/');
        string name = splitedPath[splitedPath.Length - 1];
        splitedPath = name.Split('\\');
        return splitedPath[splitedPath.Length - 1].Split('.')[0];
    }
}
