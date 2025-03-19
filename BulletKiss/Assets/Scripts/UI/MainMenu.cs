using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Play button begins the game
    public void PlayButton()
    {
        SceneManager.LoadScene("Tutorial");
        Time.timeScale = 1.0f;
        LifeBar.lifeValue = 100f;
    }
    //Credits button send you to the Credits Scene
    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1.0f;
    }
    //Quit button close the game
    public void ExitButton()
    {
        Application.Quit();
    }
    //Back button send you from the credits scene to the main menu
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
    }
}
