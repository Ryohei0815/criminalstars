using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

	public bool isJump;
	float power = 500f;

	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {

		_rigidbody = this.GetComponent<Rigidbody> ();

	}
	

	void Update () {

		///
		// for Debug
		///
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump ();
		}

	}

	public void Jump() {
		if (!isJump) {
			isJump = true;
			this._rigidbody.AddForce (Vector3.up * power);
		}

	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Wall")) {

			isJump = false;

		}
	}

}
