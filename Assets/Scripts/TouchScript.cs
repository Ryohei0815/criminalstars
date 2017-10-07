using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour {

	RaycastHit hit;
	bool isTouchDown;
	float timer;

	Vector3 touchStartPos;
	Vector3 touchEndPos;

	// Update is called once per frame
	void Update() {
		//この時点でスワイプかどうか判定する必要性
		//押された瞬間から時間を測る

		if (isTouchDown) {
			timer += Time.deltaTime;
		}
		if (!isTouchDown) {
			if (timer < 1f) {
				CheckInput();
			}

			timer = 0;
		}

		CheckTouch();
	}

	void CheckInput() {
		//タッチかどうか
		float dis = Vector3.Distance(touchStartPos, touchEndPos);
		if (dis < 1f) {
			Shot();
		} else if (dis > 3) {
			//フリックかな？
			//上向きかな？？
		}
	}

	void CheckTouch() {
		if (Input.GetMouseButtonDown(0)) {
			isTouchDown = true;
			touchStartPos = Input.mousePosition;
		} else if (Input.GetMouseButton(0)) {
			isTouchDown = true;
			touchEndPos = Input.mousePosition;
		} else {
			isTouchDown = false;
		}

	}

	void Shot() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float distance = 100;
		if (Physics.Raycast(ray, out hit, distance)) {
			if (hit.collider.tag == "Citizen") {
				hit.collider.SendMessage("Touch");
			}
		}
	}

}
