using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class medalaward : MonoBehaviour {
	private Text text;

	void Start () {
		text = GetComponent<Text> ();
	}
		
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("Target").Length == 0) { 
			if (Time.time <= 4f) {
				text.text = "Gold medal";
				text.color = Color.green;
				Time.timeScale = 0;
			}
			if (Time.time <= 6f) {
				if (Time.time > 4f) {
					text.text = "Silver medal";
					text.color = Color.green;
					Time.timeScale = 0;
				}
			}
			if (Time.time <= 10f) {
				if (Time.time > 6f) {
					text.text = "Bronze medal";
					text.color = Color.green;
					Time.timeScale = 0;
				}
			}
			if (Time.time <= 20f) {
				if (Time.time > 10f) {
					text.text = "Copper medal";
					text.color = Color.green;
					Time.timeScale = 0;
				}
			}
			if (Time.time >= 20f) {
				text.text = "No medal awarded";
				text.color = Color.red;
				Time.timeScale = 0;
			}
		}
			
	}
}