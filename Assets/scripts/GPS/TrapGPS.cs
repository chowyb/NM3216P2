using UnityEngine;
using System.Collections;

public class TrapGPS : MonoBehaviour {

	private SharedValues sharedValues = SharedValues.GetInstance();

	void Update() {
		if (GetComponent<Renderer>() != null) {
			GetComponent<Renderer>().enabled = !(SharedValues.GetInstance().areWallsShown);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player")) {
			sharedValues.isStunned = true;
			sharedValues.stunnedTime = 60;
			gameObject.SetActive(false);
		}
	}
}
