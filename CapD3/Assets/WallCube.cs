using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCube : MonoBehaviour
{
    public GameObject BallBomb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            BallBomb.SetActive(true);
        }
        else
        {
            Debug.Log("버그");
        }
    }
}
