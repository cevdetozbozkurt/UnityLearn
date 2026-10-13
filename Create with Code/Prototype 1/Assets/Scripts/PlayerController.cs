using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Movement tuning (editable in inspector)
    public float speed = 10.0f;
    public float turnSpeed;
    // Input System action exposed in inspector for binding (WASD/Arrow keys)
    public InputAction moveAction;
    // Current input value (x = left/right y = forward/backward), kept private for internal use
    private Vector2 moveInput;

    void OnEnable()
    {
        // Enable the moveAction variable so it starts reading input
        moveAction.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Read the 2D vector from moveAction x : vertical, y : horizontal
        moveInput = moveAction.ReadValue<Vector2>();
        
        // Move the vehicle forward/backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // Move the vehicle right/left
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);

    }
}
