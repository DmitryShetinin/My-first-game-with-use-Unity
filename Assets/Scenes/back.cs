using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{


    public Button back1; 
    // Start is called before the first frame update
    void Start()
    {
        back1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main_menu");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
