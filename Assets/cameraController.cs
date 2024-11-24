using JetBrains.Annotations;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    private Transform player;
    Vector3 offest;
    public GameObject Player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
                //a =    b                     -c
        Vector3 offest = transform.position - player.transform.position;

    }

    void Update()
    {
        transform.position = offest + player.transform.position + new Vector3(0,3,-4);
    }
}
