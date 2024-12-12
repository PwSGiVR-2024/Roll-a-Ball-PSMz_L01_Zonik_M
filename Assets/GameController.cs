using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    public Text txt;


    void Start()
    {
        
    }

    void Update()
    {
        if (score > 15)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1, LoadSceneMode.Single);
        }

    }
    public void printScore()
    {
        print("current score" + score);

    }
}
