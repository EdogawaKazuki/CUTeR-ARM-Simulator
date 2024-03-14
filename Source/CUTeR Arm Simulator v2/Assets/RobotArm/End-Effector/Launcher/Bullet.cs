using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet: MonoBehaviour
{
    float _existTime = 0f;
    float _totalLiveTime = 5f;
    #region Bullet Methods
    public void Start()
    {

    }
    public void Update()
    {
        _existTime += Time.deltaTime;
        if (_existTime > _totalLiveTime)
        {
            Destroy(gameObject);
        }
    }
    #endregion
}
