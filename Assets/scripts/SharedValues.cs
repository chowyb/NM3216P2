using UnityEngine;
using System.Collections;

public class SharedValues {

	private static SharedValues sharedValues = null;

	public int frames = 180;
	public bool areWallsShown = true;
	public int timeLeft;

	public static SharedValues GetInstance() {
		if (sharedValues == null) {
			sharedValues = new SharedValues();
		}

		return sharedValues;
	}
}
