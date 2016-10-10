using UnityEngine;
using System.Collections;

public class SharedValues {

	private static SharedValues sharedValues = null;

	public int frames = 180;
	public bool areWallsShown = true;
	public int timeLeft;
	public float confusedFactor = 1;
	public int confusedTime;
	public bool isStunned = false;
	public int stunnedTime;

	public static SharedValues GetInstance() {
		if (sharedValues == null) {
			sharedValues = new SharedValues();
		}

		return sharedValues;
	}
}
