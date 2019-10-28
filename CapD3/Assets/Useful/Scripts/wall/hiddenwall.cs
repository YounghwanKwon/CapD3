using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenwall : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform spwanpoint;
    [SerializeField] private GameObject HC;
    public Transform paddingspace;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("플레이어가 벽에 도달하였습니다");
            Debug.Log("탱크소환을 시도합니다");

            spwanonetank();
            spwanpoint.position = new Vector3(0f,1f,spwanpoint.transform.position.z + 40f);

            this.gameObject.SetActive(false);
            //tank.Setup();
            //HC = Instantiate(HC, spwanpoint, spwanpoint.rotation);
        }

    }

    void resetpadding()
    {
        paddingspace.position = new Vector3(Random.Range(-2f,2f), 0, Random.Range(-2f, 2f));
    }

    void movespwanpoint()
    {
        spwanpoint.position = new Vector3(spwanpoint.position.x + 2f, spwanpoint.position.y, spwanpoint.position.z);
    }

    public void spwanonetank()
    {
        //resetpadding();
        Instantiate(tank, spwanpoint.position + paddingspace.position, spwanpoint.rotation);
        movespwanpoint();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
