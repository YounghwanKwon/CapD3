using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCanvasScript1 : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    // Start is called before the first frame update

    public void whenuserdead()
    {
        childrens[0].SetActive(false);
        childrens[1].SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
