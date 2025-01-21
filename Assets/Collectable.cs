using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class Collectable : MonoBehaviour
{
    protected movementController controller;
    protected GameController gameController;
    protected GameManager gameManager;
    public event Action pickupEvent;
    public int points = 1;
    public string collectableName = "Collectable";

    public float rotationSpeed = 50f; 

    protected virtual void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            controller = player.GetComponent<movementController>();
            gameController = player.GetComponent<GameController>();
            gameManager = player.GetComponent<GameManager>();
        }
    }

    protected virtual void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    public abstract void ApplyEffect();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

    private void Collect()
    {

        if (controller == null || gameManager == null)
        {
            Debug.LogError("Controller or GameController is not assigned.");
            return;
        }

        ApplyEffect();
        if (pickupEvent != null) pickupEvent();

        AudioSource audioSource = GameObject.Find("Collectable").GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
        }

    }


    private string myVar;

    public string MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }


}
