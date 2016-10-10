﻿using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public GameObject player;

	private bool isOverview = false;
	private Vector3 offset;
	private Vector3 mazeCentre = new Vector3(2.25F, -2.25F, -10);
	private float nextSize = 3.05F;
	private Camera playerCamera;

	// Use this for initialization
	void Start() {
		offset = transform.position - player.transform.position;
		playerCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown("space")) {
			Debug.Log("pressed");
			isOverview = !isOverview;
			float tempSize = nextSize;
			nextSize = playerCamera.orthographicSize;
			playerCamera.orthographicSize = tempSize;
		}

		if (!isOverview) {
			transform.position = player.transform.position + offset;
		}

		else {
			transform.position = mazeCentre;
		}
	}
}
