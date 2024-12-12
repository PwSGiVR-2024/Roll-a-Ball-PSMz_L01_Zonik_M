using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
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

        GameObject.Find("Collectable").GetComponent<AudioSource>().Play();




        //gameObject.SetActive(false);

    }

}
