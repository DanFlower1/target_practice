using System.Collections;
using UnityEngine;

public class Colour_behavior_script : MonoBehaviour
{
    private Renderer r;

    void Start()
    {
        r = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            r.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G)) {
			r.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B)) {
			r.material.color = Color.blue;
        }
    }
}