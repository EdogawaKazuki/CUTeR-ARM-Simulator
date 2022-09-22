using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PWMFeedback : MonoBehaviour
{
    [SerializeField]
    private RobotController _robotController;
    [SerializeField]
    private DD_DataDiagram m_DataDiagram;
    private float h = 0;
    private List<GameObject> lineList = new List<GameObject>();
    private List<List<int>> _pwmQueue = new List<List<int>>() { new List<int>(), new List<int>() , new List<int>() };
    [SerializeField]
    private int _queueSize = 1;
    [SerializeField]
    private int _pwmCount = 0;
    [SerializeField]
    private Text SliderText;

    //private int _graphLength =1000;

    // Start is called before the first frame update
    void Start()
    {
        m_DataDiagram.PreDestroyLineEvent += (s, e) => { lineList.Remove(e.line); };
        for (int i = 0; i < 3; i++)
        {
            Color color = Color.HSVToRGB((h += 0.1f) > 1 ? (h - 1) : h, 0.8f, 0.8f);
            GameObject line = m_DataDiagram.AddLine("Joint " + i, color);
            if (null != line)
                lineList.Add(line);
        }
    }
    private void OnEnable()
    {
        _robotController.GetJoystickController().HideHandleText();
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
        while (_pwmCount > _queueSize)
        {
            for (int i = 0; i < lineList.Count; i++)
            {
                _pwmQueue[i].RemoveAt(0);
            }
            _pwmCount--;
        }
        List<int> vs = _robotController.GetReadPWM();
        for (int i = 0; i < lineList.Count; i++)
        {
            _pwmQueue[i].Add(vs[i]);
        }
        _pwmCount++;
        for (int i = 0; i < lineList.Count; i++)
        {
            m_DataDiagram.InputPoint(lineList[i], new Vector2(0.1f, GetCurrentAverage(i)));
        }

    }
    public void SetAverageWindowSize(float value)
    {
        _queueSize = (int)value;
        SliderText.text = value.ToString();
    }

    public void UpdateTable()
    {

        //Debug.Log(_robotController.GetPWM());
        List<int> vs = _robotController.GetReadPWM();
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
}
