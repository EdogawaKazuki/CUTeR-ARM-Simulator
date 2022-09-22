using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class UIEventManager : MonoBehaviour
{
    public void TurnOffToggle()
    {
        gameObject.GetComponent<Toggle>().isOn = false;
    }
    
}
