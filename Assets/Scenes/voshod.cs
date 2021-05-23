using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class voshod : MonoBehaviour
{

    void Start()
    {
       
    }
    float i = 0.0f; 
    // Update is called once per frame
    void Update()
    {
        
        RenderSettings.skybox.SetFloat("_Rotation", i += 0.1f);
    }
}
