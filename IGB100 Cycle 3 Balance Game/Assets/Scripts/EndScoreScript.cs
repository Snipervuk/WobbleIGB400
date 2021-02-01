using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScoreScript : MonoBehaviour
{
    public static int EndScoreVal;
    Text Score;

    // Start is called before the first frame update
    void Start()
    {
        //ScoreScript.ScoreVal = EndScoreVal;
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreScript.ScoreVal = EndScoreVal;
        Score.text = "$" + EndScoreVal + "!";
    }
}
