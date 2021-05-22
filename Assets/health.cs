using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip audio;
    public AudioSource t2;
    public  int health_of_bot = 150;
    public Slider slider;  

    void Start()
    {
      
    }
 
    // Update is called once per frame
    void Update()
    {
      
        if (this.GetComponent<health>().health_of_bot < 0)
        {
            t2.PlayOneShot(audio);
            Destroy(this.gameObject);
        }

        //  GetComponentInParent<health>().slider.value = this.GetComponent<health>().health_of_bot; 


        slider.value = health_of_bot;
        print(health_of_bot);
    }


}
