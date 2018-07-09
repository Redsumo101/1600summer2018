using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{

	public enum ArmorType

	{
		Helmet,
		Legs,
		Gloves,
		Arms,
		BreastPlate,
	}

	public ArmorObject[] ArmorObjects;

	public ArmorType CurrentArmor;


	void Update()
	{
		switch (CurrentArmor)
		{
			case ArmorType.Helmet:
				Debug.Log(ArmorObjects[0].name);
				Debug.Log(ArmorObjects[0].TakeDamage());
				break;
			case ArmorType.Legs:
				Debug.Log(ArmorObjects[1].name);
				Debug.Log(ArmorObjects[1].TakeDamage());
				break;
			case ArmorType.Gloves:
				Debug.Log(ArmorObjects[2].name);
				Debug.Log(ArmorObjects[2].TakeDamage());
				break;
			case ArmorType.Arms:
				Debug.Log(ArmorObjects[3].name);
				Debug.Log(ArmorObjects[3].TakeDamage());
				break;
			case ArmorType.BreastPlate:
				Debug.Log(ArmorObjects[4].name);
				Debug.Log(ArmorObjects[4].TakeDamage());
				break;
		}
	}
}
