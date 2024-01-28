using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : Spawner
{
    [SerializeField] private List<GameObject> _pickupPrefabs;
    [Range(0f, 1f)]
    [SerializeField] private float _pickupSpawnProbability = 0.3f;

    protected override void Spawn(int amountToSpawn)
    {
        if (DecideToSpawnPickup())
        {
            // can spawn only 1 pickup
            base.Spawn(1);
        }
    }

    private bool DecideToSpawnPickup()
    {
        float randomNumber = Random.Range(0f, 1f);
        Debug.Log(randomNumber);

        if (randomNumber > _pickupSpawnProbability)
        {
            return false;
        }
        else
        {
            _objectToSpawn = _pickupPrefabs[Random.Range(0, _pickupPrefabs.Count)];
            return true;
        }
    }
}
