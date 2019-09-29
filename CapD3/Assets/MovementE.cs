using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementE : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent nav;
    public GameObject MovePoint1;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MovePoint1);
        Debug.Log(MovePoint1.transform.position);
        Debug.Log(nav);
        nav.SetDestination(MovePoint1.transform.position);
        //nav.SetDestination(player.transform.position);
    }
}
