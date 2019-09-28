using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        for (i = 0; i < childrens.Length; i++)
        {
            childrens[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
