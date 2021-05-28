using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    float y_camera;
    void Start()
    {
      
    }

    public Camera camera; 

    bool end = true;
    int speed = 8; 
    public float speedRotation = 3f;
    public int jumpSpeed = 50;
    public Slider slider;   
    bool z = true; 
    // Update is called once per frame
    void Update()   
    {


        if (Input.GetKey(KeyCode.LeftShift))
        {
            z = true; 
        }
        else
        {
            z = false;
        }
        if(z)
        {
            if (slider.value == 0)
            {
                speed = 8;
                z = false;
            }
            else
            {
                speed = 13;
                slider.value -= 2;
            }
        }
        else
        {
            speed = 8;
            slider.value += 1;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += this.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position -= this.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.down * speedRotation);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up * speedRotation);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (end)
            {
                end = false;
                for (float i = 0; i < 5; i += 0.5f)
                {
                    this.transform.position += this.transform.up * i * Time.deltaTime;
                    end = true;
                }
            }
        }
    }

 
 
}

