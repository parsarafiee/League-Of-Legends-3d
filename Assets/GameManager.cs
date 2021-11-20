using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    float timeOfSplit;
    static int numberOfAgents;
    const int SlimeMax = 10;
    Vector2 timeToSpawn = new Vector2(10, 30);
    public GameObject agent;
    // Start is called before the first frame update
    void Start()
    {
        timeOfSplit = Time.deltaTime + Random.Range(timeToSpawn.x, timeToSpawn.y);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeOfSplit && numberOfAgents < SlimeMax)
        {
            SplitSlime();
            timeOfSplit = Time.time + Random.Range(timeToSpawn.x, timeToSpawn.y);

        }
    }
    private void SplitSlime()
    {
        GameObject newAgent = GameObject.Instantiate(agent);
        newAgent.GetComponent<NavMeshAgent>().Move(new Vector3(50, 0, 50));


    }
}
