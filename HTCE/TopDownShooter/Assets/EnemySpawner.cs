using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrototype;
    [SerializeField] private float spawnRate;
    [SerializeField] private Vector2 spawnBounds;



    private float lastSpawnTime;

    void Update()
    {
        if(Time.time > lastSpawnTime + spawnRate)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            SpawnEnemy(spawnPosition);
            lastSpawnTime = Time.time;
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {

        return new Vector3(
            UnityEngine.Random.Range(spawnBounds.x, spawnBounds.y),
            1,
            UnityEngine.Random.Range(spawnBounds.x, spawnBounds.y));

    }

    private void SpawnEnemy(Vector3 spawnPosition)
    {
        Instantiate(enemyPrototype, spawnPosition, Quaternion.identity).SetActive(true);
    }
}
