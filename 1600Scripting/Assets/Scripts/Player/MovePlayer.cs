using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class MovePlayer : MonoBehaviour
{
	private Camera cam;
	public LayerMask movementMask;
	private PlayerMotor motor;
	private Vector3 newPosition;
	
	public float Gravity = 9.81f;
	public float JumpSpeed = 10.0f;


	// Use this for initialization
	void Start()
	{
		cam = Camera.main;
		motor = GetComponent<PlayerMotor>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100, movementMask))
			{
				motor.MoveToPoint(hit.point);

			}
		}

		if (Input.GetKeyDown(KeyCode.Space))
			{
				newPosition.y = JumpSpeed;
			}

			newPosition.y -= Gravity;




		}

	}

