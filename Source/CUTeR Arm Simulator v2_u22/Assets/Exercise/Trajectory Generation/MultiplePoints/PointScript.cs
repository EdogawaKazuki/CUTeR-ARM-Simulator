using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class PointScript : MonoBehaviour
{
    public MultiplePoints _multiplePoints;
    public float x;
    public float y;
    public float z;
    public float time;
    // Start is called before the first frame update
    void OnEnable()
    {
        transform.Find("x").GetComponent<TMP_InputField>().onValueChanged.AddListener((value) => SetX(value));
        transform.Find("y").GetComponent<TMP_InputField>().onValueChanged.AddListener((value) => SetY(value));
        transform.Find("z").GetComponent<TMP_InputField>().onValueChanged.AddListener((value) => SetZ(value));
        transform.Find("time").GetComponent<TMP_InputField>().onValueChanged.AddListener((value) => SetTime(value));
        transform.Find("delete").GetComponent<Button>().onClick.AddListener(Delete);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetX(string value)
    {
        x = float.Parse(value);
    }
    public void SetY(string value)
    {
        y = float.Parse(value);
    }
    public void SetZ(string value)
    {
        z = float.Parse(value);
    }
    public void SetTime(string value)
    {
        time = float.Parse(value);
    }
    public void Delete()
    {
        if(transform.parent.childCount == 4)
        {
            return;
        }
        EventSystem.current.SetSelectedGameObject(null);
        Destroy(gameObject);
    }
}
