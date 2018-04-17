using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void CallMe()
    {
        SceneManager.LoadScene("HandTest");
        //Application.Quit();
    }
}
