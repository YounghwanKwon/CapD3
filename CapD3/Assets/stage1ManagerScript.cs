using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage1ManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject resetbtn;
    [SerializeField] private GameObject shell1;

    [SerializeField] private Transform BombPlacingPoint1;
    private float xvalue = 2.5f;
    private Transform transs;
    private int transnumber = 15;
    private bool needboom1 = true;
    private bool needboomleft = true;
    private float frequency = 1.5f;

    [SerializeField] private GameObject air;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject motherpipe;
    [SerializeField] private GameObject[] pipes;
    [SerializeField] private GameObject[] planes;
    [SerializeField] private GameObject dropshell2;
    [SerializeField] private GameObject dropshell3;
    [SerializeField] private float leftdifficulty = 0.85f;
    [SerializeField] private Text text1;

    // Start is called before the first frame update
    void Start()
    {
        bombleftA();
        //bombleftC();
        setandbombattranss();
        ResetBtnScript rsbtnscript = resetbtn.GetComponent<ResetBtnScript>();
        rsbtnscript.setstage(1);
        text1.text = "Stage : 1";




        //Debug.Log(planes);

        //setxpos(BombPlacingPoint1);
        //DropA(BombPlacingPoint1);
        //setandbombattranss();
        //setpipes();

    }
    public void makeboomstop1()
    {
        needboomleft = false;
    }

    void bombleft()
    {
        if (needboomleft == true)
        {
            //air.transform.position = ground.transform.position;

            for (int i = 0; i < 18; i++)
            {
                ground = pipes[i];
                air.transform.position = ground.transform.position;
                Drophere2(air.transform);
            }
            Invoke("bombleft", 3f);
        }
    }
    void bombleftA()
    {
        if (needboomleft == true)
        {
            //air.transform.position = ground.transform.position;

            for (int i = 0; i < 18; i++)
            {
                if (i % 2 == 0)
                {
                    ground = pipes[i];
                    air.transform.position = ground.transform.position;
                    Drophere2(air.transform);
                }
            }
            Invoke("bombleftB", leftdifficulty);
        }
    }

    void bombleftB()
    {
        if (needboomleft)
        {
            //air.transform.position = ground.transform.position;

            for (int i = 0; i < 18; i++)
            {
                if (i % 2 == 1)
                {
                    ground = pipes[i];
                    air.transform.position = ground.transform.position;
                    Drophere2(air.transform);
                }
            }
            Invoke("bombleftA", leftdifficulty);
        }
    }
    void bombleftC()
    {
        if (needboomleft == true)
        {
            air.transform.position = ground.transform.position;

            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    ground = planes[i];
                    air.transform.position = ground.transform.position;
                    Drophere3(air.transform);
                }
            }
            Invoke("bombleftD", leftdifficulty);
        }
    }

    void bombleftD()
    {
        if (needboomleft)
        {
            air.transform.position = ground.transform.position;

            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 1)
                {
                    ground = planes[i];
                    air.transform.position = ground.transform.position;
                    Drophere3(air.transform);
                }
            }
            Invoke("bombleftC", leftdifficulty);
        }
    }
    void setpipes()
    {
        Debug.Log(transform.childCount);
        //GameObject[] planes1 = new GameObject[transform.childCount];
        //GameObject[] planes1 = motherplane.GetComponentsInChildren<GameObject>();
        /*
        for (int i = 0; i<planes1.Length; i++)
        {
            pipes[i] = planes1[i].gameObject;
        }
        */
    }


    void setxpos(Transform Atransform)
    {
        //Debug.Log("called setxpos169");
        xvalue *= -1;
        Atransform.transform.position = new Vector3(xvalue, Atransform.transform.position.y, Atransform.transform.position.z);
    }

    void Drophere(Transform Atransform)
    {

        //Debug.Log("called Drop258");
        //setxpos(Atransform);
        GameObject thisshell = Instantiate(shell1, Atransform);
        thisshell.transform.parent = null;
        //Instantiate(shell1,new Vector3(0,0.1f,0),Quaternion.Euler(Vector3.zero));
        //Invoke("DropA", 2);
    }
    void Drophere2(Transform Atransform)
    {
        GameObject thisshell = Instantiate(dropshell2, Atransform);
        thisshell.transform.parent = null;
    }
    void Drophere3(Transform Atransform)
    {
        GameObject thisshell = Instantiate(dropshell3, Atransform);
        thisshell.transform.parent = null;
    }


    void setandbombattranss()
    {
        if (needboom1 == true)
        {
            transs = transform;
            //Debug.Log(BombPlacingPoint1.transform+"3");
            for (int i = 0; i < transnumber; i++)
            {
                //Debug.Log("BombPlacingPoint1"+BombPlacingPoint1 + "47");
                //Debug.Log("x"+xvalue);
                //Debug.Log("y" + BombPlacingPoint1.transform.position.y);
                //Debug.Log("z" + BombPlacingPoint1.transform.position.z);
                transs.transform.position = new Vector3(xvalue, BombPlacingPoint1.transform.position.y, BombPlacingPoint1.transform.position.z - 5.0f * i);
                //Debug.Log(i);
                setxpos(transs);
                Drophere(transs);
            }
            Invoke("setandbombattranss", frequency);
        }
    }

    public void makeboomstop()
    {
        needboom1 = false;
    }


    // Update is called once per frame
    void Update()
    {

    }
    void checktime(float atime)
    {
        float a = 0;
        a += Time.deltaTime;
        //needboom = true;
        Debug.Log("2sec");
    }
}
