using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unit : Building //inheritence
{
    NavMeshAgent agent;

    void Awake()
    {
        GetAgent();
        GetRef();
        SetName();
        HideLabel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetAgent()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public virtual void Move(Vector3 point)//Polimoprhism
    {
        agent.SetDestination(point);
    }

    public virtual void Move(Building target)
    {
        agent.SetDestination(target.transform.position);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Building")
        {
            agent.isStopped = true;
        }
    }
}
