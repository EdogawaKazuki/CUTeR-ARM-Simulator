using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    private Grabber gripper;
    void OnEnable(){
        gripper = transform.parent.GetComponent<Grabber>();
    }
// object enter the grabbing point
    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log(collider.name);
        //Debug.Log(collider.gameObject.layer + "," + LayerMask.NameToLayer("Scene"));

        // Check whether the object is scene object.
        if(collider.gameObject.layer == LayerMask.NameToLayer("Scene"))
        {
            // get the parent object of the object. Object imported from files may be made up by not only one part.
            Debug.Log(collider.transform.name);
            Debug.Log(collider.transform.GetComponent<SceneObjectPart>().GetParent());
            Transform obj = collider.transform.GetComponent<SceneObjectPart>().GetParent();
            
            // increase the counter that belongs to the entered object
            if (gripper.colliderDict.ContainsKey(obj))
            {
                gripper.colliderDict[obj]++;
            }
            else
            {
                gripper.colliderDict.Add(obj, 1);
            }
            
            // increase the colliedr counter
            gripper._colliderCounter++;
        }
    }
    // object exit the grabbing point
    void OnTriggerExit(Collider collider)
    {
        // Check whether the object is scene object.
        if (collider.gameObject.layer == LayerMask.NameToLayer("Scene"))
        {
            // get the parent object of the object. Object imported from files may be made up by not only one part.
            Transform obj = collider.transform.GetComponent<SceneObjectPart>().GetParent();
            
            // decrease the counter that belongs to the entered object
            if (gripper.colliderDict.ContainsKey(obj))
            {
                gripper.colliderDict[obj]--;
            }
            
            // decrease the colliedr counter
            gripper._colliderCounter--;
        }
    }
}