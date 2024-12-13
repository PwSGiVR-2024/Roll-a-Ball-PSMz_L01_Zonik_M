using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class Collectable : MonoBehaviour
{
    // Globalny dostêp do movementController
    protected movementController controller;
    protected GameController gameController;

    public int points = 1; 
    public string collectableName = "Collectable";
    public Boolean reverseMovement = false;

    protected virtual void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            controller = player.GetComponent<movementController>();
            gameController = player.GetComponent<GameController>();
        }
    }

    public virtual void OnCollect(Collider colider)
    {
        BaseLogic();
        print("collectable name"+ collectableName);
        // Perform different actions based on collectableName
        switch (collectableName)
        {
            case "CollectablePoints":
                gameController.score += points;  // Add points for a coin
                break;
            case "CollectableReverse":
                controller.ReverseMovement(reverseMovement);
                break;
            case "CollectableAddSpeed":
                controller.AddSpeed(200f);
                break;

            default:
                gameController.score += points;  // Default behavior for unknown collectable
                break;
        }

        // Update the UI with the new score
        gameController.txt.text = "CURRENT SCORE: " + gameController.score;
        gameController.printScore();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollect(other);
        }
    }

    private void BaseLogic()
    {
        if (controller == null)
        {
            Debug.LogError("movementController is not assigned.");
            return;
        }

        AudioSource audioSource = GameObject.Find("Collectable").GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
    public void SetCollectableName(string name)
    {
        collectableName = name;
    }
}
