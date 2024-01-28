using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour, IPickup
{
    [SerializeField] private int _healthAmount = 1;

    private PlayerHealthController _playerHealthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.PLAYER))
        {
            _playerHealthController = collision.GetComponent<PlayerHealthController>();
            ApplyEffect();
            Destroy(gameObject);
        }

        if (collision.CompareTag(Tags.FINISH))
        {
            Destroy(gameObject);
        }
    }

    public void ApplyEffect()
    {
        if (_playerHealthController != null)
        {
            _playerHealthController.AddHealth(_healthAmount);
        }
    }
}
