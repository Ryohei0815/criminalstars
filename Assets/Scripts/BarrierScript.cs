using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrierScript : MonoBehaviour {
	
	void OnCollisionEnter(Collision poco){
		if (poco.gameObject.CompareTag ("Player")) {
			SceneManager.LoadScene ("GameOver");
		}
	}
}
