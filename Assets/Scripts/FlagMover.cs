using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagMover : MonoBehaviour {

	private float time;
	public float speed;
	public float stop = 10;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime; // Recording time

		if (time > 0) {
			rb2d.AddForce (Vector2.down * speed);
		}
		if (time > 41) { // may need to be changed
			rb2d.velocity = Vector3.zero;
		}
	}
}
