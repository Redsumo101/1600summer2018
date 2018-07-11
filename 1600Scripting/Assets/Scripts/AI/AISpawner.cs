using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{

	public GameObject Ai;
	public Transform Destination;
	private void Start ()
	{
		StartCoroutine(StartSpawn());
	}

	IEnumerator StartSpawn()
	{
		while (true)
		{
			GameObject newAI = Instantiate(Ai);
			newAI.GetComponent<AIMovement>().Destination = Destination;
			yield return new WaitForSeconds(2);

		}
	}
}
