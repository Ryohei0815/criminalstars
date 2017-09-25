using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	//float speed = 5f;
	float power = 500f;

	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {

		_rigidbody = this.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		//transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		if (Input.GetKeyDown (KeyCode.Space)) {
			this._rigidbody.AddForce (Vector3.up * power);
		}

	}
}
