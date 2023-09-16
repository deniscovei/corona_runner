using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
    public void PlayGame ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void Easy ()
    {
        AruncaCovizi.initialRate = 5f;
    }

    public void Normal ()
    {
        AruncaCovizi.initialRate = 2f;
    }

    public void Hard ()
    {
        AruncaCovizi.initialRate = 0.5f;
    }
}
