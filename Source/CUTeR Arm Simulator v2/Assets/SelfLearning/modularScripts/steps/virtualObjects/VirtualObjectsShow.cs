using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 public enum ShowHideType {
        Show,
        Hide
    }
     public class SceneUtils: MonoBehaviour
    {
        public static GameObject FindInScene(string name)
        {
            GameObject[] rootObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

            foreach (GameObject root in rootObjects)
            {
                GameObject result = FindInChildren(root.transform, name);
                if (result != null)
                    return result;
            }

            return null;
        }

        private static GameObject FindInChildren(Transform parent, string name)
        {
            if (parent.name == name)
                return parent.gameObject;

            foreach (Transform child in parent)
            {
                GameObject result = FindInChildren(child, name);
                if (result != null)
                    return result;
            }

            return null;
        }
    }

// CHANGE: This ScriptableObject interpolates a scene GameObject's transform.
// Make sure to assign a scene object to 'prefabToInterpolate' in the Project window!

[CreateAssetMenu(menuName = "LessonSteps/VirtualObjects/Show")]
public class VirtualObjectsShow : LessonStep
{
    public string sceneObjectName;
    public ShowHideType showhidetype = ShowHideType.Show;
    public bool chooseposition = false;
    public Vector3 position;
    public bool chooserotation = false;
    public Vector3 rotation;
    public bool choosescale = false;
    public Vector3 scale ;



   
    public override IEnumerator Execute(LessonContext ctx)
    {
        GameObject prefabToInterpolate = SceneUtils.FindInScene(sceneObjectName);
        if (prefabToInterpolate != null && chooseposition)
        {
            prefabToInterpolate.transform.localPosition = position;
        }
        if (prefabToInterpolate != null && chooserotation)
        {
            prefabToInterpolate.transform.localEulerAngles = rotation;
        }
        if (prefabToInterpolate != null && choosescale)
        {
            prefabToInterpolate.transform.localScale = scale;
        }

        
        switch (showhidetype)
        {
            case ShowHideType.Show:
                if (prefabToInterpolate != null)
                {
                    prefabToInterpolate.SetActive(true);
                }
                else
                {
                    Debug.LogWarning("GameObject with name " + sceneObjectName + " not found in the scene.");
                }
                break;
            case ShowHideType.Hide:
                if (prefabToInterpolate != null)
                {
                    prefabToInterpolate.SetActive(false);
                }
                else
                {
                    Debug.LogWarning("GameObject with name " + sceneObjectName + " not found in the scene.");
                }
                break;
        }
        yield break;
    }
}