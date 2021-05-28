using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBots : MonoBehaviour
{
    public GameObject bot;
    private float f1 = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 20; i++)
        {
            Instantiate(bot);
            bot.transform.position = new Vector3(40.5f + (f1+=0.1f), 1, 78.894f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
