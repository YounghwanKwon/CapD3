using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenwall : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("플레이어가 벽에 도달하였습니다");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
