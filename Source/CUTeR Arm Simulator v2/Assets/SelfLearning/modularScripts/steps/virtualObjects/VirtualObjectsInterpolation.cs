using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// CHANGE: This ScriptableObject interpolates a scene GameObject's transform.
// Make sure to assign a scene object to 'prefabToInterpolate' in the Project window!

[CreateAssetMenu(menuName = "LessonSteps/VirtualObjects/Interpolation")]
public class VirtualObjectsInterpolation : LessonStep
{
    [Header("Name of the scene object to interpolate")]

    public string sceneObjectName;
    // public bool setparentobjectactivebeforeinterpolation = true;

    public bool usePosition = true;

    public bool globalPosition = false;
    public Vector3 targetPosition;

    public bool useRotation = true;
    public bool globalRotation = false;
    public Vector3 targetRotation; // Euler angles

    public bool useScale = true;
    public Vector3 targetScale = Vector3.one;

    //public float duration = 1.0f;
    public bool smoothInterpolation = true; // CHANGE: Fixed typo
    public static class SceneUtils
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
    public override IEnumerator Execute(LessonContext ctx)
    {
        GameObject prefabToInterpolate = SceneUtils.FindInScene(sceneObjectName);
        //     if (setparentobjectactivebeforeinterpolation && prefabToInterpolate != null)
        //     {
        //         GameObject parent = prefabToInterpolate.transform.parent != null
        // ? prefabToInterpolate.transform.parent.gameObject
        // : null;
        // parent.SetActive(true);

        // }


        if (prefabToInterpolate == null)
        {
            Debug.LogError("Prefab to interpolate not found in the scene! Make sure the object is named correctly.");
            yield break;
        }
        Debug.Log("VirtualObjects_Interpolation Execute called."); // CHANGE: Debug to verify execution.
       
        // CHANGE: Duration check.
        if (Duration <= 0)
        {
            Debug.LogError("Duration must be greater than zero!");
            yield break;
        }

        Transform trans = prefabToInterpolate.transform;

        // CHANGE: Print current and target values for debugging.
        Debug.Log("Initial global pos: " + trans.position + " | local pos: " + trans.localPosition);
        Debug.Log("Target pos: " + targetPosition + " | Mode: " + (globalPosition ? "Global" : "Local"));
        Debug.Log("Initial global rot: " + trans.rotation.eulerAngles + " | local rot: " + trans.localRotation.eulerAngles);
        Debug.Log("Target rot: " + targetRotation + " | Mode: " + (globalRotation ? "Global" : "Local"));
        Debug.Log("Initial scale: " + trans.localScale + " | Target scale: " + targetScale);

        // Cache initial values
        Vector3 initialPosition = globalPosition ? trans.position : trans.localPosition;
        Vector3 finalPosition = targetPosition; // CHANGE: User must enter this in the correct space.

        Quaternion initialRotation = globalRotation ? trans.rotation : trans.localRotation;
        Quaternion finalRotation = Quaternion.Euler(targetRotation); // CHANGE: User must enter this in the correct space.

        Vector3 initialScale = trans.localScale;
        Vector3 finalScale = targetScale;

        if (smoothInterpolation)
        {
            float elapsedTime = 0f;
            while (elapsedTime < Duration)
            {
                float t = Mathf.Clamp01(elapsedTime / Duration);

                if (usePosition)
                {
                    Vector3 pos = Vector3.Lerp(initialPosition, finalPosition, t);
                    if (globalPosition)
                        trans.position = pos;
                    else
                        trans.localPosition = pos;
                }

                if (useRotation)
                {
                    Quaternion rot = Quaternion.Lerp(initialRotation, finalRotation, t);
                    if (globalRotation)
                        trans.rotation = rot;
                    else
                        trans.localRotation = rot;
                }

                if (useScale)
                {
                    trans.localScale = Vector3.Lerp(initialScale, finalScale, t);
                }

                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // CHANGE: Ensure final values are set after interpolation.
            if (usePosition)
            {
                if (globalPosition)
                    trans.position = finalPosition;
                else
                    trans.localPosition = finalPosition;
            }
            if (useRotation)
            {
                if (globalRotation)
                    trans.rotation = finalRotation;
                else
                    trans.localRotation = finalRotation;
            }
            if (useScale)
            {
                trans.localScale = finalScale;
            }
        }
        else
        {
            // CHANGE: Instantly set values if not smoothing.
            if (usePosition)
            {
                if (globalPosition)
                    trans.position = finalPosition;
                else
                    trans.localPosition = finalPosition;
            }
            if (useRotation)
            {
                if (globalRotation)
                    trans.rotation = finalRotation;
                else
                    trans.localRotation = finalRotation;
            }
            if (useScale)
            {
                trans.localScale = finalScale;
            }
        }

        // CHANGE: Final debug.
        Debug.Log("Final global pos: " + trans.position + " | local pos: " + trans.localPosition);
        Debug.Log("Final global rot: " + trans.rotation.eulerAngles + " | local rot: " + trans.localRotation.eulerAngles);
        Debug.Log("Final scale: " + trans.localScale);
    }
    
}