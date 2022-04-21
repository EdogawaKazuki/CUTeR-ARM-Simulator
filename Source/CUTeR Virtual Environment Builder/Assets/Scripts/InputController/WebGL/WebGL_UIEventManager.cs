using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class WebGL_UIEventManager : MonoBehaviour
{
    Dropdown ObjectDropdown;
    ArrayList ObjectList;
    WebGL_SceneManager sceneManager;
    ArrayList SceneList;
    Transform SceneListContiner;
    Transform SceneListEle;
    // Start is called before the first frame update
    void Start()
    {
        ObjectList = ObjectManager.ObjectList;
        ObjectDropdown = ObjectManager.ObjectDropdown;
        SceneList = ObjectManager.SceneList;
        sceneManager = GameObject.Find("GameAdmin").GetComponent<WebGL_SceneManager>();
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
    public void OnSceneEleClicked(string value)
    {
        sceneManager.LoadScene(ObjectManager.SceneFolder + "/" + value + ".json", false);
    }
    public void OnNewObjClicked(int value)
    {
        ObjectManager.GameAdmin.GetComponent<WebGL_SceneManager>().CreatePrimitiveObject(value);
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
            sceneManager.SelectedObj.transform.position = new Vector3(sceneManager.SelectedObj.transform.position.x, float.Parse(value), sceneManager.SelectedObj.transform.position.z);
    }
    public void OnObjPosZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.position = new Vector3(sceneManager.SelectedObj.transform.position.x, sceneManager.SelectedObj.transform.position.y, -float.Parse(value));
    }
    public void OnObjRotationXChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.eulerAngles = new Vector3(float.Parse(value), sceneManager.SelectedObj.transform.eulerAngles.y, sceneManager.SelectedObj.transform.eulerAngles.z);
    }
    public void OnObjRotationYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.eulerAngles = new Vector3(sceneManager.SelectedObj.transform.eulerAngles.x, float.Parse(value), sceneManager.SelectedObj.transform.eulerAngles.z);
    }
    public void OnObjRotationZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.eulerAngles = new Vector3(sceneManager.SelectedObj.transform.eulerAngles.x, sceneManager.SelectedObj.transform.eulerAngles.y, float.Parse(value));
    }
    public void OnObjScaleXChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.localScale = new Vector3(float.Parse(value), sceneManager.SelectedObj.transform.localScale.y, sceneManager.SelectedObj.transform.localScale.z);
    }
    public void OnObjScaleYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.localScale = new Vector3(sceneManager.SelectedObj.transform.localScale.x, float.Parse(value), sceneManager.SelectedObj.transform.localScale.z);
    }
    public void OnObjScaleZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            sceneManager.SelectedObj.transform.localScale = new Vector3(sceneManager.SelectedObj.transform.localScale.x, sceneManager.SelectedObj.transform.localScale.y, float.Parse(value));
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
    public void OnObjFixPosYChanged(bool value)
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
    public void OnObjFixPosZChanged(bool value)
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
    public void OnObjFixRotationYChanged(bool value)
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
    public void OnObjFixRotationZChanged(bool value)
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
