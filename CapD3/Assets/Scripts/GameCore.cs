using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    //[SerializeField] private GameObject tank;
    //[SerializeField] private Canvas Maincanvas;
    //[SerializeField] private GameObject text1;
    // Start is called before the first frame update
    //[SerializeField] private GameObject resetbtn;
    //[SerializeField] private GameObject timer;

    private InGameCanvasScript gamecanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("플레이어가 코어접촉 플레이어 승리");

            //gamecanvas.text1on();
            //TimerScript temptimer = GetComponent<TimerScript>();
            //temptimer.timepassoff();
            //this.gameObject.SetActive(false);
            Invoke("deavtivate", 5);
        }
        else
        {
            Debug.Log("예외발생 예상치못한 물체 코어에접촉");
        }
    }

    void deavtivate()
    {
        gamecanvas.text1off();
        //resetbtn.SetActive(true);
    }
    void Start()
    {
        gamecanvas = GetComponent<InGameCanvasScript>();
        Debug.Log(gamecanvas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
