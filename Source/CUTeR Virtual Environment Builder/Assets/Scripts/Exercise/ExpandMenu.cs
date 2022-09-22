using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandMenu : MonoBehaviour
{
    float width;
    float height;
    float containerWidth;
    float containerHeight;
    float rowHeight;
    RectTransform RectTransform;
    RectTransform ContainerRT;
    // Start is called before the first frame update
    void Start()
    {
        RectTransform = GetComponent<RectTransform>();
        ContainerRT = transform.parent.GetComponent<RectTransform>();
        width = RectTransform.rect.width;
        height = RectTransform.rect.height;
        containerWidth = ContainerRT.rect.width;
        containerHeight = ContainerRT.rect.height;
        rowHeight = transform.GetChild(0).GetComponent<RectTransform>().rect.height;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExpandOption(bool value)
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(value);
        }
        if (value)
        {
            RectTransform.sizeDelta = new Vector2(width, height);
            ContainerRT.sizeDelta = new Vector2(containerWidth, ContainerRT.rect.height + (transform.childCount - 1) * height / transform.childCount);
        }
        else
        {
            RectTransform.sizeDelta = new Vector2(width, height / transform.childCount);
            ContainerRT.sizeDelta = new Vector2(containerWidth, ContainerRT.rect.height - (transform.childCount - 1) * height / transform.childCount);
        }
    }
}
