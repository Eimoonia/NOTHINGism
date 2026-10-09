using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Necessary Components")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private InputActionReference moveAction;

    [Space]

    [Header("Variable Components")]
    [SerializeField] private float moveSpeed;
    private Vector2 movement;

    private void OnEnable()
    {
        moveAction.action.Enable();
    }
    private void OnDisable()
    {
        moveAction.action.Disable();
    }

    private void Update()
    {
        movement = moveAction.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}