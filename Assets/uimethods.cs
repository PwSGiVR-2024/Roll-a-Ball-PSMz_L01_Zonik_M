using UnityEngine;
using UnityEngine.SceneManagement;

public class uimethods : MonoBehaviour
{
    

    public void startGame()
    {
        print("test");
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
