using Unity.VisualScripting;
using UnityEngine;

public class movementController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            m_Rigidbody.AddForce(Vector3.forward * m_Thrust);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Rigidbody.AddForce(-Vector3.forward * m_Thrust);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            m_Rigidbody.AddForce(Vector3.left * m_Thrust);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody.AddForce(Vector3.right * m_Thrust);
        }
    }


    public void printScore()
    {
        print("current score" + score);
    }
}
