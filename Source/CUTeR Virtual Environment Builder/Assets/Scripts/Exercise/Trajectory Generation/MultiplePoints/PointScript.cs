using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("x").GetComponent<InputField>().onValueChanged.AddListener((value) => SetX(value));
        transform.Find("y").GetComponent<InputField>().onValueChanged.AddListener((value) => SetY(value));
        transform.Find("z").GetComponent<InputField>().onValueChanged.AddListener((value) => SetZ(value));
        transform.Find("time").GetComponent<InputField>().onValueChanged.AddListener((value) => SetTime(value));
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
        EventSystem.current.SetSelectedGameObject(null);
        Destroy(gameObject);
    }
}
