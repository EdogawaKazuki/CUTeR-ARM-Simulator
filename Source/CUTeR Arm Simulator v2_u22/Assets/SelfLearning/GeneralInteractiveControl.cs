using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GeneralInteractiveControl : MonoBehaviour
{
    private GeneralRobotControl _robotControl;

    public GameObject _mc_layout;
    private int _selectedAnswer = -1;  // Add this field to store the answer
    private bool _waitingForAnswer = false;

    // Start is called before the first frame update
    void Start()
    {
        // _mc_layout = GameObject.Find("SelfLearningCanvas/MCLayout");
        _mc_layout.SetActive(false);
        _robotControl = GetComponent<GeneralRobotControl>();
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
                string buttonPath = FindOptionPath(i-1);
                Button button = _mc_layout.transform.Find(buttonPath).GetComponent<Button>();
                button.interactable = true;
            }
        }
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

        yield return new WaitUntil(() => !_waitingForAnswer);
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
        yield return SetMC(texts);
        yield return WaitForMCAnswer();
        while (_selectedAnswer != correctOption)
        {
            string buttonPath = FindOptionPath(_selectedAnswer);
            Debug.Log("Button path: " + buttonPath);
            Button button = _mc_layout.transform.Find(buttonPath).GetComponent<Button>();
            button.interactable = false;
            Debug.Log("Incorrect answer. Please try again.");

            yield return WaitForMCAnswer();
        }
        Debug.Log("Correct answer selected!");
        yield return DisableMC();
        _robotControl._currentState = GeneralRobotControl.State.finished;
    }



    // Update is called once per frame
    void Update()
    {

    }
}
