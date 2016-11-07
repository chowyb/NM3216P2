using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartupMain : MonoBehaviour {

	public GameObject helmsman;
	public GameObject engineer;
	public GameObject captain;

	public GameObject hel;
	public GameObject eng;
	public GameObject cap;

	[HideInInspector]
	public int dialogueState;
	/* possible dialogue states:
	0: just started
	1: just finished 1 prequest
	2: just finished level 1
	3: just finished 1 postquest
	4: just finished 2 prequest
	5: just finished level 2
	6: just finished 2 postquest
	7: just finished 3 prequest
	8: just finished level 3
	9: just finished 3 postquest
	*/

	private SharedValues sharedValues = SharedValues.GetInstance();

	private bool l1c = false;
	private bool l2c = false;
	private bool l3c = false;

	// Use this for initialization
	void Start () {
		l1c = ((sharedValues.crossWinState & (1 << 0)) != 0);
		l2c = ((sharedValues.crossWinState & (1 << 1)) != 0);
		l3c = ((sharedValues.crossWinState & (1 << 2)) != 0);
		Color faded = new Color(1, 1, 1, 0.2F);
		if (!l1c) {
			engineer.GetComponent<SpriteRenderer>().color = faded;
			captain.GetComponent<SpriteRenderer>().color = faded;
			dialogueState = 0;
		}
		else if (!l2c) {
			captain.GetComponent<SpriteRenderer>().color = faded;
			dialogueState = 2;
		}
		else if (!l3c) {
			dialogueState = 5;
		}
		else {
			dialogueState = 8;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (dialogueState == 1) {
			SceneManager.LoadScene("level1");
		}
		else if (dialogueState == 4) {
			SceneManager.LoadScene("level2");
		}
		else if (dialogueState == 7) {
			SceneManager.LoadScene("level3");
		}
	}
}
