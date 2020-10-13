using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(collision.gameObject);
			Debug.Log("Ruined");
		}
	}

//	public float delay = 4f;
//	// Use this for initialization
//	void Awake () {
//		Destroy(gameObject, delay);
//	}

//	public void DestroyOnImpact()
//	{
//		Destroy((gameObject));
//	}
	// Update is called once per frame
	
}
