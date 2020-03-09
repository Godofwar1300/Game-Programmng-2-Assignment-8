using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }

        DontDestroyOnLoad(instance);
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

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}
