using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    HashSet<Transform> colliderSet = new HashSet<Transform>();
    Dictionary<Transform, int> colliderDict = new Dictionary<Transform, int>();
    Color selfColor;
    Material selfMaterial;
    public GameObject targetObject = null;
    Transform LeftPalm;
    Transform RightPalm;
    bool Grabbing = false;
    bool Releasing = false;
    public bool Grabbed = false;
    public bool toggle = false;
    Transform playingScene;
    int colliderCounter;
    // Start is called before the first frame update
    void Start()
    {
        selfMaterial = GetComponent<MeshRenderer>().material;
        selfColor = selfMaterial.color;
        LeftPalm = transform.parent.Find("PartHand/Left");
        RightPalm = transform.parent.Find("PartHand/Right");
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle && !(Grabbing || Releasing))
        {
            Grab();
            toggle = false;
        }
        if (Grabbing)
        {
            RightPalm.localRotation = Quaternion.Lerp(RightPalm.localRotation, Quaternion.Euler(60, 0, 0), 0.5f);
            LeftPalm.localRotation = Quaternion.Lerp(LeftPalm.localRotation, Quaternion.Euler(-60, 0, 0), 0.5f);
            if (Mathf.Abs(RightPalm.localEulerAngles.x - 60) < 0.1)
            {
                Grabbing = false;
                Grabbed = true;
                Grab();
            }
        }
        if (Releasing)
        {
            RightPalm.localRotation = Quaternion.Lerp(RightPalm.localRotation, Quaternion.Euler(40, 0, 0), 0.5f);
            LeftPalm.localRotation = Quaternion.Lerp(LeftPalm.localRotation, Quaternion.Euler(-40, 0, 0), 0.5f);
            if (Mathf.Abs(RightPalm.localEulerAngles.x - 40) < 0.1)
            {
                Grabbed = false;
                Releasing = false;
            }
        }
        //Debug.Log("released: " + Released + " grabber: " + Grabbed + " releasing: " + Releasing + " grabbing: " + Grabbing);
    }
    // 碰撞开始
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.name);
        Debug.Log(collider.gameObject.layer + "," + LayerMask.NameToLayer("Scene"));
        if(collider.gameObject.layer == LayerMask.NameToLayer("Scene"))
        {
            Transform obj = collider.transform.GetComponent<SceneObjectController>().parent;
            if (colliderDict.ContainsKey(obj))
            {
                colliderDict[obj]++;
            }
            else
            {
                colliderDict.Add(obj, 1);
            }
            colliderCounter++;
            selfMaterial.color = new Color(0, 1, 0, 0.5f);
        }
    }

    // 碰撞结束
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Scene"))
        {
            Transform obj = collider.transform.GetComponent<SceneObjectController>().parent;
            if (colliderDict.ContainsKey(obj))
            {
                colliderDict[obj]--;
            }
            colliderCounter--;
            if (colliderCounter == 0)
            {
                selfMaterial.color = selfColor;
            }
        }
    }

    // 碰撞持续中
    void OnCollisionStay(Collision collision)
    {

    }

    public void Toggle()
    {
        if (gameObject.activeSelf)
        {
            toggle = true;
        }
    }
    public void Grab()
    {
        if (Grabbing || Releasing)
        {
            return;
        }
        if (targetObject)
        {
            Debug.Log("Release");
            targetObject.transform.SetParent(playingScene);

            Rigidbody rigidbody = targetObject.GetComponent<Rigidbody>();
            if (rigidbody)
            {
                rigidbody.isKinematic = false;
            }
            Releasing = true;
            targetObject = null;
        }
        else
        {
            Debug.Log("Try Grab");
            if (!Grabbed)
            {
                Grabbing = true;
                return;
            }
            GameObject target = null;
            float min_dist = Mathf.Infinity;
            foreach (var ele in colliderDict)
            {
                if (ele.Value == 0)
                    continue;
                Transform collider = ele.Key;
                Debug.Log("Check " + collider.name);
                float distance = Vector3.Distance(collider.transform.position, transform.position);
                if (distance < min_dist)
                {
                    min_dist = distance;
                    target = collider.gameObject;
                }
            }
            targetObject = target;
            if (targetObject)
            {
                Debug.Log(targetObject.name);
                playingScene = targetObject.transform.parent;
                targetObject.transform.SetParent(transform);
                Rigidbody rigidbody = targetObject.GetComponent<Rigidbody>();
                if (rigidbody)
                {
                    rigidbody.isKinematic = true;
                }
            }
            else
            {
                Releasing = true;
            }
        }
    }
}
