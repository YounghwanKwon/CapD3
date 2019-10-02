using System.Collections;
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
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;
        InvokeRepeating("MoveNextWayPoint", 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
            }
        }
        if(SightTrigger.SightCat == true)
        {
            nav.SetDestination(player.position);
        }
    }
}
