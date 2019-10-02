using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPosition2 : MonoBehaviour
{
    public static bool posstatus2;
    // Start is called before the first frame update
    void Start()
    {
        posstatus2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter()
    {
        Debug.Log("position2 test");
        posstatus2 = true;
        BotPosition1.posstatus1 = false;
    }
}