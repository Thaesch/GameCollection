using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;



    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + new Vector3(0, 15, -10), 0.1f);
    }
}
