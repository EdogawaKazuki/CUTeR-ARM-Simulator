using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotJoint : MonoBehaviour
{
    #region Variables
    private float _angle = 0;
    enum Axis
    {
        x,
        y,
        z,
    }
    enum Direction
    {
        neg,
        nul,
        pos
    }
    [SerializeField]
    private Axis _rotateAxis;
    [SerializeField]
    private Direction _rotateDirection;
    [SerializeField]
    private float offsetX;
    [SerializeField]
    private float offsetY;
    [SerializeField]
    private float offsetZ;
    [SerializeField]
    private GameObject _sign;
    [SerializeField]
    private Text _line1;
    [SerializeField]
    private Text _line2;
    #endregion
    #region Methods
    public float GetAngle() { return _angle; }
    public void SetAngle(float angle) { 
        _angle = angle;
        switch (_rotateAxis)
        {
            case Axis.x: transform.localEulerAngles = new Vector3(_angle * ((int)_rotateDirection - 1) + offsetX, offsetY, offsetZ); break;
            case Axis.y: transform.localEulerAngles = new Vector3(offsetX, _angle * ((int)_rotateDirection - 1) + offsetY, offsetZ); break;
            case Axis.z: transform.localEulerAngles = new Vector3(offsetX, offsetY, _angle * ((int)_rotateDirection - 1) + offsetZ); break;
        }

    }
    public void SetSignText(string line1, string line2)
    {
        _line1.text = line1;
        _line2.text = line2;
    }
    public void SetSignActivate(bool value)
    {
        if(_sign != null)
            _sign.SetActive(value);
    }
    #endregion
}
