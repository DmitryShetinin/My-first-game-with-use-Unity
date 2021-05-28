using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_rotation : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera _camera;

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = _camera.transform.rotation; 
    }
}
