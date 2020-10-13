using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy2 : MonoBehaviour {
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("GameController"))
		{
			Destroy(collision.gameObject);
			Debug.Log("Gammer");
			
		}

		
	}
}
