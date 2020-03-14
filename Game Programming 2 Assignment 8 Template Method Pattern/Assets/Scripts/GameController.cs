/*
 * (Christopher Green)
 * (GameController.cs)
 * (Assignment 8)
 * (This script handles basic game necessities.)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("Menus")]
    public GameObject gameMenu;
    public GameObject tutorialMenu;
    public GameObject pauseMenu;

    [Header("Pause Menu Stuff")]
    private bool isPaused;

    [Header("Timer Stuff")]
    public Text timerText;
    public float timerDuration;
    public bool isInTutorial;

    public ShopTestDrive shopTestDrive;


    // Start is called before the first frame update
    private void Start()
    {
        isPaused = false;
        isInTutorial = true;
        pauseMenu.SetActive(false);
        gameMenu.SetActive(false);
        StartCoroutine(TutorialTimer());

    }

    public void Update()
    {
        if(!isInTutorial)
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Time.timeScale = 0.000001f;
            pauseMenu.SetActive(true);
            isPaused = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            isPaused = false;
        }
    }

    public IEnumerator TutorialTimer()
    {
        timerDuration = 15f;
        tutorialMenu.SetActive(true);

        while (timerDuration > 0)
        {
            timerDuration -= Time.deltaTime;
            timerText.text = "Timer: " + timerDuration.ToString("00");
            yield return null;
        }

        if(timerDuration <= 0)
        {
            tutorialMenu.SetActive(false);
            gameMenu.SetActive(true);
            isInTutorial = false;
        }
    }
}
