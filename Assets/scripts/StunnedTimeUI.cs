using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StunnedTimeUI : MonoBehaviour {

	private Text stunnedTimeUI;
	private SharedValues sharedValues = SharedValues.GetInstance();

	// Use this for initialization
	void Start () {
		stunnedTimeUI = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (sharedValues.isStunned) {
			string timeLeftString = (sharedValues.stunnedTime / 60.0F).ToString("0.00");
			stunnedTimeUI.text = "Stunned!: " + timeLeftString;
		}
		else {
			stunnedTimeUI.text = "";
		}
	}
}
