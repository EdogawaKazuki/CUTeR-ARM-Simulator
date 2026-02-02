using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TwoDRotation : MonoBehaviour
{
    RobotController _robotController;
    RobotJointController _robotJointController;
    [SerializeField]
    LineRenderer _blueLine;
    [SerializeField]
    LineRenderer _greenLine;
    [SerializeField]
    LineRenderer _redLine;
    [SerializeField]
    Transform _blueLineHead;
    [SerializeField]
    Transform _greenLineHead;
    [SerializeField]
    Transform _redLineHead;
    List<Transform> _jointTransformList;
    TMP_Text matrix1aText;
    TMP_Text matrix1bText;
    TMP_Text matrix1cText;
    TMP_Text matrix1dText;

    TMP_Text matrix2aText;
    TMP_Text matrix2bText;
    TMP_Text matrix2cText;
    TMP_Text matrix2dText;

    Button JointSetBtn1;
    Button JointSetBtn2;
    Toggle FrameBtn1, FrameBtn2;
    float Angle2Sin;
    float Angle2Cos;
    float Angle3Sin;
    float Angle3Cos;
    
    Vector3 _redLineStart;
    Vector3 _redLineEnd;
    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _robotJointController = GameObject.Find("Robot/Joints").GetComponent<RobotJointController>();

        _jointTransformList = _robotController.GetJointsTransform();
        matrix1aText = transform.Find("Input/Line2/Values/a").GetComponent<TMP_Text>();
        matrix1bText = transform.Find("Input/Line2/Values/b").GetComponent<TMP_Text>();
        matrix1cText = transform.Find("Input/Line2/Values/c").GetComponent<TMP_Text>();
        matrix1dText = transform.Find("Input/Line2/Values/d").GetComponent<TMP_Text>();
        FrameBtn1 = transform.Find("Input/Line2/R").GetComponent<Toggle>();

        matrix2aText = transform.Find("Input/Line3/Values/a").GetComponent<TMP_Text>();
        matrix2bText = transform.Find("Input/Line3/Values/b").GetComponent<TMP_Text>();
        matrix2cText = transform.Find("Input/Line3/Values/c").GetComponent<TMP_Text>();
        matrix2dText = transform.Find("Input/Line3/Values/d").GetComponent<TMP_Text>();
        FrameBtn2 = transform.Find("Input/Line3/R").GetComponent<Toggle>();

        JointSetBtn1 = transform.Find("Input/Line4/Set1").GetComponent<Button>();
        JointSetBtn2 = transform.Find("Input/Line5/Set2").GetComponent<Button>();
        JointSetBtn1.onClick.AddListener(() => SetJointAngles(new(){ 30, 180, -140 }));
        JointSetBtn2.onClick.AddListener(() => SetJointAngles(new(){ 30, 100, -140 }));
        FrameBtn1.onValueChanged.AddListener((value) => ShowRelativeFrames(0, value));
        FrameBtn2.onValueChanged.AddListener((value) => ShowRelativeFrames(1,value));
        UpdateTable();

        // _robotJointController.ShowJointBaseFrame(true);
        // _robotJointController.ShowJointFrame(1, true);
    }

    void OnDisable()
    {
        if (_robotJointController != null)
        {
            _robotController.ShowFrames(false);
        }
    }

    private void ShowRelativeFrames(int index, bool value)
    {
        _robotController.ShowFrames(false);
        if (value){
            if (index == 0)
            {
                // turn on base frame and frame 1, turn off others
                _robotJointController.ShowJointBaseFrame(true);
                _robotJointController.ShowJointFrame(1, true);
                FrameBtn2.isOn = false;
            }
            else
            {
                _robotJointController.ShowJointFrame(1, true);
                _robotJointController.ShowJointFrame(2, true);
                FrameBtn1.isOn = false;
            }
        }
    }

    private void FixedUpdate()
    {
        UpdateTable();
    }
    void UpdateTable()
    {
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        matrix1aText.text = (Angle2Cos + 0.00001f).ToString("F3");
        matrix1bText.text = (-Angle2Sin + 0.00001f).ToString("F3");
        matrix1cText.text = (Angle2Sin + 0.00001f).ToString("F3");
        matrix1dText.text = (Angle2Cos + 0.00001f).ToString("F3");

        Angle3Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(2));
        Angle3Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(2));
        matrix2aText.text = (Angle3Cos + 0.00001f).ToString("F3");
        matrix2bText.text = (-Angle3Sin + 0.00001f).ToString("F3");
        matrix2cText.text = (Angle3Sin + 0.00001f).ToString("F3");
        matrix2dText.text = (Angle3Cos + 0.00001f).ToString("F3");


        _redLineStart = _jointTransformList[1].position;
        _redLineEnd = _jointTransformList[1].position - _jointTransformList[1].forward * 10;
        _redLine.SetPosition(0, _redLineStart);
        _redLine.SetPosition(1, _redLineEnd - Vector3.Normalize(_redLineEnd - _redLineStart) * 2f);
        _redLineHead.transform.SetPositionAndRotation(_redLineEnd, Quaternion.LookRotation(_redLineEnd - _redLineStart));
    }

    public void SetJointAngles(List<float> joints)
    {
        _robotController.MoveJointsTo(joints);
    }
}
