using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public float myTimer = 99;
	public Text timerText;

	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		float blah = myTimer;
		if (blah >= 0.0) {
			myTimer -= Time.deltaTime;
			timerText.text = myTimer.ToString ("f2");


			//gameObject.GetComponent<Text> ().text;
			//print (myTimer);
			//print (blah);
		} else {
			timerText.text = ("done ..");
		}
	
	}
}
