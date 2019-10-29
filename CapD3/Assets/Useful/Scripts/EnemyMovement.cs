using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent nav;

    void awake()
    {
        player = GameObject.FindWithTag("player").transform;
        nav = GetComponent<NavMeshAgent>();

    }
}
