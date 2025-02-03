using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpandMenu : MonoBehaviour
{
    [SerializeField]
    bool initStatus;
    float width;
    float height;
    float containerWidth;
    RectTransform RectTransform;
    RectTransform ContainerRT;
    // Start is called before the first frame update
    void OnEnable()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetupExpand(){
        transform.Find("Title").GetComponent<Toggle>().onValueChanged.AddListener((value) => ExpandOption(value));
        RectTransform = GetComponent<RectTransform>();
        ContainerRT = transform.parent.GetComponent<RectTransform>();
        width = RectTransform.sizeDelta.x;
        height = RectTransform.sizeDelta.y;
        containerWidth = ContainerRT.sizeDelta.x;
        Debug.Log(containerWidth);
        ExpandOption(initStatus);
        ContainerRT.sizeDelta = new Vector2(containerWidth, ContainerRT.sizeDelta.y + 1 * height / transform.childCount + 5);
    }
    public void ExpandOption(bool value)
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            // if(transform.name!= "Item")
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
