using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{

    [SerializeField] private Transform player;

    private NavMeshAgent agent;



    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        agent.SetDestination(player.position);
    }



    public void GotHit()
    {
        UIControl.AddScore(10);
        Destroy(gameObject);
    }


}
