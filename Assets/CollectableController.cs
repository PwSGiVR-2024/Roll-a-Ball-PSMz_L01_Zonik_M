using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CollectableController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(23 , 11,44)* Time.deltaTime);

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    gameObject.SetActive(false);
    //    collision.gameObject.GetComponent<movementController>().score += 1;


    //    print("hejka");
    //}


    private void OnTriggerEnter(Collider other)
    {

        other.gameObject.GetComponent<movementController>().score += 1;
        other.gameObject.GetComponent<movementController>().txt.text = "CURRENT SCORE: " + other.gameObject.GetComponent<movementController>().score;


        other.gameObject.GetComponent<movementController>().printScore();

        if(other.gameObject.GetComponent<movementController>().score == 8){
            print("wszystkie punkty zaebrane!");
        }


        gameObject.SetActive(false);

    }

}
