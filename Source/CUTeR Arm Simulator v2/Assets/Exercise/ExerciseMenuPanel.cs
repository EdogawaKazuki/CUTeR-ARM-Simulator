using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Video;

public class ExerciseMenuPanel : MonoBehaviour
{
    [SerializeField]
    private ExercisePanel _exercisePanel;
    private Color[] colors = new Color[] { new Color(0f, 0.2f, 0.8333334f), new Color(0f, 0.5882353f, 0.5333334f), new Color(0.5450981f, 0.764706f, 0.2901961f), new Color(1f, 0.7568628f, 0f), new Color(0.9568628f, 0.2588235f, 0.2078432f) };
    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("Enable");
        Transform exercisePanel = transform.Find("../ExercisePanel");
        Transform container = transform.Find("Scroll View/Viewport/Content");
        Transform groupTemplate = container.Find("Group");
        Transform itemTemplate = container.Find("Group/Item");
        if(groupTemplate == null) return;
        for (int i = 0; i < exercisePanel.childCount; i++)
        {
            if(!exercisePanel.GetChild(i).gameObject.activeSelf) continue;
            string GroupName = exercisePanel.GetChild(i).name;
            Transform newGroup = Instantiate(groupTemplate).transform;
            newGroup.name = GroupName;
            newGroup.GetChild(0).GetComponent<Image>().color = colors[i];
            newGroup.SetParent(container);
            newGroup.localPosition = new Vector3(0, -125 * i, 0);
            newGroup.transform.localScale = Vector3.one;
            newGroup.transform.localRotation = Quaternion.identity;
            newGroup.Find("Title/Text").GetComponent<TMP_Text>().text = GroupName;
            for(int j = 0; j < exercisePanel.GetChild(i).childCount; j++)
            {
                // if(!exercisePanel.GetChild(i).GetChild(j).gameObject.activeSelf) continue;
                string ItemName = exercisePanel.GetChild(i).GetChild(j).name;
                Transform newItem = Instantiate(itemTemplate);
                newItem.name = ItemName;
                newItem.SetParent(newGroup);
                newItem.localPosition = new Vector3(0, -125 * j, 0);
                newItem.transform.localScale = Vector3.one;
                newItem.transform.localRotation = Quaternion.identity;
                newItem.Find("Text").GetComponent<TMP_Text>().text = ItemName;
                Debug.Log(GroupName + "/" + ItemName);
                newItem.GetComponent<Button>().onClick.AddListener(() => {
                    _exercisePanel.Select(GroupName + "/" + ItemName); 
                    exercisePanel.gameObject.SetActive(true); 
                    gameObject.SetActive(false);
                });
            }
            newGroup.GetComponent<RectTransform>().sizeDelta = new Vector2(newGroup.GetComponent<RectTransform>().rect.width, 125 * (newGroup.childCount - 1) - 5);
            newGroup.GetComponent<ExpandMenu>().SetupExpand();
            Destroy(newGroup.Find("Item").gameObject);
        }
        Destroy(container.Find("Group").gameObject);
        // transform.Find("../Menu").GetComponent<Toggle>().onValueChanged.AddListener((value) => {
        //     gameObject.SetActive(value); 
        //     exercisePanel.gameObject.SetActive(false);
        // });
        transform.Find("Top Bar/Button").GetComponent<Button>().onClick.AddListener(() => {
            if(exercisePanel.GetComponent<ExercisePanel>()._currentSelectedPanel == null)
                transform.Find("../Menu").GetComponent<Toggle>().isOn = false;
        });
        // gameObject.SetActive(false);
        transform.Find("Scroll View").GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
