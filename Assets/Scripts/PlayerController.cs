using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	private int count;

	public float speed;
	public Text countText;
	public Text winText;

	void Start () {
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	// called before rendering a frame. most game code comes here.
	void Update () {

	}

	// called before performing any physics calculations. where physics code goes.
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pickup"))
		{
			other.gameObject.SetActive (false);
			count += 1;
			SetCountText ();
			if (count == 8) {
				winText.text = "You won!";
			}
		}
	}

	void SetCountText () {
		countText.text = "Count: " + count.ToString ();
	}

}