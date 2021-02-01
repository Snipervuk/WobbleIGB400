using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloor : MonoBehaviour
{

    public GameObject GameOverScreen;
    public GameObject InGameUI;
    public GameObject Player;
    public GameObject Cam;
    ChracterController CharScript;
    NewMouseLook LookScript;
    public AudioSource announcer;
    public AudioClip announcement;


    // Start is called before the first frame update
    void Start()
    {
        CharScript = Player.GetComponent<ChracterController>();
        LookScript = Cam.GetComponent<NewMouseLook>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Object")
        {
            Destroy(Col.gameObject);
        }

        if (Col.gameObject.tag == "throwable")
        {
            Destroy(Col.gameObject);
        }

        if (Col.gameObject.tag == "thrown")
        {
            Destroy(Col.gameObject);
        }

        if (Col.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            GameOverScreen.gameObject.SetActive(true);
            InGameUI.gameObject.SetActive(false);
            CharScript.enabled = !CharScript.enabled;
            LookScript.enabled = !LookScript.enabled;
            //Freeze Player Movement Here as well
            announcer.clip = announcement;
            announcer.Play();
        }

    }

    void OnTriggerEnter()
    {
        Destroy(gameObject);

    }

}
