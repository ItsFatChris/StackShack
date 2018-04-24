using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour {


    public void callMe()
    {
        SceneManager.LoadScene("Level2");
        //Application.Quit();
    }
}
