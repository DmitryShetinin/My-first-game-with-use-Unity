using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Game : MonoBehaviour
{
    public Button Play;
    public Button Score;
    public Button Exit;
 
    void Start()
    {
        Play.onClick.AddListener(zxc);
        Score.onClick.AddListener(zxc2);
        Exit.onClick.AddListener(zxc3);
    }

    private void zxc()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void zxc2()
    {
        SceneManager.LoadScene("Score");
    }

    private void zxc3()
    {
        SceneManager.LoadScene("Exit");
        
    }

}
