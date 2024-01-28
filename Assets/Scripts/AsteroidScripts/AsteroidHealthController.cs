using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AsteroidHealthController : MonoBehaviour
{
    public UnityEvent OnDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.FINISH))
        {
            OnDeath.Invoke();
            Destroy(gameObject);
        }

        if (collision.CompareTag(Tags.PLAYER))
        {
            Destroy(gameObject);
        }
    }
}
