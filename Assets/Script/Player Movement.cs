using UnityEngine; // Gives access to all Unity features and classes

public class PlayerMovement : MonoBehaviour // MonoBehaviour lets this script attach to a Unity GameObject
{
    // How fast the character moves - can be adjusted with Inspector
    public float speed = 5f;

    // Stores a reference to the Rigidbody component attached to this character
    private Rigidbody rb;

    void Start() // Start runs once when the game begins
    {
        // Find and store the Rigidbody component attached to this same GameObject
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() // FixedUpdate runs on a fixed timer - better for physics than Update()
    {
        // Get horizontal input (-1 for left, 1 for right, 0 for nothing)
        float moveX = Input.GetAxis("Horizontal");

        // Get vertical input (Same as above)
        float moveZ = Input.GetAxis("Vertical");

        // Combine the two inputs into a single 3D direction vector
        // Y is 0 to keep the character from moving up or down
        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        // Move the Rigidbody to a new position based on direction, speed and time
        // Time.deltaTime keeps movement consistent regardless of frame rate
        rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }
}