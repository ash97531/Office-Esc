using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Fracture fractureScript;
    int count = 0;
    private void Start()
    {
        fractureScript = GetComponent<Fracture>();
        //fractureScript.triggerOptions.
        //Debug.Log(fractureScript.triggerOptions.GetType());
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.tag);
        //count++;
        //Debug.Log(count);
        //if (collision.gameObject.CompareTag("Weapon"))
        //{
        //    count++;
        //    if (count == 4)
        //    {
        //        fractureScript.triggerOptions.minimumCollisionForce = 0;
        //        //fractureScript.triggerOptions.triggerType = TriggerType.Trigger;

        //    }
        //    //fractureScript.triggerOptions.minimumCollisionForce -= 5;
        //}
    }

    public void ObjectHit(Collider collider, GameObject obj, Vector3 vec)
    {
        Debug.Log($"collider: {collider.tag}, count: {count}");
    }
}
