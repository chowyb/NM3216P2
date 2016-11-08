using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class OPScript : MonoBehaviour {

	private int frames = 0;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			SceneManager.LoadScene("main");
		}
		frames++;
		if (frames % 120 < 40) {
			GetComponent<Image>().enabled = false;
		}
		else {
			GetComponent<Image>().enabled = true;
		}
	}
}
