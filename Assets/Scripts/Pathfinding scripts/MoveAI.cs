using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAI : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(agent == null)
        {
            Debug.Log("agent is lost");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(agent != null)
        {
            if(agent.destination != goal.position)
            {
                agent.destination = goal.position;
            }
        }
    }
}
