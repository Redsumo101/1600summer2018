﻿using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
	private Item item;

	public void AddItem(Item newItem)
	{
		item = newItem;
		icon.sprite = item.Icon;
		icon.enabled = true;
	}

	public void ClearSlot()
	{
		item = null;
		icon.sprite = null;
		icon.enabled = false;
	}
	
}
