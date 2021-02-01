using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text TimerText;

    float CurrentTime = 0f;
    float StartTime = 150f;

    public GameObject GameOverScreen;
    public GameObject InGameUi;
    public GameObject Cam;
    public GameObject Player;
    public AudioSource announcer;
    public AudioClip announcement;

    NewMouseLook LookScript;
    ChracterController CharScript;

    void Start()
    {
        CurrentTime = StartTime;
        LookScript = Cam.GetComponent<NewMouseLook>();
        CharScript = Player.GetComponent<ChracterController>();
    }


    void Update()
    {
        float t = CurrentTime -= 1 * Time.deltaTime;
        //TimerText.text = CurrentTime.ToString("0");

        string mins = ((int)t / 60).ToString();
        string secs = (t % 60).ToString("f1");
        TimerText.text = mins + ":" + secs;


        if (CurrentTime <= 0)
        {
            CurrentTime = 0;

            announcer.clip = announcement;
            announcer.Play();
            InGameUi.gameObject.SetActive(false);
            GameOverScreen.gameObject.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            LookScript.enabled = !LookScript.enabled;
            CharScript.enabled = !CharScript.enabled;




        }
    }
}