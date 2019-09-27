using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCore : MonoBehaviour
{
    [HideInInspector] public GameObject Ingamecanvas;
    //private Text[] texts;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("플레이어가 코어접촉 플레이어 승리");
            //texts[0].text = "Player win \n: condition 1 Activated";
            InGameCanvasScript thiscanvas = Ingamecanvas.GetComponent<InGameCanvasScript>();
            thiscanvas.text1on();
            Debug.Log(thiscanvas);

            Invoke("deavtivate", 5);
        }
        else
        {
            Debug.Log("예외발생 예상치못한 물체 코어에접촉");
        }
    }
    public void settingcanvas(GameObject ingamecanvasfromout)
    {
        Ingamecanvas = ingamecanvasfromout;
        //texts = Ingamecanvas.GetComponentsInChildren<Text>();
    }

    void deavtivate()
    {
        //gamecanvas1.text1off();
        //resetbtn.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
