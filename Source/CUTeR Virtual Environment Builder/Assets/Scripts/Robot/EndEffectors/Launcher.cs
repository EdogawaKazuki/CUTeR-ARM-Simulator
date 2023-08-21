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
        Bullet.transform.position = transform.position;
        Rigidbody rigidboty = Bullet.AddComponent<Rigidbody>();
        rigidboty.velocity = transform.up * _force;
        Bullet.transform.SetParent(_robotController.GetEditorController().GetSceneManager().GetPlayingScene());
        // enable physical property
        // rigidboty.useGravity
        // rigidboty.useGravity = false;
        // give force
        // rigidboty.AddForce(transform.up * _force * 50);
    }
    #endregion
}
