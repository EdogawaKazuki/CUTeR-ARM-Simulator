/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DrawGraph : MonoBehaviour {

    [SerializeField] private Sprite circleSprite;
    private GameObject CreateCircle(Vector2 anchoredPosition, RectTransform graphContainer)
    {
        //GameObject gameObject = new GameObject("circle", typeof(Image));
        GameObject gameObject = new GameObject("circle");
        gameObject.transform.SetParent(graphContainer, false);
        //gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }
    public void DrawGrid(string name, List<float> valueList)
    {
        RectTransform graphContainer = transform.Find(name + "/Table").GetComponent<RectTransform>();
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float yMax = valueList.Max();
        float yMin = valueList.Min();
        float deltaY = yMax - yMin;
        if (deltaY > 6)
        {
            deltaY = 6 * Mathf.Ceil(deltaY / 6f);
        }
        else if (deltaY == 0)
        {
            yMin = yMin - 1;
            deltaY = 2;
        }
        float xSize = graphWidth / (valueList.Count - 1);
        for (int i = 0; i < 7; i++)
        {
            GameObject newText = new GameObject("x_label" + i);
            Text myText = newText.AddComponent<Text>();
            myText.text = ((valueList.Count - 1) / 20f / 6 * i).ToString("F1");
            Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
            myText.font = ArialFont;
            myText.material = ArialFont.material;
            myText.color = new Color(0, 0, 0, 1);
            myText.fontSize = 12;
            myText.alignment = TextAnchor.MiddleCenter;
            newText.transform.SetParent(graphContainer.transform);
            newText.GetComponent<RectTransform>().sizeDelta = new Vector2(graphWidth / 6, graphHeight / 6);
            newText.transform.localPosition = new Vector3((valueList.Count - 1) / 6f * xSize * i - graphWidth / 2, -graphHeight / 2 - graphHeight / 6 / 2, 0);
            CreateDotConnection(graphContainer, new Vector2(graphWidth / 6f * i, 0), new Vector2(graphWidth / 6f * i, graphHeight), new Color(0, 0, 0, 0.5f), 1f);
        }
        for (int i = 0; i < 7; i++)
        {
            GameObject newText = new GameObject("y_label" + i);
            Text myText = newText.AddComponent<Text>();
            myText.text = (deltaY / 6f * i + yMin).ToString("F1");
            Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
            myText.font = ArialFont;
            myText.material = ArialFont.material;
            myText.color = new Color(0, 0, 0, 1);
            myText.fontSize = 12;
            myText.alignment = TextAnchor.MiddleCenter;
            newText.transform.SetParent(graphContainer.transform);
            newText.GetComponent<RectTransform>().sizeDelta = new Vector2(graphWidth / 6, graphHeight / 6);
            newText.transform.localPosition = new Vector3(-graphWidth / 2 - graphWidth / 6 / 2, graphHeight / 6f * i - graphHeight / 2, 0);
            CreateDotConnection(graphContainer, new Vector2(0, graphHeight / 6f * i), new Vector2(graphWidth, graphHeight / 6f * i), new Color(0, 0, 0, 0.5f), 1f);
        }
    }
    public void ShowGraph(List<float> valueList, string name)
    {
        DrawGrid(name, valueList);
        PlotPoints(name, valueList, new Color32(255, 0, 0, 255));
    }
    public void PlotPoints(string name, List<float> valueList, Color32 color)
    {
        RectTransform graphContainer = transform.Find(name + "/Table").GetComponent<RectTransform>();
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float yMax = valueList.Max();
        float yMin = valueList.Min();
        float deltaY = yMax - yMin;
        if (deltaY > 6)
        {
            deltaY = 6 * Mathf.Ceil(deltaY / 6f);
        }
        else if (deltaY == 0)
        {
            yMin = yMin - 1;
            deltaY = 2;
        }
        float xSize = graphWidth / (valueList.Count - 1);
        float ySize = graphHeight / deltaY;

        Vector2 lastPosition = new Vector2(0 * xSize, (valueList[0] - yMin) * ySize);
        for (int i = 1; i < valueList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = (valueList[i] - yMin) * ySize;
            //GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition));
            if (lastPosition != null)
            {
                CreateDotConnection(graphContainer, lastPosition, new Vector2(xPosition, yPosition), color);
            }
            lastPosition = new Vector2(xPosition, yPosition);
        }
    }
    public void ClearGraph(string name)
    {
        RectTransform graphContainer = transform.Find(name + "/Table").GetComponent<RectTransform>();
        foreach (Transform child in graphContainer.transform)
        {
            Destroy(child.gameObject);
        }
    }
    private void CreateDotConnection(RectTransform graphContainer, Vector2 dotPositionA, Vector2 dotPositionB, Color color, float thickness = 3f) {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = color;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, thickness);
        rectTransform.anchoredPosition = dotPositionA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, 180 * (Mathf.Atan2(dotPositionB.y -dotPositionA.y , dotPositionB.x - dotPositionA.x) / Mathf.PI));
    }

}
