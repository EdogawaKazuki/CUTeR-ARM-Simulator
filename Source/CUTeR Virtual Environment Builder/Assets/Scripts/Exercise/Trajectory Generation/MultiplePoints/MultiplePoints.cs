using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplePoints : MonoBehaviour
{
    [SerializeField]
    RobotController _robotController;
    [SerializeField]
    private Transform sample;
    List<Vector3> pointList = new List<Vector3>();
    List<float> timeList = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPoint()
    {
        Transform newPoint = Instantiate(sample);
        newPoint.SetParent(sample.parent);
        RectTransform sampleRect = sample.GetComponent<RectTransform>();
        RectTransform newRect = newPoint.GetComponent<RectTransform>();
        Debug.Log(sampleRect.localPosition);
        newRect.localPosition = sampleRect.localPosition - new Vector3(0,1,0) * (sample.parent.childCount - 2) * 70;
        newRect.localScale = new Vector3(1.4f, 1.4f, 1);
        newRect.gameObject.SetActive(true);
        newRect.gameObject.AddComponent<PointScript>();
    }
    public void StartTraj()
    {
        for(int i = 1; i < sample.parent.childCount; i++)
        {
            PointScript pointScript = sample.GetChild(i).GetComponent<PointScript>();
            pointList.Add(new Vector3(pointScript.x, pointScript.y, pointScript.z));
            timeList.Add(pointScript.time);
        }

    }
    public void StopTraj()
    {

    }
}
