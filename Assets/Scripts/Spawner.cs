using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_enemyPrefab);   
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elapsedTime = 0;
                _secondsBetweenSpawn = Random.Range(0.5f, _secondsBetweenSpawn);

                int spawnPointNumber = Random.Range(0, _spawnPoint.Length);

                SetEnemy(enemy, _spawnPoint[spawnPointNumber].position);
            }
        }
    }

    private void SetEnemy(GameObject enemy, Vector2 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
