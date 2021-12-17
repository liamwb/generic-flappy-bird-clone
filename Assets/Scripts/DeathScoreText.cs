using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScoreText : MonoBehaviour
{
    public Text myText;

    // Update is called once per frame
    void Update()
    {
        if (DeathControl.deathControl.isDead)
        {
            myText.text = "Your Score: " + ScoreControl.control.score;
        }
    }
}
