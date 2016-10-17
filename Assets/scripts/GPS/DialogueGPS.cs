using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueGPS : MonoBehaviour {

	public GameObject DialogueTextBox;

	private SharedValues sharedValues = SharedValues.GetInstance();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("return")) {
			SetUIState(false);
			sharedValues.hasGameStarted = true;
		}
	}

	void SetUIState(bool state) {
		DialogueTextBox.SetActive(state);
		GetComponent<Image>().enabled = state;
	}

}
