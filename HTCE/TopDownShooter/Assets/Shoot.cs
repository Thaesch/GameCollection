using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrototype;
    [SerializeField] private float spawnRate;

    private float lastSpawnTime;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time > lastSpawnTime + spawnRate)
            {
                lastSpawnTime = Time.time;
                Vector3 direction = GetDirection(Input.mousePosition);
                SpawnBullet(direction);
            }
        }
    }

    private Vector3 GetDirection(Vector3 mousePosition)
    {

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(mouseRay, out hit))
        {
            return hit.point - transform.position;
        }

        return transform.forward;
    }

    private void SpawnBullet(Vector3 direction)
    {
        Instantiate(bulletPrototype, transform.position, Quaternion.LookRotation(direction, Vector3.up)).SetActive(true);
    }
}
