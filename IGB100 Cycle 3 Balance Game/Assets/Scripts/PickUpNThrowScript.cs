using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpNThrowScript : MonoBehaviour
{
    public GameObject holder;
    public bool objectHeld = false;
    public float thrust = 10;
    private GameObject throwable;
    // how far the objects can be picked up from
    public float pickupLength = 1.6f;

    public GameObject eToPickup;
    public GameObject eToThrow;

    //public Image EPickImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectHeld == true)
        {
            eToPickup.SetActive(false);
            eToThrow.SetActive(true);
        }
        else if(objectHeld == false)
        {
            eToPickup.SetActive(true);
            eToThrow.SetActive(false);
        }
        ///SeeToInstruct();
        if (Input.GetKeyDown("e"))
        {
            SeeObject();

            if (objectHeld == true)
            {
                // detach object from holder
                holder.transform.DetachChildren();

                //turn on gravity
                throwable.GetComponent<Rigidbody>().useGravity = true;

                throwable.GetComponent<Rigidbody>().isKinematic = false;

                //make the collider a trigger
                throwable.GetComponent<Collider>().isTrigger = true;

                //turn on the collider
                throwable.GetComponent<Collider>().enabled = true;
                //set to the start position to throw
                throwable.transform.position = this.transform.position;
                //throw
                throwable.GetComponent<Rigidbody>().velocity = (this.transform.forward * thrust);
                //empty the throwable gameobject space, ready for the next one
                throwable.tag = "thrown";
                throwable = null;

                objectHeld = false;
            }

            else if (objectHeld == false)
            {
                //set parent to holder
                throwable.transform.SetParent(holder.transform);
                //turn off gravity
                throwable.GetComponent<Rigidbody>().useGravity = false;
                //turn off the collider
                throwable.GetComponent<Collider>().enabled = false;
                // turn off the rigidbody
                throwable.GetComponent<Rigidbody>().useGravity = false;
                throwable.GetComponent<Rigidbody>().isKinematic = true;
                //set the position to holder's position.
                throwable.transform.position = holder.transform.position;

                objectHeld = true;
            }
        }
        


        
    }

    // testing if there is an object within range
    public void SeeObject()
    {
        if (objectHeld == false)
        {
            int layermask = 1 << 8;
            layermask = ~layermask;
            RaycastHit rayHit;
            /// check if the ray collides with anything
            ///         
            if (Physics.Raycast(transform.position, transform.forward, out rayHit, pickupLength))
            {

                Debug.Log("hit something");
                if (rayHit.collider.tag == "throwable")
                {
                    Debug.Log("hit throwable");
                    throwable = rayHit.collider.gameObject;
                }

            }
        }
        

    }
    public void SeeToInstruct()
    {
        int layermask = 1 << 8;
        layermask = ~layermask;
        RaycastHit rayHit;
        /// check if the ray collides with anything
        ///         
        if (Physics.Raycast(transform.position, transform.forward, out rayHit, pickupLength))
        {

            Debug.Log("See Something");
            if (rayHit.collider.tag == "throwable" && objectHeld==false)
            {
                eToPickup.SetActive(true);
            }

            else
            {
                eToPickup.SetActive(false);
            }

        }
    }


}
