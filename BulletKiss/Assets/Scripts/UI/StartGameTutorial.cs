using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameTutorial : MonoBehaviour
{
    public GameObject startGamePanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            startGamePanel.SetActive(true);
            PauseMenu.isPaused = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void ResumeButton()
    {
        startGamePanel.SetActive(false);
        Time.timeScale = 1.0f;
        //PauseMenu.isPaused = false;
    }
    public void StartGameButton()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1.0f;
        PauseMenu.isPaused = false;
        LifeBar.lifeValue = 100f;
        PointsText.points = 0;
    }
}
