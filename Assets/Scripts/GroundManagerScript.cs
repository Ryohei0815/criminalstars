using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManagerScript : MonoBehaviour {

	[SerializeField] GameObject groundPrefab;
	[SerializeField] GameObject prevObj;

	void Update () {
		//Debug.Log (prevObj.transform.position.x);
		if (prevObj.transform.position.x < -10) {
			prevObj = Instantiate (groundPrefab, new Vector3(39, -4 , 0), Quaternion.identity) as GameObject;
			//Debug.Log ("Instansiate");
		}

		if (prevObj.transform.position.x < -38) {
			Destroy (prevObj);
		}

	}
	public GameObject ReturnPrevObj (){
		return prevObj;
	}

}
