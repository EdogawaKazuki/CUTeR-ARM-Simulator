using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseMenuPanel : MonoBehaviour
{
    [SerializeField]
    private ExercisePanel _exercisePanel;
    // Start is called before the first frame update
    void Start()
    {
        Transform content = transform.Find("Scroll View/Viewport/Content");
        for (int i = 0; i < content.childCount; i++)
        {
            for(int j = 1; j < content.GetChild(i).childCount; j++)
            {
                string path = content.GetChild(i).name + "/" + content.GetChild(i).GetChild(j).name;
                if(content.GetChild(i).GetChild(j).GetComponent<Button>())
                    content.GetChild(i).GetChild(j).GetComponent<Button>().onClick.AddListener(() => _exercisePanel.Select(path));  
                else
                    Debug.Log(path);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
