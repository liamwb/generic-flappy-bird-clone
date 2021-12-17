using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    public static ScoreControl control;
    public int score;
    void Awake() 
    {
        if (control == null)
        {
            control = this;
        }

        score = 0;
    }
}