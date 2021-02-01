using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    AnnouncerScript StartOfGame;
    public GameObject ControlMenu;
    public GameObject Cam;
    public GameObject DestroyHolder;


    public void Start()
    {
        StartOfGame = Cam.GetComponent<AnnouncerScript>();
    }
    
    //Plays Game
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Exits Game
    public void ExitGame()
    {
        Application.Quit();
    }
    //Returns to Menu
    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);

    }
    //Restarts Game
    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
