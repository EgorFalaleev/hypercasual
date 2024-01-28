using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _asteroidPrefab;
    [SerializeField] private float _minSpawnCooldownInSeconds = 0.5f;
    [SerializeField] private float _maxSpawnCooldownInSeconds = 1.5f;
    [SerializeField] private int _minNumberOfAsteroidsToSpawn = 1;
    [SerializeField] private int _maxNumberOfAsteroidsToSpawn = 3;

    private float _timer = 0f;
    private Vector2 _screenBounds;
    private int _numberOfAsteroidsToSpawn = 0;
    private float _timeTillNextAsteroidInSeconds = 1f;

    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _timeTillNextAsteroidInSeconds)
        {
            // randomize number of spawned asteroids
            _numberOfAsteroidsToSpawn = Random.Range(_minNumberOfAsteroidsToSpawn, _maxNumberOfAsteroidsToSpawn + 1);
            
            SpawnAsteroids(_numberOfAsteroidsToSpawn);

            // randomize spawn cooldown
            _timeTillNextAsteroidInSeconds = Random.Range(_minSpawnCooldownInSeconds, _maxSpawnCooldownInSeconds);

            _timer = 0f;
        }
    }

    private void SpawnAsteroids(int amountToSpawn)
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            Instantiate(_asteroidPrefab, GenerateRandomPosition(), Quaternion.identity);
        }
    }

    private Vector2 GenerateRandomPosition()
    {
        // generate position above the screen within its width
        return new Vector2(Random.Range(-_screenBounds.x, _screenBounds.x), _screenBounds.y * 1.5f);
    }
}
