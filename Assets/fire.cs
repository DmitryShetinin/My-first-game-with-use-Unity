using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{


   // public GameObject obj;
    public GameObject effect; 
    public Camera camera;
    public AudioClip audio;
    public AudioSource t2;
    public Transform bulletSpawn;
    public int force = 100;

    private LineRenderer line;
    protected LayerMask Layer;
    void Start()
    {
     
    }
    //GameObject[] gameObjects = new GameObject[100];
    GameObject[] effects = new GameObject[100]; 
    RaycastHit hit;
    int i = 0;
    bool z = true;
    float range = 1500;
    // Update is called once per frame
    void Update()
    {

 
        if (Input.GetMouseButton(0))
        {    
            GameObject GameObj = GameObject.Find("Core(Clone)");
            Shoot();
            t2.PlayOneShot(audio);
           // gameObjects[i] = Instantiate(obj, bulletSpawn.position, bulletSpawn.rotation);
            effects[i] = Instantiate(effect, bulletSpawn.position, bulletSpawn.rotation);
          // GameObj1.transform.position = Vector3.MoveTowards(gameObjects[i].transform.position, hit.point, 100f);
            GameObj.transform.position = Vector3.MoveTowards(effects[i].transform.position, hit.point, 100f );
           // gameObjects[i].transform.position = Vector3.MoveTowards(gameObjects[i].transform.position, hit.point, 100f);
            print("Я попал " + hit.collider);
            Vector3 forward = transform.TransformDirection(camera.transform.forward) * 10;
            Debug.DrawRay(camera.transform.position, forward, Color.green, 5);
            z = false;
        }
        if (z == false)
        {
           // gameObjects[i].transform.position =  hit.point;
            effects[i].transform.position = hit.point;
            i++;
            if(i == 100)
            {
                i = 0;
            }
            z = true;
        }
    }
 
 
    void Shoot()            
    {


        

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
      
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }
            if(hit.collider.ToString() == "w (UnityEngine.CapsuleCollider)" || hit.collider.ToString() == "w(Clone) (UnityEngine.CapsuleCollider)"  || hit.collider.ToString() == "Capsule (UnityEngine.CapsuleCollider)")
            {
                hit.transform.gameObject.GetComponent<health>().health_of_bot = hit.transform.gameObject.GetComponent<health>().health_of_bot - 20;
            }
          
        }
  
    }
}
