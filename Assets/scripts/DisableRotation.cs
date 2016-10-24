using UnityEngine;
using System.Collections;

public class DisableRotation : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.freezeRotation = true;
	}
	
	// Update is called once per frame
	void OnTriggerStay2D (Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			float h = Input.GetAxis("Fire3");
			Vector3 offset = (other.transform.position - transform.position);
			transform.Translate(offset * h * 0.15F);
		}

	}
}
