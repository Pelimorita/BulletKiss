using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("Pause Menu Panel")]
    public GameObject pausePanel;
    public static bool isPaused = false;
    //First, we check if button escape is pushed
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && FinishGame.isFinished == false) 
        {
            if (isPaused)
            {
                ResumeButton();
            }
            else 
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        //We stop the time and active the pause panel
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;    
        Cursor.visible = true;
    }
    //Resume button continue with the game and the time scale is 1f again
    public void ResumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false;
    }
    //Main Menu button send the player to the main menu
    public void GotoMainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
        isPaused = false;
    }

}
