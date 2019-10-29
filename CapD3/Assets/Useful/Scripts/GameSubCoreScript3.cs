using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript3 : MonoBehaviour
{
    [SerializeField] private GameObject Rightarrow;
    [SerializeField] private GameObject chasetrap;
    [SerializeField] private GameObject uicapslider;
    [SerializeField] private GameObject lazerturret;
    [SerializeField] private GameObject CM;
    [SerializeField] private GameObject s2righttrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            deactive();
            chasetrap.SetActive(false);
            uicapslider.gameObject.SetActive(false);
            if(lazerturret)
                lazerturret.SetActive(false);
            if (s2righttrigger)
            {
                Stage2DodgeFieldScript thisscript = s2righttrigger.GetComponent<Stage2DodgeFieldScript>();
                thisscript.needboomoff();
            }
            if (CM)
            {
                CMScript cms = CM.GetComponent<CMScript>();
                cms.needboomfalsefy();
                CM.SetActive(false);
            }
            this.gameObject.SetActive(false);
        }
    }
    void deactive()
    {
        Rightarrow.SetActive(false);
    }
}
