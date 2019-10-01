using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab2ManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject shell1;

    [SerializeField] private Transform BombPlacingPoint1;
    private float xvalue=2.5f;
    private Transform transs;
    private int transnumber = 15;
    private bool needboom1 = true;
    private float frequency = 1.5f;

    [SerializeField] private GameObject motherplane;
    [SerializeField] private GameObject motherpipe;
    private GameObject[] planes=new GameObject[14];
    private GameObject[] pipes=new GameObject[14];



    // Start is called before the first frame update
    void Start()
    {
        //setxpos(BombPlacingPoint1);
        //DropA(BombPlacingPoint1);
        //setandbombattranss();
        setpipes();


    }
    void setpipes()
    {
        GameObject[] planes1 = new GameObject[transform.childCount];
        GameObject[] planes1 = motherplane.GetComponentsInChildren<GameObject>();
        for (int i = 0; i<planes1.Length; i++)
        {
            pipes[i] = planes1[i].gameObject;
        }
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
