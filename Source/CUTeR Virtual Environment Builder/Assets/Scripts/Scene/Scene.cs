using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene
{
    private string _name;
    private string _description;
    private List<GameObject> _objectList;
    public Scene Init()
    {
        _name = "New Scene";
        _description = "New Scene";
        _objectList = new List<GameObject>();
        return this;
    }
    public string GetName() { return _name; }
    public void SetName(string name) { _name = name; }
    public string GetDescription() { return _description; }
    public void SetDescription(string description) { _description = description; }
    public List<GameObject> GetObjectList() {  return _objectList; } 
    public void AddObject(GameObject obj) { _objectList.Add(obj); }
    public void RemoveObject(GameObject obj) { _objectList.Remove(obj); }

}
