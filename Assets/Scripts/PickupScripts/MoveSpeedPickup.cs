using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeedPickup : MonoBehaviour, IPickup
{
    [SerializeField] private float _moveSpeedIncreaseAmount = 0.3f;

    private PlayerMovementController _playerMovementController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.PLAYER))
        {
            _playerMovementController = collision.GetComponent<PlayerMovementController>();
            ApplyEffect();
            Destroy(gameObject);
        }
    }

    public void ApplyEffect()
    {
        if (_playerMovementController != null)
        {
            _playerMovementController.ModifyMoveSpeed(_moveSpeedIncreaseAmount);
        }
    }
}
