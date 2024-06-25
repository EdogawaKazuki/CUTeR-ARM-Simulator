using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ARButtonHandler : MonoBehaviour
{
    public TextMeshProUGUI displayText;  // 用于显示文本的TextMesh Pro对象

    public void OnButtonClick()
    {
        displayText.text = "hello";
    }
}