using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public GameObject A;
    GameObject player;

	void Start () 
	{
		player = 
		GameObject.Find ("FPSController");
	}

	void Update () {
		Debug.Log(player);
		transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime);
	}
}