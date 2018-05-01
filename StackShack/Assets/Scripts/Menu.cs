using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(4);
    }

    public void Credits()
    {
        SceneManager.LoadScene(5);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void lvl1()
    {
        SceneManager.LoadScene(1);
    }

    public void lvl2()
    {
        SceneManager.LoadScene(2);
    }

    public void lvl3()
    {
        SceneManager.LoadScene(3);
    }
}
