/*
 * (Christopher Green)
 * (ButtonManager.cs)
 * (Assignment 8)
 * (This script handles basic button functioality.)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Refernce to the static instance of Button Manager
    //private static ButtonManager instance;

    public GameController gameCon;

    // Literally no idea why this doesn't work and I would appreciate if you could help me with it, thank!

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //    else
    //    {
    //        if(instance != this)
    //        {
    //            Destroy(gameObject);
    //        }
    //    }

    //    DontDestroyOnLoad(gameObject);
    //}

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            gameCon = GameObject.Find("Game Controller").GetComponent<GameController>();
        }
    }


    public void LoadLevel(string levelName)
    {
        switch (levelName)
        {
            case "Main Menu":
                SceneManager.LoadScene(0);
                break;

            case "Game":
                SceneManager.LoadScene(1);
                break;

            case "Instructions":
                SceneManager.LoadScene(2);
                break;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gameCon.pauseMenu.SetActive(false);
    }

    public void SkipTutorial()
    {
        gameCon.isInTutorial = false;
        gameCon.tutorialMenu.SetActive(false);
        gameCon.gameMenu.SetActive(true);
        gameCon.StopAllCoroutines();
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}
