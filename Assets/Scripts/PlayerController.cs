using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// called before rendering a frame. most game code comes here.
	void Update () {

	}

	// called before performing any physics calculations. where physics code goes.
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement);
	}

}