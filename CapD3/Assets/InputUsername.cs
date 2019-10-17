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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetName()
    {
        UserName = InputName.text;
        Debug.Log(UserName);
        InputName.text = null;
        Debug.Log(InputName.text);
        Button.SetActive(false);
        Input.SetActive(false);
        TimerScript ts = GameObject.FindWithTag("Timer").GetComponent<TimerScript>();
        StageSaveScript sss = GameObject.FindWithTag("StageSave").GetComponent<StageSaveScript>();
        sss.Makerecord1fortest(UserName, ts.gettc2());

=======
        sss.Save();
        Debug.Log("저장완료");
>>>>>>> #13_tryscoreboard_save
    }
}
