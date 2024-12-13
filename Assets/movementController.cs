using System;
using UnityEngine;

public class movementController : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 30f;
    public float maxSpeed = 70f;

    public float wallSlideSpeed = 2f;
    public float gravityScale = 1.5f;

    private bool isWallSliding = false;
    public Vector3 direction;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.useGravity = false; // Custom gravity handling
    }

    void Update()
    {
        HandleInput();
        HandleWallSliding();
    }

    void FixedUpdate()
    {
        ApplyGravity();
        AddForce();
        LimitSpeed();
    }

    public void AddForce()
    {
        Vector3 adjustedDirection = direction.normalized;
        m_Rigidbody.AddForce(adjustedDirection * m_Thrust);
    }

    public void HandleInput()
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
    }

    void HandleWallSliding()
    {
        if (isWallSliding)
        {
            Vector3 wallSlide = new Vector3(0, -wallSlideSpeed, 0);
            m_Rigidbody.linearVelocity = new Vector3(m_Rigidbody.linearVelocity.x, wallSlide.y, m_Rigidbody.linearVelocity.z);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isWallSliding = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isWallSliding = false;
        }
    }

    void ApplyGravity()
    {
        if (!isWallSliding)
        {
            m_Rigidbody.AddForce(Physics.gravity * gravityScale, ForceMode.Acceleration);
        }
    }

    void LimitSpeed()
    {
        if (m_Rigidbody.linearVelocity.magnitude > maxSpeed)
        {
            m_Rigidbody.linearVelocity = m_Rigidbody.linearVelocity.normalized * maxSpeed;
        }
    }

    public void ReverseMovement(bool reverseStatus)
    {
        m_Thrust = reverseStatus ? -Mathf.Abs(m_Thrust) : Mathf.Abs(m_Thrust);
    }

    public void AddSpeed(float additionalSpeed)
    {
        m_Thrust += additionalSpeed;
    }
}
