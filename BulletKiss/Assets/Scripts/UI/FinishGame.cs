using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FinishGame : MonoBehaviour
{
    public GameObject finishPanel;
    public static bool isFinished;
    public TMP_Text finalMessage;
    private void Awake()
    {
        isFinished = false;
    }
    private void Start()
    {
        finishPanel.SetActive(false);
    }
    private void Update()
    {
        if (LifeBar.lifeValue <= 0)
        {
            Time.timeScale = 0;
            finishPanel.SetActive(true);
            isFinished = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Debug.Log("esto es FinishGame" + isFinished);
            finalMessage.text = "Only " + PointsText.points + " points? Wow! You should uninstall me, so you don't have to touch me again";
        }
    }
    public void FinishButton()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1.0f;
    }
}
