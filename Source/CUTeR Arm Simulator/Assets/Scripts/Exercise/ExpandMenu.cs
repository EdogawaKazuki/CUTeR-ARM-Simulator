using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandMenu : MonoBehaviour
{
    float width;
    float containerWidth;
    RectTransform RectTransform;
    RectTransform ContainerRT;
    // Start is called before the first frame update
    void Start()
    {
        RectTransform = GetComponent<RectTransform>();
        ContainerRT = transform.parent.GetComponent<RectTransform>();
        width = RectTransform.rect.width;
        containerWidth = ContainerRT.rect.width;
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
            RectTransform.sizeDelta = new Vector2(width, transform.childCount * 150);
            ContainerRT.sizeDelta = new Vector2(containerWidth, ContainerRT.rect.height + (transform.childCount - 1) * 150);
        }
        else
        {
            RectTransform.sizeDelta = new Vector2(width, 150);
            ContainerRT.sizeDelta = new Vector2(containerWidth, ContainerRT.rect.height - (transform.childCount - 1) * 150);
        }
    }
}
