using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDMDforleft1Script : MonoBehaviour
{
    [SerializeField] private GameObject camerarig;
    [SerializeField] private GameObject[] botsset;
    [SerializeField] private GameObject s1HDMDmanager;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            forleft1func1();
        }
    }
    public void forleft1func1()
    {
        Complete.CameraControl camerascript = camerarig.GetComponent<Complete.CameraControl>();
        camerascript.setmainobj();
        if (s1HDMDmanager)
        {
            stage1HDMDManagerScript s1HDMDmscript = s1HDMDmanager.GetComponent<stage1HDMDManagerScript>();
            s1HDMDmscript.order2_1lfbc();
        }
    }
}
