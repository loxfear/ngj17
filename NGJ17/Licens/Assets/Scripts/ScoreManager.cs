using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	
	public float points = 10;
	private float score;
	public GameObject itemOBJ;
	private bool blah;





	// Use this for initialization

	void Start () {

		itemOBJ = GameObject.FindWithTag ("itemOBJ");

		//this.blah = GetComponent<pickItem> ();
		}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

	//		hit.collider.gameObject.GetComponent<pickItem> ().isPicked ();

			//pickItem blah = hit.collider.gameObject.GetComponent<pickItem> ();

			Physics.Raycast (ray, out hit);
			if (hit.collider.tag == "itemOBJ") {
				if (hit.collider.GetComponent<pickItem> ().isPicked == true) {
					AddPoints (points);
				}
			}
		}
	}

	void OnGUI() {
		GUILayout.Label("Score: " + score.ToString("0"));
	}

	void AddPoints(float points) {
		score += points;
	}
}
