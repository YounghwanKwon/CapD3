using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Leftctrl : MonoBehaviour
{
    public GameObject Road1;
    [SerializeField] private GameObject s2m;
    private bool did = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(did == false)
        {
            if (Switch1Script.colorset == 0 && Switch2Script.colorset == 2 && Switch3Script.colorset == 1 && Switch4Script.colorset == 1)
            {
                if (Switch5Script.colorset == 2 && Switch6Script.colorset == 2 && Switch7Script.colorset == 2 && Switch8Script.colorset == 2)
                {
                    if (Switch9Script.colorset == 2 && Switch10Script.colorset == 3 && Switch11Script.colorset == 4 && Switch12Script.colorset == 1)
                    {
                        if (Switch13Script.colorset == 2 && Switch14Script.colorset == 3 && Switch15Script.colorset == 2 && Switch16Script.colorset == 2)
                        {
                            stage2ManagerScript s2ms = s2m.GetComponent<stage2ManagerScript>();
                            s2ms.order2s2l2fbc();
                            did = true;
                            Road1.SetActive(true);
                        }
                    }
                }
            }
        }
        
    }
}
