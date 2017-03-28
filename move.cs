using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 5.0f;

	void FixedUpdate(){
			// Get input from key WSAD, Gampads, ....
			float h = Input.GetAxisRaw("Horizontal");
			float v = Input.GetAxisRaw("Vertical");

			// set the rigidbody's velocity
			Vector2 dir = new Vector2(h, v);
			GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;

			GetComponent<Animator>().SetBool("flying", (v > 0));
	}
}
