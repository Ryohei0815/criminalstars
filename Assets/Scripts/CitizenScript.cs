using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenScript : MonoBehaviour
{

	GameManager gameManager;

	void Awake ()
	{

		gameManager = GameObject.FindGameObjectWithTag ("Manager").GetComponent<GameManager> ();

	}

	void Touch ()
	{
		gameManager.degree--;
		gameManager.speed--;
		Destroy (this.gameObject);
	}
}
