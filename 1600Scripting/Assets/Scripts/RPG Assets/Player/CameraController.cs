using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	public Transform target;
	public float zoomSpeed = 4f;
	public float minZoom = 5f;
	public float maxZoom = 15f;
	public Vector3 offset;
	private float currentZoom = 8f;
	//speed of moving the camera
    	public float yawSpeed = 100f;
	//current angle
	private float currentYaw = 0f;
	private float pitch = 2f;

	private void Update()
	{
		currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
		//this keeps the zoom inbetween the minimum and maximum
		currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
		//controls which way I can turn the camera
		currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
	}

	void LateUpdate()
	{
		//controls the general angle of the camera
		transform.position = target.position - offset * currentZoom;
		transform.LookAt(target.position+Vector3.up * pitch );
		//allows rotation around the target
		transform.RotateAround(target.position,Vector3.up,currentYaw);
	}
}
