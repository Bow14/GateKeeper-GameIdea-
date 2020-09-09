using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Description : MonoBehaviour
{
	private UnityEvent action;

	private void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			print("Welcome to GateKeeper, Find the gems and compelete the level. GL :D");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
