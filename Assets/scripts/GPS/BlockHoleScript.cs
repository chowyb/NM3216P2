using UnityEngine;
using System.Collections;

public class BlockHoleScript : MonoBehaviour {

	public GameObject block;
	public GameObject hole;
	public GameObject selfobject;

	private SharedValues sharedValues = SharedValues.GetInstance();

	protected const float WALL_DISTANCE = FixedParameters.WALL_DISTANCE;
	protected const float HALF_WALL_DISTANCE = FixedParameters.HALF_WALL_DISTANCE;
	protected const float QUARTER_WALL_DISTANCE = FixedParameters.QUARTER_WALL_DISTANCE;

	private const int numRows = FixedParameters.numRows;
	private const int numCols = FixedParameters.numCols;

	public const int numHoles = FixedParameters.numHoles;

	private int [,] holes = new int[numHoles, 2];
	private int [,] blocks = new int[numHoles, 2];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < numHoles; i++) {
			holes[i, 0] = Random.Range(0, numRows * 2);
			holes[i, 1] = Random.Range(0, numCols * 2);
			blocks[i, 0] = Random.Range(0, numRows * 2);
			blocks[i, 1] = Random.Range(0, numCols * 2);
		}
		SpawnNewBlockHolePair();
	}
	
	public void SpawnNewBlockHolePair() {
		if (sharedValues.holesSpawned < numHoles) {
			SpawnHole(sharedValues.holesSpawned);
			SpawnBlock(sharedValues.holesSpawned);
			sharedValues.holesSpawned++;
		}
		else {
			sharedValues.win = true;
			sharedValues.isGameOver = true;
			sharedValues.holesSpawned++;
		}
	}

	void SpawnHole(int index) {
		int holeRow = holes[index, 0];
		int holeCol = holes[index, 1];
		GameObject newhole = (GameObject)Instantiate(hole, new Vector2(holeCol * HALF_WALL_DISTANCE + QUARTER_WALL_DISTANCE,
			                                      -(holeRow * HALF_WALL_DISTANCE) - QUARTER_WALL_DISTANCE), Quaternion.identity);
		newhole.GetComponent<HoleScript>().bhscriptContainer = selfobject;
		newhole.GetComponent<HoleScript>().GetScript();

	}

	void SpawnBlock(int index) {
		int blockRow = blocks[index, 0];
		int blockCol = blocks[index, 1];
		Instantiate(block, new Vector2(blockCol * HALF_WALL_DISTANCE + QUARTER_WALL_DISTANCE,
			              -(blockRow * HALF_WALL_DISTANCE) - QUARTER_WALL_DISTANCE), Quaternion.identity);

	}
}
