using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenwall : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform spwanpoint;
    [SerializeField] private GameObject HC;
    public Transform paddingspace;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            spwanonetank();
            spwanpoint.position = new Vector3(0f,1f,spwanpoint.transform.position.z + 40f);

            this.gameObject.SetActive(false);
        }
    }

    void resetpadding()
    {
        paddingspace.position = new Vector3(Random.Range(-2f,2f), 0, Random.Range(-2f, 2f));
    }

    void movespwanpoint()
    {
        spwanpoint.position = new Vector3(spwanpoint.position.x + 2f, spwanpoint.position.y, spwanpoint.position.z);
    }

    public void spwanonetank()
    {
        Instantiate(tank, spwanpoint.position + paddingspace.position, spwanpoint.rotation);
        movespwanpoint();
    }
}
