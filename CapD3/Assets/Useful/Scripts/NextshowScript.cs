using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextshowScript : MonoBehaviour
{
    [SerializeField] private GameObject nextobj;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nextobj.SetActive(true);
            Debug.Log("다음 오브젝트 활성화");
            this.gameObject.SetActive(false);
        }
    }
}
