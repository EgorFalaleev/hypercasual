using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealthController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.FINISH))
        {
            Destroy(gameObject);
        }
    }
}
