using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotJointController : MonoBehaviour
{

    #region Variables
    [SerializeField]
    private List<RobotJoint> _joints = new List<RobotJoint>();
    [SerializeField]
    private List<float> _initialAngles = new List<float>();
    private int _jointNumber = 0;
    private RobotClient _robotClient;
    private string path_root;
    #endregion
    #region MonoBehaviour
    // Start is called before the first frame update
    void Start()
    {
        _robotClient = GameObject.Find("Robot").GetComponent<RobotClient>();
    }
    void OnEnable(){
        
        Transform nextJoint = transform.Find("Joint" + (_jointNumber + 1));
        while (true)
        {
            if (nextJoint != null)
            {
                _jointNumber++;
                _joints.Add(nextJoint.GetComponent<RobotJoint>());
                nextJoint = nextJoint.Find("Joint" + (_jointNumber + 1));
            }
            else
            {
                break;
            }
        }
        SetJointAngles(_initialAngles);
        ShowJointsFrame(false);
        // Debug.Log("Joint number: " + _jointNumber);
    }
    
    // Update is called once per frame
    void Update()
    {
    }


    #endregion
    #region Methods
    public void SetPathRoot(string path) { path_root = path; }
    public int GetJointAngleMax(int index) { return _joints[index].MaxAngle; }
    public int GetJointAngleMin(int index) { return _joints[index].MinAngle; }
    public List<float> GetJointAngles()
    {
        List<float> result = new List<float>();
        foreach(RobotJoint joint in _joints)
        {
            result.Add(joint.GetAngle());
        }
        return result;
    }
    public float GetJointAngle(int index)
    {
        return _joints[index].GetAngle();
    }
    public void SetJointAngles(List<float> angleList)
    {
        for (int i = 0; i < angleList.Count && i < _joints.Count; i++)
        {
            _joints[i].SetAngle(angleList[i]);
        }
    }
    public void SetJointAngle(int index, float angle)
    {
        _joints[index].SetAngle(angle);
    }
    public Transform GetJointTransform(int index)
    {
        return _joints[index].transform;
    }
    public List<Transform> GetJointsTransform()
    {
        List<Transform> jointTransforms = new List<Transform>();
        foreach(var joint in _joints)
            jointTransforms.Add(joint.transform);
        return jointTransforms;
    }
    public void HideJointLink(int index)
    {
        _joints[index].transform.Find("Part")?.gameObject.SetActive(false);
    }
    public void HideJointMask(int index)
    {
        _joints[index].transform.Find("Mask")?.gameObject.SetActive(true);
    }
    public void ShowJointLink(int index)
    {
        _joints[index].transform.Find("Part")?.gameObject.SetActive(true);
    }
    public void ShowJointMask(int index)
    {
        _joints[index].transform.Find("Mask")?.gameObject.SetActive(true);
    }
    public void SetJointSignActivate(bool value)
    {
        foreach (var joint in _joints)
        {
            joint.SetJointSignActivate(value);
        }
    }
    public void SetLinkSignActivate(bool value)
    {
        foreach (var joint in _joints)
        {
            joint.SetLinkSignActivate(value);
        }
    }
    public void SetJointSignActivate(int index, bool value)
    {
        _joints[index].SetJointSignActivate(value);
    }
    public void SetLinkSignActivate(int index, bool value)
    {
        _joints[index].SetLinkSignActivate(value);
    }
    public void SetJointSign(int index, string line1, string line2 = "")
    {
        _joints[index].SetSignText(line1, line2);
    }
    
    public void ShowJointFrame(int index, bool value){
        _joints[index].ShowFrame(value);
    }
    public void ShowJointsFrame(bool value){
        transform.Find(path_root + "/frame_visual")?.gameObject.SetActive(value);
        foreach (var joint in _joints)
        {
            joint.ShowFrame(value);
        }
        transform.Find("frame_visual")?.gameObject.SetActive(value);
    }
    
    public void ShowJointDHFrame(int index, bool value){
        _joints[index].ShowDHFrame(value);
    }
    public void ShowJointsDHFrame(bool value){
        transform.Find("DHFrame")?.gameObject.SetActive(value);
        foreach (var joint in _joints)
        {
            joint.ShowDHFrame(value);
        }
    }
    public void SetMask(bool value){
        if(value){
            for(int i = 0; i < _joints.Count; i++){
                HideJointLink(i);
                ShowJointMask(i);
            }
        }else{
            for(int i = 0; i < _joints.Count; i++){
                ShowJointLink(i);
                HideJointMask(i);
            }
        }
    }
    public void SetJointsVisible(bool value){
        GameObject partObject = transform.Find("Part")?.gameObject;
        if(partObject == null) {
            Debug.LogWarning("Part GameObject not found!");
        }
        
        if(value){
            partObject?.SetActive(false);
            for(int i = 0; i < _joints.Count; i++){
                HideJointLink(i);
            }
        }else{
            partObject?.SetActive(true);
            for(int i = 0; i < _joints.Count; i++){
                ShowJointLink(i);
            }
        }
    }
    
    public void SetColor(Color color){
        foreach (var joint in _joints)
        {
            joint.SetColor(color);
        }
    }
    #endregion
}
