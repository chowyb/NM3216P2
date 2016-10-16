using UnityEngine;
using System.Collections;

public class SharedValues {

	private static SharedValues sharedValues = null;

	public int wallFrames = 0;
	public bool areWallsShown = true;
	public int timeLeft;
	public int trapDisplayState = 1;
	public int trapDisplayStateTime = 120;
	public float confusedFactor = 1;
	public int confusedTime;
	public bool isStunned = false;
	public int stunnedTime;
	public bool isGameOver = false;

	public static SharedValues GetInstance() {
		if (sharedValues == null) {
			sharedValues = new SharedValues();
		}

		return sharedValues;
	}
}
