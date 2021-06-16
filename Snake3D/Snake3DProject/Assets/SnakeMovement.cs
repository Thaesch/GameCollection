using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{


    [SerializeField] private float moveSpeed;

    private Vector3 moveDirection;


    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        moveDirection = Vector3.Lerp(moveDirection, new Vector3(xMove, 0, yMove), 0.1f);

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
        if (moveDirection.magnitude > 0.1f)
            transform.LookAt(transform.position + moveDirection, Vector3.up);
    }
}
