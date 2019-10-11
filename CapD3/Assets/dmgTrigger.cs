using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgTrigger : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SightTrigger.SightCat == true)
        {
            //Debug.Log(i);
            i++;
        }
    }
}
