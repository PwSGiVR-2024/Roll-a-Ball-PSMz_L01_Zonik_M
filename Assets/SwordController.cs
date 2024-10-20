using UnityEngine;

public class SwordController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            print("halo");
            transform.Rotate(new Vector3(0,100,20) * Time.deltaTime);
        }
    }
}
