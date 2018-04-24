using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel3 : MonoBehaviour {

    // Use this for initialization

    public void callMe()
    {
        SceneManager.LoadScene("Level3");
        //Application.Quit();
    }
}
