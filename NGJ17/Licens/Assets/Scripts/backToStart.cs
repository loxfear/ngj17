using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class backToStart : MonoBehaviour, IPointerClickHandler {




		public void OnPointerClick(PointerEventData eventData) {
			Application.LoadLevel("start_screen");
		}
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
	}
