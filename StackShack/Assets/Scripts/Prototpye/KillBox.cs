using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {


    private static int deaths = 0;


	// Use this for initialization
	void Start () {
        deaths = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        deaths++;
        
    }

    public int getDeaths()
    {
        return deaths;

    }

    
}
