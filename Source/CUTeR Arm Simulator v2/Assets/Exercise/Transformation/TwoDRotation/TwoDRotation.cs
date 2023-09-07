using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TwoDRotation : MonoBehaviour
{
    RobotController _robotController;
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

    Button JointSetBtn1;
    Button JointSetBtn2;
    float Angle1Sin;
    float Angle1Cos;
    Vector3 _redLineStart;
    Vector3 _redLineEnd;
    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _jointTransformList = _robotController.GetJointsTransform();
        matrix1aText = transform.Find("Input/Line2/Values/a").GetComponent<TMP_Text>();
        matrix1bText = transform.Find("Input/Line2/Values/b").GetComponent<TMP_Text>();
        matrix1cText = transform.Find("Input/Line2/Values/c").GetComponent<TMP_Text>();
        matrix1dText = transform.Find("Input/Line2/Values/d").GetComponent<TMP_Text>();
        JointSetBtn1 = transform.Find("Input/Line3/Set1").GetComponent<Button>();
        JointSetBtn2 = transform.Find("Input/Line4/Set2").GetComponent<Button>();
        JointSetBtn1.onClick.AddListener(() => SetJointAngles(new(){ 30, 180, -140 }));
        JointSetBtn2.onClick.AddListener(() => SetJointAngles(new(){ -60, 180, -140 }));
        UpdateTable();
    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    void UpdateTable()
    {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        matrix1aText.text = (Angle1Cos + 0.00001f).ToString("F3");
        matrix1bText.text = (-Angle1Sin + 0.00001f).ToString("F3");
        matrix1cText.text = (Angle1Sin + 0.00001f).ToString("F3");
        matrix1dText.text = (Angle1Cos + 0.00001f).ToString("F3");

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
