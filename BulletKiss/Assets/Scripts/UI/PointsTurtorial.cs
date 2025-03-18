using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsTurtorial : MonoBehaviour
{
    public GameObject pointsPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            pointsPanel.SetActive(true);
            PauseMenu.isPaused = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void ResumeButton()
    {
        pointsPanel.SetActive(false);
        Time.timeScale = 1.0f;
        PauseMenu.isPaused = false;
    }
}
