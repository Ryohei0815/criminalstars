using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

	float speed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);

		if (this.transform.position.x < -38) {
			Destroy (this.gameObject);
		}

	}
}
