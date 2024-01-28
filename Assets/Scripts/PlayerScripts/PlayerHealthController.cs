using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthController : MonoBehaviour
{
    public UnityEvent OnHealthChanged;
    public UnityEvent OnDeath;

    [SerializeField] private int _maxHealth = 3;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.ASTEROID))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        OnHealthChanged.Invoke();

        if (_currentHealth <= 0 )
        {
            OnDeath.Invoke();
            Destroy(gameObject);
        }
    }

    public void AddHealth(int amount)
    {
        _currentHealth += amount;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        OnHealthChanged.Invoke();
    }

    public int GetHealth()
    { 
        return _currentHealth; 
    }

}
