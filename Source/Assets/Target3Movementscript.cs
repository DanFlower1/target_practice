using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target3Movementscript : MonoBehaviour {

	public GameObject A3;
	GameObject targ;
	GameObject [] targets;
	int currentindex = 0;

	void Start () {
		targ = 
			GameObject.Find ("B3");
		targets = new GameObject[2];
		targets [0] = GameObject.Find ("A3");
		targets [1] = GameObject.Find ("B3");
	}

	void Update () {
		Debug.Log(targ);
		transform.position = Vector3.Lerp (transform.position, targets [currentindex].transform.position, Time.deltaTime);
		if (Vector3.Distance (transform.position, targets [currentindex].transform.position) < 1.5) {
			currentindex = (currentindex+1) % targets.Length;
		}
	}
}