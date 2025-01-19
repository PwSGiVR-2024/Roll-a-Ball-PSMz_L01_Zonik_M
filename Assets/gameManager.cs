using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] points; // Tablica obiekt�w z tagiem "Collectable"

    [SerializeField]
    private int maxPoints; // Liczba wszystkich obiekt�w "Collectable"

    [SerializeField]
    private textHandler textHandler; // Referencja do komponentu textHandler

    void Start()
    {
        // Znajd� wszystkie obiekty z tagiem "Collectable"
        points = GameObject.FindGameObjectsWithTag("Collectable");

        // Zaktualizuj liczb� obiekt�w
        maxPoints = points.Length;

        // Debug - wypisz wszystkie obiekty i ich liczb�
        foreach (GameObject obj in points)
        {
            Debug.Log("Znaleziono obiekt: " + obj.name);

            // Subskrybuj zdarzenie pickupEvent
            Collectable collectable = obj.GetComponent<Collectable>();
            if (collectable != null)
            {
                collectable.pickupEvent += OnCollectablePickedUp;
            }
        }

        Debug.Log("��czna liczba punkt�w: " + maxPoints);
    }

    void OnValidate()
    {
        // Znajd� wszystkie obiekty w edytorze podczas edycji
        points = GameObject.FindGameObjectsWithTag("Collectable");

        // Zaktualizuj liczb� obiekt�w
        maxPoints = points.Length;
    }

    private void OnCollectablePickedUp()
    {
        Debug.Log("Zdarzenie pickupEvent zosta�o wywo�ane!");
        textHandler.addPoints();
        print(textHandler.player.GetComponent<GameController>().score);
        print(maxPoints);
        if (textHandler.player.GetComponent<GameController>().score > maxPoints)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1, LoadSceneMode.Single);
        }
        
    }
}
