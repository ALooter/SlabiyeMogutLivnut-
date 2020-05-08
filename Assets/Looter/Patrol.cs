using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : StateMachineBehaviour
{
    //private PatrolSpots patrol;
    public float speed;
    private int randomSpot;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       // patrol = GameObject.FindGameObjectsWithTag("PatrolSpots").GetComponent<PatrolSpots>();
    }
}
