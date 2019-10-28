using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightTrigger : MonoBehaviour
{
    public GameObject Sight;
    public static bool SightCat;
    public GameObject Lighting;
    // Start is called before the first frame update
    void Start()
    {
        SightCat = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        //if (other.name == "tank_e1")
        if (other.transform.CompareTag("Player"))
        {            
            SightCat = true;
            //Debug.Log("SightCat = true");
            Lighting.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            
        }
    }
}
