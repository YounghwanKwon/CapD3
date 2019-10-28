using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recordforstage2
{
    private int rank;
    private string username;
    private float cleartime;
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
    public float Cleartime
    {
        set { this.cleartime = value; }
        get { return this.cleartime; }
    }
    public recordforstage2()
    {
        rank = 0;
        username = "undefined in class";
        cleartime = 0f;
    }
}
public class StageSaveScript : MonoBehaviour
{
    public static int StageNum;
    public static int StageSave = 0;
    int getnum;
    private static bool onepls=false;
    public static recordforstage2[,] records = new recordforstage2[3,9];

    // Start is called before the first frame update
    void Awake()
    {
        donotdestory();
        Load();
    }
    void donotdestory()
    {
        if (onepls == false)
        {
            DontDestroyOnLoad(gameObject);
            onepls = true;
        }
    }
    public void checknum()
    {
        getnum = StageNum;
        getnum -= 1;
        if (StageNum == -2)
        {
            getnum = 0;
        }
        if (getnum == 100)
        {
            getnum = 2;
        }
    }
    public int getgetnum()
    {
        return getnum;
    }


    public void Makerecord1fortest(string Useraname1,float time1 )
    {
        recordforstage2 recordvalue1 = new recordforstage2();
        recordvalue1.Rank = setrank(time1);
        recordvalue1.Username = Useraname1;
        recordvalue1.Cleartime = time1;
        setinrecords(recordvalue1);
    }
    public recordforstage2 Makerecord1fortest1(string Useraname1, float time1,int rank1)
    {
        recordforstage2 recordvalue1 = new recordforstage2();
        recordvalue1.Rank = rank1;
        recordvalue1.Username = Useraname1;
        recordvalue1.Cleartime = time1;
        return recordvalue1;
    }

    public void setinrecords(recordforstage2 newreco)
    {
        checknum();
        int newrank = 1;
        for(int i=0; i < records.GetLength(1); i++)
        {
            if (records[getnum,i] == null)
            {
                records[getnum, i] = newreco;
                break;
            }
            else
            {
                if (records[getnum, i].Cleartime > newreco.Cleartime)
                {
                    for (int j = records.GetLength(1) - 1; j > i; j--)
                    {
                        if (records[getnum, j - 1] != null)
                        {
                            records[getnum, j] = records[getnum, j - 1];
                            records[getnum, j].Rank++;
                        }
                    }
                    records[getnum, i] = newreco;
                    break;
                }
                else
                    newrank++;
            }
        }
    }

    public int setrank(float time1)
    {
        checknum();
        int guessrank = 1;
        for (int i =0; i < records.GetLength(1); i++)
        {
            if (records[getnum, i] != null && time1 >= records[getnum, i].Cleartime )
            {
                guessrank++;
            }
        }
        return guessrank;
    }
    
    public void Save()
    {
        for (int l = 0; l < records.GetLength(0); l++)
        {
            for (int k = 0; k < records.GetLength(1); k++)
            {
                if(records[l,k] != null)
                {
                    PlayerPrefs.SetInt("Rank" + l + "+" + k, records[l, k].Rank);
                    PlayerPrefs.SetString("Username" + l + "+" + k, records[l, k].Username);
                    PlayerPrefs.SetFloat("ClearTime" + l + "+" + k, records[l, k].Cleartime);
                }
            }
        }
        Load();
    }
    public void Load()
    {
        for (int m = 0; m < records.GetLength(0); m++)
        {
            for (int n = 0; n < records.GetLength(1); n++)
            {
                records[m,n] = Makerecord1fortest1(PlayerPrefs.GetString("Username" + m + "+" + n,"Undefined"), PlayerPrefs.GetFloat("ClearTime" + m + "+" + n,n*50.0f+200f), PlayerPrefs.GetInt("Rank" + m + "+" + n,n+1));
            }
        }
    }
}
