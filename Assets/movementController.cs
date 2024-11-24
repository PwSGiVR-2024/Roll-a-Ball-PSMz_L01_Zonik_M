using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class movementController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    public float m_special_Thrust = 200f;
    public Text txt;
    public bool specialForce = false;

    public Vector3 direction;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
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
        if (specialForce)
        {
            m_Rigidbody.AddForce(direction.normalized * m_special_Thrust);
            specialForce = false;
        }
        m_Rigidbody.AddForce(direction.normalized * m_Thrust);
        

    }

    public void printScore()
    {
        print("current score" + score);

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
}
