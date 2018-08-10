using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{
	 Transform target;
	 NavMeshAgent agent;
	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		if (target != null)
		{
			agent.SetDestination(target.position);
			FaceTarget();
		}
	}

	public void MoveToPoint(Vector3 point)
	{
		agent.SetDestination(point);
	}
//this is to follow the target even if it moves
	public void FollowTarget(Interactable newTarget)
	{
		//this is so that even though the player is in the max distance of the interactable it will still turn to face the object if it moves 
		agent.stoppingDistance = newTarget.radius * .8f;
		agent.updateRotation = false;
		target = newTarget.interactionTransform;
	}

	public void StopFollowingTarget()
	{
		agent.stoppingDistance = 0f;
		target = null;
		agent.updateRotation = true;
	}
//this is so that even though the player is in the max distance of the interactable it will still turn to face the object if it moves 
	void FaceTarget()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		//controls the rotation of the player and doesnt allow the player to look up and down
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
	}
	
	
}
