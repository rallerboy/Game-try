using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform targetPoint;

    void Update()
    {
        agent.SetDestination(targetPoint.position);
    }

    /*
    public void TargetLocked()
    {
        agent.SetDestination(targetPoint.position);
    }
    */
}

