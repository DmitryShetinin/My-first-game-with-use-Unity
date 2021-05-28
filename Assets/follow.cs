using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 


public class follow : MonoBehaviour
{
    public Transform target;
    Vector3 destination;
    NavMeshAgent agent;

    // Start is called before the first frame update


 
    private void SetTarget(ref Transform target)
    {
        target = GameObject.Find("Capsule").transform;
    }
    void Start()
    {
        SetTarget(ref target);
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (Vector3.Distance(destination, target.position) > 1.0f)
            {
                destination = target.position;
                agent.destination = destination;
            }
        }
        else
        {

        }

     
    }
}
