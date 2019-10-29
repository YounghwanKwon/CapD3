using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcubetempScript : MonoBehaviour
{
    [SerializeField] private Transform Destination;
    [SerializeField] private GameObject NWmanager;
    [SerializeField] private GameObject roundmove;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Transform playerTF = other.GetComponent<Transform>();
            playerTF.transform.position = Destination.position;
            if(NWmanager)
                NWmanager.SetActive(true);
            if (roundmove)
                roundmove.SetActive(true);
        }
    }
}
