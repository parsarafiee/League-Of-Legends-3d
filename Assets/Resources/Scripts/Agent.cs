using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{


    NavMeshAgent agent;
    public GameObject targerPlayer;
    public float radius=100;
    public Transform destination;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //if (Physics.SphereCast(transform.position,radius,, out hit, 10))
        //{

        //}
        foreach (Collider c in Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Player")))
        {
            if (c)
            {
                Debug.Log("hi");
                targerPlayer = c.gameObject;
            }
            else
            {
                SetDestination(destination);
                targerPlayer = null;
            }

        }

        if (targerPlayer)
        {
            agent.SetDestination(targerPlayer.transform.position);
        }
        else
        {
            agent.SetDestination(destination.position);
        }
        
    }
    public void SetDestination(Transform _destination)
    {
        destination = _destination;
    }


}
