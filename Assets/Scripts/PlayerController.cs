using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 10.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Left and right inputs
        horizontalInput = Input.GetAxis("Horizontal");
        // Forward and back inputs
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle left or right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
