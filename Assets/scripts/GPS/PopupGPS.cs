using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopupGPS : MonoBehaviour {

	public GameObject PopupTextBox;

	private SharedValues sharedValues = SharedValues.GetInstance();
	private int displayedState = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (displayedState == 0 && sharedValues.hasGameStarted) {
			if (sharedValues.win) {
				SetUIState(true);
				PopupTextBox.GetComponent<Text>().text = "You win!";
				displayedState = 1;
			}
			else if (sharedValues.hasGameStarted && sharedValues.isGameOver) {
				SetUIState(true);
				PopupTextBox.GetComponent<Text>().text = "Time up!";
				displayedState = 1;
			}
		}
	}

	void SetUIState(bool state) {
		PopupTextBox.SetActive(state);
		GetComponent<Image>().enabled = state;
	}

}
