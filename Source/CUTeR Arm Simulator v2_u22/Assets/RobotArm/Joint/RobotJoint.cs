using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    [SerializeField]
    public int MaxAngle;
    [SerializeField]
    public int MinAngle;
    private TMP_Text _title;
    private TMP_Text _value;
    private Transform _frame;
    private Transform _DHframe;
    #endregion
    #region Methods
    private void OnEnable()
    {
        _jointSign = transform.Find("Canvas")?.gameObject;
        _title = transform.Find("Canvas/Panel/Title")?.GetComponent<TMP_Text>();
        _value = transform.Find("Canvas/Panel/pwm")?.GetComponent<TMP_Text>();
        SetJointSignActivate(false);
    }
    public float GetAngle() { return _angle; }
    public void SetAngle(float angle)
    {
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
    public void ShowFrame(bool value) { transform.Find("frame_visual")?.gameObject.SetActive(value); }
    public void ShowDHFrame(bool value) { transform.Find("DHFrame")?.gameObject.SetActive(value); }

    public void ShowArrows(bool value)
    {
        var arrow = transform.Find("arrow")?.gameObject;
        var arrow1 = transform.Find("arrow (1)")?.gameObject;
        var arrow2 = transform.Find("arrow (2)")?.gameObject;

        Debug.Log("Attempting to show/hide arrows with value: " + value);

        if (arrow != null)
        {
            arrow.SetActive(value);
            Debug.Log("Single arrow found and set to active: " + value);
        }
        else if (arrow1 != null && arrow2 != null)
        {
            arrow1.SetActive(value);
            arrow2.SetActive(value);
            Debug.Log("Two arrows found and set to active: " + value);
        }
        else
        {
            Debug.LogError("No arrows found to show/hide.");
        }
    }

    public void SetColor(Color color)
    {
        Transform part = transform.Find("Part");
        if (part != null)
        {
            for (int i = 0; i < part.childCount; i++)
            {
                for (int j = 0; j < part.GetChild(i).childCount; j++)
                {
                    if (part.GetChild(i).GetChild(j).GetComponent<Renderer>() != null)
                    {
                        part.GetChild(i).GetChild(j).GetComponent<Renderer>().material.color = color;
                    }
                }
            }
        }
    }
    #endregion
}
