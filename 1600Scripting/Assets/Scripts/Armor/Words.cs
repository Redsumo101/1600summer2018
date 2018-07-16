using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Words : MonoBehaviour
{
	public Text DisplayText;

	public List<ArmorObject> Armor;

	// Use this for initialization
	void Start()
	{
		foreach (var protection in Armor)
		{
			Debug.Log(protection);
			if(protection.name == "Helmet")
			{
				DisplayText.text = "You are ready to go";
			}
			else
			{
				DisplayText.text = "Watch your head";
			}
		}
	}
}
	