using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{

    [SerializeField] private float minSpawnTime;
    [SerializeField] private float maxSpawnTime;
    [SerializeField] private GameObject applePrototype;

    private float lastAppleSpawnTime;
    private float nextSpawnTime;

    void Update()
    {
        if(Time.time > lastAppleSpawnTime + nextSpawnTime)
        {
            Instantiate(applePrototype, new Vector3(
                Random.Range(-10, 10),
                0.75f,
                Random.Range(-10, 10)
                ), Quaternion.identity).SetActive(true);
            lastAppleSpawnTime = Time.time;
            nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
