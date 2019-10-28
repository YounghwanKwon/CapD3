using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcubetempScript : MonoBehaviour
{
    [SerializeField] private Transform Destination;
    [SerializeField] private GameObject NWmanager;
    [SerializeField] private GameObject roundmove;
    //[SerializeField] private GameObject[] sliders;
    // Start is called before the first frame update

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
            //sliders[0].SetActive(true);
            //sliders[1].SetActive(true);
        }
    }
}
