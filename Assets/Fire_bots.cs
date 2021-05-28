using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_bots : MonoBehaviour
{
    RaycastHit hit; 
    public GameObject t1;
    private Vector3 t2; 
    // Start is called before the first frame update

    private void SetTarget(ref GameObject target)
    {
        t1 = GameObject.Find("Capsule");
    }
    void Start()
    {
        InvokeRepeating("Shoot1", 0, 2);
        SetTarget(ref t1);
 
    }
    int force = 2;
    void Shoot1()
    {
        if (t1 != null)
        {
            t2 = t1.transform.position - this.transform.position;

            print("Позиция игрока " + t1.transform.position);
            if (Physics.Raycast(this.transform.position, t2, out hit, 1500f))
            {
                print("Бот выстрелил ");
                Debug.DrawRay(this.transform.position, t2, Color.green, 5);
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * force);
                }
                if (hit.collider.ToString() == "Capsule (UnityEngine.CapsuleCollider)")
                {
                    hit.transform.gameObject.GetComponent<health>().health_of_bot = hit.transform.gameObject.GetComponent<health>().health_of_bot - 15;
                    print("1");
                }
            }
        }
        else
        {

        }

    }
    // Update is called once per frame
    void Update()
    {
 
    }


 


}
