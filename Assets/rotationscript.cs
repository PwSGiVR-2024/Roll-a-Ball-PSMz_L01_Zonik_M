using UnityEngine;

public class rotationscript : MonoBehaviour
{
    public float rotationSpeed = 40f;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
