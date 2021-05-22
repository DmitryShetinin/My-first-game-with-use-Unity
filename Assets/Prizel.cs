using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prizel : MonoBehaviour
{
    public Texture2D CrossHair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2, Screen.height / 2,25, 25), CrossHair);
     
    }
}
