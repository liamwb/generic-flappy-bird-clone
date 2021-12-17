using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdater : MonoBehaviour
{
    public Text myText;
    private int currentScore;


    // Update is called once per frame
    void Update()
    {
        currentScore = ScoreControl.control.score;
        myText.text = "" + currentScore;
    }
}
