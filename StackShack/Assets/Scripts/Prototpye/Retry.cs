using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {

   
  

    public void changeSceneTo(string s)
    {
        Debug.Log("HAAH");
        SceneManager.LoadScene(s);
    }

}
