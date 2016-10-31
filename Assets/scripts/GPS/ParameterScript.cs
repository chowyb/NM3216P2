using UnityEngine;
using System.Collections;

public class ParameterScript : MonoBehaviour {

	private float wallDistance = 0.25F;

	public int numRows;
	public int numCols;
	public int trapCount;
	public int numGuards;

	public float timeDeduction;
	public float timeInvincible;

	public int numHoles;
	public float gameTime;

	public float timeout;

	// Use this for initialization
	void Awake () {
		FixedParameters.generateParameters(wallDistance, numRows, numCols, trapCount, numHoles,
			                               Mathf.CeilToInt(timeout * 60), numGuards, Mathf.CeilToInt(timeDeduction * 60), Mathf.CeilToInt(timeInvincible * 60));
	    SharedValues sharedValues = SharedValues.GetInstance();
	    sharedValues.timeLeft = Mathf.CeilToInt(gameTime * 60);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
