using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallMovementE : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent nav;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Vector3 point = new Vector3(0f, 1f, -210f);
        nav.SetDestination(point);
    }
}
