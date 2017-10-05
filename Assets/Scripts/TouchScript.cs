﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour {

	RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Shot ();
		}
		
	}

	void Shot(){
		Vector3 center = new Vector3(Screen.width/2,Screen.height/2,0);
		Ray ray = Camera.main.ScreenPointToRay (center);
		float distance = 100;
		if (Physics.Raycast (ray, out hit, distance)) {
			if (hit.collider.tag == "Citizen") {
				hit.collider.SendMessage ("Touch");
			}
		}
	}

}
