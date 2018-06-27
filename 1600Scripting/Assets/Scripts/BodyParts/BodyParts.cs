using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BodyParts : MonoBehaviour {

	public enum BodyPartType
	
	{
		BigRightArm,
		BigLeftArm,
		BigRightLeg,
		BigLeftLeg,
		StrongChest,
		
	}

	public BodyPart[] BodyObejects;

	public BodyPartType CurrentBodyPart;
	
	
	void Update () 
	{
		switch (CurrentBodyPart)
		{
			case BodyPartType.BigRightArm:
				Debug.Log(BodyObejects[0].name);
				Debug.Log(BodyObejects[0].DoDamage());
				break;
         
			case BodyPartType.BigLeftArm:
				Debug.Log(BodyObejects[1].name);
				Debug.Log(BodyObejects[1].DoDamage());
				break;
         
			case BodyPartType.BigRightLeg:
				Debug.Log(BodyObejects[2].name);
				Debug.Log(BodyObejects[2].DoDamage());
				break;
         
			case BodyPartType.BigLeftLeg:
				Debug.Log(BodyObejects[3].name);
				Debug.Log(BodyObejects[3].DoDamage());
				break;
         
			case BodyPartType.StrongChest:
				Debug.Log(BodyObejects[4].name);
				Debug.Log(BodyObejects[4].DoDamage());
				break;
		}
	}
}
