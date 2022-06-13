using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ghost : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;

    // Use this for initialization
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        agent.SetDestination(target.position);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<pacman>() != null)
        {
            Destroy(other.gameObject);
        }
    }
}
