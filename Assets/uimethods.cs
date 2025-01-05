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

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
