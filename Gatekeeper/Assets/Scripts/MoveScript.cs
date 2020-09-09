using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

	private Vector3 position;
	public CharacterController keyboard;
	public float speed = 10f;
	public float gravity = 3f;
	public float jumpSpeed = 30f;
	public int jumpCount;
	public int jumpMax = 2;

	public void ChangeJumpMax()
	{
		jumpMax = 2;
	}
	// Use this for initialization
	void Start ()
	{
		keyboard = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		position.y -= gravity;
		if (Input.GetAxis("Horizontal")> 0)
		{
			Vector3 newScale = new Vector3(1,1,1);
			transform.localScale = newScale;//Google and research new scale to make sure you know what you mean
			
		}
		else if (Input.GetAxis("Horizontal")< 0)
		{
			Vector3 newScale = new Vector3(-1,1,1);
			transform.localScale = newScale;
		}

		if (Input.GetButtonDown("Jump")&& jumpCount < jumpMax)
		{
			jumpCount++;
			position.y = jumpSpeed;
		}

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			speed = 20;
		}

		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			speed = 10;
		}

		if (keyboard.isGrounded)
		{
			position.y = 0;
			jumpCount = 0;
		}
		keyboard.Move(position * Time.deltaTime);

	}
}
