using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
	
	GameManager gameManager;
	public float score;
	public Text scoreText;
	//public static ScoreManager Instance = null;

	void Awake ()
	{

		gameManager = GameObject.FindGameObjectWithTag ("Manager").GetComponent<GameManager> ();

//		if (Instance = null) {
//			Instance = this;
//			DontDestroyOnLoad (this.gameObject);
//		} else {
//			Destroy (this.gameObject);
//			Debug.Log ("Destroy");
//		}

	}

	private void Update ()
	{

		score += gameManager.speed * Time.deltaTime;
		scoreText.text = score.ToString ("000.0") + "M";

	}

}
