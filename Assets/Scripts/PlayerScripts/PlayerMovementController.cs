using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    private PlayerInput _playerInput;
    private InputAction _moveAction;
    private Rigidbody2D _rb;
    private Vector2 _moveDirection;

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody2D>();

        _moveAction = _playerInput.actions["Move"];
    }

    void Update()
    {
        // read direction from joystick
        _moveDirection = _moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Move(_moveDirection, _moveSpeed * Time.fixedDeltaTime);
    }

    private void Move(Vector2 direction, float speed)
    {
        _rb.velocity = direction * speed;
    }
}
