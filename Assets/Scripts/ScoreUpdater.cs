using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "birb")
        {
            ScoreControl.control.score++;
            Debug.Log("score: " + ScoreControl.control.score);
        }
    }
}
