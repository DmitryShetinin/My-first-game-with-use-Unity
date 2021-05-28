using UnityEngine;
using System.Collections;

public class csDestroyEffect : MonoBehaviour {

	void Update ()
    {
            Destroy(GameObject.Find("Core(Clone)"),0.4f);      
	}
}
