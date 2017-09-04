using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
	private Text text;

	void Start () 
	{
		text = GetComponent<Text> ();
	}

	void Update () 
	{
		text.text = "Time: " + Time.time.ToString() + "s";
		if (Time.time >= 20)
		{
			text.text = ("Time: 20.00000s");
		}
	}
}