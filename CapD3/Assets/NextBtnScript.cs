using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextBtnScript : MonoBehaviour
{
    
    //private int stagenumber;
    //[SerializeField] private GameObject completedtuesdaymap;
    // Start is called before the first frame update

    public void whennextbtnpressed()
    {
        Time.timeScale = 1;
        if (StageSaveScript.StageNum == 0)
            SceneManager.LoadScene("stage1");
        else if (StageSaveScript.StageNum == 1)
            SceneManager.LoadScene("stage2");
        else if (StageSaveScript.StageNum == 2)
            SceneManager.LoadScene("stage3");
        else if (StageSaveScript.StageNum == 3)
            SceneManager.LoadScene("Lab2");
        else
            Debug.Log("망함.. stagenumber : " + StageSaveScript.StageNum);
    }
}
