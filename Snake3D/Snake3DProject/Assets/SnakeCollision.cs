using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeCollision : MonoBehaviour
{
    [SerializeField] private SnakeBodyCreation creation;

    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Head": break;
            case "Body": BodyCollision(); break;
            case "Apple": AppleCollision(other.gameObject); break;
            case "Wall": WallCollision();  break;
            default: break;
        }
    }

    private void WallCollision()
    {
        Destroy(gameObject);
    }

    private void AppleCollision(GameObject appleObject)
    {
        // Add Body
        creation.AddBody();
        Destroy(appleObject);
    }

    private void BodyCollision()
    {
        Destroy(gameObject);
    }
}
