using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnedObjectsContainer;
    [SerializeField] protected float _minSpawnCooldownInSeconds = 0.5f;
    [SerializeField] protected float _maxSpawnCooldownInSeconds = 1.5f;
    [SerializeField] protected int _minNumberOfObjectsToSpawn = 1;
    [SerializeField] protected int _maxNumberOfObjectsToSpawn = 3;

    protected GameObject _objectToSpawn;
    protected float _timeTillNextObjectSpawnInSeconds = 1f;

    private float _timer = 0f;
    private Vector2 _screenBounds;
    private int _numberOfObjectToSpawn = 0;

    protected virtual void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _timeTillNextObjectSpawnInSeconds)
        {
            // randomize number of spawned asteroids
            _numberOfObjectToSpawn = Random.Range(_minNumberOfObjectsToSpawn, _maxNumberOfObjectsToSpawn + 1);

            Spawn(_numberOfObjectToSpawn);

            // randomize spawn cooldown
            _timeTillNextObjectSpawnInSeconds = Random.Range(_minSpawnCooldownInSeconds, _maxSpawnCooldownInSeconds);

            _timer = 0f;
        }
    }

    protected virtual void Spawn(int amountToSpawn)
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            GameObject newObject = Instantiate(_objectToSpawn, GenerateRandomPosition(), Quaternion.identity);

            newObject.transform.SetParent(_spawnedObjectsContainer);
        }
    }

    private Vector2 GenerateRandomPosition()
    {
        var spawnPosition = new Vector2(Random.Range(-_screenBounds.x, _screenBounds.x), _screenBounds.y * 1.5f);

        // find another spawn position if another object was spawned close
        while (!IsSpawnPointFree(spawnPosition))
        {
            spawnPosition = new Vector2(Random.Range(-_screenBounds.x, _screenBounds.x), _screenBounds.y * 1.5f);
        }
           
        return spawnPosition;
    }

    private bool IsSpawnPointFree(Vector2 spawnPosition)
    {
        var overlappingCollider = Physics2D.OverlapCircle(spawnPosition, 1f);

        if (overlappingCollider == null)
            return true;
        else
            return false;
    }
}
