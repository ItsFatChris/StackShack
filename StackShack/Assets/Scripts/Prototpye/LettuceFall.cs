using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettuceFall : MonoBehaviour {

    int way = 1;
    int moveSpeed = 2;
    public Rigidbody2D m_Movement;



	// Use this for initialization
	void Start () {

        InvokeRepeating("switchWay", 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 moveMe = transform.right * 2 * moveSpeed * way * Time.deltaTime;  //create the vector 
        m_Movement.MovePosition(m_Movement.position + moveMe);  //apply the vector to the object

    }


    private void switchWay()
    {

        if(way ==1)
        {
            way = -1;
        }
        else
        {
            way = 1;
        }
    }

}
