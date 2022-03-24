using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPanel : MonoBehaviour
{
    static GameObject currentPanel=null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Select()
    {
        if(currentPanel != null)
            currentPanel.SetActive(false);
        GameObject self = GameObject.Find("Canvas/ExercisePanel/" + transform.parent.name + "/" + name);
        self.SetActive(true);
        currentPanel = self;
    }
}
