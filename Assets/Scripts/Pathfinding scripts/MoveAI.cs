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
        agent = GetComponent<NavMeshAgent>();//find agent 47
        if(agent == null)
        {
            Debug.Log("agent is lost");// tell me if agent 47 cant be found
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(agent != null)
        {
            if(agent.destination != goal.position)
            {
                agent.destination = goal.position;// give agent 47 a target
            }
        }
    }
}
