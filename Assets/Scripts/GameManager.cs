using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public float speed;

	public float degree;

	public Text degreeText;

	float timer;

	void Update ()
	{
		timer += Time.deltaTime;

		if (timer > 2.5f) {
			timer = 0;
			speed += 0.5f;
			degree++;
		}
		if (degree >= 6f) {
			degree = 6f;
		}

		degreeText.text = "★ × " + degree.ToString ();

	}

	void DegreeDown ()
	{
		degree--;
		speed--;
	}

}
