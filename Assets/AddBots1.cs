using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBots1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bot; 
    void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            Instantiate(bot);
            bot.transform.position = new Vector3(this.transform.position.x + i, this.transform.position.y, this.transform.position.z + i);
        }
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
