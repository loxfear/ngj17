using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour {

	public GameObject getScore;
	public string final;


	// Use this for initialization
	void Awake() {

		DontDestroyOnLoad (this);

	}

	void Start () {


		//getScore = Object.FindObjectOfType<scoreCounter>
		getScore = GameObject.FindWithTag ("getScore");
		if (getScore != null) {
			//final = getScore.GetComponent<scoreCounter>()
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
