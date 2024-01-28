using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthController : MonoBehaviour
{
    public UnityEvent OnDamageTaken;
    public UnityEvent OnDeath;

    [SerializeField] private int _health = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.ASTEROID))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int amount)
    {
        _health -= amount;
        OnDamageTaken.Invoke();

        if (_health <= 0 )
        {
            OnDeath.Invoke();
            Destroy(gameObject);
        }
    }

    public int GetHealth()
    { 
        return _health; 
    }

}
