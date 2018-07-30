
using UnityEngine;

public class ObjectPickUp : Interactable {
	public override void Interact()
	{
		base.Interact();
		PickUp();
	}

	void PickUp()
	{
		Debug.Log("Picking up item");
		Destroy(gameObject);
	}
	
}
