using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneObjectAttrPanelController : MonoBehaviour
{
    [SerializeField]
    private SceneObjDeletePanel _sceneObjDeletePanel;
    private Transform _selectedObj;
    private Button _deleteButton;
    private InputField _nameInputField;
    private InputField _posXInputField;
    private InputField _posYInputField;
    private InputField _posZInputField;
    private InputField _rotXInputField;
    private InputField _rotYInputField;
    private InputField _rotZInputField;
    private InputField _scaleXInputField;
    private InputField _scaleYInputField;
    private InputField _scaleZInputField;
    private Toggle _useTrajToggle;
    private Button _uploadTrajButton;
    private Text _uploadTrajResultText;
    private Toggle _isRigidbodyToggle;
    private Toggle _fixPosXToggle;
    private Toggle _fixPosYToggle;
    private Toggle _fixPosZToggle;
    private Toggle _useGravityToggle;
    // Start is called before the first frame update
    void Start()
    {
        _deleteButton = transform.Find("Name/Options/Delete").GetComponent<Button>();
        _deleteButton.onClick.AddListener(OnDeleteButtonClicked);

        _nameInputField = transform.Find("Name/Options/InputField").GetComponent<InputField>();
        _nameInputField.onValueChanged.AddListener(OnObjNameValueChanged);

        _posXInputField = transform.Find("Position/Options/X/InputField").GetComponent<InputField>();
        _posXInputField.onValueChanged.AddListener(OnObjPosXChanged);

        _posYInputField = transform.Find("Position/Options/Y/InputField").GetComponent<InputField>();
        _posYInputField.onValueChanged.AddListener(OnObjPosYChanged);

        _posZInputField = transform.Find("Position/Options/Z/InputField").GetComponent<InputField>();
        _posZInputField.onValueChanged.AddListener(OnObjPosZChanged);

        _rotXInputField = transform.Find("Rotation/Options/X/InputField").GetComponent<InputField>();
        _rotXInputField.onValueChanged.AddListener(OnObjRotationXChanged);

        _rotYInputField = transform.Find("Rotation/Options/Y/InputField").GetComponent<InputField>();
        _rotYInputField.onValueChanged.AddListener(OnObjRotationYChanged);

        _rotZInputField = transform.Find("Rotation/Options/Z/InputField").GetComponent<InputField>();
        _rotZInputField.onValueChanged.AddListener(OnObjRotationZChanged);

        _scaleXInputField = transform.Find("Scale/Options/X/InputField").GetComponent<InputField>();
        _scaleXInputField.onValueChanged.AddListener(OnObjScaleXChanged);

        _scaleYInputField = transform.Find("Scale/Options/Y/InputField").GetComponent<InputField>();
        _scaleYInputField.onValueChanged.AddListener(OnObjScaleYChanged);

        _scaleZInputField = transform.Find("Scale/Options/Z/InputField").GetComponent<InputField>();
        _scaleZInputField.onValueChanged.AddListener(OnObjScaleZChanged);

        _useTrajToggle = transform.Find("Trajectory/Options/UseTrajectory").GetComponent<Toggle>();
        _useTrajToggle.onValueChanged.AddListener(OnUseTrajChanged);

        _uploadTrajButton = transform.Find("Trajectory/Options/Upload").GetComponent<Button>();
        _uploadTrajResultText = transform.Find("Trajectory/Options/ResultText").GetComponent<Text>();

        _isRigidbodyToggle = transform.Find("IsRigidbody/Options/Toggle").GetComponent<Toggle>();
        _isRigidbodyToggle.onValueChanged.AddListener(OnObjIsRigidbodyChanged);

        _fixPosXToggle = transform.Find("FixPosition/Options/X/Toggle").GetComponent<Toggle>();
        _fixPosXToggle.onValueChanged.AddListener(OnObjFixPosXChanged);

        _fixPosYToggle = transform.Find("FixPosition/Options/Y/Toggle").GetComponent<Toggle>();
        _fixPosYToggle.onValueChanged.AddListener(OnObjFixPosYChanged);

        _fixPosZToggle = transform.Find("FixPosition/Options/Z/Toggle").GetComponent<Toggle>();
        _fixPosZToggle.onValueChanged.AddListener(OnObjFixPosZChanged);

        _useGravityToggle = transform.Find("UseGravity/Options/Toggle").GetComponent<Toggle>();
        _useGravityToggle.onValueChanged.AddListener(OnObjUseGravityChanged);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_selectedObj != null)
            UpdateInfo(_selectedObj);
    }
    public void SelectObject(Transform selectedObj)
    {
        _selectedObj = selectedObj;
        if(selectedObj == null)
        {
            gameObject.SetActive(false);
        }
        else
        {
            UpdateInfo(selectedObj);
            //_selectedObj = _selectedObj.GetComponent<SceneObjectPart>().GetParent();
            gameObject.SetActive(true);
        }
    }
    private void UpdateInfo(Transform selectedObj)
    {
        // Debug.Log("Before:" + selectedObj.transform.position);
        _nameInputField.text = selectedObj.name;
        _posXInputField.text = (-selectedObj.transform.position.x).ToString("F3");
        _posZInputField.text = selectedObj.transform.position.y.ToString("F3");
        _posYInputField.text = (-selectedObj.transform.position.z).ToString("F3");
        // Debug.Log("After1:" + selectedObj.transform.position);
        _rotXInputField.text = (-selectedObj.transform.eulerAngles.x).ToString("F3");
        _rotZInputField.text = selectedObj.transform.eulerAngles.y.ToString("F3");
        _rotYInputField.text = (-selectedObj.transform.eulerAngles.z).ToString("F3");
        // Debug.Log("After2:" + selectedObj.transform.position);
        _scaleXInputField.text = (-selectedObj.transform.localScale.x).ToString("F3");
        _scaleZInputField.text = selectedObj.transform.localScale.y.ToString("F3");
        _scaleYInputField.text = (-selectedObj.transform.localScale.z).ToString("F3");
        // Debug.Log("After3:" + selectedObj.transform.position);
        _useTrajToggle.isOn = selectedObj.GetComponent<SceneObjectTrajectoryController>().GetIsUseTraj();
        // Debug.Log("After4:" + selectedObj.transform.position);
        selectedObj.GetComponent<SceneObjectTrajectoryController>().AddOnClickListener(_uploadTrajButton, _uploadTrajResultText);
        // Debug.Log("After5:" + selectedObj.transform.position);
        SceneObjectController selectedObjController = selectedObj.GetComponent<SceneObjectController>();
        // Debug.Log("After6:" + selectedObj.transform.position);
        _isRigidbodyToggle.isOn = selectedObjController.isRigidbody;
        _fixPosXToggle.isOn = selectedObjController.fixPositionX;
        _fixPosZToggle.isOn = selectedObjController.fixPositionY;
        _fixPosYToggle.isOn = selectedObjController.fixPositionZ;
        _useGravityToggle.isOn = selectedObjController.useGravity;
        // Debug.Log("After7:" + selectedObj.transform.position);
    }
    public void SetPanel()
    {

    }
    #region OnValueChanged CallBack Mechods
    public void OnDeleteButtonClicked()
    {
        _sceneObjDeletePanel.SetTarget(_selectedObj);
        _sceneObjDeletePanel.gameObject.SetActive(true);
        
    }
    public void OnObjNameValueChanged(string value)
    {
        _selectedObj.name = value;
    }
    public void OnObjPosXChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.position = new Vector3(-float.Parse(value), _selectedObj.transform.position.y, _selectedObj.transform.position.z);
    }
    public void OnObjPosYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.position = new Vector3(_selectedObj.transform.position.x, _selectedObj.transform.position.y, -float.Parse(value));
    }
    public void OnObjPosZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.position = new Vector3(_selectedObj.transform.position.x, float.Parse(value), _selectedObj.transform.position.z);
    }
    public void OnObjRotationXChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.eulerAngles = new Vector3(-float.Parse(value), _selectedObj.transform.eulerAngles.y, _selectedObj.transform.eulerAngles.z);
    }
    public void OnObjRotationYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.eulerAngles = new Vector3(_selectedObj.transform.eulerAngles.x, _selectedObj.transform.eulerAngles.y, -float.Parse(value));
    }
    public void OnObjRotationZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.eulerAngles = new Vector3(_selectedObj.transform.eulerAngles.x, float.Parse(value), _selectedObj.transform.eulerAngles.z);
    }
    public void OnObjScaleXChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.localScale = new Vector3(-float.Parse(value), _selectedObj.transform.localScale.y, _selectedObj.transform.localScale.z);
    }
    public void OnObjScaleYChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.localScale = new Vector3(_selectedObj.transform.localScale.x, _selectedObj.transform.localScale.y, -float.Parse(value));
    }
    public void OnObjScaleZChanged(string value)
    {
        if (float.TryParse(value, out float n))
            _selectedObj.transform.localScale = new Vector3(_selectedObj.transform.localScale.x, float.Parse(value), _selectedObj.transform.localScale.z);
    }
    public void OnObjFixPosXChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().fixPositionX = value;
    }
    public void OnObjFixPosYChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().fixPositionZ = value;
    }
    public void OnObjFixPosZChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().fixPositionY = value;
    }
    public void OnObjFixRotationXChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().fixRotationX = value;
    }
    public void OnObjFixRotationYChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().fixRotationZ = value;
    }
    public void OnObjFixRotationZChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().fixRotationY = value;
    }
    public void OnObjIsRigidbodyChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().isRigidbody = value;
    }
    public void OnObjUseGravityChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectController>().useGravity = value;
    }
    public void OnUseTrajChanged(bool value)
    {
        _selectedObj.GetComponent<SceneObjectTrajectoryController>().SetIsUseTraj(value);
    }
    #endregion
}
