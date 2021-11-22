using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    static int numberOfAgents=10;
    const int SlimeMax = 10;
    public float timeToSpawn = 15f;
    public GameObject agent;
    public Transform ResownPoint;
    public Transform Destination;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToSpawn)
        {
            RespawnUnits(numberOfAgents);
            timeToSpawn += timeToSpawn;
        }
    }
    private void RespawnUnits(int numb)
    {
        
        for (int i = 0; i < numb; i++)
        {
            GameObject newAgent = GameObject.Instantiate(agent, ResownPoint.position,Quaternion.identity);
            newAgent.GetComponent<NavMeshAgent>().Move(new Vector3(ResownPoint.position.x, 0, ResownPoint.position.z));
            newAgent.GetComponent<Agent>().SetDestination(Destination);
        }


    }

}
