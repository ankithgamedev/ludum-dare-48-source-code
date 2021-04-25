using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public void Restart()
    {
        int currentindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentindex);

    }

    public void StartTheGame()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void AboutUs()
    {
        SceneManager.LoadScene("about");
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }
}
