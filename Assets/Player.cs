using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		ScoreManager.Instance.score = 0;
		GameManager.Instance.degree = 0;
		GameManager.Instance.speed = 5f;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
