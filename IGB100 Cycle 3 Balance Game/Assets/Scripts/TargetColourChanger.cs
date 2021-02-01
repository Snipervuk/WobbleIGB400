using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetColourChanger : MonoBehaviour
{
    public bool red;
    public bool blue;
    public bool green;
    public bool yellow;



    //target colours
    public Material redTarget;
    public Material blueTarget;
    public Material greenTarget;
    public Material yellowTarget;
    //colours for the lights
    public Material redLight;
    public Material blueLight;
    public Material greenLight;
    public Material yellowLight;
    // the animations
    public RuntimeAnimatorController blueFlasher;
    public RuntimeAnimatorController blueFlasher2;
    public RuntimeAnimatorController greenFlasher;
    public RuntimeAnimatorController greenFlasher2;
    //the animation for the lights to flash
    //Animator animator; 

    //for use in the code only
    Material thisMaterial;
    Renderer[] flashingLights;

    //List<GameObject> children = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //thisMaterial = this.gameObject.GetComponent<Material>();
        flashingLights = this.gameObject.GetComponentsInChildren<Renderer>();
        //whichAnimation = this.transform.GetComponentsInChildren<WhichAnimationScript>();
        //animator = this.GetComponent<Animator>();

        // old code that didn't work but could be made to work in future
        //Transform[] ts = gameObject.GetComponentsInChildren<Transform>();
        //foreach (Transform child in ts)
        //{
        //    children.Add(child.gameObject); 
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (red == true)
        {
            for (int i = 0; i < flashingLights.Length; i++)
            {
                flashingLights[i].material = redLight;

            }

            //for (int i = 0; i < children.Count; i++)
            //{


            //}

            this.GetComponent<Renderer>().material = redTarget;


        }

        else if (blue == true)
        {

            for (int i = 0; i < flashingLights.Length; i++)
            {
                flashingLights[i].material = blueLight;

            }

            //for (int i = 0; i < children.Count; i++)
            //{


            //    bool whichanimation = children[i].GetComponent<WhichAnimationScript>().whichAnimation;
            //    if (whichanimation == true)
            //    {
            //        children[i].GetComponent<Animator>().runtimeAnimatorController = blueFlasher;
            //    }

            //    else if (whichanimation == false)
            //    {
            //        children[i].GetComponent<Animator>().runtimeAnimatorController = blueFlasher2;
            //    }

            //}

            this.GetComponent<Renderer>().material = blueTarget;
        }

        else if (green == true)
        {

            for (int i = 0; i < flashingLights.Length; i++)
            {
                flashingLights[i].material = greenLight;

            }
            //for (int i = 0; i < children.Count; i++)
            //{


            //    bool whichanimation = children[i].GetComponent<WhichAnimationScript>().whichAnimation;
            //    if (whichanimation == true)
            //    {
            //        children[i].GetComponent<Animator>().runtimeAnimatorController = greenFlasher;
            //    }

            //    else if (whichanimation == false)
            //    {
            //        children[i].GetComponent<Animator>().runtimeAnimatorController = greenFlasher2;
            //    }

            //}


            this.GetComponent<Renderer>().material = greenTarget;
        }

        else if (yellow == true)
        {

            for (int i = 0; i < flashingLights.Length; i++)
            {
                flashingLights[i].material = yellowLight; ;

            }

            this.GetComponent<Renderer>().material = yellowTarget;

        }
    }
}
