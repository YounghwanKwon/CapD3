using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenwall1 : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform spwanpoint;
    [SerializeField] private GameObject HC;
    [SerializeField] private GameObject originwall;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        hiddenwall hiddenwallorigin = originwall.GetComponent<hiddenwall>();
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("플레이어가 벽에 도달하였습니다");
            Debug.Log("탱크둘소환을 시도합니다");
            hiddenwallorigin.spwanonetank();
            hiddenwallorigin.spwanonetank();

            spwanpoint.position = new Vector3(0f, 1f, spwanpoint.transform.position.z + 40f);

            this.gameObject.SetActive(false);
            //tank.Setup();
            //HC = Instantiate(HC, spwanpoint, spwanpoint.rotation);
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
