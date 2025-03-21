using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPanel;
    [SerializeField] private GameObject curePanel;
    [SerializeField] private GameObject pointsPanel;
    [SerializeField] private GameObject startPanel;
    private void Awake()
    {
        PauseMenu.isPaused = false;
        FinishGame.isFinished = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) enemyPanel.SetActive(true);
        else if (other.gameObject.CompareTag("Cure")) curePanel.SetActive(true);
        else if (other.gameObject.CompareTag("Points")) pointsPanel.SetActive(true);
        else if (other.gameObject.CompareTag("Start"))
        {
            startPanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) enemyPanel.SetActive(false);
        else if (other.gameObject.CompareTag("Cure")) curePanel.SetActive(false);
        else if (other.gameObject.CompareTag("Points")) pointsPanel.SetActive(false);
        else if (other.gameObject.CompareTag("Start"))
        {
            startPanel.SetActive(false);
        }
    }
    public void StartGameButton()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1.0f;
        LifeBar.lifeValue = 100f;
        PointsText.points = 0;
        FinishGame.isFinished = false;
        PauseMenu.isPaused = false;
    }
}
