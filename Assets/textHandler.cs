using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class textHandler : MonoBehaviour
{
    public Text txt;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addPoints()
    {
        int score = player.GetComponent<GameController>().score;
        txt.text = "Score: " + score;
    }
}
