using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour
{
	private const float locomationAnimationSmoothTime = .1f;
	private NavMeshAgent agent;
	private Animator animator;
	
	
	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		animator = GetComponentInChildren<Animator>();

	}
	
	// Update is called once per frame
	void Update ()
	{
		float SpeedPercent = agent.velocity.magnitude / agent.speed;
		animator.SetFloat("SpeedPercent", SpeedPercent, locomationAnimationSmoothTime, Time.deltaTime);
	}
}
