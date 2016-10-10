using UnityEngine;
using System.Collections;

public class TrapGPS : MonoBehaviour {

	private SharedValues sharedValues = SharedValues.GetInstance();

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player")) {
			sharedValues.isStunned = true;
			sharedValues.stunnedTime = 60;
			gameObject.SetActive(false);
		}
	}
}
