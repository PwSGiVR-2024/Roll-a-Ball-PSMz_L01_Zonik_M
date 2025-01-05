using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //OnTriggerEnter();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("halo jestem");
        if (other.CompareTag("Player"))
        {
            print("halo jestem");

            print("koniec");
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1, LoadSceneMode.Single);
        }
    }
}
