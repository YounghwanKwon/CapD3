using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public void setstagenumber(int number)
    {
        Text text1 = childrens[7].GetComponent<Text>();
        text1.text = "Stage Number : " + number;
    }

    public void setsentence(int i,string strings)
    {
        Text text1 = childrens[i].GetComponent<Text>();
        text1.text = strings;
    }
    public void setactive(int i)
    {
        childrens[i].SetActive(true);
    }
    public void setdisactive(int i)
    {
        childrens[i].SetActive(false);
    }
}
