using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartupMain : MonoBehaviour {

	public GameObject helmsman;
	public GameObject engineer;
	public GameObject captain;

	public GameObject hel;
	public GameObject eng;
	public GameObject cap;

	public Image fadeToBlack;
	public Text counter;

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

	private int counterFrames = 0;

	// Use this for initialization
	void Start () {
		l1c = ((sharedValues.crossWinState & (1 << 0)) != 0);
		l2c = ((sharedValues.crossWinState & (1 << 1)) != 0);
		l3c = ((sharedValues.crossWinState & (1 << 2)) != 0);
		Color faded = new Color(1, 1, 1, 0.2F);
		Color invisible = new Color(1, 1, 1, 0);
		if (!l1c) {
			engineer.GetComponent<SpriteRenderer>().color = faded;
			captain.GetComponent<SpriteRenderer>().color = faded;
			eng.GetComponent<SpriteRenderer>().color = invisible;
			cap.GetComponent<SpriteRenderer>().color = invisible;
			dialogueState = 0;
		}
		else if (!l2c) {
			captain.GetComponent<SpriteRenderer>().color = faded;
			cap.GetComponent<SpriteRenderer>().color = invisible;
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
		else if (dialogueState == 9) {
			Color nextColour = fadeToBlack.color;
			Color textColour = counter.color;
			if (nextColour.a != 1) {
				nextColour.a = nextColour.a + 0.009F;
				if (nextColour.a > 0.99F) {
					nextColour.a = 1;
				}
				fadeToBlack.color = nextColour;
			}
			else if (textColour.a != 1) {
				textColour.a = textColour.a + 0.009F;
				if (textColour.a > 0.99F) {
					textColour.a = 1;
				}
				counter.color = textColour;
			}
			else {
				if (counterFrames > 300) {
					counter.text = "Times run: 0001858";
				}
				else if (counterFrames > 210) {
					counter.text = "Times run: 000185";
				}
				else if (counterFrames < 90) {
					counter.text = "Times run: 0001857";
				}
				else {
					if (counterFrames % 40 < 20) {
						counter.text = "Times run: 000185_";
					}
					else {
						counter.text = "Times run: 000185";
					}
				}
				counterFrames++;
			}
		}
	}
}
