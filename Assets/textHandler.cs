using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class textHandler : MonoBehaviour
{
    public Text txt;
    public Text txt2;
    public GameObject player;
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
    public void addPoints()
    {
        int score2 = player.GetComponent<GameManager>().score;

        txt.text = "Score: " + score2;
    }
}
