using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextBtnScript : MonoBehaviour
{

    public void whennextbtnpressed()
    {
        Time.timeScale = 1;
        if (StageSaveScript.StageNum == 0)
            SceneManager.LoadScene("stage1");
        else if (StageSaveScript.StageNum == 1)
            SceneManager.LoadScene("stage2");
        else if (StageSaveScript.StageNum == 2)
            SceneManager.LoadScene("StageSelect");
        
    }
}
