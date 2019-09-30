using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallMovement : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        nav = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
