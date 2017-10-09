using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
	public Text ScoreText;

	GameObject FindObject;

	void Start ()
	{
	
//		FindObject = GameObject.Find ("ScoreManager");
//		ScoreManager sco = FindObject.GetComponent<ScoreManager> ();
		ScoreText.text = ScoreManager.Instance.score.ToString ("000.0") + "M";
	
	}

	public void Retry ()
	{

		SceneManager.LoadScene ("Main");

	}

}
