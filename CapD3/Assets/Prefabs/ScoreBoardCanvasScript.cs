using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoardCanvasScript : MonoBehaviour
{
    private int stagenum1=0;
    [SerializeField] private Text rankingnum;
    [SerializeField] private Text rankername;
    [SerializeField] private Text rankercleartime;
    private StageSaveScript sss;
    // Start is called before the first frame update

    public void Stage1BtnPressed()
    {
        stagenum1 = 0;
        boardreset();
        //SceneManager.LoadScene("Stage1");
    }
    
    public void Stage2BtnPressed()
    {
        stagenum1 = 1;
        boardreset();
        //SceneManager.LoadScene("Stage2");
    }
    public void Stage1HDMDBtnPressed()
    {
        stagenum1 = 2;
        boardreset();
        //SceneManager.LoadScene("Stage1");
    }
    public void setrankingnum()
    {
        
        rankingnum.text = "";
        for(int i = 0; i < StageSaveScript.records.GetLength(1); i++)
        {
            Debug.Log(stagenum1);
            Debug.Log(i);
            if (StageSaveScript.records[stagenum1, i] != null)
            {
                if (i != 0)
                {
                    rankingnum.text += "\n";
                }
                rankingnum.text += StageSaveScript.records[stagenum1, i].Rank;
            }
        }
        //rankingnum.text = "1\n2\n3\n4\n5\n6\n7\n8\n9";
    }

    public void setrankername()
    {
        rankername.text = "";
        for (int i = 0; i < StageSaveScript.records.GetLength(1); i++)
        {
            if (StageSaveScript.records[stagenum1, i] != null)
            {
                if (i != 0)
                {
                    rankername.text += "\n";
                }
                rankername.text += StageSaveScript.records[stagenum1, i].Username;
            }
        }
    }
    public void setrankercleartime()
    {
        rankercleartime.text = "";
        for (int i = 0; i < StageSaveScript.records.GetLength(1); i++)
        {
            if (StageSaveScript.records[stagenum1, i] != null)
            {
                if (i != 0)
                {
                    rankercleartime.text += "\n";
                }
                rankercleartime.text += StageSaveScript.records[stagenum1, i].Cleartime;
            }
        }
    }
    public void BackToMainBtnPressed()
    {
        SceneManager.LoadScene("Main");
    }
    void Start()
    {
        sss = GameObject.FindWithTag("StageSave").GetComponent<StageSaveScript>();
        sss.checknum();
        //stagenum1 = sss.getgetnum();
        boardreset();
    }
    private void boardreset()
    {
        setrankingnum();
        setrankername();
        setrankercleartime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
