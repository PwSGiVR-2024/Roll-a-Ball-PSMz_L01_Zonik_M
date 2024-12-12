using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class movementController : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    public float m_special_Thrust = 200f;
    public bool specialForce = false;
    Boolean reverse = false;

    public Vector3 direction;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        movement();
       

    }

    void FixedUpdate()
    {
        addForce();   
    }


    public void addForce()
    {
        Vector3 adjustedDirection = reverse ? -direction : direction; 
        if (specialForce)
        {
            m_Rigidbody.AddForce(adjustedDirection.normalized * m_special_Thrust);
            specialForce = false;
        }
        m_Rigidbody.AddForce(adjustedDirection.normalized * m_Thrust);
    }


    public void movement()
    {
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += -Vector3.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector3.right;
        } 
        if (Input.GetKey(KeyCode.Space))
        {
            direction += Vector3.up;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            direction += Vector3.forward;
            specialForce = true;
        }
    }

    public void reverseMovement(bool reverseStatus)
    {
        reverse = reverseStatus;
    }

    public void addSpped(float additionalSpped)
    {
        m_Thrust += additionalSpped;
    }
}
