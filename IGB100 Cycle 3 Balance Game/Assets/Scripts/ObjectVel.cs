using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVel : MonoBehaviour
{
    public GameObject Platform;
    
    
    void OnTriggerEnter (Collider col)
    {
        if(col.gameObject.tag.Equals("throwable"))
        {
            col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

        }


    }
}
