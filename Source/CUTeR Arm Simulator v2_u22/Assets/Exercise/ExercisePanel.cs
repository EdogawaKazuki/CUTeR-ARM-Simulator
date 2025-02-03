using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercisePanel : MonoBehaviour
{
    public Transform _currentSelectedPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Select(string path)
    {
        Transform select = transform.Find(path);
         Debug.Log(path);
         Debug.Log(select);
        if (select != null)
        {
            if(_currentSelectedPanel)
                _currentSelectedPanel.gameObject.SetActive(false);
            _currentSelectedPanel = select;
            select.gameObject.SetActive(true);
        }
    }
}
