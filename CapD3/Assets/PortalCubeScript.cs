﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCubeScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform Destination;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Transform playerTF = other.GetComponent<Transform>();
            playerTF.transform.position = Destination.position;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
