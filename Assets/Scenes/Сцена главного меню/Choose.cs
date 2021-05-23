using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Application.Quit();



public class Choose : MonoBehaviour
{
    public Button Yes;
    public Button No;
    void Start()
    {
        Yes.onClick.AddListener(() =>
        {
            Application.Quit();
        });

        No.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main_menu");
        });
    }

  
}
