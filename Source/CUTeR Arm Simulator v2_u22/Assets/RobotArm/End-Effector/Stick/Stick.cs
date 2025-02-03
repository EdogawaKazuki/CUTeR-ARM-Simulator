using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : EndEffector
{
    #region EndEffector Methods
    public override void Init()
    {
        base.Init();
        _name = "Stick";
        _force = 0;
    }
    #endregion
}
