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
        if(other.name == "Tank_e1")
        {            
            SightCat = true;
            Lighting.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            
        }
    }
}
