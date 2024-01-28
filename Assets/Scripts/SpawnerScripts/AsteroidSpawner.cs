using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : Spawner
{
    [SerializeField] private GameObject _asteroidPrefab;

    protected override void Start()
    {
        base.Start();
        _objectToSpawn = _asteroidPrefab;
    }
}
