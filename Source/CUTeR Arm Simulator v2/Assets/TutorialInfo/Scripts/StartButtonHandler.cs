using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonHandler : MonoBehaviour
{
    public GameObject lesson4content;
    public GameObject Wheel;
    public GameObject canvas;
  
    public void OnStartButtonClicked()
    {
        lesson4content.SetActive(true);
        canvas.SetActive(false);
    }
}
