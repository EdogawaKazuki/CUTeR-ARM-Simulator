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
    private float h = 0;
    private List<GameObject> lineList = new List<GameObject>();
    private List<List<int>> _pwmQueue = new List<List<int>>() { new List<int>(), new List<int>() , new List<int>() };
    private List<Vector3[]> _pwmPositions = new List<Vector3[]>();
    [SerializeField]
    private int _queueSize = 100;
    [SerializeField]
    private int _pwmCount = 0;
    [SerializeField]
    private Text SliderText;
    private bool useMovingAverage;
    private int windowSize = 5;
    int count = 0;
    float tmp;
    float[] sum = { 0, 0, 0 };
    List<Queue<float>> tail;


    //private int _graphLength =1000;

    // Start is called before the first frame update
    private void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        _robotController.GetJoystickController().HideHandleText();
        for (int i = 0; i < 3; i++)
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
        tail = new List<Queue<float>>() { new Queue<float>(), new Queue<float>(), new Queue<float>() };
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
        _robotController.SetRobotArmLock(false);
    }
    private void ContinueInput()
    {
        if (useMovingAverage && count <= windowSize) {
            count++;
        }

        List<int> vs = _robotController.GetReadPWM();
        for (int i = 0; i < _pwmPositions.Count; i++)
        {
            for(int j = _joinLines[0].positionCount - 1; j > 0; j--)
            {
                _pwmPositions[i][j] = _pwmPositions[i][j - 1];
                _pwmPositions[i][j].x += 1;
            }
            if (useMovingAverage)
            {
                tmp = vs[i];
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
                _pwmPositions[i][0] = new Vector3(0, vs[i] / 30, 0);
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
        for (int i = 0; i < 3; i++)
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

        //Debug.Log(_robotController.GetPWM());
        List<int> vs = new List<int> { (int)(_pwmPositions[0][0].y * 30), (int)(_pwmPositions[1][0].y * 30), (int)(_pwmPositions[2][0].y * 30) };
        for (int i = 0; i < vs.Count; i++)
        {
            _robotController.SetJointSign(i, "Joint " + (i + 1) + " PWM:", vs[i].ToString());
        }
        /*
        if(_joint0PWMList.Count > _graphLength)
        {
            _joint0PWMList.RemoveAt(0);
            _joint1PWMList.RemoveAt(1);
            _joint2PWMList.RemoveAt(2);
        }
        _joint0PWMList.Add(vs[0]);
        _joint1PWMList.Add(vs[1]);
        _joint2PWMList.Add(vs[2]);
        _drawer.ClearGraph("PWM");
        _drawer.PlotPoints("PWM", _joint0PWMList, new Color32(255, 0, 0, 255));
        _drawer.PlotPoints("PWM", _joint1PWMList, new Color32(0, 255, 0, 255));
        _drawer.PlotPoints("PWM", _joint2PWMList, new Color32(0, 0, 255, 255));
        */
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
            transform.localScale = Vector3.one * 3.5f;
            transform.localPosition = new Vector3(-620, 100, 0);
        }
        else
        {
            transform.localScale = Vector3.one;
            transform.localPosition = new Vector3(-15, 215, 0);
        }
    }
}
