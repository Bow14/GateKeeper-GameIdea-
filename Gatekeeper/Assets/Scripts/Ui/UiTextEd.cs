using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class UiTextEd : MonoBehaviour
{


	private Text _label;

	public void UpdateText(IntData data)
	{
		_label.text = data.gemScore.ToString();
	}

	private void Awake()
	{
		_label = GetComponent<Text>();
	}
}
