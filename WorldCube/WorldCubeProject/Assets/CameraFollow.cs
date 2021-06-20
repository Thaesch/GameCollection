using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform toFollow;


    void Update()
    {
        if(toFollow)
        {
            transform.position = Vector3.Lerp(transform.position, toFollow.position + Vector3.up * 15 + Vector3.back * 5, 0.1f);
        }
    }
}
