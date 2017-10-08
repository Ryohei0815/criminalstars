using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

	GameManager gameManager;

	void Awake () {
		gameManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager> ();
	}

	void Update () {

		transform.position += new Vector3 (-gameManager.speed * Time.deltaTime, 0, 0);

		if (this.transform.position.x < -38) {
			Destroy (this.gameObject);
		}

	}
}
