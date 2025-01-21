using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    public Text txt2;
    private float elapsedTime;

    void Start()
    {
        elapsedTime = 0f;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        txt2.text = "Time: " + Mathf.Floor(elapsedTime).ToString() + "s";

    }
 

}
