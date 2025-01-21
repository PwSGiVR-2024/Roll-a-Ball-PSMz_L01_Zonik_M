using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    [SerializeField]
    private GameObject[] points; 

    [SerializeField]
    private int maxPoints; 

    [SerializeField]
    private textHandler textHandler; 

    void Start()
    {
        points = GameObject.FindGameObjectsWithTag("Collectable");

        maxPoints = points.Length;

        foreach (GameObject obj in points)
        {

            Collectable collectable = obj.GetComponent<Collectable>();
            if (collectable != null)
            {
                collectable.pickupEvent += OnCollectablePickedUp;
            }
        }

    }

   
    void OnValidate()
    {
        points = GameObject.FindGameObjectsWithTag("Collectable");

        maxPoints = points.Length;
    }

    private void OnCollectablePickedUp()
    {
        textHandler.addPoints();
       
        
    }

}
