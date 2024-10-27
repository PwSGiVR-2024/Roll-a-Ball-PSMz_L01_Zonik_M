using JetBrains.Annotations;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    Vector3 offest;
    public GameObject Player;
    void Start()
    {
                //a =    b                     -c
        Vector3 offest = transform.position - Player.transform.position;

    }

    void Update()
    {
        transform.position = offest + Player.transform.position + new Vector3(0,3,-4);
    }
}
