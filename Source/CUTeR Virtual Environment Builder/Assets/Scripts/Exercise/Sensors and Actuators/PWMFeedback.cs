using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PWMFeedback : MonoBehaviour
{
    private RobotController _robotController;
    [SerializeField]
    private DD_DataDiagram m_DataDiagram;
    [SerializeField]
    List<LineRenderer> _joinLines;
    // private float h = 0;
    private List<GameObject> lineList = new List<GameObject>();
    private List<List<int>> _pwmQueue = new List<List<int>>();
    private List<Vector3[]> _pwmPositions = new List<Vector3[]>();
    [SerializeField]
    private int _queueSize = 100;
    // [SerializeField]
    // private int _pwmCount = 0;
    [SerializeField]
    private Text SliderText;
    private bool useMovingAverage;
    private int windowSize = 5;
    int count = 0;
    float tmp;
    float[] sum = { 0, 0, 0 };
    List<Queue<float>> tail;
    List<int> pwmList;


    //private int _graphLength =1000;

    // Start is called before the first frame update
    private void OnEnable()
    {
        lineList = new List<GameObject>();
        _pwmQueue = new List<List<int>>();
        _pwmPositions = new List<Vector3[]>();
        sum = new float[] { 0, 0, 0, 0, 0, 0 };
        
        _robotController = GameObject.Find("EditorAdmin").GetComponent<EditorController>().GetRobotController();
        _robotController.GetJoystickController().HideHandleText();
        for (int i = 0; i < _robotController.GetRobotDoF(); i++)
        {
            _pwmPositions.Add(new Vector3[_queueSize]);
        }
        for (int i = 0; i < 3; i++)
        {
            _joinLines[i].positionCount = _queueSize;
        }

        {
            for (int i = 0; i < _pwmPositions.Count; i++)
            {
                for (int j = 0; j < _queueSize; j++)
                    _pwmPositions[i][j] = new Vector3(j, 0, 0);
            }
        }
        tail = new List<Queue<float>>();
        for (int i = 0; i < _robotController.GetRobotDoF(); i++)
        {
            tail.Add(new Queue<float>());
        }
        _robotController.SetJointSignActivate(true);
    }
    private void OnDisable()
    {
        _robotController.SetJointSignActivate(false);
        _robotController.GetJoystickController().ShowHandleText();
    }
    private void FixedUpdate()
    {
        ContinueInput();
        UpdateTable();
    }
    public void UnlockRobot()
    {
        _robotController.UnlockRobotArm();
    }
    private void ContinueInput()
    {
        if (useMovingAverage && count <= windowSize) {
            count++;
        }

        pwmList = _robotController.GetReadPWM();
        for (int i = 0; i < _pwmPositions.Count; i++)
        {
            for(int j = _joinLines[0].positionCount - 1; j > 0; j--)
            {
                _pwmPositions[i][j] = _pwmPositions[i][j - 1];
                _pwmPositions[i][j].x += 1;
            }
            // print(i);
            if (useMovingAverage)
            {
                print(i);
                tmp = pwmList[i];
                sum[i] += tmp;
                tail[i].Enqueue(tmp);
                if (count > windowSize)
                {
                    sum[i] -= tail[i].Dequeue();
                }
                //Debug.Log(sum[i]);
                //Debug.Log(tail[i].Count);
                _pwmPositions[i][0] = new Vector3(0, sum[i] / tail[i].Count / 30, 0);
            }
            else
            {
                _pwmPositions[i][0] = new Vector3(0, pwmList[i] / 30, 0);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            _joinLines[i].SetPositions(_pwmPositions[i]);
        }
    }
    public void SetAverageWindowSize(float value)
    {
        windowSize = (int)value;
        SliderText.text = value.ToString();
        count = 0;
        for (int i = 0; i < _robotController.GetRobotDoF(); i++)
        {
            sum[i] = 0;
            tail[i].Clear();
        }
}
    public void ToggleMovingAberage(bool value)
    {
        useMovingAverage = value;
    }
    public void UpdateTable()
    {

        for (int i = 0; i < pwmList.Count; i++)
        {
            _robotController.SetJointSign(i, "Joint " + (i + 1) + " PWM:", pwmList[i].ToString());
        }
    }
    private int GetCurrentAverage(int index)
    {
        return (int)_pwmQueue[index].Average();
    }
    public void ShowJoint(int value)
    {
        if(value < 0)
        {
            foreach (LineRenderer line in _joinLines)
            {
                line.gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (LineRenderer line in _joinLines)
            {
                line.gameObject.SetActive(false);
            }
            _joinLines[value].gameObject.SetActive(true);
        }
    }
    public void ToggleZoom(bool value)
    {
        if (value)
        {
            transform.localScale = Vector3.one * 2f;
            transform.localPosition = new Vector3(-620, 0, 0);
        }
        else
        {
            transform.localScale = Vector3.one;
            transform.localPosition = new Vector3(-15, 215, 0);
        }
    }
}
