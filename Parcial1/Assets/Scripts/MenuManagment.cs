using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagment : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play ()
    {
        SceneManager.LoadScene(2);
    }

    public void Proto ()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void Menu ()
    {
        SceneManager.LoadScene(0);
    }

    public void Continue ()
    {
        Time.timeScale = 1;
    }


}