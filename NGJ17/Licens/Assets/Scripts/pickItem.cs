using UnityEngine;
using System.Collections;

public class pickItem : MonoBehaviour
{	
	//private bool isFarvet;
	public bool isPicked = false;
			

	void OnMouseDown()
	{
		if (gameObject.GetComponent<Renderer>().material.color != Color.green) {
			gameObject.GetComponent<Renderer> ().material.color = Color.green;

			print ("farvede object");
			isPicked = true;

		} else {
			print ("allerede farvet");
			isPicked = false;
		}

	}


}
	