using UnityEngine;
using System.Collections;

public class CapnColl : MonoBehaviour {

	public GameObject logic;
	public GameObject dialogue;

	void OnTriggerEnter2D(Collider2D other) {
		if (logic.GetComponent<StartupMain>().dialogueState == 0) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(21);
		}
		else if (logic.GetComponent<StartupMain>().dialogueState == 2) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(33);
		}
	}
}
