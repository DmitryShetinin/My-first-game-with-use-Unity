using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_health : MonoBehaviour
{
    // Start is called before the first frame update
    private float a; 
    void Start()
    {
        a = this.GetComponent<Slider>().value;  
    }

    // Update is called once per frame
    void Update()
    {
        if(a < (this.GetComponent<Slider>().maxValue * 0.2))
        {

        }
    }
}
