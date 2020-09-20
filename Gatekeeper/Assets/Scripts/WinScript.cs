using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinScript : MonoBehaviour
{

	public UnityEvent script;

	private void OnTriggerEnter(Collider other)
	{
		
		print("Gem Collected Move Forward");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
