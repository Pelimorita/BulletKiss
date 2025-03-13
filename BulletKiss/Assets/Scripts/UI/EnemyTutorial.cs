using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTutorial : MonoBehaviour
{
    public GameObject enemyPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            enemyPanel.SetActive(true);
            PauseMenu.isPaused = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void ResumeButton()
    {
        enemyPanel.SetActive(false);
        Time.timeScale = 1.0f;
        PauseMenu.isPaused = false;
    }
}
