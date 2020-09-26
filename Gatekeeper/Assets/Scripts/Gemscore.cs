using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Gemscore : MonoBehaviour
{

	public static int gemAmount;
	private Text scoreText;

	// Use this for initialization
	void Start ()
	{
		scoreText = GetComponent<Text>();
		gemAmount = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		scoreText.text = "Gem Collected" + gemAmount;
	}
}
