using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour {

	public GameObject A0;
	GameObject targ;
	GameObject [] targets;
	int currentindex = 0;

	void Start () {
		targ = 
			GameObject.Find ("B0");
		targets = new GameObject[2];
		targets [0] = GameObject.Find ("A0");
		targets [1] = GameObject.Find ("B0");
	}
		
	void Update () {
		Debug.Log(targ);
		transform.position = Vector3.Lerp (transform.position, targets [currentindex].transform.position, Time.deltaTime);
		if (Vector3.Distance (transform.position, targets [currentindex].transform.position) < 1.5) {
			currentindex = (currentindex+1) % targets.Length;
		}
	}
}