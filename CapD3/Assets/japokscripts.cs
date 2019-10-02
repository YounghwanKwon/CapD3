using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class japokscripts : MonoBehaviour
{
    [SerializeField] private GameObject dropshell4;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject oneshell = Instantiate(dropshell4, transform);
            oneshell.transform.parent = null;
            //Destroy(this.transform.parent.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
