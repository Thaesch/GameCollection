using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBMovement : MonoBehaviour
{

    [SerializeField] private WBrush brush;
    [SerializeField] private int moveSteps = 20;

    private Vector3 goalPosition;
    private Vector3 rotationAxis;
    private Coroutine moveRoutine;
    private bool moving;


    void Update()
    {
        if(!moving)
        {
            CheckMovementInput();
        }
    }

    private void CheckMovementInput()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxisRaw("Vertical");
        if (hMove > 0.5f)
        {
            goalPosition = transform.position + Vector3.right;
            rotationAxis = Vector3.back;
            StartMovement();
        }
        else if (hMove < -0.5f)
        {
            goalPosition = transform.position + Vector3.left;
            rotationAxis = Vector3.forward;
            StartMovement();
        }
        else if (vMove > 0.5f)
        {
            goalPosition = transform.position + Vector3.forward;
            rotationAxis = Vector3.right;
            StartMovement();
        }
        else if (vMove < -0.5f)
        {
            goalPosition = transform.position + Vector3.back;
            rotationAxis = Vector3.left;
            StartMovement();
        }

    }

    void StartMovement()
    {
        if(moveRoutine != null)
        {
            StopCoroutine(moveRoutine);
        }
        moveRoutine = StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        moving = true;
        Vector3 startPosition = transform.position;
        int steps = moveSteps;


        for(int step = 0; step <= steps; step++)
        {
            transform.position = startPosition + (goalPosition - startPosition) * ((float)step) / steps;
            transform.Rotate(rotationAxis, 90.0f / (steps + 1), Space.World);
            yield return new WaitForSeconds(0.03f);
        }
        yield return null;
        brush.CreateTile();
        moving = false;
    }

}
