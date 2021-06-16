using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : MonoBehaviour
{

    [SerializeField] private Transform previousBodyPart;

    public void Init(Transform previous)
    {
        previousBodyPart = previous;
        transform.position = previous.position + Vector3.up * 2f;
    }


    void Update()
    {
        if(!previousBodyPart)
        {
            Destroy(gameObject);
            return;
        }
        if(Vector3.Distance(transform.position, previousBodyPart.position) > 1)
        {
            transform.Translate((previousBodyPart.position - transform.position) * 3 * Time.deltaTime);
        }
    }
}
