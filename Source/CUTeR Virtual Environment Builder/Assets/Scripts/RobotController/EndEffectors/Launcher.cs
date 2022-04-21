using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    float force = 50;
    Text forceValue;
    public bool toggle = false;
    GameObject Parent;
    static public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        forceValue = GameObject.Find("Canvas/Joystick/Panel/Force/Handle Slide Area/Handle/Value").GetComponent<Text>();
        Parent = transform.parent.gameObject;
    }
    void Update()
    {

        if (toggle)
        {
            Fire();
            toggle = false;
        }
    }
    public void SetForce(float value)
    {
        force = value;
        forceValue.text = value.ToString("F0");
    }
    public void Toggle()
    {
        //Debug.Log(isActive +"," + (WebGL_SceneManager.isPlaying || SceneManager.isPlaying));
        if (isActive && (WebGL_SceneManager.isPlaying || SceneManager.isPlaying))
        {
            toggle = true;
        }
    }
    public void Fire()
    {
        if (isActive && (WebGL_SceneManager.isPlaying || SceneManager.isPlaying))
        {
            GameObject Bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Bullet.transform.position = transform.position;
            Rigidbody rigidboty = Bullet.AddComponent<Rigidbody>();
            rigidboty.AddForce(transform.up * force * 100);

#if UNITY_WEBGL && !UNITY_EDITOR
            Bullet.transform.SetParent(WebGL_SceneManager.PlayingScene.transform);
#else
            Bullet.transform.SetParent(SceneManager.PlayingScene.transform);
#endif
        }
    }
}
