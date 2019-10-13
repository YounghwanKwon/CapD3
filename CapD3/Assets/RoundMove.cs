using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundMove : MonoBehaviour
{
    public GameObject Roundmove1;
    public GameObject Roundmove2;
    public GameObject RoundCenter;
    //public float count = 0;
    public float QuadrantChk = 0;
    public Vector3 movement = new Vector3(0f, 1.25f, 0f);
    public Vector3 movement2 = new Vector3(0f, 1.25f, 0f);
    public float xpos1, zpos1;
    public float xpos2, zpos2;
    [SerializeField] private GameObject loseUI;
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject btncanvas;
    [SerializeField] private GameObject pausecanvas;
    [SerializeField] private GameObject resumebtn;
    [SerializeField] private GameObject NextStgBtn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("movementstart", 0f, 0.01f);
        InvokeRepeating("setpos", 0f, 0.01f);
        InvokeRepeating("movementstart2", 0f, 0.01f);
        InvokeRepeating("setpos2", 0f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void setpos()
    {
        Roundmove1.transform.position = movement;
        Roundmove1.transform.rotation = Quaternion.Euler(0, Mathf.Atan2(xpos1, zpos1) * Mathf.Rad2Deg + 180, 0);
    }
    void setpos2()
    {
        Roundmove2.transform.position = movement2;
        Roundmove2.transform.rotation = Quaternion.Euler(0, Mathf.Atan2(xpos2, zpos2) * Mathf.Rad2Deg, 0);
    }
    void movementstart()
    {
        if (QuadrantChk < 300)
        {
            QuadrantChk++;
            xpos1 += 0.1f;
            float t = (-xpos1 * -xpos1 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos1 = Mathf.Sqrt(t);
            movement = RoundCenter.transform.position;
            movement.x += xpos1;
            movement.z += zpos1;

        }
        else if (QuadrantChk >= 300 && QuadrantChk < 600)
        {
            QuadrantChk++;
            xpos1 -= 0.1f;
            float t = (-xpos1 * -xpos1 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos1 = -1 * Mathf.Sqrt(t);
            movement = RoundCenter.transform.position;
            movement.x += xpos1;
            movement.z += zpos1;
        }
        else if (QuadrantChk >= 600 && QuadrantChk < 900)
        {
            QuadrantChk++;
            xpos1 -= 0.1f;
            float t = (-xpos1 * -xpos1 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos1 = -1 * Mathf.Sqrt(t);
            movement = RoundCenter.transform.position;
            movement.x += xpos1;
            movement.z += zpos1;
        }
        else if (QuadrantChk >= 900 && QuadrantChk < 1200)
        {
            QuadrantChk++;
            xpos1 += 0.1f;
            float t = (-xpos1 * -xpos1 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos1 = Mathf.Sqrt(t);
            movement = RoundCenter.transform.position;
            movement.x += xpos1;
            movement.z += zpos1;
        }
        else if (QuadrantChk >= 1200)
        {
            QuadrantChk = 0;
        }
    }
    void movementstart2()
    {
        if (QuadrantChk >= 600 && QuadrantChk < 900)
        {
            QuadrantChk++;
            xpos2 += 0.1f;
            float t = (-xpos2 * -xpos2 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos2 = Mathf.Sqrt(t);
            movement2 = RoundCenter.transform.position;
            movement2.x += xpos2;
            movement2.z += zpos2;

        }
        else if (QuadrantChk >= 900 && QuadrantChk < 1200)
        {
            QuadrantChk++;
            xpos2 -= 0.1f;
            float t = (-xpos2 * -xpos2 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos2 = -1 * Mathf.Sqrt(t);
            movement2 = RoundCenter.transform.position;
            movement2.x += xpos2;
            movement2.z += zpos2;
        }
        else if (QuadrantChk < 300)
        {
            QuadrantChk++;
            xpos2 -= 0.1f;
            float t = (-xpos2 * -xpos2 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos2 = -1 * Mathf.Sqrt(t);
            movement2 = RoundCenter.transform.position;
            movement2.x += xpos2;
            movement2.z += zpos2;
        }
        else if (QuadrantChk >= 300 && QuadrantChk < 600)
        {
            QuadrantChk++;
            xpos2 += 0.1f;
            float t = (-xpos2 * -xpos2 * -1) + 900;
            t = Mathf.Round(t * 10) * 0.1f;
            zpos2 = Mathf.Sqrt(t);
            movement2 = RoundCenter.transform.position;
            movement2.x += xpos2;
            movement2.z += zpos2;
        }
        else if (QuadrantChk >= 1200)
        {
            QuadrantChk = 0;
        }
    }
    public void missionfail1()
    {
        TimerScript tscript = timer.GetComponent<TimerScript>();
        tscript.timepassoff();
        loseUI.SetActive(true);
        btncanvas.SetActive(false);
        pausecanvas.SetActive(true);
        NextStgBtn.SetActive(false);
        resumebtn.SetActive(false);
        Time.timeScale = 0;
    }
}
