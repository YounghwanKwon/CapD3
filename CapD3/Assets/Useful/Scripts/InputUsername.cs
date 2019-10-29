using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputUsername : MonoBehaviour
{
    [SerializeField] private Text UsernameField;
    [SerializeField] private InputField InputName;
    public GameObject Button;
    public GameObject Input;

    private string UserName;
    
    public void GetName()
    {
        UserName = InputName.text;
        InputName.text = null;
        Button.SetActive(false);
        Input.SetActive(false);
        TimerScript ts = GameObject.FindWithTag("Timer").GetComponent<TimerScript>();
        StageSaveScript sss = GameObject.FindWithTag("StageSave").GetComponent<StageSaveScript>();
        sss.Makerecord1fortest(UserName, ts.gettc2());
        sss.Save();
    }
}
