using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timecomplete : MonoBehaviour {
	private Text text;

	void Start () {
		text = GetComponent<Text> ();
	}

	void Update () {
		if (Time.timeScale == 0){
			text.text = "Targets destroyed in: " + Time.time.ToString() + "s";
			text.color = Color.red;
		}
	}
}