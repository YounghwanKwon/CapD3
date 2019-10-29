using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenwall1 : MonoBehaviour
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

            spwanpoint.position = new Vector3(0f, 1f, spwanpoint.transform.position.z + 40f);

            this.gameObject.SetActive(false);
        }
    }
}
