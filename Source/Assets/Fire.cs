using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour 
{
	private Text text;

	void Start () {
		text = GetComponent<Text> ();
	}

	void Update () 
	{
		if (Input.GetMouseButton (0)) {

			Debug.Log ("Fired");

			RaycastHit hit;

			if (Physics.Raycast (transform.position + transform.forward, transform.forward * 2.5f, out hit, 100.0f)) {
				Debug.Log (hit.collider.gameObject.tag);
				if (hit.collider.gameObject.tag == "Target") {
					GameObject.Destroy (hit.collider.gameObject);
				}
			}
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine (transform.position + transform.forward * 2.5f, transform.position + (transform.forward * 10.0f));
	}
}