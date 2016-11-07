using UnityEngine;
using System.Collections;

public class CapnColl : MonoBehaviour {

	public GameObject logic;
	public GameObject dialogue;

	void OnTriggerEnter2D(Collider2D other) {
		if (logic.GetComponent<StartupMain>().dialogueState == 6) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(44);
		}
		else if (logic.GetComponent<StartupMain>().dialogueState == 8) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(65);
		}
	}
}
