using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_2 : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyPrefab;
    [SerializeField] private float _startTimeSpawn;
    [SerializeField] private float _descreaseTime;


    private float _spawnTime;
    private float _minTime = 0.65f;

    private void Update()
    {
        if (_spawnTime <= 0)
        {
            int rand = Random.Range(0, _enemyPrefab.Length);
            Instantiate(_enemyPrefab[rand], transform.position, Quaternion.identity);
            _spawnTime = _startTimeSpawn;
            if (_startTimeSpawn >= _minTime)
                _startTimeSpawn -= _descreaseTime;
        }
        else
            _spawnTime -= Time.deltaTime;
    }
}
