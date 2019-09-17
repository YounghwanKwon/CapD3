using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{

    public class HealingTest : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] private float healingamount = 15.0f;
        void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag("Player"))
            {
                Debug.Log("유저충돌감지");
                Rigidbody targetRigidbody = other.GetComponent<Rigidbody>();

                TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();
                targetHealth.GetHealing(healingamount);


                Destroy(this.gameObject);
                regen();

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

        void regen()
        {

        }
    }
}