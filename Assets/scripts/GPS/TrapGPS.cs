using UnityEngine;
using System.Collections;

public class TrapGPS : MonoBehaviour {

	public int trapStateOn;

	private SharedValues sharedValues = SharedValues.GetInstance();

	void Update() {
		if (GetComponent<Renderer>() != null) {
			GetComponent<Renderer>().enabled = (sharedValues.trapDisplayState == trapStateOn);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player") && sharedValues.trapDisplayState == trapStateOn) {
			sharedValues.areWallsShown = false;
			sharedValues.wallFrames = 240;
			gameObject.SetActive(false);
		}
	}
}
