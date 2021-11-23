using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{


    NavMeshAgent agent;
    public GameObject target;
    public float radius = 100;
    public float rangeToDmage;
    public Transform destination;
    public float damage = 10;
    public float timeToDamage = 1;

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
        CheckTofindEnemy();
        if (target)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < rangeToDmage)
            {
                DealDmage(target);
            }

        }



    }
    public void SetDestination(Transform _destination)
    {
        destination = _destination;
    }
    public void CheckTofindEnemy()
    {
        foreach (Collider c in Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Player")))
        {
            if (c)
            {
                Debug.Log("hi");
                target = c.gameObject;
            }


        }


        if (target)
        {
            agent.SetDestination(target.transform.position);
            if (Vector3.Distance(transform.position, target.transform.position) > radius)
            {
                target = null;
            }

        }
        else
        {
            agent.SetDestination(destination.position);
        }
    }

    public void DealDmage(GameObject _target)
    {
        _target.GetComponent<Hp>().AbsorbTheDmage(damage);
    }

    public void SetDamage(int _damage)
    {
        damage = _damage;
    }

}
