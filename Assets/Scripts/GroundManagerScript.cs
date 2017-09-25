using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManagerScript : MonoBehaviour {

	[SerializeField] GameObject groudPrefab;
	[SerializeField] GameObject prevObj;

	void Update () {
		if (prevObj.transform.position.x < -10) {
			prevObj = Instantiate (groudPrefab, new Vector3(39, -4 , 0), Quaternion.identity) as GameObject;
		}

		if (prevObj.transform.position.x < -38) {
			Destroy (prevObj);
		}

	}
}
