using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    float force = 0;
    Text forceValue;
    // Start is called before the first frame update
    void Start()
    {
        forceValue = GameObject.Find("Canvas/Joystick/Panel/Force/Handle Slide Area/Handle/Value").GetComponent<Text>();
    }

    public void SetForce(float value)
    {
        force = value;
        forceValue.text = value.ToString("F0");
    }
    public void Fire()
    {
        if (gameObject.activeSelf && SceneManager.isPlaying)
        {
            GameObject Bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Bullet.transform.position = transform.position;
            Rigidbody rigidboty = Bullet.AddComponent<Rigidbody>();
            rigidboty.AddForce(transform.up * force * 100);
            Bullet.transform.SetParent(SceneManager.PlayingScene.transform);
        }
    }
}
