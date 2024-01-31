using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovementController : MonoBehaviour
{
    [SerializeField] private float _minMoveSpeed = 5f;
    [SerializeField] private float _maxMoveSpeed = 10f;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(0, -Random.Range(_minMoveSpeed, _maxMoveSpeed));
    }
}
