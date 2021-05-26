using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider : MonoBehaviour
{
    public Transform w1;
    private Transform w2;
    private Transform w3;
     
    // Start is called before the first frame update
    void Start()
    {
        w1 = this.gameObject.transform.parent.transform;
        w2 = w1.transform.parent.transform;
        w3 = w2.transform.parent.transform;
     
    }

    // Update is called once per frame
    void Update()
            {
      //  print(w3.eulerAngles.y);
        this.transform.rotation = Quaternion.Euler(w3.eulerAngles.x, w3.eulerAngles.y, w3.eulerAngles.z);
    }
}
