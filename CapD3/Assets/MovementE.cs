using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementE : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent nav;
    private bool poweron = false;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void poweronfunc()
    {
        poweron = true;
    }
    public void powerofffunc()
    {
        poweron = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(poweron)
            nav.SetDestination(player.transform.position);
    }
}
