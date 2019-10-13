﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallMovementE : MonoBehaviour
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
        Vector3 point = new Vector3(0f, 1f, -210f);
        nav.SetDestination(point);
    }
}
