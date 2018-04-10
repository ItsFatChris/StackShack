using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour {

    private Rigidbody2D m_Movement;
    private string movementAxisName;
    private float movementInputValue;
    private float speed = 15f;
    private float moveSpeed = 5f;
    private static bool canMove = true;


    private void Awake()
    {
        m_Movement = GetComponent<Rigidbody2D>(); //get the rigidbody we will be influencing
    }


    // Use this for initialization
    void Start () {
        movementAxisName = "Horizontal";  //set the axis name
    }
	
	// Update is called once per frame
	void Update () {
        movementInputValue = Input.GetAxis(movementAxisName);  //get the value of the axis from the axis name
        Move();  //call the move method
    }

    private void Move()
    {
        if (canMove == true)
        {
            Vector2 moveMe = transform.right * 2 * moveSpeed * movementInputValue * Time.deltaTime;  //create the vector 
            m_Movement.MovePosition(m_Movement.position + moveMe);  //apply the vector to the object



        }
        /*
        if(movementInputValue >0.1 )
        {
            //rotate right

            m_Movement.MoveRotation(m_Movement.rotation - 4* speed* movementInputValue * Time.deltaTime);
            if(m_Movement.rotation < -15)
            {
                m_Movement.MoveRotation(-15);
            }
        }
        else if(movementInputValue < -0.1)
        {
            //rotate left
            m_Movement.MoveRotation(m_Movement.rotation -4* speed *movementInputValue * Time.deltaTime);
            if (m_Movement.rotation > 15)
            {
                m_Movement.MoveRotation(15);
            }
        }
        else
        {
            //flatten hand out
            if (m_Movement.rotation > 0.2)
            {
                m_Movement.MoveRotation(m_Movement.rotation - 8*speed  * Time.deltaTime);
            }
            else if(m_Movement.rotation < 0.2)
            {
                m_Movement.MoveRotation(m_Movement.rotation + 8*speed * Time.deltaTime);
            }
            
 

           
        }
        */

    }

    public void setCanMove(bool b)
    {
        canMove = b;
    }
}
