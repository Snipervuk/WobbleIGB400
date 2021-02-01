using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetDetection : MonoBehaviour
{

    public AudioSource announcer;
    public AudioClip colourMatch;
    public AudioClip shapeMatch;
    public AudioClip bothMatch;
    // maybe ontriggerexit will fix it
    void OnTriggerEnter (Collider col)
    {


        //YES I KNOW THIS COULD BE CLEANER/LISTED BUT IF IT FITS IT SITS - Christian (Soz Joel)
        if (this.gameObject.tag.Equals("YellowCircleTarget"))
        {
            if (col.gameObject.name.Equals("YellowSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;

            }
            else if (col.gameObject.name.Equals("YellowCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("YellowPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            
            else if (col.gameObject.name.Equals("BlueSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }

            else if (col.gameObject.name.Equals("GreenSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }

            else if (col.gameObject.name.Equals("RedSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("YellowCubeTarget"))
        {
            if (col.gameObject.name.Equals("YellowSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;


            }
            else if (col.gameObject.name.Equals("YellowCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }
            else if (col.gameObject.name.Equals("YellowPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }

            else if (col.gameObject.name.Equals("GreenCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;
               
            }
            else if (col.gameObject.name.Equals("BlueCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("RedCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("YellowTriTarget"))
        {
            if (col.gameObject.name.Equals("YellowSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;

            }
            else if (col.gameObject.name.Equals("YellowCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("YellowPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }

            else if (col.gameObject.name.Equals("GreenPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("BluePrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("RedPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }

            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("RedCircleTarget"))
        {
            if (col.gameObject.name.Equals("RedSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;


            }
            else if (col.gameObject.name.Equals("RedCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("RedPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("GreenSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("BlueSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("RedCubeTarget"))
        {
            if (col.gameObject.name.Equals("RedSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;


            }
            else if (col.gameObject.name.Equals("RedCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }
            else if (col.gameObject.name.Equals("RedPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("GreenCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("BlueCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("RedTriTarget"))
        {
            if (col.gameObject.name.Equals("RedSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;


            }
            else if (col.gameObject.name.Equals("RedCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("RedPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }
            else if (col.gameObject.name.Equals("GreenPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("BluePrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("GreenCircleTarget"))
        {
            if (col.gameObject.name.Equals("GreenSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;


            }
            else if (col.gameObject.name.Equals("GreenCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("GreenPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("RedSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("BlueSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("GreenCubeTarget"))
        {
            if (col.gameObject.name.Equals("GreenSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;


            }
            else if (col.gameObject.name.Equals("GreenCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }
            else if (col.gameObject.name.Equals("GreenPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("RedCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("BlueCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("GreenTriTarget"))
        {
            if (col.gameObject.name.Equals("GreenSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;


            }
            else if (col.gameObject.name.Equals("GreenCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("GreenPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }
            else if (col.gameObject.name.Equals("RedPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("BluePrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("BlueCircleTarget"))
        {
            if (col.gameObject.name.Equals("BlueSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;


            }
            else if (col.gameObject.name.Equals("BlueCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("BluePrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("RedSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("GreenSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("BlueCubeTarget"))
        {
            if (col.gameObject.name.Equals("BlueSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;


            }
            else if (col.gameObject.name.Equals("BlueCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }
            else if (col.gameObject.name.Equals("BluePrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("RedCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("GreenCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        if (this.gameObject.tag.Equals("BlueTriTarget"))
        {
            if (col.gameObject.name.Equals("BlueSphere(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;


            }
            else if (col.gameObject.name.Equals("BlueCube(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = colourMatch;
            }
            else if (col.gameObject.name.Equals("BluePrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 30;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = bothMatch;
            }
            else if (col.gameObject.name.Equals("RedPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("GreenPrism(Clone)"))
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else if (col.gameObject.name.Equals("YellowPrism(Clone)"))
            {
                Debug.Log("shape match scoreup");
                ScoreScript.ScoreVal += 20;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = shapeMatch;

            }
            else
            {
                Debug.Log("scoreup");
                ScoreScript.ScoreVal += 10;
                Debug.Log(gameObject.name);
                Destroy(col.gameObject);
                announcer.clip = null;
            }
            announcer.Play();
        }

        Debug.Log("triggered");
    }
}
