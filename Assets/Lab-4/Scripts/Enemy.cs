using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform player;

    public Material mat1;
    public Material mat2;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(player.position);

        if (navMeshAgent.remainingDistance > navMeshAgent.stoppingDistance)
            this.GetComponent<MeshRenderer>().material = mat1;
        else
            this.GetComponent<MeshRenderer>().material = mat2;
    }
}
