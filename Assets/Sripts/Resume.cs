using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                resume();
            } else
            {
                Pause();
            }
        }
    }
    public void resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Home(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("awal");
    }

    public void Quit(){
        Debug.Log("QUIT");
        Application.Quit();         
        
    }
}
