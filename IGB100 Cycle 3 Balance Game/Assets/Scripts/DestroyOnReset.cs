using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnReset : MonoBehaviour
{
    //UIButtons RestartFunction;
    //public GameObject go;

    //public GameObject AnnouncerHolder;
    //public GameObject ControlMenu;
    //public GameObject GameOverScreen;
    private static DestroyOnReset instance = null;


    void Awake()
    {        
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
                return;

            }
            Destroy(this.gameObject);
            
        

    }

    void Start()
    {


    }
}
