using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueMain : MonoBehaviour {

	public GameObject dialogueTextBox;
	public GameObject rightDialogueImage;

	public Sprite capn;
	public Sprite doc;
	public Sprite engie;
	public Sprite helms;

	private SharedValues sharedValues = SharedValues.GetInstance();
	private int currentDialogueState = -1;


	private string[,] dialogues = {
		{"end", "=============================================== HELMSMAN PREQUEST DIALOGUE ======================================================"},
		{"blank", "Note: to advance the text, hit \"Enter\""},
		{"helms", "Hello it’s great that you’re passing by!\nUnfortunately our spaceship, the SS Adscensio,isn’t in its best condition."},
		{"helms", "What was once the epitome of technological advancement is now stranded deep in the vast emptiness of space."},
		{"helms", "What tragedy.."},
		{"player", "um hello. Who are you? And what happened?"},
		{"helms", "My name is Finnick and I am the chief helmsman of the Adscensio."},
		{"helms", "But what good is a helmsman where we are just floating around in nothingness, at risk of being hit by a stray piece of asteroid debris anytime??"},
		{"helms", "It all started when a computer virus infected this ship and and started sabotaging all her systems."},
		{"player", "The situation sounds severe.\nIs there anything I can do to help?\nI really wish to help!!!"},
		{"helms", "We only have about 2 weeks worth of oxygen and supplies left. We’re desperate.\nYou can try fixing the systems I suppose - we’ve tried before but it never worked..."},
		{"player", "Let me try!\nI...I really want to do this."},
		{"helms", "Okay... lets go."},
		{"end", "=============================================== HELMSMAN POSTQUEST DIALOGUE ========================================================"},
		{"helms", "You...you did it.\nWhat...How...?"},
		{"player", "I don’t know.\nIt wasn’t that hard, I suppose."},
		{"helms", "What????\nHow??\nWe spent weeks trying to fix the systems and you did it in such a short period of time.. I don’t..how?"},
		{"helms", "Thank you! Thank you so much! With this there is still hope...\nI can see my beloved Martha back on Earth.\nThe thought of never seeing her again was..."},
		{"helms", "You need to go and help the others with their systems!! Go to Kaden the head engineer, he’s at his wits end. Go!"},
		{"player", "I really am glad that I could help you.\nI really am so happy that I could be of use to you."},
		{"end", "=============================================== ENGINEER PREQUEST DIALOGUE ========================================================="},
		{"helms", "Hello it’s great that you’re passing by!"},
		{"helms", "Hello it’s great that you’re passing by!"},
		{"helms", "Hello it’s great that you’re passing by!"},
		{"helms", "Hello it’s great that you’re passing by!"},
		{"helms", "Hello it’s great that you’re passing by!"},
	};


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("return")) {
			if (currentDialogueState != -1) {
				if (dialogues[currentDialogueState + 1, 0] == "end") {
					SetUIState(false);
					sharedValues.hasGameStarted = true;
					currentDialogueState = -1;
				}
				else {
					currentDialogueState++;
					SetDialogue(dialogues[currentDialogueState, 0], dialogues[currentDialogueState, 1]);
				}
			}
		}
		if (Input.GetKeyDown("j")) {
			StartDialogue(1);
		}
		if (Input.GetKeyDown("k")) {
			StartDialogue(14);
		}
	}

	public void StartDialogue(int index) {
		SetUIState(true);
		SetDialogue(dialogues[index, 0], dialogues[index, 1]);
		currentDialogueState = index;
		sharedValues.hasGameStarted = false;
	}

	void SetDialogue(string rightImage, string dialogue) {
		switch(rightImage) {
			case "capn":
				SetRightImage(capn);
				break;
			case "doc":
				SetRightImage(doc);
				break;
			case "engie":
				SetRightImage(engie);
				break;
			case "helms":
				SetRightImage(helms);
				break;
		}
		dialogueTextBox.GetComponent<Text>().text = dialogue;
	}

	void SetRightImage(Sprite sprite) {
		rightDialogueImage.GetComponent<Image>().sprite = sprite;
	}

	void SetUIState(bool state) {
		dialogueTextBox.SetActive(state);
		rightDialogueImage.SetActive(state);
		GetComponent<Image>().enabled = state;
	}

}
