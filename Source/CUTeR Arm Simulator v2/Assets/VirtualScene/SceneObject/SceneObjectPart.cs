using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectPart : MonoBehaviour
{
    public Transform _parent;
    public Transform GetParent() { return _parent; }
    public void SetParent(Transform parent) { _parent = parent; }

}
