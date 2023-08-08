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
    private GameObject _jointSign;
    [SerializeField]
    private List<GameObject> _linkSign;
    private Text _title;
    private Text _value;
    private Transform _frame;
    #endregion
    #region Methods
    private void OnEnable()
    {
        _jointSign = transform.Find("Canvas/Panel")?.gameObject ;
        _title = transform.Find("Canvas/Panel/Title")?.GetComponent<Text>();
        _value = transform.Find("Canvas/Panel/pwm")?.GetComponent<Text>();
        _frame = transform.Find("frame_visual");
        SetJointSignActivate(false);
    }
    public float GetAngle() { return _angle; }
    public void SetAngle(float angle) {
        //Debug.Log(angle);
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
        _title.text = line1;
        _value.text = line2;
    }
    public void SetJointSignActivate(bool value) { _jointSign?.SetActive(value); }
    public void SetLinkSignActivate(bool value)
    {
        if (_linkSign.Count != 0)
            foreach (var link in _linkSign)
                link.SetActive(value);
    }
    public void ShowFrame(bool value) { _frame?.gameObject.SetActive(value); }
    #endregion
}
