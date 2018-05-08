using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCredits : MonoBehaviour {

    public void callMe()
    {
        SceneManager.LoadScene("Credits");
        //Application.Quit();
    }
}
