using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GeneralInteractiveControl : MonoBehaviour
{
    private GeneralRobotControl _robotControl;
    public DHTableUI _DHTableUI;
    public InteractiveRobotArmUI _interactiveRobotArmUI;
    public Interactive2RPlanarRobotArm _interactive2RPlanarRobotArm;
    public Jacobian _jacobianVisualizer;
    private List<DHRowData> dhParameters = new();

    public GameObject _mc_layout;
    private int _selectedAnswer = -1;  // Add this field to store the answer
    private bool _waitingForAnswer = false;
    private GameObject _imageDisplayer;
    public AudioClip CorrectAnswerClip;
    public AudioClip WrongAnswerClip;
    public int branch_index = -1;

    // Start is called before the first frame update
    void Start()
    {
        // _mc_layout = GameObject.Find("SelfLearningCanvas/MCLayout");
        _mc_layout.SetActive(false);
        _robotControl = GetComponent<GeneralRobotControl>();
        _imageDisplayer = _mc_layout.transform.Find("ImageDisplayer").gameObject;
        SetImageStatus(false);
        _DHTableUI = transform.Find("../Visualizer/DH Table").GetComponent<DHTableUI>();
        _interactiveRobotArmUI = transform.Find("../Visualizer/Hand Guidance UI").GetComponent<InteractiveRobotArmUI>();
        _interactive2RPlanarRobotArm = transform.Find("../Visualizer/Hand Guidance UI").GetComponent<Interactive2RPlanarRobotArm>();
        _jacobianVisualizer = transform.Find("Self Learning Modules/8. Jacobian").GetComponent<Jacobian>();
    }

    public void CloseAllUIs()
    {
        _interactiveRobotArmUI.gameObject.SetActive(false);
        _interactive2RPlanarRobotArm.gameObject.SetActive(false);
        _DHTableUI.gameObject.SetActive(false);
        DisableMC();
    }

    public void SetDHTableStatus(bool status)
    {
        _DHTableUI.gameObject.SetActive(status);
    }
    public void AssignDefaultDHTable()
    {
        var angleList = _robotControl._robotController.GetCmdJointAngles();
        // If DH parameters already exist, reconstruct expected thetas and compare.
        // If nothing changed, return early to avoid rebuilding the table every frame.
        if (dhParameters.Count >= 7)
        {
            float delta = Mathf.Rad2Deg * Mathf.Atan2(3, 26.4f);
            float[] expected = new float[7];
            expected[0] = 90f;
            expected[1] = angleList[0];
            expected[2] = angleList[1] + 90 - delta;
            expected[3] = -angleList[2] + 45 + delta;
            expected[4] = angleList[3];
            expected[5] = angleList[4];
            expected[6] = angleList[5];

            bool identical = true;
            for (int i = 0; i < 7; i++)
            {
                // assume DHRowData exposes the theta field/property named "theta"
                if (!Mathf.Approximately(dhParameters[i].Theta, expected[i]))
                {
                    identical = false;
                    break;
                }
            }

            if (identical) return;
        }
        dhParameters.Clear();
        dhParameters.Add(new DHRowData("Link 0", 90, 15.9f, 0, 0));
        dhParameters.Add(new DHRowData("Link 1", angleList[0], 0f, 0, 90));
        dhParameters.Add(new DHRowData("Link 2", angleList[1] + 90 -Mathf.Rad2Deg * Mathf.Atan2(3, 26.4f), 0f, Mathf.Sqrt(26.4f * 26.4f + 3 * 3), 0));
        dhParameters.Add(new DHRowData("Link 3", -angleList[2]+ 45 + Mathf.Rad2Deg * Mathf.Atan2(3, 26.4f), 0f, 3, 90));
        dhParameters.Add(new DHRowData("Link 4", angleList[3], 25.8f, 0, -90));
        dhParameters.Add(new DHRowData("Link 5", angleList[4], 0f, 0, 90));
        dhParameters.Add(new DHRowData("Link 6", angleList[5], 12.3f, 0, 0));
        _DHTableUI.SetDHParameters(dhParameters);

    }
    
    public void SetMCQuestion(string question)
    {
        _mc_layout.transform.Find("Question").GetComponent<TMPro.TextMeshProUGUI>().text = question;
    }

    public void SetMCOptionText(int option, string text)
    {
        string option_path = FindOptionPath(option);
        _mc_layout.transform.Find(option_path).transform.Find("Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text = text;
    }

    private string FindOptionPath(int option)
    {
        return "ButtonGroup/" + (option < 2 ? "Group1/Button" : "Group2/Button") + option.ToString();
    }

    public IEnumerator SetMC(List<string> texts)
    {
        // First text will be the question while the others would be the options
        if (texts.Count > 0)
        {
            SetMCQuestion(texts[0]);
            for (int i = 1; i < Mathf.Min(texts.Count, 5); i++)
            {
                string optionLetter = ((char)('A' + i - 1)).ToString();
                SetMCOptionText(i - 1, optionLetter + ": " + texts[i]);

                // Add button listener
                AddButtonListener(i - 1);

                // Set the buttons to interactable to reset them
                string buttonPath = FindOptionPath(i - 1);
                Button button = _mc_layout.transform.Find(buttonPath).GetComponent<Button>();
                button.interactable = true;
            }
        }
        _waitingForAnswer = false;
        _mc_layout.SetActive(true);
        _mc_layout.transform.Find("ButtonGroup/Group2").gameObject.SetActive(texts.Count > 3);
        return null;
    }

    private void AddButtonListener(int index)
    {
        string buttonPath = FindOptionPath(index);
        Button button = _mc_layout.transform.Find(buttonPath).GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => OnMCOptionSelected(index));
    }

    public IEnumerator DisableMC()
    {
        _mc_layout.SetActive(false);
        Debug.Log("Disabling MC layout");
        return null;
    }

    public void OnMCOptionSelected(int optionIndex)
    {
        if (!_waitingForAnswer)
        {
            GameObject myEventSystem = GameObject.Find("EventSystem");
            myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
            return;
        }
        _selectedAnswer = optionIndex;
        _waitingForAnswer = false;
        // Convert numeric option to letter (0=A, 1=B, etc)
        string selectedLetter = ((char)('A' + _selectedAnswer)).ToString();
        Debug.Log("Selected option: " + selectedLetter);
    }

    // Coroutine to wait for answer
    public IEnumerator WaitForMCAnswer()
    {
        _selectedAnswer = -1;
        _waitingForAnswer = true;
        if (_waitingForAnswer) {
            yield return new WaitUntil(() => !_waitingForAnswer);
        }
        Debug.Log("Waiting for MC answer finished");
    }

    // Helper method to get the selected answer
    public int GetSelectedAnswer()
    {
        return _selectedAnswer;
    }

    // New function to set MC with answer 
    public IEnumerator SetMCWithAnswer(List<string> texts, int correctOption)
    {   
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();;
        yield return SetMC(texts);
        yield return WaitForMCAnswer();
        while (_selectedAnswer != correctOption)
        {
            string buttonPath = FindOptionPath(_selectedAnswer);
            Debug.Log("Button path: " + buttonPath);
            Button button = _mc_layout.transform.Find(buttonPath).GetComponent<Button>();
            button.interactable = false;
            Debug.Log("Incorrect answer. Please try again.");
            audioSource.PlayOneShot(WrongAnswerClip, 1.0f);
            yield return new WaitForSeconds(WrongAnswerClip.length);
            yield return WaitForMCAnswer();
        }
        Debug.Log("Correct answer selected!");
        audioSource.PlayOneShot(CorrectAnswerClip, 1.0f);
        yield return new WaitForSeconds(CorrectAnswerClip.length);
        GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
        yield return DisableMC();
        _robotControl._currentState = GeneralRobotControl.State.finished;
    }

    public IEnumerator SetImage(Sprite image, Vector2 size)
    {
        _imageDisplayer.GetComponent<Image>().sprite = image;
        float aspectRatio = size.x / size.y;
        float widthLimit = 800;
        float heightLimit = 300;
        float widthScale = widthLimit / size.x;
        float heightScale = heightLimit / size.y;
        float scale = Mathf.Min(widthScale, heightScale);
        Vector2 newSize = new Vector2(size.x * scale, size.y * scale);
        _imageDisplayer.GetComponent<RectTransform>().sizeDelta = newSize;
        return null;
    }

    public IEnumerator SetImageStatus(bool active)
    {
        _imageDisplayer.SetActive(active);
        return null;
    }

    public IEnumerator SetCompleteMC(List<string> texts, int correctOption, Sprite image = null, Vector2 imageSize = new Vector2())
    {
        if (image != null)
        {
            yield return SetImage(image, imageSize);
            yield return SetImageStatus(true);
        }
        else
        {
            yield return SetImageStatus(false);
        }
        yield return SetMCWithAnswer(texts, correctOption);
    }
    // Update is called once per frame
    void Update()
    {
        if (_DHTableUI.isActiveAndEnabled)
            AssignDefaultDHTable();

    }
}
