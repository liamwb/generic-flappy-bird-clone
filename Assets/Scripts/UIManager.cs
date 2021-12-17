using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    GameObject[] pauseObjects;
    GameObject[] gameOverObjects;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();

        gameOverObjects = GameObject.FindGameObjectsWithTag("ShowOnGameOver");
        hideGameOver();
    }

    // Update is called once per frame
    void Update()
    {
        
        // Pause with escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }

            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hidePaused();
            }
        }

        // Check for death
        if (DeathControl.deathControl.isDead)
        {
            showGameOver();
        }
    }
    
    // Reloads the level
    public void reload()
    {
        DeathControl.deathControl.isDead = false;
        hideGameOver();
        loadLevel("SampleScene"); 
    }


    // Controls the pausing of the scene
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }

        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    public void showGameOver()
    {
        foreach (GameObject g in gameOverObjects)
        {
            g.SetActive(true);
        }
    }

    public void hideGameOver()
    {
        foreach (GameObject g in gameOverObjects)
        {
            g.SetActive(false);
        }
    }


    public void loadLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
