using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public float speed;

	public int degree;

	float timer;

	private void Awake ()
	{
		if (instance == null)
			DontDestroyOnLoad (this);
	}

	protected static GameManager instance;

	public static GameManager Instance {
		get {
			if (instance == null) {
				instance = (GameManager)FindObjectOfType (typeof(GameManager));

				if (instance == null) {
					Debug.LogWarning (typeof(GameManager) + "is nothing");
				}
			}

			return instance;
		}
	}

	void Update ()
	{
		timer += Time.deltaTime;

		if (timer > 2.5f) {
			timer = 0;
			speed += 0.5f;
			degree++;
		}
		if (degree >= 6) {
			degree = 6;
		}

	}

	void DegreeDown ()
	{
		degree--;
		speed--;
	}

}
