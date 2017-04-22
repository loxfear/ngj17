using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickItem : MonoBehaviour
{	
	//private bool isFarvet;
	public bool isPicked = false;
	public Color myColer;

	public GameObject timerText2;

	void OnMouseDown()
	{

		if (isPicked == false) {
			
			myColer.b = 0.1f;
			myColer.g = 1f;
			myColer.a = 0.1f;
			gameObject.GetComponent<Renderer> ().material.SetColor ("_TintColor", myColer);

			timerText2 = GameObject.FindWithTag ("scoreDims");
			if (timerText2.tag == "scoreDims") {
				//hit.collider.GetComponent<pickItem> ().isPicked = true;

				timerText2.GetComponent<timer>().myTimer = timerText2.GetComponent<timer>().myTimer + 5;
				//print ("scoreDims");
			}


			//timerText2.text = gameObject.GetComponent<Text> ().text;
			//timerText2 = gameObject.GetComponent<Text> ().text;
			//timerText.text = timerText.text + 5;
			//print (timerText);
			//print(timerText2.text);
			//print ("farvede object");
		} 

		//isPicked = true;
	}
}
	