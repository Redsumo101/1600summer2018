using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
public class BodyPartCollection : ScriptableObject
{
	public List<BodyPart> BodyParts;

	public void CollectBodyPart(BodyPart bodyparts)
	{
		BodyParts.Add(bodyparts);
		foreach (var part in BodyParts)
		{
			Debug.Log(part);
			if (part.name == "BigRightArm")
			{
				Debug.Log("ExtraStrenght");
			}
		}
	}
}
	