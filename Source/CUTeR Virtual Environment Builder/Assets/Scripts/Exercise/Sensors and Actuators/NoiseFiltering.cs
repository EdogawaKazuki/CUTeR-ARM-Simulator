using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseFiltering : MonoBehaviour
{
    [SerializeField]
    private RobotController _robotController;

    List<GameObject> lineList = new List<GameObject>();

    [SerializeField]
    private DD_DataDiagram m_DataDiagram;
    //private RectTransform DDrect;

    private float h = 0;

    //private int _graphLength =1000;

    // Start is called before the first frame update
    void Start()
    {
        m_DataDiagram.PreDestroyLineEvent += (s, e) => { lineList.Remove(e.line); };
        for(int i = 0; i < 3; i++)
        {
            Color color = Color.HSVToRGB((h += 0.1f) > 1 ? (h - 1) : h, 0.8f, 0.8f);
            GameObject line = m_DataDiagram.AddLine("Joint " + i, color);
            if (null != line)
                lineList.Add(line);
        }
    }
    private void FixedUpdate()
    {
        ContinueInput();
    }
    public void UnlockRobot()
    {
        _robotController.UnlockRobotArm();
    }
    private void ContinueInput()
    {
        List<int> vs = _robotController.GetReadPWM();
        for(int i = 0; i < lineList.Count; i++)
        {
            m_DataDiagram.InputPoint(lineList[i], new Vector2(0.1f, vs[i]));
        }
    }

}
