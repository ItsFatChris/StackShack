using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitSpeed : MonoBehaviour {


    public float maxSpeed = 5f;
    public Rigidbody2D m_Rigid;


    private void FixedUpdate()
    {
        if(m_Rigid.velocity.magnitude > maxSpeed)
        {
            m_Rigid.velocity = m_Rigid.velocity.normalized * maxSpeed;
        }
    }
}
