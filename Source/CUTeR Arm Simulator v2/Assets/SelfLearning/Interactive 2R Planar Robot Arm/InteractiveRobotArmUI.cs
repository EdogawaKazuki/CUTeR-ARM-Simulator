using UnityEngine;

public class InteractiveRobotArmUI : MonoBehaviour
{
    public GeneralVisualControl _generalVisaulControl;
    public int branchIndex;
    private Transform _sphere;
    private Transform _menu;
    

    void Start()
    {
        _menu = transform.Find("Menu");
        _menu.Find("QuitButton").GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() =>
        {
            this.gameObject.SetActive(false);
            transform.Find("/Interactable Objects").GetChild(0).gameObject.SetActive(false);
            branchIndex = -2;
        });
    }
    void OnEnable()
    {
        transform.Find("/Interactable Objects").GetChild(0).gameObject.SetActive(true);
        _generalVisaulControl.SetJointSpaceStatDisplayLatexVisibility(true);
        _generalVisaulControl.SetTaskSpaceStatDisplayLatexVisibility(true);
        branchIndex = -1;
    }

    void OnDisable()
    {
        _generalVisaulControl.SetJointSpaceStatDisplayLatexVisibility(false);
        _generalVisaulControl.SetTaskSpaceStatDisplayLatexVisibility(false);
    }

}