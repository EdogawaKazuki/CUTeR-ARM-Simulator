using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class EndEffectorController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private List<EndEffector> _endEffectors = new List<EndEffector>();
    [SerializeField]
    //private RobotController _robotController;
    private int _currentEndEffectorIndex;
    private EndEffector _currentEndEffector;
    private List<string> _endEffectorNames = new List<string>();
    private TMP_Text statusText;
    private Transform _robotArm;
    #endregion
    #region MonoBehaviour
    private void OnEnable()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).GetComponent<EndEffector>() == null) continue;
            _endEffectors.Add(transform.GetChild(i).GetComponent<EndEffector>());
            _endEffectors[i].Init();
            _endEffectorNames.Add(_endEffectors[i].GetEndEffectorName());
        }
        SetEndEffector(_currentEndEffectorIndex);
        statusText = GameObject.Find("Robot/RobotCanvas/EEStatus").GetComponent<TMP_Text>();
        _robotArm = GameObject.Find("Robot").transform;
    }
    void FixedUpdate()
    {
        if(_currentEndEffector != null)
        {
            statusText.text = "";
            // Vector3 euler = quaternion2Euler(_currentEndEffector.transform.rotation, RotSeq.yxz);
            // euler = euler * Mathf.Rad2Deg;
            // Display End Effector Position (Divide by the scale of the robot GameObject so it accurately represents real life position)
            GameObject robot = GameObject.Find("Robot");
            Transform robotTransform = robot.transform;
            Vector3 robotScale = robotTransform.localScale;
            Vector3 position = _endEffectors[_currentEndEffectorIndex].transform.position - _robotArm.transform.position;
            position.x /= robotScale.x;
            position.y /= robotScale.y;
            position.z /= robotScale.z;
            statusText.text = "Pos: " + "x: " + position.x * 100 + 
            " y: " + position.y * 100 + 
            " z: " + position.z * 100;   
            // statusText.text += "\nEular: " + "x: " + euler.y + " y: " + (180 + euler.x) + " z: " + -(180 + euler.z);
        }
    }
    #endregion
    #region Methods
    public void SetEndEffector(int index)
    {
        for(int i = 0; i < _endEffectors.Count; i++)
        {
            _endEffectors[i].GetGameObject().SetActive(false);
        }
        _currentEndEffector = _endEffectors[index];
        _currentEndEffector.GetGameObject().SetActive(true);
        _currentEndEffectorIndex = index;
    }
    public int GetEndEffector() { return _currentEndEffectorIndex; }
    public void Fire()
    {
        //if (_robotController.GetEditorController().GetSceneManager().GetPlayingScene() != null)
        _currentEndEffector?.Fire();
    }
    public void SetForce(float force)
    {
        _currentEndEffector?.SetForce(force);
    }
    public List<string> GetEndEffectorList()
    {
        return _endEffectorNames;
    }

    public void ResetEndEffector()
    {
        _currentEndEffector.Reset();
    }
    enum RotSeq
    {
        zyx, zyz, zxy, zxz, yxz, yxy, yzx, yzy, xyz, xyx, xzy,xzx
    };
 
    Vector3 twoaxisrot(float r11, float r12, float r21, float r31, float r32){
        Vector3 ret = new Vector3();
        ret.x = Mathf.Atan2( r11, r12 );
        ret.y = Mathf.Acos ( r21 );
        ret.z = Mathf.Atan2( r31, r32 );
        return ret;
    }
 
    Vector3 threeaxisrot(float r11, float r12, float r21, float r31, float r32){
        Vector3 ret = new Vector3();
        ret.x = Mathf.Atan2( r31, r32 );
        ret.y = Mathf.Asin ( r21 );
        ret.z = Mathf.Atan2( r11, r12 );
        return ret;
    }
 
    Vector3 quaternion2Euler(Quaternion q, RotSeq rotSeq)
    {
        switch(rotSeq){
        case RotSeq.zyx:
            return threeaxisrot( 2*(q.x*q.y + q.w*q.z),
                q.w*q.w + q.x*q.x - q.y*q.y - q.z*q.z,
                -2*(q.x*q.z - q.w*q.y),
                2*(q.y*q.z + q.w*q.x),
                q.w*q.w - q.x*q.x - q.y*q.y + q.z*q.z);
           
 
        case RotSeq.zyz:
            return twoaxisrot( 2*(q.y*q.z - q.w*q.x),
                2*(q.x*q.z + q.w*q.y),
                q.w*q.w - q.x*q.x - q.y*q.y + q.z*q.z,
                2*(q.y*q.z + q.w*q.x),
                -2*(q.x*q.z - q.w*q.y));
           
 
        case RotSeq.zxy:
            return threeaxisrot( -2*(q.x*q.y - q.w*q.z),
                q.w*q.w - q.x*q.x + q.y*q.y - q.z*q.z,
                2*(q.y*q.z + q.w*q.x),
                -2*(q.x*q.z - q.w*q.y),
                q.w*q.w - q.x*q.x - q.y*q.y + q.z*q.z);
           
 
        case RotSeq.zxz:
            return twoaxisrot( 2*(q.x*q.z + q.w*q.y),
                -2*(q.y*q.z - q.w*q.x),
                q.w*q.w - q.x*q.x - q.y*q.y + q.z*q.z,
                2*(q.x*q.z - q.w*q.y),
                2*(q.y*q.z + q.w*q.x));
           
 
        case RotSeq.yxz:
            return threeaxisrot( 2*(q.x*q.z + q.w*q.y),
                q.w*q.w - q.x*q.x - q.y*q.y + q.z*q.z,
                -2*(q.y*q.z - q.w*q.x),
                2*(q.x*q.y + q.w*q.z),
                q.w*q.w - q.x*q.x + q.y*q.y - q.z*q.z);
 
        case RotSeq.yxy:
            return twoaxisrot( 2*(q.x*q.y - q.w*q.z),
                2*(q.y*q.z + q.w*q.x),
                q.w*q.w - q.x*q.x + q.y*q.y - q.z*q.z,
                2*(q.x*q.y + q.w*q.z),
                -2*(q.y*q.z - q.w*q.x));
           
 
        case RotSeq.yzx:
            return threeaxisrot( -2*(q.x*q.z - q.w*q.y),
                q.w*q.w + q.x*q.x - q.y*q.y - q.z*q.z,
                2*(q.x*q.y + q.w*q.z),
                -2*(q.y*q.z - q.w*q.x),
                q.w*q.w - q.x*q.x + q.y*q.y - q.z*q.z);
           
 
        case RotSeq.yzy:
            return twoaxisrot( 2*(q.y*q.z + q.w*q.x),
                -2*(q.x*q.y - q.w*q.z),
                q.w*q.w - q.x*q.x + q.y*q.y - q.z*q.z,
                2*(q.y*q.z - q.w*q.x),
                2*(q.x*q.y + q.w*q.z));
           
 
        case RotSeq.xyz:
            return threeaxisrot( -2*(q.y*q.z - q.w*q.x),
                q.w*q.w - q.x*q.x - q.y*q.y + q.z*q.z,
                2*(q.x*q.z + q.w*q.y),
                -2*(q.x*q.y - q.w*q.z),
                q.w*q.w + q.x*q.x - q.y*q.y - q.z*q.z);
           
 
        case RotSeq.xyx:
            return twoaxisrot( 2*(q.x*q.y + q.w*q.z),
                -2*(q.x*q.z - q.w*q.y),
                q.w*q.w + q.x*q.x - q.y*q.y - q.z*q.z,
                2*(q.x*q.y - q.w*q.z),
                2*(q.x*q.z + q.w*q.y));
           
 
        case RotSeq.xzy:
            return threeaxisrot( 2*(q.y*q.z + q.w*q.x),
                q.w*q.w - q.x*q.x + q.y*q.y - q.z*q.z,
                -2*(q.x*q.y - q.w*q.z),
                2*(q.x*q.z + q.w*q.y),
                q.w*q.w + q.x*q.x - q.y*q.y - q.z*q.z);
           
 
        case RotSeq.xzx:
            return twoaxisrot( 2*(q.x*q.z - q.w*q.y),
                2*(q.x*q.y + q.w*q.z),
                q.w*q.w + q.x*q.x - q.y*q.y - q.z*q.z,
                2*(q.x*q.z + q.w*q.y),
                -2*(q.x*q.y - q.w*q.z));
           
        default:
            Debug.LogError("No good sequence");
            return Vector3.zero;
 
        }
 
    }
    #endregion
}
