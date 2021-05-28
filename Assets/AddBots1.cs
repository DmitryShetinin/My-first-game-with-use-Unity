using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddBots1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bot;
    bool z = true; 
    int n = 4;
    int i = 1;
    GameObject[] bots = new GameObject[4];

    private void Start()
    {
        InvokeRepeating("Generation", 0,5);
  
    }

    private void NewArray(ref GameObject[] arr, int Newlength)
    {
        GameObject[] NewArrayBots = new GameObject[Newlength+1];
        arr = NewArrayBots;
    }
    int f = -1; 
   void Generation()
    {
        
        if (GameObject.Find("w(Clone)") == null || f == 0)
        {
            if (i > 3)
            {


            }
            else
            {
                n = n * i;
                NewArray(ref bots, n);
                for (int i = 0; i < n; i++)
                {
                    bots[i] = Instantiate(bot);
                }

                //for(float i = 60f; i < 88; i+=4)
                for (float j = 0, i = 62f; (j < n || i < 88f); j++, i += 4)
                    bots[Convert.ToInt32(j)].transform.position = new Vector3(11f, this.transform.position.y + 10f, this.transform.position.z + i);

                z = true; 
            }
        }
        else
        {

        }
    }
   
    // Update is called once per frame
    void Update()
    {
        if (i > 3)
        {

        }
        else
        {
            if (GameObject.Find("w(Clone)") == null && z == true)
            {
                z = false;
                i++;
                 
            }
        }
    }




  
}
