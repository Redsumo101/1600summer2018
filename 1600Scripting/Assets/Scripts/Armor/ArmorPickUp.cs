using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPickUp : MonoBehaviour
{

	public ArmorObject Armor;
	public ArmorCollection Collection;
	
	private void OnTriggerEnter(Collider obj)
	
	{
		Collection.CollectArmor(Armor);
		
	}

	
}
