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

        Vector3 movement = Vector3.zero;
        movement.x = Input.acceleration.x;
        movement.z = Input.acceleration.y;
        if (movement.sqrMagnitude > 1) {
            movement.Normalize();
        }

        if (movement.ToString() != null) {
			text.text = "(X: " + Input.acceleration.x + ", Y: " + Input.acceleration.y + ", Z: " + Input.acceleration.z + ")\nmoveHorizontal: " + movement.x + "\nmoveVertical:" + movement.z;
		}

		rb.AddForce (movement * speed);
	}
}