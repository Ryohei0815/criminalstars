using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour {

	public GameObject barrier;
	int num = Randam.Range(0,3);


	void Awake(){
		if (num = 0) {
			transform.position = new Vector3 (Randam.Range(14,62),0,0);
			Instantiate (barrier,transform.position,Quaternion.identity);
		}
		
	}
	

	void Update () {
		
	}
}
