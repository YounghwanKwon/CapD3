using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameCanvasScript : MonoBehaviour
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
        childrens[4].SetActive(true);
        TimerScript timer = childrens[6].GetComponent<TimerScript>();
        timer.timepassoff();
    }
}
