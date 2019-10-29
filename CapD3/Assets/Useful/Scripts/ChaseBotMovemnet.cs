﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseBotMovemnet : MonoBehaviour
{
    public Transform player;
    [SerializeField] Transform[] WayPoint = null;
    int count = 0;
    private Transform Bot1;
    private NavMeshAgent nav;
    private int countsecond = 0;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;
        InvokeRepeating("MoveNextWayPoint", 0f, 0.1f);
    }

    void MoveNextWayPoint()
    {
        if (SightTrigger.SightCat == false)
        {
            if (nav.velocity == Vector3.zero)
            {
                nav.SetDestination(WayPoint[count++].position);
                if (count >= WayPoint.Length)
                {
                    count = 0;
                }
                countsecond = 0;
            }
            else
            {
                countsecond++;
                if (countsecond == 40)
                {
                    count += (int)((Random.value * 4)-2);
                    if(count < 0 || count >9)
                        count = (int)(Mathf.Round(Random.value * 9));
                    nav.SetDestination(WayPoint[count].position);
                    if (count >= WayPoint.Length)
                    {
                        count = 0;
                    }
                    countsecond = 0;
                }
            }
        }
        if(SightTrigger.SightCat == true)
        {
            nav.SetDestination(player.position);
        }
    }

    public void countchange()
    {
        nav.velocity = Vector3.zero;
    }
}
