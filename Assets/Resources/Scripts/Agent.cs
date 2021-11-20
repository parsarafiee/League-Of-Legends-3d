using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{

    static int numberOfAgents;
    const int SlimeMax = 10;
    Vector2 timeToSpawn = new Vector2(10, 30);
    float timeOfSplit;
    NavMeshAgent agent;
    public Player targerPlayer;

    private void Awake()
    {
        numberOfAgents++;
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        timeOfSplit = Time.deltaTime + Random.Range(timeToSpawn.x, timeToSpawn.y);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Time.time >timeOfSplit&& numberOfAgents<SlimeMax)
        //{
        //    SplitSlime();
        //    timeOfSplit = Time.time + Random.Range(timeToSpawn.x, timeToSpawn.y);

        //}

        if (targerPlayer)
        {
            agent.SetDestination(targerPlayer.transform.position);
        }
        else
        {
            agent.SetDestination(new Vector3(0,0,0));
        }
        
    }

    private void SplitSlime()
    {
        GameObject newAgent = GameObject.Instantiate(gameObject);
        newAgent.GetComponent<NavMeshAgent>().Move(new Vector3(50, 0, 50));


    }
}
