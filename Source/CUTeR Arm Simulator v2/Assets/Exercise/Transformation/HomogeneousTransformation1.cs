using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomogeneousTransformation1 : MonoBehaviour
{
    RobotController _robotController;
    StaticRobotTrajectoryController _trajController;
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
    Vector3 _redLineStart;
    Vector3 _redLineEnd;
    Vector3 _blueLineStart;
    Vector3 _blueLineEnd;
    Vector3 _greenLineStart;
    Vector3 _greenLineEnd;
    List<Transform> _jointTransformList;
    Text[] matrix1Text;
    Text[] matrix2Text;
    Slider BaseSlider;
    Slider Joint0Slider;
    Slider Joint1Slider;

    float Angle1Sin;
    float Angle1Cos;
    float Angle2Sin;
    float Angle2Cos;
    float Angle3Sin;
    float Angle3Cos;
    float x1;
    float y1;
    float z1;
    float x2;
    float y2;
    float z2;
    List<List<float>> _JointSetList = new List<List<float>> { new List<float> { 0, 0, 0 }, new List<float> { -90, 0, 0 }, new List<float> { -90, 90, 0 } };


    // Start is called before the first frame update
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        matrix1Text = new Text[9];
        for (int i = 0; i < 9; i++)
        {
            matrix1Text[i] = transform.Find("Input/Line2/" + (i + 1)).GetComponent<Text>();
        }
        matrix2Text = new Text[3];
        for (int i = 0; i < 3; i++)
        {
            matrix2Text[i] = transform.Find("Input/Line6/" + (i + 1)).GetComponent<Text>();
        }
        _jointTransformList = _robotController.GetJointsTransform();
    }
    private void FixedUpdate()
    {
        UpdateTable();
    }
    public void UpdateTable()
    {
        Angle1Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle1Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(0));
        Angle2Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle2Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(1));
        Angle3Sin = Mathf.Sin(Mathf.Deg2Rad * _robotController.GetJointAngle(2));
        Angle3Cos = Mathf.Cos(Mathf.Deg2Rad * _robotController.GetJointAngle(2));

        matrix1Text[0].text = (Angle1Cos).ToString("F3");
        matrix1Text[1].text = (-Angle1Sin * Angle2Cos).ToString("F3");
        matrix1Text[2].text = (Angle1Sin * Angle2Sin).ToString("F3");
        matrix1Text[3].text = (Angle1Sin).ToString("F3");
        matrix1Text[4].text = (Angle1Cos * Angle2Cos).ToString("F3");
        matrix1Text[5].text = (-Angle1Cos * Angle2Sin).ToString("F3");
        matrix1Text[6].text = "0";
        matrix1Text[7].text = (Angle2Sin).ToString("F3");
        matrix1Text[8].text = (Angle2Cos).ToString("F3");

        matrix2Text[0].text = (x2 * Angle1Cos + y2 * -Angle1Sin * Angle2Cos + z2 * Angle1Sin * Angle2Sin + x1).ToString();
        Debug.Log((x2 +","+ Angle1Sin + "," + y2 +","+ Angle1Cos * Angle2Cos + "," + z2 + "," + Angle1Cos * Angle2Sin + "," + y1));
        matrix2Text[1].text = (x2 * Angle1Sin + y2 * Angle1Cos * Angle2Cos + z2 * -Angle1Cos * Angle2Sin + y1).ToString();
        matrix2Text[2].text = (x2 * 0 + y2 * Angle2Sin + z2 * Angle2Cos + z1).ToString();



        _blueLineStart = _robotController.transform.position;
        _blueLineEnd = _robotController.transform.position - _robotController.transform.right * x1 - _robotController.transform.forward * y1 + _robotController.transform.up * z1;
        _blueLine.SetPosition(0, _blueLineStart);
        _blueLine.SetPosition(1, _blueLineEnd - Vector3.Normalize(_blueLineEnd - _blueLineStart) * 2f);
        _blueLineHead.transform.SetPositionAndRotation(_blueLineEnd, Quaternion.LookRotation(_blueLineEnd - _blueLineStart));

        _greenLineStart = _robotController.transform.position - _robotController.transform.right * x1 - _robotController.transform.forward * y1 + _robotController.transform.up * z1;
        _greenLineEnd = _jointTransformList[1].position - _jointTransformList[1].right * x2 - _jointTransformList[1].forward * y2 - _jointTransformList[1].up * z2;
        _greenLine.SetPosition(0, _greenLineStart);
        _greenLine.SetPosition(1, _greenLineEnd - Vector3.Normalize(_greenLineEnd - _greenLineStart) * 2f);
        _greenLineHead.transform.SetPositionAndRotation(_greenLineEnd, Quaternion.LookRotation(_greenLineEnd - _greenLineStart));


        _redLineStart = _robotController.transform.position;
        _redLineEnd = _jointTransformList[1].position - _jointTransformList[1].right * x2 - _jointTransformList[1].forward * y2 - _jointTransformList[1].up * z2;
        _redLine.SetPosition(0, _redLineStart);
        _redLine.SetPosition(1, _redLineEnd - Vector3.Normalize(_redLineEnd - _redLineStart) * 2f);
        _redLineHead.transform.SetPositionAndRotation(_redLineEnd, Quaternion.LookRotation(_redLineEnd - _redLineStart));
    }

    public void SetX1(string value)
    {
        float.TryParse(value, out x1);
        UpdateTable();
    }
    public void SetY1(string value)
    {
        float.TryParse(value, out y1);
        UpdateTable();
    }
    public void SetZ1(string value)
    {
        float.TryParse(value, out z1);
        UpdateTable();
    }
    public void SetX2(string value)
    {
        float.TryParse(value, out x2);
        UpdateTable();
    }
    public void SetY2(string value)
    {
        float.TryParse(value, out y2);
        UpdateTable();
    }
    public void SetZ2(string value)
    {
        float.TryParse(value, out z2);
        UpdateTable();
    }
    public void SetJointAngles(int index)
    {
        _robotController.MoveJointsTo(_JointSetList[index]);
    }
}
