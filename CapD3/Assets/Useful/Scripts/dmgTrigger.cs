using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgTrigger : MonoBehaviour
{
    int i = 0;
    void Update()
    {
        if (SightTrigger.SightCat == true)
        {
            i++;
        }
    }
}
