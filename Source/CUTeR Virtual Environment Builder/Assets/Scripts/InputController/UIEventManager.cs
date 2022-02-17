using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class UIEventManager : MonoBehaviour
{
    Dropdown ObjectDropdown;
    ArrayList ObjectList;
    SceneManager sceneManager;
    ArrayList SceneList;
    Transform SceneListContiner;
    Transform SceneListEle;
    // Start is called before the first frame update
    void Start()
    {
        ObjectList = ObjectManager.ObjectList;
        ObjectDropdown = ObjectManager.ObjectDropdown;
        SceneList = ObjectManager.SceneList;
        sceneManager = GameObject.Find("GameAdmin").GetComponent<SceneManager>();
        SceneListContiner = ObjectManager.SceneListContiner;
        SceneListEle = ObjectManager.SceneListEle;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void TurnOffToggle()
    {
        gameObject.GetComponent<Toggle>().isOn = false;
    }
    public void LoadObj()
    {

    }
    public void ScanObjFolder()
    {

        ObjectDropdown.options.Clear();
        ObjectList.Clear();

        ObjectDropdown.options.Add(new Dropdown.OptionData("Select .obj..."));
        ObjectList.Add("Placeholder");

        if (Directory.Exists(ObjectManager.ObjectFolder))
        {
            Debug.Log("Obj folder exists: " + ObjectManager.ObjectFolder);
            foreach (string file in Directory.GetFiles(ObjectManager.ObjectFolder + "\\", "*.obj"))
            {
                Debug.Log(file);
                string[] splitedPath = file.Split('.');
                if (splitedPath[splitedPath.Length - 1].Equals("obj"))
                {
                    ObjectDropdown.options.Add(new Dropdown.OptionData(file.Split('\\')[1]));
                    ObjectList.Add(file);
                }
            }
        }
        else
        {
            Debug.Log("Scene folder doesn't exist");
        }
        ObjectDropdown.value = 0;

    }
    public void ScanSceneFolder()
    {
        SceneList.Clear();

        SceneList.Add("Placeholder");

        for(int i = 1; i < SceneListContiner.childCount; i++)
        {
            Destroy(SceneListContiner.GetChild(i).gameObject);
        }

        if (Directory.Exists(ObjectManager.SceneFolder))
        {
            Debug.Log("Scene folder exists");
            foreach (string file in Directory.GetFiles(ObjectManager.SceneFolder, "*.json"))
            {
                Debug.Log(file);
                string[] splitedPath = file.Split('.');
                Debug.Log(splitedPath[splitedPath.Length - 1]);
                if (splitedPath[splitedPath.Length - 1].Equals("json"))
                {
                    Debug.Log("parsing " + file);
                    string name = file.Split('\\')[1].Split('.')[0];
                    SceneList.Add(file);
                    Transform newEle = Instantiate(SceneListEle);
                    newEle.SetParent(SceneListContiner);
                    newEle.gameObject.SetActive(true);
                    newEle.name = name;
                    // read scene info
                    string sceneDictString = File.ReadAllText(file);
                    Dictionary<string, object> sceneDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(sceneDictString);
                    // load screenshot image
                    Texture2D tex = new Texture2D(2, 2);
                    tex.LoadImage(File.ReadAllBytes(file.Replace(".json", ".png")));
                    // modify the scene card
                    newEle.Find("Name").GetComponent<Text>().text = sceneDict["name"].ToString();
                    newEle.Find("Date").GetComponent<Text>().text = sceneDict["date"].ToString();
                    newEle.Find("Desc").GetComponent<Text>().text = sceneDict["description"].ToString();
                    newEle.Find("Path").GetComponent<Text>().text = ObjectManager.SceneFolder + "/" + sceneDict["name"].ToString() + ".json";
                    newEle.Find("Image").GetComponent<Image>().overrideSprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                    newEle.GetComponent<Button>().onClick.AddListener(delegate { OnSceneEleClicked(name); ObjectManager.LoadScenePanel.SetActive(false); });

                }
            }
        }
        else
        {
            Debug.Log("Scene folder doesn't exist");
        }

    }
    public void OnSceneEleClicked(string value)
    {
        sceneManager.LoadScene(ObjectManager.SceneFolder + "/" + value + ".json", false);
    }
    public void OnObjDropdpwnValueChanged(int value)
    {
        ObjectManager.GameAdmin.GetComponent<SceneManager>().CreateObjectFromFile(value);
    }
    public void OnNewObjClicked(int value)
    {
        ObjectManager.GameAdmin.GetComponent<SceneManager>().CreatePrimitiveObject(value);
    }
    public void OnSceneNameValueChanged(string value)
    {
        sceneManager.SceneName = value;
    }
    public void OnSceneDescriptionValueChanged(string value)
    {
        sceneManager.SceneDescription = value;
    }
    public void OnObjNameValueChanged(string value)
    {
        sceneManager.SelectedObj.name = value;
    }
    public void OnObjPosXChanged(string value)
    {
        if(float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.position = new Vector3(-float.Parse(value), sceneManager.SelectedObj.transform.position.y, sceneManager.SelectedObj.transform.position.z);
    }
    public void OnObjPosYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.position = new Vector3(sceneManager.SelectedObj.transform.position.x, sceneManager.SelectedObj.transform.position.y, -float.Parse(value));
    }
    public void OnObjPosZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.position = new Vector3(sceneManager.SelectedObj.transform.position.x, float.Parse(value), sceneManager.SelectedObj.transform.position.z);
    }
    public void OnObjRotationXChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.eulerAngles = new Vector3(float.Parse(value), sceneManager.SelectedObj.transform.eulerAngles.y, sceneManager.SelectedObj.transform.eulerAngles.z);
    }
    public void OnObjRotationYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.eulerAngles = new Vector3(sceneManager.SelectedObj.transform.eulerAngles.x, sceneManager.SelectedObj.transform.eulerAngles.y, float.Parse(value));
    }
    public void OnObjRotationZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.eulerAngles = new Vector3(sceneManager.SelectedObj.transform.eulerAngles.x, float.Parse(value), sceneManager.SelectedObj.transform.eulerAngles.z);
    }
    public void OnObjScaleXChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.localScale = new Vector3(float.Parse(value), sceneManager.SelectedObj.transform.localScale.y, sceneManager.SelectedObj.transform.localScale.z);
    }
    public void OnObjScaleYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.localScale = new Vector3(sceneManager.SelectedObj.transform.localScale.x, sceneManager.SelectedObj.transform.localScale.y, float.Parse(value));
    }
    public void OnObjScaleZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.localScale = new Vector3(sceneManager.SelectedObj.transform.localScale.x, float.Parse(value), sceneManager.SelectedObj.transform.localScale.z);
    }
    public void OnObjFixPosXChanged(bool value)
    {
        if (value)
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints |= RigidbodyConstraints.FreezePositionX;
        }
        else
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionX;
        }
        
    }
    public void OnObjFixPosZChanged(bool value)
    {
        if (value)
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints |= RigidbodyConstraints.FreezePositionY;
        }
        else
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionY;
        }
    }
    public void OnObjFixPosYChanged(bool value)
    {
        if (value)
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints |= RigidbodyConstraints.FreezePositionZ;
        }
        else
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionZ;
        }
    }
    public void OnObjFixRotationXChanged(bool value)
    {
        if (value)
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints |= RigidbodyConstraints.FreezeRotationX;
        }
        else
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezeRotationX;
        }
    }
    public void OnObjFixRotationZChanged(bool value)
    {
        if (value)
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints |= RigidbodyConstraints.FreezeRotationY;
        }
        else
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezeRotationY;
        }
    }
    public void OnObjFixRotationYChanged(bool value)
    {
        if (value)
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints |= RigidbodyConstraints.FreezeRotationZ;
        }
        else
        {
            sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezeRotationZ;
        }
    }
    public void OnObjIsRigidbodyChanged(bool value)
    {
        if (value)
        {
            if (!sceneManager.SelectedObj.GetComponent<Rigidbody>())
            {
                sceneManager.SelectedObj.AddComponent<Rigidbody>();
                sceneManager.SelectedObj.GetComponent<Rigidbody>().isKinematic = true;
                ObjectManager.AttributePanel.transform.Find("FixPosition/Options/X/Toggle").GetComponent<Toggle>().isOn = (sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezePositionX) != RigidbodyConstraints.None;
                ObjectManager.AttributePanel.transform.Find("FixPosition/Options/Y/Toggle").GetComponent<Toggle>().isOn = (sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezePositionY) != RigidbodyConstraints.None;
                ObjectManager.AttributePanel.transform.Find("FixPosition/Options/Z/Toggle").GetComponent<Toggle>().isOn = (sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezePositionZ) != RigidbodyConstraints.None;
                ObjectManager.AttributePanel.transform.Find("FixRotation/Options/X/Toggle").GetComponent<Toggle>().isOn = (sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezeRotationX) != RigidbodyConstraints.None;
                ObjectManager.AttributePanel.transform.Find("FixRotation/Options/Y/Toggle").GetComponent<Toggle>().isOn = (sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezeRotationY) != RigidbodyConstraints.None;
                ObjectManager.AttributePanel.transform.Find("FixRotation/Options/Z/Toggle").GetComponent<Toggle>().isOn = (sceneManager.SelectedObj.GetComponent<Rigidbody>().constraints & RigidbodyConstraints.FreezeRotationZ) != RigidbodyConstraints.None;
                ObjectManager.AttributePanel.transform.Find("UseGravity/Options/Toggle").GetComponent<Toggle>().isOn = sceneManager.SelectedObj.GetComponent<Rigidbody>().useGravity;
            }
        }
        else
        {
            Destroy(sceneManager.SelectedObj.GetComponent<Rigidbody>());
        }
    }
    public void OnObjUseGravityChanged(bool value)
    {
        sceneManager.SelectedObj.GetComponent<Rigidbody>().useGravity = value;
    }
}
