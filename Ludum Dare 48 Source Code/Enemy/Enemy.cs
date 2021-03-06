using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;

    public Animator animator;

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
        animator.SetBool("run", true); //playing the run animation
    }
}
