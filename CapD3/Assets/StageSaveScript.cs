using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSaveScript : MonoBehaviour
{
    public static int StageNum;
    public static int StageSave = 0;
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
}
