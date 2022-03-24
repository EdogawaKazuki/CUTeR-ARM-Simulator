using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotController : MonoBehaviour
{
    static public Transform RobotArm;
    static public Transform[] Joints = new Transform[4];
    static public List<List<float>> Trajs;
    static public float[] JointAngle = { 0, 140, -140 };
    static public int currentTrajIndex = 0;
    static public int trajLength = 0;
    static public bool runTraj = false;

    static public float A1 = 10;  //length properties of the teaching robot arm (in cm)
    static public float A2 = 2.8f; //length properties of the teaching robot arm (in cm)
    static public float L1 = 19.2f; //length properties of the teaching robot arm (in cm)
    static public float L2 = 21;  //length properties of the teaching robot arm (in cm)//20.8 + 0.5 for plastic cap

    static public Slider[] Sliders = new Slider[3];
    bool isLoop = false;
    Image TrajectoryBG;

    Text[] SliderValueTexts = new Text[3];

    Vector3[] JointLocalEularAngles = new Vector3[3];
    // Start is called before the first frame update
    void Start()
    {
        TrajectoryBG = GameObject.Find("Canvas/WSBtnGroup/RunTrajectory/Image").GetComponent<Image>();
        Trajs = new List<List<float>>();
        for (int i = 0; i < 3; i++)
        {
            Trajs.Add(new List<float>());
        }
        currentTrajIndex = 0;
        RobotArm = GameObject.Find("RobotArm").transform;
        Joints[0] = RobotArm.Find("Joint0");
        for (int i = 0; i < 3; i++)
        {
            Joints[i + 1] = Joints[i].Find("Joint" + (i + 1));
            Sliders[i] = GameObject.Find("Canvas/Joystick/Panel/Joint" + i).GetComponent<Slider>();
            SliderValueTexts[i] = Sliders[i].transform.Find("Handle Slide Area/Handle/Value").GetComponent<Text>();
            JointLocalEularAngles[i] = new Vector3(0, 0, 0);
        }
        JointLocalEularAngles[1] = new Vector3(0, 90, 0);
        //GameObject.Find("Canvas/Joystick").GetComponent<Renderer>().enabled = false; ;
        //GameObject.Find("Canvas/Joystick").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void FixedUpdate()
    {
        MoveRobot();
        UpdateUI();
        if (runTraj)
        {
            if (currentTrajIndex < trajLength)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Trajs[i][currentTrajIndex] == 1000)
                        continue;
                    JointAngle[i] = Trajs[i][currentTrajIndex];
                }
                currentTrajIndex++;
            }
            else
            {
                runTraj = isLoop;
                currentTrajIndex = 0;
                if (!runTraj)
                {
                    TrajectoryBG.color = new Color32(255, 255, 255, 78);
                }
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
    void MoveRobot()
    {
        JointLocalEularAngles[0].y = JointAngle[0];
        JointLocalEularAngles[1].x = JointAngle[1];
        JointLocalEularAngles[2].x = JointAngle[2];
        for(int i = 0; i < 3; i++)
        {
            Joints[i].localEulerAngles = JointLocalEularAngles[i];
        }
    }
    void UpdateUI()
    {
        for (int i = 0; i < 3; i++)
        {
            Sliders[i].value = JointAngle[i];
            SliderValueTexts[i].text = Sliders[i].value.ToString("F2");
        }
    }

    public void StartTraj()
    {
        Debug.Log(Trajs[0].Count);
        if (!RobotClient.isConnectedToRobot || !RobotClient.isRecvingMode)
        {
            if (!runTraj)
            {
                if (trajLength != 0)
                {
                    runTraj = true;
                    TrajectoryBG.color = new Color32(100, 255, 100, 160);
                }
            }
            else
            {
                runTraj = false;
                TrajectoryBG.color = new Color32(255, 255, 100, 160);
            }
        }
    }
    public void LoopTraj()
    {
        if (trajLength != 0)
        {
            runTraj = true;
            TrajectoryBG.color = new Color32(100, 255, 100, 160);
            isLoop = true;
        }
    }
    public void StopTraj()
    {
        if (!RobotClient.isConnectedToRobot || !RobotClient.isRecvingMode)
        {
            runTraj = false;
            isLoop = false;
            currentTrajIndex = 0;
            JointAngle[0] = 0;
            JointAngle[1] = 180;
            JointAngle[2] = -170;
            TrajectoryBG.color = new Color32(255, 255, 255, 78);
        }
    }
}
