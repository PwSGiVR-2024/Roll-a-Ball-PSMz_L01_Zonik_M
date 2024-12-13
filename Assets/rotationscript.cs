using UnityEngine;

public class rotationscript : MonoBehaviour
{
    public float rotationSpeed = 40f; // Public variable to set the rotation speed in the Inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Optional initialization if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the Y-axis at the specified speed
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
