using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
				PopupTextBox.GetComponent<Text>().text = "You win!\nPress \"Enter\" to continue";
				sharedValues.crossWinState = sharedValues.crossWinState | (1 << sharedValues.level);
				displayedState = 2;
			}
			else if (sharedValues.hasGameStarted && sharedValues.isGameOver) {
				SetUIState(true);
				PopupTextBox.GetComponent<Text>().text = "Time up!\nPress \"r\" to restart";
				displayedState = 1;
			}
		}
		if (displayedState == 2 && Input.GetKeyDown("return")) {
			SceneManager.LoadScene("main");
		}
	}

	void SetUIState(bool state) {
		PopupTextBox.SetActive(state);
		GetComponent<Image>().enabled = state;
	}

}
