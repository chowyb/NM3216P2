using UnityEngine;
using System.Collections;

public class PlayerMovementGPSNonGrid : MonoBehaviour {

	private Rigidbody2D rb2d;
	private const float MOVEMENT_PER_FRAME = 0.0125F;

	// Use this for initialization
	void Start() {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update() {
	
	}

	void FixedUpdate() {

		float h = Input.GetAxis("Horizontal");

		float v = Input.GetAxis("Vertical");

		Vector2 movement = (Vector2.up * v * MOVEMENT_PER_FRAME) + (Vector2.right * h * MOVEMENT_PER_FRAME);

		transform.Translate(movement);
	}

}
