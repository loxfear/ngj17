﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : MonoBehaviour {
	
	public float points = 10;
	public float score;

	public GameObject itemOBJ;



	void Start () {

		itemOBJ = GameObject.FindWithTag ("itemOBJ");

		}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
 	
			Physics.Raycast (ray, out hit);

			if (hit.collider.tag == "itemOBJ") {
				if (hit.collider.GetComponent<pickItem> ().isPicked == false) {
				
					AddPoints (points);
					hit.collider.GetComponent<pickItem> ().isPicked = true;
				}
			}
		}
	}

	public void OnGUI() {
		//GUI.contentColor = Color.white;
		GUIStyle myStyle = new GUIStyle(GUI.skin.GetStyle("label"));
		myStyle.fontSize = 35;

		GUI.Label(new Rect (70, 20, 100, 100),score.ToString("0"), myStyle);
		//GUILayout.Label("Score: " + score.ToString("0"));
	}

	void AddPoints(float points) {
		score += points;

		//this.hit.collider.GetComponent<pickItem> ().isPicked = true;
	}
}
