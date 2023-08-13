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
    // Start is called before the first frame update
    void OnEnable()
    {
        Transform exercisePanel = transform.Find("../ExercisePanel");
        Transform container = transform.Find("Scroll View/Viewport/Content");
        Transform groupTemplate = container.Find("Group");
        Transform itemTemplate = container.Find("Group/Item");
        for (int i = 0; i < exercisePanel.childCount; i++)
        {
            string GroupName = exercisePanel.GetChild(i).name;
            Transform newGroup = Instantiate(groupTemplate).transform;
            newGroup.name = GroupName;
            newGroup.SetParent(container);
            newGroup.transform.localScale = Vector3.one;
            newGroup.GetComponent<RectTransform>().sizeDelta = new Vector2(newGroup.GetComponent<RectTransform>().rect.width, 125 * exercisePanel.GetChild(i).childCount + 120);
            newGroup.Find("Title/Text").GetComponent<TMP_Text>().text = GroupName;
            newGroup.GetComponent<ExpandMenu>().SetupExpand();
            for(int j = 0; j < exercisePanel.GetChild(i).childCount; j++)
            {
                string ItemName = exercisePanel.GetChild(i).GetChild(j).name;
                Transform newItem = Instantiate(itemTemplate);
                newItem.name = ItemName;
                newItem.SetParent(newGroup);
                newItem.transform.localScale = Vector3.one;
                newItem.Find("Text").GetComponent<TMP_Text>().text = ItemName;
                newItem.GetComponent<Button>().onClick.AddListener(() => {
                    _exercisePanel.Select(GroupName + "/" + ItemName); 
                    exercisePanel.gameObject.SetActive(true); 
                    gameObject.SetActive(false);
                });
            }
            Destroy(newGroup.Find("Item").gameObject);
        }
        Destroy(container.Find("Group").gameObject);
        transform.Find("../Menu").GetComponent<Toggle>().onValueChanged.AddListener((value) => {
            gameObject.SetActive(value); 
            exercisePanel.gameObject.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
