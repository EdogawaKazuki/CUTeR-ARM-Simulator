using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    Text matrix1aText;
    Text matrix1bText;
    Text matrix1cText;
    Text matrix1dText;
    float Angle1Sin;
    float Angle1Cos;
    Vector3 _redLineStart;
    Vector3 _redLineEnd;
    List<List<float>> _JointSetList = new List<List<float>> { new List<float> { 30, 180, -140 }, new List<float> { -60, 180, -140 } };
    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("EditorAdmin").GetComponent<EditorController>().GetRobotController();
        _jointTransformList = _robotController.GetJointTransforms();
        matrix1aText = transform.Find("Input/Line2/a").GetComponent<Text>();
        matrix1bText = transform.Find("Input/Line2/b").GetComponent<Text>();
        matrix1cText = transform.Find("Input/Line2/c").GetComponent<Text>();
        matrix1dText = transform.Find("Input/Line2/d").GetComponent<Text>();
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

    public void SetJointAngles(int index)
    {
        _robotController.MoveJointsTo(_JointSetList[index]);
    }
}
