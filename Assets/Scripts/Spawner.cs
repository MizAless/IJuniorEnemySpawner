using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnCooldown;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        var spawnCooldown = new WaitForSeconds(_spawnCooldown);

        while (enabled)
        {
            SpawnEnemy();
            yield return spawnCooldown;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = GetRandomSpawnPosition();
        Vector3 randomDirection = GetRandomDirection();

        Enemy spawnedEnemy = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
        spawnedEnemy.Init(randomDirection);
    }

    private Vector3 GetRandomSpawnPosition()
    {
        int randomPointIndex = Random.Range(0, _spawnPoints.Count);
        return _spawnPoints[randomPointIndex].transform.position; 
    }

    private Vector3 GetRandomDirection()
    {
        int maxAngle = 360;
        float randomAngle = Random.Range(0, maxAngle);
        return Quaternion.Euler(0, randomAngle, 0) * Vector3.forward;
    }
}
