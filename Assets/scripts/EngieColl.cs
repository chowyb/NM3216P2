using UnityEngine;
using System.Collections;

public class EngieColl : MonoBehaviour {

	public GameObject logic;
	public GameObject dialogue;

	void OnTriggerEnter2D(Collider2D other) {
		if (logic.GetComponent<StartupMain>().dialogueState == 3) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(21);
		}
		else if (logic.GetComponent<StartupMain>().dialogueState == 5) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(33);
		}
	}
}
