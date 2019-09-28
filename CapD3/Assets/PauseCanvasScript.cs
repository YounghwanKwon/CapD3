using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void whenuserdead()
    {
        childrens[2].SetActive(true);
        childrens[4].SetActive(true);
    }
}
