using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCube : MonoBehaviour
{
    public GameObject zxc1; 
    void Start()
    {
        for(float i = 0f; i < 157.2f; i += 15f)
        {
            Instantiate(zxc1);   
            zxc1.transform.position = new Vector3(zxc1.transform.position.x, zxc1.transform.position.y, i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
