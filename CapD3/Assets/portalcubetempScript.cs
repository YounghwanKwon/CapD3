using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcubetempScript : MonoBehaviour
{
    [SerializeField] private Transform Destination;
    [SerializeField] private GameObject[] sliders;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Transform playerTF = other.GetComponent<Transform>();
            playerTF.transform.position = Destination.position;
            sliders[0].SetActive(true);
            sliders[1].SetActive(true);
        }
    }
}
