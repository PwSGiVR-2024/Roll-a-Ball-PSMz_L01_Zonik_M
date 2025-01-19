using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] points; // Tablica obiektów z tagiem "Collectable"

    [SerializeField]
    private int maxPoints; // Liczba wszystkich obiektów "Collectable"

    [SerializeField]
    private textHandler textHandler; // Referencja do komponentu textHandler

    void Start()
    {
        // ZnajdŸ wszystkie obiekty z tagiem "Collectable"
        points = GameObject.FindGameObjectsWithTag("Collectable");

        // Zaktualizuj liczbê obiektów
        maxPoints = points.Length;

        // Debug - wypisz wszystkie obiekty i ich liczbê
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

        Debug.Log("£¹czna liczba punktów: " + maxPoints);
    }

    void OnValidate()
    {
        // ZnajdŸ wszystkie obiekty w edytorze podczas edycji
        points = GameObject.FindGameObjectsWithTag("Collectable");

        // Zaktualizuj liczbê obiektów
        maxPoints = points.Length;
    }

    private void OnCollectablePickedUp()
    {
        Debug.Log("Zdarzenie pickupEvent zosta³o wywo³ane!");
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
