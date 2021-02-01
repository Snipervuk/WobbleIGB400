using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int ScoreVal;
    public static int EndScoreVal;
    public GameObject EndHolder;

    Text Score;
    Text EndScore;


    public TextMeshProUGUI tmpScore;
    

    // Start is called before the first frame update
    void Start()
    {
        ScoreVal = 0;
        Score = GetComponent<Text> ();
        //tmpScore = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "You've Won: $" + ScoreVal;
        //tmpScore.text = "" + ScoreVal;
        EndScoreScript.EndScoreVal = ScoreVal;
    }
}
