using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MultiplePoints : MonoBehaviour
{
    private RobotController _robotController;
    private Button generateButton;
    private Transform sample;
    Button addPointButton;
    List<Vector3> pointList = new List<Vector3>();
    List<float> timeList = new List<float>();
    void OnEnable()
    {
        _robotController = GameObject.Find("Robot").GetComponent<RobotController>();
        sample = transform.Find("Scroll View/Viewport/Content/Sample");
        addPointButton = transform.Find("Scroll View/Viewport/Content/Add/Add").GetComponent<Button>();
        addPointButton.onClick.AddListener(AddPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPoint()
    {
        Transform newPoint = Instantiate(sample, sample.parent);
        // newPoint.SetParent(sample.parent);
        // RectTransform sampleRect = sample.GetComponent<RectTransform>();
        // RectTransform newRect = newPoint.GetComponent<RectTransform>();
        // Debug.Log(sampleRect.localPosition);
        // newRect.localPosition = sampleRect.localPosition - new Vector3(0,1,0) * (sample.parent.childCount - 2) * 70;
        // newRect.localScale = new Vector3(1f, 1f, 1);
        newPoint.gameObject.SetActive(true);
        newPoint.name = "Point";
        newPoint.gameObject.AddComponent<PointScript>()._multiplePoints = this;

        newPoint.transform.SetSiblingIndex(sample.parent.childCount - 2);
    }
    public void UpdatePointList(){
        pointList.Clear();
        timeList.Clear();
        for(int i = 2; i < transform.Find("Scroll View/Viewport/Content").childCount - 1; i++)
        {
            pointList.Add(new Vector3(transform.Find("Scroll View/Viewport/Content").GetChild(i).GetComponent<PointScript>().x, transform.Find("Scroll View/Viewport/Content").GetChild(i).GetComponent<PointScript>().y, transform.Find("Scroll View/Viewport/Content").GetChild(i).GetComponent<PointScript>().z));
            timeList.Add(transform.Find("Scroll View/Viewport/Content").GetChild(i).GetComponent<PointScript>().time);
        }
    }
    public void GenerateTrajectory()
    {
        UpdatePointList();
        // _robotController._trajController.GenerateTrajectory(pointList, timeList);
        List<List<float>> result = new();
        
        for(int i = 1; i < pointList.Count; i++)
        {
            float[] startAngle = _robotController.CartesianToAngle(pointList[i - 1].x, pointList[i - 1].y, pointList[i - 1].z);
            float[] endAngle = _robotController.CartesianToAngle(pointList[i].x, pointList[i].y, pointList[i].z);
            for(int j = 0; j < startAngle.Length; j++)
            {
                if(result.Count <= j)
                {
                    result.Add(new());
                }
                result[j].AddRange(_robotController.gameObject.GetComponent<StaticRobotTrajectoryController>().GenerateCubicTraj(startAngle[j], endAngle[j], timeList[i] - timeList[i - 1]));
            }
        }
        _robotController.gameObject.GetComponent<StaticRobotTrajectoryController>().SetTraj(result);
    }
}
