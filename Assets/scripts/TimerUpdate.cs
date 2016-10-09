using UnityEngine;
using System.Collections;

public class TimerUpdate : MonoBehaviour {

	private SharedValues sharedValues = SharedValues.GetInstance();

	void Start() {
		sharedValues.timeLeft = 180 * 60;
	}

	void Update() {
		sharedValues.frames--;
		if (sharedValues.frames < 0) {
			sharedValues.areWallsShown = !sharedValues.areWallsShown;
			sharedValues.frames = 180;
		}
		sharedValues.timeLeft--;

		sharedValues.confusedTime--;
		if (sharedValues.confusedTime <= 0) {
			sharedValues.confusedFactor = 1;
		}
	}
}
