using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_wear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gun;
    public SkinnedMeshRenderer playSkin;
    void Start()
    {
        GameObject obj = Instantiate<GameObject>(gun);
        obj.transform.SetParent(playSkin.transform.parent);
        SkinnedMeshRenderer mass = obj.GetComponent<SkinnedMeshRenderer>();
        mass.bones = playSkin.bones;
        mass.rootBone = playSkin.rootBone;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
