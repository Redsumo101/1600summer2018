using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats {

	// Use this for initialization
	void Start ()
	{
		EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
		
	}

	void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
	{
		if (newItem != null) 
		{
			armor.Addmodifier(newItem.armorModifier);
			damage.Addmodifier(newItem.damageModifier);
		}

		if (oldItem != null)
		{
			armor.RemoveModifier(oldItem.armorModifier);
			damage.RemoveModifier(oldItem.damageModifier);
		}
	}

	public override void Die()
	{
		base.Die();
		PlayerManager.instance.KillPlayer();
	}
}
