using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeLeftUI : MonoBehaviour {

	private Text timeLeftUI;
	private SharedValues sharedValues = SharedValues.GetInstance();

	// Use this for initialization
	void Start () {
		timeLeftUI = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		string timeLeftString = (sharedValues.timeLeft / 60).ToString();
		timeLeftUI.text = "Time Left: " + timeLeftString;
	}
}
