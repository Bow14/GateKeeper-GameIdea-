using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Camera : MonoBehaviour
{

	public Transform playerTransform;

	private Vector3 _cameraOffset;

	public float SmoothFactor = 0.5f;
	
// Use this for initialization
	void Start ()
	{
		_cameraOffset = transform.position - playerTransform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 newPos = playerTransform.position + _cameraOffset;

		transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
	}
}
