using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneObjDeletePanel : MonoBehaviour
{
    private EditorController _editorController;
    [SerializeField]
    private Button _deleteButton;
    [SerializeField]
    private Button _cancelButton;
    // Start is called before the first frame update
    void Start()
    {
        _editorController = GameObject.Find("EditorAdmin").GetComponent<EditorController>();
        _cancelButton.onClick.AddListener(() => { gameObject.SetActive(false); });
        gameObject.SetActive(false);
    }

    public void SetTarget(Transform target)
    {
        _deleteButton.onClick.RemoveAllListeners();
        _deleteButton.onClick.AddListener(() => { Destroy(target.gameObject); _editorController.GetHandleController().HideHandle(); _editorController.SelectObj(null); });
    }
}
