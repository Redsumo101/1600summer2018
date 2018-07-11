using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIMovement : MonoBehaviour
{
	private NavMeshAgent Agent;
	public Transform Destination;
	public AIControl Control;
	
	
	private void Start ()
	{
		Agent = GetComponent<NavMeshAgent>();
		Control.ConfigAI(Agent);
	}
	
	
	private void Update ()
	{
		Agent.destination = Destination.position;
	}
}
