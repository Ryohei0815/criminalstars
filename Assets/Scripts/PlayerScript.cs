using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public bool jump;
	float power = 500f;

	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {

		_rigidbody = this.GetComponent<Rigidbody> ();

	}
	

	void Update () {
		
		if (!jump && Input.GetKeyDown (KeyCode.Space)) {

			jump = true;
			this._rigidbody.AddForce (Vector3.up * power);
		}

	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Wall")) {

			jump = false;

		}
	}

}
