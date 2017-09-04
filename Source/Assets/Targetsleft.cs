using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Targetsleft : MonoBehaviour {
	private Text text;

	void Start () {
		text = GetComponent<Text> ();
	}

	void Update () {
		text.text = "Targets Left: " + (GameObject.FindGameObjectsWithTag("Target").Length);
	}
}