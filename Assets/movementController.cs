using Unity.VisualScripting;
using UnityEngine;

public class movementController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    public Vector3 direction;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = - Vector3.forward;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right;
        }
    }

    void FixedUpdate()
    {
        addForce();   
    }


    public void addForce()
    {
        m_Rigidbody.AddForce(direction * m_Thrust);
        direction = Vector3.zero;

    }

    public void printScore()
    {
        print("current score" + score);
    }
}
