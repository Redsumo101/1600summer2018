using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{

	public float lookRadius = 10f;

	private Transform target;
	private NavMeshAgent agent;

	private CharacterCombat combat;
	// Use this for initialization
	void Start ()
	{
		target = PlayerManager.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();
		combat = GetComponent<CharacterCombat>();
	}
	
	// Update is called once per frame
	void Update()
	{
		float distance = Vector3.Distance(target.position, transform.position);

		if (distance <= lookRadius)
		{
			CharacterStats targetStats = target.GetComponent<CharacterStats>();
			if (targetStats != null)
			{
				combat.Attack(targetStats);
			}
			
			agent.SetDestination(target.position);
		}
	}

	private void OnDrawGizmosSelected()
	{
	Gizmos.color=Color.red;
		Gizmos.DrawWireSphere(transform.position, lookRadius);
	}
}
