using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MiscScriptGPS : MonoBehaviour {

	public GameObject player;
	public Text miscTextUI;

	private bool win = false;
	private bool cheat = false;
	private bool farexpanses = false;
	private SharedValues sharedValues = SharedValues.GetInstance();
	
	// Update is called once per frame
	void Update () {
		if (!cheat && player.transform.position.x > 2 && player.transform.position.y > 0
			|| player.transform.position.x < 0 && player.transform.position.y < -2) {
			if (win) {
				miscTextUI.text = "";
			}
			else {
				miscTextUI.text = "Cheater =P ";
			}
			cheat = true;
		}
		if (!win && player.transform.position.x > 9.825F && player.transform.position.y < -7.325F) {
			if (cheat) {
				miscTextUI.text = "You win, but you cheated :(";
			}
			else {
				miscTextUI.text = "You win!";
			}
			win = true;
			sharedValues.isGameOver = true;
		}
		/*
		if (!farexpanses && (player.transform.position.x < -0.75F || player.transform.position.x > 5.5F
			                 || player.transform.position.y > 0.75F || player.transform.position.y < -5.5F)) {
			miscTextUI.text = "The vastness of space is cold and silent...";
			farexpanses = true;
		}
		*/
	}
}
