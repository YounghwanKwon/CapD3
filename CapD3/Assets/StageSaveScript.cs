using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordforstage2
{
    int rank = 0;
    string username = "";
    string cleatime = "";
}
public class StageSaveScript : MonoBehaviour
{
    public static int StageNum;
    public static int StageSave = 0;
    
    public void globalfunc1()
    {
        Debug.Log("connectsuceess!!");
        Debug.Log("connectsuceess!!");
        Debug.Log("connectsuceess!!");
        Debug.Log("connectsuceess!!");
        Debug.Log("connectsuceess!!");
    }
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Makerecord1fortest()
    {
        recordforstage2 recordvalue1 = new recordforstage2();
    }
}
