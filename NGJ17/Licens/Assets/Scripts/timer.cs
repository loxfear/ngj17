﻿using System.Collections;
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
		
		myTimer -= Time.deltaTime;
		timerText.text = myTimer.ToString ("f2");
		print (myTimer);
	
	}
}
