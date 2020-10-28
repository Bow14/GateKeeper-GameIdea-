using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{

	public GameManger gameManger;
	private void OnTriggerEnter()
	{
		gameManger.CompleteLevel();
	}
}
