using UnityEngine;
using System.Collections;

public class CapnColl : MonoBehaviour {

	public GameObject logic;
	public GameObject dialogue;

	void OnTriggerEnter2D(Collider2D other) {
		if (logic.GetComponent<StartupMain>().dialogueState == 10) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(44);
			logic.GetComponent<StartupMain>().dialogueState++;
		}
		else if (logic.GetComponent<StartupMain>().dialogueState == 13) {
			dialogue.GetComponent<DialogueMain>().StartDialogue(65);
			logic.GetComponent<StartupMain>().dialogueState++;
		}
	}
}
