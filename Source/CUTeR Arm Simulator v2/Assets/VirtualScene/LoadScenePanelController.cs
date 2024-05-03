using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoadScenePanelController : MonoBehaviour
{
    [SerializeField]
    private SceneManager _sceneManager;
    [SerializeField]
    private Transform _sceneListContiner;
    [SerializeField]
    private Transform _sceneListEle;
    [SerializeField]
    private TMP_Text _debugText;

    private List<string> _sceneList;
    private string _sceneFolder = "";

    private void Start()
    {
    }
    private void OnEnable()
    {
        //_debugText = transform.Find("../DebugText").GetComponent<Text>();
        _sceneListEle.gameObject.SetActive(false);
        #if UNITY_EDITOR || UNITY_STANDALONE
            _sceneFolder = Application.dataPath + "/Resources/scenes";
        #elif UNITY_ANDROID
            _sceneFolder = Application.persistentDataPath+ "/scenes";
            Debug.Log(Application.persistentDataPath);
        #endif
        if (_sceneList == null)
            _sceneList = new List<string>();
        ScanSceneFolder();
    }
    public void ScanSceneFolder()
    {
        _debugText.text = _sceneFolder + "\n" + _debugText.text;
        _sceneList.Clear();

        _sceneList.Add("Placeholder");

        for (int i = 1; i < _sceneListContiner.childCount; i++)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Destroy(_sceneListContiner.GetChild(i).gameObject);
        }

        if (Directory.Exists(_sceneFolder))
        {
            Debug.Log("Scene folder exists");
            foreach (string file in Directory.GetFiles(_sceneFolder, "*.json"))
            {
                _debugText.text = file + "\n" + _debugText.text;
                Debug.Log(file);
                string[] splitedPath = file.Split('.');
                Debug.Log(splitedPath[splitedPath.Length - 1]);
                if (splitedPath[splitedPath.Length - 1].Equals("json"))
                {
                    splitedPath = file.Split('/');
                    splitedPath = splitedPath[splitedPath.Length - 1].Split('\\');
                    string name = splitedPath[splitedPath.Length - 1].Split('.')[0];

                    Debug.Log("parsing " + file);
                    _sceneList.Add(file);
                    Transform newEle = Instantiate(_sceneListEle);
                    newEle.SetParent(_sceneListContiner);
                    newEle.localScale = new Vector3(1, 1, 1);
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
                    newEle.Find("Path").GetComponent<Text>().text = _sceneFolder + "/" + sceneDict["name"].ToString() + ".json";
                    newEle.Find("Image").GetComponent<Image>().overrideSprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                    newEle.GetComponent<Button>().onClick.AddListener(()=>OnSceneEleClicked(sceneDict["name"].ToString()));

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
        try { 
            _sceneManager.LoadSceneByPath(_sceneFolder + "/" + value + ".json");
        }catch(Exception e)
        {
            _debugText.text = e + "\n" + _debugText.text;
            Debug.Log(e);
        }
        gameObject.SetActive(false);
    }
}
