using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _asteroidPrefab;
    [SerializeField] private float _spawnCooldownInSeconds = 1f;
    [Range(1, 3)]
    [SerializeField] private int _numberOfAsteroidsToSpawn = 1;

    private float _timer = 0f;
    private Vector2 _screenBounds;

    void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _spawnCooldownInSeconds)
        {
            SpawnAsteroids(_numberOfAsteroidsToSpawn);
            _timer = 0f;
        }
    }

    private void SpawnAsteroids(int amountToSpawn)
    {
        for (int i = 0; i < _numberOfAsteroidsToSpawn; i++)
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
