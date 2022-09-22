using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotJointController : MonoBehaviour
{

    #region Variables
    [SerializeField]
    private List<RobotJoint> _joints = new List<RobotJoint>();
    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
    #region Methods
    public void SetJointAngle(int index, float angle)
    {
        _joints[index].SetAngle(angle);
    }
    public float GetJointAngle(int index)
    {
        return _joints[index].GetAngle();
    }
    public void SetJointSign(int index, string line1, string line2 = "")
    {
        _joints[index].SetSignText(line1, line2);
    }
    public void SetJointAngles(List<float> angleList)
    {
        for (int i = 0; i < angleList.Count && i < _joints.Count; i++)
        {
            _joints[i].SetAngle(angleList[i]);
        }
    }
    public List<float> GetJointAngles()
    {
        List<float> result = new List<float>();
        foreach(RobotJoint joint in _joints)
        {
            result.Add(joint.GetAngle());
        }
        return result;
    }
    public Transform GetJointTransformByIndex(int index)
    {
        return _joints[index].transform;
    }
    public List<Transform> GetJointTransforms()
    {
        List<Transform> jointTransforms = new List<Transform>();
        foreach(var joint in _joints)
            jointTransforms.Add(joint.transform);
        return jointTransforms;
    }
    public void HideJointLink(int index)
    {
        _joints[index].transform.Find("Mask").gameObject.SetActive(true);
        _joints[index].transform.Find("Part").gameObject.SetActive(false);
    }
    public void ShowJointLink(int index)
    {
        _joints[index].transform.Find("Mask").gameObject.SetActive(false);
        _joints[index].transform.Find("Part").gameObject.SetActive(true);
    }
    public void SetSignActivate(bool value)
    {
        foreach(var joint in _joints)
        {
            joint.SetSignActivate(value);
        }
    }
    #endregion
}
