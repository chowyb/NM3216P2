using UnityEngine;
using System.Collections;

public class TimerUpdate : MonoBehaviour {

	private SharedValues sharedValues = SharedValues.GetInstance();

	void Update() {
		sharedValues.frames--;
		if (sharedValues.frames < 0) {
			sharedValues.areWallsShown = !sharedValues.areWallsShown;
			sharedValues.frames = 180;
		}
	}
}
