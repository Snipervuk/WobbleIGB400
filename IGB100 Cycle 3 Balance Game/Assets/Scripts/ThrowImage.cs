using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowImage : MonoBehaviour
{
    [SerializeField] public Image EPickImage;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            EPickImage.enabled = true;
        }

    }

    // Update is called once per frame
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            EPickImage.enabled = false;
        }
    }
}
