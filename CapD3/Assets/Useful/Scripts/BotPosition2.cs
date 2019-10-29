using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPosition2 : MonoBehaviour
{
    public static bool posstatus2;
    void Start()
    {
        posstatus2 = false;
    }

    private void OnTriggerEnter()
    {
        Debug.Log("position2 test");
        posstatus2 = true;
        BotPosition1.posstatus1 = false;
    }
}