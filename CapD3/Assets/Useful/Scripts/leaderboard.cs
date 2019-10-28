using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaderboard : MonoBehaviour
{
    public static float[,] StageTime = new float[3, 10];
    public int Stage;
    public int Time;
    public static float ClearTime;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StageSaveScript.StageNum == 1)
        {
            Stage = 1;
        }
        else if (StageSaveScript.StageNum == 101)
        {
            Stage = 2;
        }
        else if (StageSaveScript.StageNum == 2)
        {
            Stage = 3;
        }

        if (ClearTime != 0)
        {
            for (int i = 0; i < 10; i++)
            {
                if (StageTime[Stage, i] == 0)
                {
                    StageTime[Stage, i] = ClearTime;
                }
                else if (StageTime[Stage, i] != 0)
                {
                    if (StageTime[Stage, i] > ClearTime)
                    {
                        for (int j = 10 - i; j > -1; i--)
                        {
                            StageTime[Stage, i + 1] = StageTime[Stage, i];
                        }
                        StageTime[Stage, i] = ClearTime;
                    }
                }
            }
            ClearTime = 0;
        }        
    }
    void LeaderSet()
    {
        
    }
}
