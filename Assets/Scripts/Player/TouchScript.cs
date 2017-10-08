using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour {

	PlayerJump playerJump;
	RaycastHit hit;
	bool isTouchDown;
	float timer;
	bool isJumpInOneTouch;

	Vector3 touchStartPos;
	Vector3 touchEndPos;

	void Awake() {
		playerJump = GetComponent<PlayerJump> ();
	}

	// Update is called once per frame
	void Update() {
		//この時点でスワイプかどうか判定する必要性
		//押された瞬間から時間を測る
		CheckTouch();

		if (isTouchDown) {
			timer += Time.deltaTime;
			if (timer > 0.1f) {
				CheckInput (timer);
			}
		}
		if (!isTouchDown) {
//			if (0.01f < timer && timer < 1f) {
//				CheckInput();
//			}
			isJumpInOneTouch = false;
//			float dis = Vector3.Distance(touchStartPos, touchEndPos);
//			Debug.Log (dis / timer);
			timer = 0;
		}

	}
	void CheckInput(float timer) {
		//タッチかどうか
		float dis = Vector3.Distance(touchStartPos, touchEndPos);
		if (dis / timer > 200f && !isJumpInOneTouch) {
			playerJump.Jump ();
			isJumpInOneTouch = true;
		}
		if (dis / timer < 100f) {
			Shot();
			Debug.Log ("aaaaaaa");
			//フリックかな？
			//上向きかな？？
		} 
//		else if (dis > 30f && (touchEndPos - touchStartPos).y >0) {
//			playerJump.Jump ();
//		}
	}

//	void CheckInput() {
//		//タッチかどうか
//		float dis = Vector3.Distance(touchStartPos, touchEndPos);
//		if (dis < 20f) {
//			Shot();
//		//フリックかな？
//		//上向きかな？？
//		} else if (dis > 30f && (touchEndPos - touchStartPos).y >0) {
//			playerJump.Jump ();
//		}
//	}

	void CheckTouch() {
		if (Input.GetMouseButtonDown(0)) {
			isTouchDown = true;
			touchStartPos = Input.mousePosition;
//			Debug.Log("StarPos : " + touchStartPos);
		} else if (Input.GetMouseButton(0)) {
			isTouchDown = true;
			touchEndPos = Input.mousePosition;
		} else {
			isTouchDown = false;
			if (Input.GetMouseButtonUp (0)) {
//				Debug.Log ("EndPos : " + touchEndPos);
//				Debug.Log ("Dis" + Vector3.Distance (touchStartPos, touchEndPos));
			}
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
