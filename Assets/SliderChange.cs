using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    // Start is called before the first frame update
    private Slider sl;
    public GameObject w; 
    void Start()
    {
        sl = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        sl.value = w.GetComponent<health>().health_of_bot; 
    }
}
