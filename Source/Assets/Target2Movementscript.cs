using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target2Movementscript : MonoBehaviour {

	public GameObject B2;
	GameObject targ;
	GameObject [] targets;
	int currentindex = 0;

	void Start () {
		targ = 
			GameObject.Find ("A2");
		targets = new GameObject[2];
		targets [0] = GameObject.Find ("B2");
		targets [1] = GameObject.Find ("A2");
	}
		
	void Update () {
		Debug.Log(targ);
		transform.position = Vector3.Lerp (transform.position, targets [currentindex].transform.position, Time.deltaTime);
		if (Vector3.Distance (transform.position, targets [currentindex].transform.position) < 1.5) {
			currentindex = (currentindex+1) % targets.Length;
		}
	}
}