using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
	 
	public int gemScore = 0;
	// Use this for initialization
	void Reset ()
	{
		gemScore = 0;
	}

	public void UpdategemScore(int number)
	{
		gemScore += number;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
