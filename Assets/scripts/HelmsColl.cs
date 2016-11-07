using UnityEngine;
using System.Collections;

public class HelmsColl : MonoBehaviour {

	public GameObject logic;
	public GameObject dialogue;

	void OnTriggerEnter2D(Collider2D other) {
		if (logic.GetComponent<StartupMain>().dialogueState == 0) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(1);
		}
		else if (logic.GetComponent<StartupMain>().dialogueState == 2) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(14);
		}
	}
}
