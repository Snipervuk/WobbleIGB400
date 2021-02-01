using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnouncerScript : MonoBehaviour
{
    public AudioClip welcome;
    public AudioClip intro;
    public AudioClip clap;
    public AudioClip go;
    public AudioSource audio;
    public GameObject player;
    public GameObject InGameUI;
    private ChracterController character;


    public GameObject ControlMenu;
    public GameObject Timer;
    TimerScript TimerActive; 
    

    private int count = 0;
    // will need an audioscript for each possible announcement;

    // Start is called before the first frame update
    void Start()
    {
        audio.clip = welcome;
        audio.Play();
        character = player.GetComponent<ChracterController>();
        TimerActive = Timer.GetComponent<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (audio.isPlaying == false && count == 0)
        {
            audio.clip = clap;
            audio.Play();
            count++;
        }

        if (audio.isPlaying == false && count == 1)
        {
            audio.clip = intro;
            audio.Play();
            count++;
        }

        if (audio.isPlaying == false && count == 2)
        {
            audio.clip = go;
            audio.Play();
            count++;
            character.ifMove = true;
            ControlMenu.gameObject.SetActive(false);
            InGameUI.gameObject.SetActive(true);
            TimerActive.enabled = true; //Timer and Movement Go a bit before announcer says start)
        }
        if (audio.isPlaying == false && count == 3)
        {
            audio.clip = null;
        }


    }


}
