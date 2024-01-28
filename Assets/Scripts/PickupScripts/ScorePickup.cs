using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : ScoreObject, IPickup
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.PLAYER))
        {
            ApplyEffect();
            Destroy(gameObject);
        }
    }

    public void ApplyEffect()
    {
        ModifyScore();
    }
}
