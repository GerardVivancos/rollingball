using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AccelerometerInputScript : MonoBehaviour {

	public float speed;
	//public GameObject textObject;

	private Rigidbody rb;
	public Text text;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		//text = textObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = (float) System.Math.Round(Input.acceleration.x, 1);
		float moveVertical = (float) System.Math.Round(Input.acceleration.y, 1);

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		if (movement.ToString() != null) {
			text.text = "(X: " + Input.acceleration.x + ", Y: " + Input.acceleration.y + ", Z: " + Input.acceleration.z + ")\nmoveHorizontal: " + moveHorizontal + "\nmoveVertical:" +moveVertical;
		}

		rb.AddForce (movement * speed);
	}
}