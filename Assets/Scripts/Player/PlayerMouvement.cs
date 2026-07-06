using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouvement : MonoBehaviour
{
    [SerializeField] private float playerMoveSpeed = 4f;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.linearVelocity = moveInput * playerMoveSpeed;
    }

    public void Move (InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
