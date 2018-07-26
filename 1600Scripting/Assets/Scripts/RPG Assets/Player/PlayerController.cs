using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
	private Camera cam;
	public LayerMask movementMask;
	private PlayerMotor motor;
	public Interactable Focus;
	void Start () {
		cam = Camera.main;
		motor = GetComponent<PlayerMotor>();
	}
	
	
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100, movementMask))
			{
				motor.MoveToPoint(hit.point);
				
				//Stop focusing on the object so the player can move
				RemoveFocus();
			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100))
			{
				Interactable interactable = hit.collider.GetComponent<Interactable>();
				if (interactable != null)
				{
					SetFocus(interactable);
				}


			}
		}
	}

	void SetFocus(Interactable newFocus)
	{
		Focus = newFocus;
		motor.FollowTarget(newFocus);
	}

	void RemoveFocus()
	{
		Focus = null;
		motor.StopFollowingTarget();
	}
}
