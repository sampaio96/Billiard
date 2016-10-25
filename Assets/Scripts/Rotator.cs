using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float speedOfOscillation;

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (-30,-30,30) * Time.deltaTime);

		float oscillationAmplitude = Mathf.Sin (Time.time);

		// transform.Translate (new Vector3 (0, speedOfOscillation * oscillationAmplitude, 0) * Time.deltaTime);
	}
}
