using UnityEngine;
using System.Collections;

public class pickItem : MonoBehaviour
{	
	//private bool isFarvet;
	public bool isPicked = false;
	public Color myColer;



	void OnMouseDown()
	{

		if (isPicked == false) {
			
			myColer.b = 0.1f;
			myColer.g = 1f;
			myColer.a = 0.1f;
			gameObject.GetComponent<Renderer> ().material.SetColor ("_TintColor", myColer);

			print ("farvede object");
		} 

		//isPicked = true;
	}
}
	