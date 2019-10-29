using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherCubeScript : MonoBehaviour
{
    [SerializeField] private GameObject meshcube;
    [SerializeField] private GameObject colicube;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            meshcube.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        meshcube.SetActive(false);
    }
}
