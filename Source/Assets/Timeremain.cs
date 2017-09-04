using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeremain : MonoBehaviour {

	private Text text;
	private Renderer r;

	void Start () 
	{
		r = GetComponent<Renderer> ();
		text = GetComponent<Text> ();
	}
		
	void Update () 
	{
		float t = 20.0f - Time.time;
		text.text = "Time Remaining: " + t.ToString () + "s";
		if (t <= 10) 
		{
			text.color = Color.red;
		}
		if (t <= 0)
		{
			text.text = ("TIME UP    GAME OVER");
		}
	}
}