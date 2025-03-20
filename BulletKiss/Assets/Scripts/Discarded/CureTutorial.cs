using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureTutorial : MonoBehaviour
{
    public GameObject curePanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            curePanel.SetActive(true);
            PauseMenu.isPaused = true;
            FinishGame.isFinished = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void ResumeButton()
    {
        curePanel.SetActive(false);
        Time.timeScale = 1.0f;
        PauseMenu.isPaused = false;
        FinishGame.isFinished = false;
    }
}
