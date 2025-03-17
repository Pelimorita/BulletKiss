using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    public GameObject finishPanel;
    private void Update()
    {
        if (LifeBar.lifeValue < 0)
        {
            Time.timeScale = 0;
            finishPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void FinishButton()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1.0f;
        PauseMenu.isPaused = false;
    }
}
