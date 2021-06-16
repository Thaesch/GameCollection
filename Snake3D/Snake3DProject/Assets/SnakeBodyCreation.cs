using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBodyCreation : MonoBehaviour
{

    [SerializeField] private BodyMovement bodyPrototype;

    private List<Transform> body;

    private void Start()
    {
        body = new List<Transform>();
    }

    public void AddBody()
    {
        BodyMovement nextBodyPart = Instantiate(bodyPrototype);
        if(body.Count > 0)
        {
            nextBodyPart.Init(body[body.Count - 1]);
        }
        else
        {
            nextBodyPart.Init(transform);
        }
        nextBodyPart.gameObject.SetActive(true);
        body.Add(
            nextBodyPart.transform
            );
    }
}
