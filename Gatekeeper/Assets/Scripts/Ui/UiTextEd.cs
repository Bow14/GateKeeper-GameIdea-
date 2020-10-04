using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class UiTextEd : MonoBehaviour
{


	private Text Label;

	public void UpdateText(IntData data)
	{
		Label.text = data.gemScore.ToString();
	}

	private void Awake()
	{
		Label = GetComponent<Text>();
	}
}
