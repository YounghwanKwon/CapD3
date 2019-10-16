using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordforstage2
{
    private int rank;
    private string username;
    private string cleartime;
    private int stagenum;

    public int Rank
    {
        set { this.rank = value; }
        get { return this.rank; }
    }
    public string Username
    {
        set { this.username = value; }
        get { return this.username; }
    }
    public string Cleartime
    {
        set { this.cleartime = value; }
        get { return this.cleartime; }
    }
    public int Stagenum
    {
        set { this.stagenum = value; }
        get { return this.stagenum; }
    }
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

    public void globalfunc2()
    {
        if (StageNum == -1)
            Debug.Log("stagenum -1 ? : " + StageSaveScript.StageNum);
    }
}
