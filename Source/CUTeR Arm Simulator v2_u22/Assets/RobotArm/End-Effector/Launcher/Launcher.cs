using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : EndEffector
{
    #region EndEffector Methods
    public override void Init()
    {
        base.Init();
        _name = "Launcher";
        _force = 50;
    }
    public override void Fire()
    {
        // create a bullet
        GameObject Bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Bullet.AddComponent<Bullet>();
        Bullet.transform.position = transform.position;
        Bullet.transform.localScale = Vector3.one * 0.01f;
        Bullet.transform.SetParent(transform);
        // enable physical property
        Rigidbody rigidboty = Bullet.AddComponent<Rigidbody>();
        // give force
        rigidboty.AddForce(-transform.forward * _force * 5);
    }
    #endregion
}
