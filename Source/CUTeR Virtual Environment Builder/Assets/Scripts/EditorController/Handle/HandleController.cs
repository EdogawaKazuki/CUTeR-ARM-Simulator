using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleController : MonoBehaviour
{
    [SerializeField]
    private EditorController _editorController;
    [SerializeField]
    private Transform _handleUI;

    [SerializeField]
    private Transform _positionHandle;
    [SerializeField]
    private Transform _rotateHandle;
    [SerializeField]
    private Transform _scaleHandle;
    [SerializeField]
    private Transform _rotateHidingPlane;

    private HandleType _currentHandleType;

    public enum HandleType
    {
        view,
        position,
        rotation,
        scale
    }
    // Start is called before the first frame update
    void Start()
    {
        SetHandle(HandleType.position);
    }

    private void OnEnable()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_editorController.GetSelectedObj());
        if (_editorController.GetSelectedObj())
            transform.position = Camera.main.transform.position - Vector3.Normalize(Camera.main.transform.position - _editorController.GetSelectedObj().localPosition) * 50; 
        if(_currentHandleType == HandleType.rotation)
        {
            _rotateHidingPlane.eulerAngles = new Vector3(Camera.main.transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, Camera.main.transform.eulerAngles.z);
        }
    }
    public void ShowHandle()
    {
        gameObject.SetActive(true);
    }
    public void HideHandle()
    {
        gameObject.SetActive(false);
    }
    public void SetHandle(HandleType handleType)
    {
        for (int i = 0; i < _handleUI.childCount; i++)
        {
            _handleUI.GetChild(i).Find("Background/Checkmark").gameObject.SetActive(false);
        }
        _handleUI.GetChild((int)handleType).Find("Background/Checkmark").gameObject.SetActive(true);

        _positionHandle.gameObject.SetActive(false);
        _rotateHandle.gameObject.SetActive(false);
        _scaleHandle.gameObject.SetActive(false);
        switch (handleType)
        {
            case HandleType.position:
                _positionHandle.gameObject.SetActive(true);
                break;
            case HandleType.rotation:
                _rotateHandle.gameObject.SetActive(true);
                break;
            case HandleType.scale:
                _scaleHandle.gameObject.SetActive(true);
                break;
            default:
                break;
        }
        _currentHandleType = handleType;
    }
    public bool CheckCurrentHandleType(HandleType handleType)
    {
        return handleType == _currentHandleType;
    }

}
