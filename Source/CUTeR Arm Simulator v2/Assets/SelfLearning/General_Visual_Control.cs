using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class GeneralVisualControl : MonoBehaviour
{

    public LineRenderer PathLine;
    private Transform _robotArm;
    private GameObject _visualizer;
    private GameObject _visualizer_image;
    public GameObject startSpherePrefab;
    public GameObject endSpherePrefab;
    int pathPointCount = 0;
    private Vector3 startPoint; // Store the start point for spheres
    private Vector3 endPoint;   // Store the end point for spheres
    private GameObject startSphere; // Reference to the instantiated start sphere
    private GameObject endSphere;   // Reference to the instantiated end sphere

    // Start is called before the first frame update
    void Start()
    {
        _robotArm = GameObject.Find("Robot").transform;
        _visualizer = GameObject.Find("SelfLearningCanvas/Visualizer");
        // _visualizer_image = _visualizer.GetComponent<Image>();
        _visualizer_image = GameObject.Find("SelfLearningCanvas/Visualizer/ImageDisplayer");

    }

    // Update is called once per frame
    void Update()
    {

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
        for(int i =0; i < texture_list.Length; i++)
        {
            image_sprite_list.Add(ConvertToSprite(texture_list[i]));
        }
        return image_sprite_list;
    }

    public List<Vector2> FindTextureSizeList(Texture2D[] texture_list)
    {
        List<Vector2> image_size_list = new List<Vector2>();
        for(int i =0; i < texture_list.Length; i++)
        {
            image_size_list.Add(new Vector2(texture_list[i].width, texture_list[i].height));
        }
        return image_size_list;
    }

    public IEnumerator SetImage(Sprite image, Vector2 size)
    {
        _visualizer_image.GetComponent<Image>().sprite = image;
        float aspectRatio = size.x / size.y;
        float widthLimit = 1024;
        float heightLimit = 512;
        float widthScale = widthLimit / size.x;
        float heightScale = heightLimit / size.y;
        float scale = Mathf.Min(widthScale, heightScale);
        Vector2 newSize = new Vector2(size.x * scale, size.y * scale);
        _visualizer_image.GetComponent<RectTransform>().sizeDelta = newSize;
        _visualizer.GetComponent<RectTransform>().sizeDelta = newSize;
        
        return null;
    }

    public IEnumerator SetImageStatus(bool active)
    {
        _visualizer_image.SetActive(active);
        return null;
    }

    Vector3 GlobalFrame2UnityFrame(Vector3 global_coordinate)
    {
        // List<float> unity_coordinate = new List<float> {-global_coordinate[0]/100*1.06f-0.01f, global_coordinate[2]/100*1.06f-0.03f, -global_coordinate[1]/100*1.06f+0.34f};
        Vector3 unity_rot_coordinate = new Vector3(-global_coordinate.x, global_coordinate.z, -global_coordinate.y);
        Vector3 unity_frame_coordinate = Vector3.Scale(unity_rot_coordinate * (1/100f), _robotArm.transform.localScale) + _robotArm.transform.position;
        
        return unity_frame_coordinate;
    }

    public IEnumerator DrawTrajectory(List<List<float>> TaskSpaceTraj)
    {
        PathLine.positionCount = 0;

        if (TaskSpaceTraj.Count > 0)
        {
            startPoint = GlobalFrame2UnityFrame(new Vector3(TaskSpaceTraj[0][0], TaskSpaceTraj[0][1], TaskSpaceTraj[0][2]));
            endPoint = GlobalFrame2UnityFrame(new Vector3(TaskSpaceTraj[TaskSpaceTraj.Count - 1][0], TaskSpaceTraj[TaskSpaceTraj.Count - 1][1], TaskSpaceTraj[TaskSpaceTraj.Count - 1][2]));
        }

        for (int i = 0; i < TaskSpaceTraj.Count; i++)
        {
            Vector3 global_frame_point = new Vector3(TaskSpaceTraj[i][0], TaskSpaceTraj[i][1], TaskSpaceTraj[i][2]);
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

    public IEnumerator DisplayTraj(bool showSpheres=true)
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
        else {
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
}


