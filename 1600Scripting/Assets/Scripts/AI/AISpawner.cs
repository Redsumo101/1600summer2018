using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{

	public GameObject Ai;
	public Transform Destination;
	public Level CurrentLevel;
	public int aiCount;
	private void Start ()

	{
		aiCount = CurrentLevel.AiCount;
		StartCoroutine(StartSpawn());
	}

	private IEnumerator StartSpawn()
	{
		while (aiCount > 0)
		{
			GameObject newAI = Instantiate(Ai);
			newAI.GetComponent<AIMovement>().Destination = Destination;
			aiCount--;
			
			yield return new WaitForSeconds(2);
			}
		CurrentLevel.CheckAiCount(aiCount);
	}
}
