using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateControler : MonoBehaviour
{
    public GameObject go1;
    public void OnTriggerEnter()
    {
        go1.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
