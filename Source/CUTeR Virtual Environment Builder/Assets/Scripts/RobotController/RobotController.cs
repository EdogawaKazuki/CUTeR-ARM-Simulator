using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotController : MonoBehaviour
{
    static public Transform currentRobotArm;
    
    static public Transform[] Joints = new Transform[7];
    string[] EndEffectorNames = { "Nothing", "Hand", "Pen", "Launcher" };
    static public Transform[] EndEffectors;
    static public List<List<float>> Trajs;
    static public float[] JointAngle = { 0, 180, -170, 0, 0, 0 };
    static public int currentTrajIndex = 0;
    static public int trajLength = 0;
    static public bool runTraj = false;
    static public Grabber Grabber;
    static public Launcher Launcher;
    
    GameObject RobotArm;
    GameObject RobotArm6DoF;
    GameObject Joystick;
    GameObject Joystick6DoF;

    Button FunctionBtn;

    static public Slider[] Sliders = new Slider[7];

    Text[] SliderValueTexts = new Text[6];

    Vector3[] JointLocalEularAngles = new Vector3[6];
    // Start is called before the first frame update
    void Start()
    {
        RobotArm = GameObject.Find("RobotArm");
        RobotArm6DoF = GameObject.Find("RobotArm6DoF");
        Joystick = GameObject.Find("Canvas/Joystick");
        Joystick6DoF = GameObject.Find("Canvas/Joystick6DoF");
        usingRobot(0);
        usingRobot(1);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void usingRobot(int value)
    {
        if(value == 0)
        {
            RobotArm.SetActive(true);
            RobotArm6DoF.SetActive(false);
            Joystick.SetActive(true);
            Joystick6DoF.SetActive(false);
            Trajs = new List<List<float>>();
            for (int i = 0; i < 3; i++)
            {
                Trajs.Add(new List<float>());
            }
            currentTrajIndex = 0;
            currentRobotArm = GameObject.Find("RobotArm").transform;
            Joints[0] = currentRobotArm.Find("Joint0");
            for (int i = 0; i < 3; i++)
            {
                Joints[i + 1] = Joints[i].Find("Joint" + (i + 1));
                Sliders[i] = GameObject.Find("Canvas/Joystick/Panel/Joint" + i).GetComponent<Slider>();
                SliderValueTexts[i] = Sliders[i].transform.Find("Handle Slide Area/Handle/Value").GetComponent<Text>();
                JointLocalEularAngles[i] = new Vector3(0, 0, 0);
            }
            Sliders[3] = GameObject.Find("Canvas/Joystick/Panel/Force").GetComponent<Slider>();
            FunctionBtn = GameObject.Find("Canvas/Joystick/Panel/Function").GetComponent<Button>();
            FunctionBtn.interactable = false;
            EndEffectors = new Transform[EndEffectorNames.Length];
            for (int i = 0; i < EndEffectorNames.Length; i++)
            {
                EndEffectors[i] = Joints[3].Find(EndEffectorNames[i]);
            }
            JointLocalEularAngles[1] = new Vector3(0, 90, 0);
            Grabber = Joints[3].Find("Hand/HoldingPoint").GetComponent<Grabber>();
            Launcher = Joints[3].Find("Launcher/Sphere").GetComponent<Launcher>();
        }
        else
        {
            RobotArm.SetActive(false);
            RobotArm6DoF.SetActive(true);
            Joystick.SetActive(false);
            Joystick6DoF.SetActive(true);
            Trajs = new List<List<float>>();
            for (int i = 0; i < 6; i++)
            {
                Trajs.Add(new List<float>());
            }
            currentTrajIndex = 0;
            currentRobotArm = GameObject.Find("RobotArm6DoF").transform;
            Joints[0] = currentRobotArm.Find("Joint0");
            for (int i = 0; i < 6; i++)
            {
                Joints[i + 1] = Joints[i].Find("Joint" + (i + 1));
                Sliders[i] = GameObject.Find("Canvas/Joystick6DoF/Panel/Joint" + i).GetComponent<Slider>();
                SliderValueTexts[i] = Sliders[i].transform.Find("Handle Slide Area/Handle/Value").GetComponent<Text>();
                JointLocalEularAngles[i] = new Vector3(0, 0, 0);
            }
            Sliders[6] = GameObject.Find("Canvas/Joystick6DoF/Panel/Force").GetComponent<Slider>();
            FunctionBtn = GameObject.Find("Canvas/Joystick6DoF/Panel/Function").GetComponent<Button>();
            FunctionBtn.interactable = false;
            EndEffectors = new Transform[EndEffectorNames.Length];
            for (int i = 0; i < EndEffectorNames.Length; i++)
            {
                EndEffectors[i] = Joints[5].Find(EndEffectorNames[i]);
            }
            JointLocalEularAngles[1] = new Vector3(0, 90, 0);
            Grabber = Joints[5].Find("Hand/HoldingPoint").GetComponent<Grabber>();
            Launcher = Joints[5].Find("Launcher/Sphere").GetComponent<Launcher>();
        }
    }
    public void FixedUpdate()
    {
        MoveRobot();
        UpdateUI();
        if (runTraj)
        {
            if (currentTrajIndex < trajLength)
            {
                if (Trajs[0][currentTrajIndex] == 1000)
                {
                    Grabber.Toggle();
                    Launcher.Fire();
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        {
                            JointAngle[i] = Trajs[i][currentTrajIndex];
                        }
                    }
                }
                currentTrajIndex++;
            }
            else
            {
                ObjectManager.TrajectoryStatus.text = "Finised";
                ObjectManager.TrajectoryBG.color = new Color32(255, 255, 255, 78);
                runTraj = false;
                currentTrajIndex = 0;
            }
        }
    }
    public void setAngle0(float value)
    {
        JointAngle[0] = value;
    }
    public void setAngle1(float value)
    {
        JointAngle[1] = value;
    }
    public void setAngle2(float value)
    {
        JointAngle[2] = value;
    }
    public void setEndEffector(int value)
    {
        for (int i = 0; i < EndEffectors.Length; i++)
        {
            EndEffectors[i].gameObject.SetActive(false);
        }
        Sliders[3].interactable = value == 3;
        EndEffectors[value].gameObject.SetActive(true);
        if (value == 1)
        {
            Grabber.isActive = true;
            Launcher.isActive = false;
            FunctionBtn.interactable = true;
        }
        else if (value == 3)
        {
            Grabber.isActive = false;
            Launcher.isActive = true;
            FunctionBtn.interactable = true;
        }
        else
        {

            FunctionBtn.interactable = false;
        }
    }
    void MoveRobot()
    {
        JointLocalEularAngles[0].y = JointAngle[0];
        JointLocalEularAngles[1].x = JointAngle[1];
        JointLocalEularAngles[2].x = JointAngle[2];
        for (int i = 0; i < 3; i++)
        {
            Joints[i].localEulerAngles = JointLocalEularAngles[i];
        }
    }
    void UpdateUI()
    {
        for (int i = 0; i < 3; i++)
        {
            Sliders[i].value = JointAngle[i];
            SliderValueTexts[i].text = Sliders[i].value.ToString("F0");
        }
    }

    public void StartTraj()
    {
        if (!RobotClient.isRecvingMode)
        {
            if (!runTraj && (Trajs[0].Count!= 0))
            {
                runTraj = true;
                ObjectManager.TrajectoryStatus.text = "Playing";
                ObjectManager.TrajectoryBG.color = new Color32(100, 255, 100, 160);
            }
            else
            {
                runTraj = false;
            }
        }
    }
    public void StopTraj()
    {
        if (!RobotClient.isRecvingMode && (Trajs[0].Count != 0))
        {
            ObjectManager.TrajectoryStatus.text = "Ready to play";
            ObjectManager.TrajectoryBG.color = new Color32(255, 255, 255, 78);
            runTraj = false;
            currentTrajIndex = 0;
            JointAngle[0] = 0;
            JointAngle[1] = 180;
            JointAngle[2] = -170;
        }
    }

}
