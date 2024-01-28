using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupMovementController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(0, -_moveSpeed);
    }
}
