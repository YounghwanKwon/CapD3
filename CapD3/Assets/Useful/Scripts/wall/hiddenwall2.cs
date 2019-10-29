using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenwall2 : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform spwanpoint;
    [SerializeField] private GameObject HC;
    [SerializeField] private GameObject originwall;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        hiddenwall hiddenwallorigin = originwall.GetComponent<hiddenwall>();
        if (other.transform.CompareTag("Player"))
        {
            hiddenwallorigin.spwanonetank();
            hiddenwallorigin.spwanonetank();
            hiddenwallorigin.spwanonetank();
            hiddenwallorigin.spwanonetank();

            this.gameObject.SetActive(false);
        }
    }
}
