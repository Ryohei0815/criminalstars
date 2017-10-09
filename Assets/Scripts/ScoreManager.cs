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

	private void Awake ()
	{
		gameManager = GameObject.FindWithTag ("Manager").GetComponent<GameManager> ();
		if (instance == null)
			DontDestroyOnLoad (this);
	}

	protected static ScoreManager instance;

	public static ScoreManager Instance {
		get {
			if (instance == null) {
				instance = (ScoreManager)FindObjectOfType (typeof(ScoreManager));

				if (instance == null) {
					Debug.LogWarning (typeof(ScoreManager) + "is nothing");
				}
			}

			return instance;
		}
	}


	private void Update ()
	{

		score += gameManager.speed * Time.deltaTime;
		scoreText.text = score.ToString ("000.0") + "M";

	}

}
