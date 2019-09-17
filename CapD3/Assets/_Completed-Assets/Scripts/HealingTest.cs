using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class HealingTest : MonoBehaviour
    {
        // Start is called before the first frame update

        [SerializeField] private GameObject HC;
        [SerializeField] private Transform HZ;
        [SerializeField] private float healingamount = 15.0f;
        private int i;
        private float timer;

        private WaitForSeconds waiting = new WaitForSeconds(5f);
        void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag("Player"))
            {
                Debug.Log("유저충돌감지");
                Rigidbody targetRigidbody = other.GetComponent<Rigidbody>();

                TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();
                targetHealth.GetHealing(healingamount);

                this.gameObject.SetActive(false);
                regentry();
                //Destroy(this.gameObject);

            }
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            spin();
        }

        void spin()
        {
            this.transform.rotation = new Quaternion(0, this.transform.rotation.y + 5, 0, 0);
        }
        
        IEnumerator Waiting()
        {
            yield return waiting;
        }

        void regentry()
        {
            Debug.Log("regentry진입");
            Invoke("regen", 5);
        }
        void regen()
        {
           
            Debug.Log("HC생성");
            this.gameObject.SetActive(true);
            //Instantiate(HC, HZ.position, HZ.rotation);
        }
    }
}