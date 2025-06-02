using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using TexDrawLib;
using Unity.VisualScripting;



public class GeneralVisualControl : MonoBehaviour
{
    public LineRenderer PathLine;
    private Transform _robotArm;
    public GameObject _visualizer;
    private DrawGraph _graph_drawer;
    private GameObject _visualizer_image;
    private GameObject _visualizer_latex;
    public RobotController _robotController;
    public GeneralRobotControl _generalRobotControl;
    public GameObject startSpherePrefab;
    public GameObject endSpherePrefab;
    int pathPointCount = 0;
    private Vector3 startPoint; // Store the start point for spheres
    private Vector3 endPoint; // Store the end point for spheres
    private GameObject startSphere; // Reference to the instantiated start sphere
    private GameObject endSphere; // Reference to the instantiated end sphere
    private List<float> _taskSpaceState; // [x, y, z, θx, θy, θz], updated in FixedUpdate()
    private TMP_Text TaskSpaceStatDisplay;
    private TEXDraw TaskSpaceStatDisplayVector;
    private TMP_Text JointSpaceStatDisplay;
    private TEXDraw JointSpaceStatDisplayVector;

    // Start is called before the first frame update
    void Start()
    {
        _robotArm = GameObject.Find("Robot").transform;
        // _visualizer_image = _visualizer.GetComponent<Image>();
        _visualizer_image = GameObject.Find("SelfLearningCanvas/Visualizer/ImageDisplayer");
        _visualizer_latex = GameObject.Find("SelfLearningCanvas/Visualizer/LatexDisplayer");
        _graph_drawer = _visualizer.GetComponent<DrawGraph>();
        TaskSpaceStatDisplay = GameObject
            .Find("SelfLearningCanvas/StatDisplays/TaskSpaceStatDisplay")
            .GetComponent<TMP_Text>();
        TaskSpaceStatDisplayVector = GameObject
            .Find("SelfLearningCanvas/StatDisplays/TaskSpaceStatDisplayVector")
            .GetComponent<TEXDraw>();
        JointSpaceStatDisplay = GameObject
            .Find("SelfLearningCanvas/StatDisplays/JointSpaceStatDisplay")
            .GetComponent<TMP_Text>();
        JointSpaceStatDisplayVector = GameObject
            .Find("SelfLearningCanvas/StatDisplays/JointSpaceStatDisplayVector")
            .GetComponent<TEXDraw>();
    }

    // Update is called once per frame
    void Update() { }

    void FixedUpdate()
    {
        List<float> current_angles = _robotController.GetJointAngles();
        string angleStr = "aaaa ";
        for (int i = 0; i < current_angles.Count; i++)
        {
            angleStr += string.Format("{0:F2}", current_angles[i]);
            if (i < current_angles.Count - 1)
            {
                angleStr += ", ";
            }
        }
        Debug.Log(angleStr);
        _taskSpaceState = _generalRobotControl.ForwardKinematicsOpenManipulatorPro6DOF(
            current_angles
        );

        Debug.Log(string.Format("Task Space State Length: {0}", _taskSpaceState.Count));
        // Update task space state display
        if (_taskSpaceState != null && _taskSpaceState.Count >= 6)
        {
            TaskSpaceStatDisplay.text = string.Format(
                "End Effector State: {0:F1}, {1:F1}, {2:F1}, {3:F1}°, {4:F1}°, {5:F1}°",
                _taskSpaceState[0], // Convert to cm
                _taskSpaceState[1],
                _taskSpaceState[2],
                _taskSpaceState[3],
                _taskSpaceState[4],
                _taskSpaceState[5]
            );
            TaskSpaceStatDisplayVector.text = string.Format(
                "$$x = \\begin{{bmatrix}} x\\\\ y\\\\ z\\\\ \\theta_x\\\\ \\theta_y\\\\ \\theta_z \\end{{bmatrix}}=\\begin{{bmatrix}} {0:F1}\\\\ {1:F1}\\\\ {2:F1}\\\\ {3:F1}^\\circ\\\\ {4:F1}^\\circ\\\\ {5:F1}^\\circ\\end{{bmatrix}}$$",
                _taskSpaceState[0],
                _taskSpaceState[1],
                _taskSpaceState[2],
                _taskSpaceState[3],
                _taskSpaceState[4],
                _taskSpaceState[5]
            );
            JointSpaceStatDisplay.text = string.Format(
                "Joint Space State: {0:F1}°, {1:F1}°, {2:F1}°, {3:F1}°, {4:F1}°, {5:F1}°",
                current_angles[0],
                current_angles[1],
                current_angles[2],
                current_angles[3],
                current_angles[4],
                current_angles[5]
            );
            JointSpaceStatDisplayVector.text = string.Format(
                "$$q = \\begin{{bmatrix}} q_1\\\\ q_2\\\\ q_3\\\\ q_4\\\\ qa_5\\\\ q_6 \\end{{bmatrix}}=\\begin{{bmatrix}} {0:F1}^\\circ\\\\ {1:F1}^\\circ\\\\ {2:F1}^\\circ\\\\ {3:F1}^\\circ\\\\ {4:F1}^\\circ\\\\ {5:F1}^\\circ \\end{{bmatrix}}$$",
                current_angles[0],
                current_angles[1],
                current_angles[2],
                current_angles[3],
                current_angles[4],
                current_angles[5]
            );
            Debug.Log("Task Space State: " + TaskSpaceStatDisplay.text);
        }
    }

    public IEnumerator PlotGraph(List<float> YList, List<float> XList, string name = "Graph1")
    {
        string graph_root = FindGraphRoot(name);
        string graph_path = graph_root + name;
        _graph_drawer.ClearGraph(graph_path);
        _graph_drawer.ShowGraph(YList, graph_path, XList);
        // _graph_drawer.PlotPoints(graph_path, XList, new Color32(0, 255, 0, 255));
        return null;
    }

    public IEnumerator ClearGraph(string name)
    {
        string graph_root = FindGraphRoot(name);
        string graph_path = graph_root + name;
        _graph_drawer.ClearGraph(graph_path);
        return null;
    }

    public IEnumerator SetGraphStatus(string name, bool status)
    {
        string graph_root = "SelfLearningCanvas/Visualizer/" + FindGraphRoot(name);
        string graph_path = graph_root + name;
        GameObject.Find(graph_path).SetActive(status);
        EnableGraph(graph_root);

        return null;
    }

    public IEnumerator CloseAllGraphs()
    {
        for (int i = 0; i < 6; i++)
        {
            string name = "Graph" + (char)(i + 1 + 48);
            ClearGraph(name);
            SetGraphStatus(name, false);
        }

        return null;
    }

    public IEnumerator SetGraphTitle(string name, string title)
    {
        string graph_root = "SelfLearningCanvas/Visualizer/" + FindGraphRoot(name);
        string title_path = graph_root + name + "/Title";
        GameObject.Find(title_path).GetComponent<TMP_Text>().text = title;

        return null;
    }

    private string FindGraphRoot(string name)
    {
        return "Graphs" + (name[5] < '4' ? "0" : "1") + "/";
    }

    public void EnableGraph(string graph_root)
    {
        // string graph_root = "SelfLearningCanvas/Visualizer/Graphs";
        Transform graphTransform = GameObject.Find(graph_root).transform;

        bool anyActive = false;
        foreach (Transform child in graphTransform)
        {
            if (child.gameObject.activeSelf)
            {
                anyActive = true;
                break; // Exit loop if any child is active
            }
        }

        // Set the graph_root game object active if any child is active
        graphTransform.gameObject.SetActive(anyActive);
    }

    public IEnumerator SetGameObjectActive(GameObject gameObject, bool status)
    {
        gameObject.SetActive(status);
        return null;
    }

    public Sprite ConvertToSprite(Texture2D texture)
    {
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }

    public List<Sprite> ConvertToSpriteList(Texture2D[] texture_list)
    {
        List<Sprite> image_sprite_list = new List<Sprite>();
        for (int i = 0; i < texture_list.Length; i++)
        {
            image_sprite_list.Add(ConvertToSprite(texture_list[i]));
        }
        return image_sprite_list;
    }

    public List<Vector2> FindTextureSizeList(Texture2D[] texture_list)
    {
        List<Vector2> image_size_list = new List<Vector2>();
        for (int i = 0; i < texture_list.Length; i++)
        {
            image_size_list.Add(new Vector2(texture_list[i].width, texture_list[i].height));
        }
        return image_size_list;
    }

    public IEnumerator SetImage(Sprite image, Vector2 size)
    {
        _visualizer_image.GetComponent<Image>().sprite = image;
        float aspectRatio = size.x / size.y;
        float widthLimit = 2048;
        float heightLimit = 1024;
        float widthScale = widthLimit / size.x;
        float heightScale = heightLimit / size.y;
        float scale = Mathf.Min(widthScale, heightScale);
        Vector2 newSize = new Vector2(size.x * scale, size.y * scale);
        Vector2 newSizeV = new Vector2(size.x * scale + 670, size.y * scale);
        _visualizer_image.GetComponent<RectTransform>().sizeDelta = newSize;
        _visualizer.GetComponent<RectTransform>().sizeDelta = newSize;

        return null;
    }

    public IEnumerator SetImageStatus(bool active)
    {
        _visualizer_image.SetActive(active);
        return null;
    }

    public IEnumerator SetTaskSpaceStatDisplayVisibility(bool isVisible)
    {
        TaskSpaceStatDisplay.gameObject.SetActive(isVisible);
        return null;
    }

    public IEnumerator SetTaskSpaceStatDisplayLatexVisibility(bool isVisible)
    {
        TaskSpaceStatDisplayVector.gameObject.SetActive(isVisible);
        return null;
    }

    public IEnumerator SetJointSpaceStatDisplayVisibility(bool isVisible)
    {
        JointSpaceStatDisplay.gameObject.SetActive(isVisible);
        return null;
    }

    public IEnumerator SetJointSpaceStatDisplayLatexVisibility(bool isVisible)
    {
        JointSpaceStatDisplayVector.gameObject.SetActive(isVisible);
        return null;
    }

    public IEnumerator SetLatex(string latexText)
    {
        _visualizer_latex.GetComponent<TEXDraw>().text = latexText;
        return null;
    }

    public IEnumerator SetLatexStatus(bool active)
    {
        _visualizer_latex.SetActive(active);
        return null;
    }

    Vector3 GlobalFrame2UnityFrame(Vector3 global_coordinate)
    {
        // List<float> unity_coordinate = new List<float> {-global_coordinate[0]/100*1.06f-0.01f, global_coordinate[2]/100*1.06f-0.03f, -global_coordinate[1]/100*1.06f+0.34f};
        Vector3 unity_rot_coordinate = new Vector3(
            -global_coordinate.x,
            global_coordinate.z,
            -global_coordinate.y
        );
        Vector3 unity_frame_coordinate =
            Vector3.Scale(unity_rot_coordinate * (1 / 100f), _robotArm.transform.localScale)
            + _robotArm.transform.position;

        return unity_frame_coordinate;
    }

    public IEnumerator DrawTrajectory(List<List<float>> TaskSpaceTraj)
    {
        PathLine.positionCount = 0;
        if (TaskSpaceTraj.Count > 0)
        {
            startPoint = GlobalFrame2UnityFrame(
                new Vector3(TaskSpaceTraj[0][0], TaskSpaceTraj[0][1], TaskSpaceTraj[0][2])
            );
            endPoint = GlobalFrame2UnityFrame(
                new Vector3(
                    TaskSpaceTraj[TaskSpaceTraj.Count - 1][0],
                    TaskSpaceTraj[TaskSpaceTraj.Count - 1][1],
                    TaskSpaceTraj[TaskSpaceTraj.Count - 1][2]
                )
            );
        }

        for (int i = 0; i < TaskSpaceTraj.Count; i++)
        {
            Vector3 global_frame_point = new Vector3(
                TaskSpaceTraj[i][0],
                TaskSpaceTraj[i][1],
                TaskSpaceTraj[i][2]
            );
            Vector3 point = GlobalFrame2UnityFrame(global_frame_point);
            // Vector3 point = new Vector3(TaskSpaceTraj[i][0], TaskSpaceTraj[i][1], TaskSpaceTraj[i][2]);
            // Vector3 point = new Vector3(unity_task_space_point[0], unity_task_space_point[1], unity_task_space_point[2]);

            try
            {
                PathLine.positionCount = pathPointCount + 1;
                PathLine.SetPosition(pathPointCount, point);
                pathPointCount++;
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
        }

        // Store the spheres for later instantiation
        if (TaskSpaceTraj.Count > 0)
        {
            startSphere = Instantiate(startSpherePrefab, startPoint, Quaternion.identity); // Instantiate start sphere at start point
            endSphere = Instantiate(endSpherePrefab, endPoint, Quaternion.identity); // Instantiate end sphere at end point
        }

        return null;
    }

    public IEnumerator DisplayTraj(bool showSpheres = true)
    {
        PathLine.gameObject.SetActive(true);
        if (showSpheres)
        {
            if (startSphere != null)
            {
                startSphere.SetActive(true); // Show the start sphere
            }
            if (endSphere != null)
            {
                endSphere.SetActive(true); // Show the end sphere
            }
        }
        else
        {
            if (startSphere != null)
            {
                startSphere.SetActive(false); // Hide the start sphere
            }
            if (endSphere != null)
            {
                endSphere.SetActive(false); // Hide the end sphere
            }
        }
        return null;
    }

    public IEnumerator HideTraj()
    {
        PathLine.gameObject.SetActive(false);
        if (startSphere != null)
        {
            startSphere.SetActive(false); // Hide the start sphere
        }
        if (endSphere != null)
        {
            endSphere.SetActive(false); // Hide the end sphere
        }
        return null;
    }

    public IEnumerator ClearPoints()
    {
        PathLine.positionCount = 0;
        pathPointCount = 0;
        if (startSphere != null)
        {
            Destroy(startSphere); // Destroy the start sphere
            startSphere = null; // Clear the reference
        }
        if (endSphere != null)
        {
            Destroy(endSphere); // Destroy the end sphere
            endSphere = null; // Clear the reference
        }
        return null;
    }

    public IEnumerator ShowArrow(int joint, bool value)
    {
        _robotController.ShowArrow(joint, value);
        return null;
    }
}
