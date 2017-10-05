using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenManagerScript : MonoBehaviour {

	GameObject mainCamera;
	GameObject Citizen;
	Camera main;

	public GameObject[] citizenObjs;

	private int num;

	void Awake() {
		num = Random.Range(1, citizenObjs.Length);
		List<int> tempNums = new List<int>() { 0, 1, 2, 3 };
		//refObj = GameObject.Find("GroundCreater");
		//d1 = refObj.GetComponent<GroundManagerScript>();

		for (int i = 0; i < num; i++) {
			int randomIndex = Random.Range(0, tempNums.Count);
			citizenObjs[tempNums[randomIndex]].SetActive(true);
			tempNums.Remove(randomIndex);
		}


		if (this.transform.parent.name == "Ground") {
			num = 0;
		}
	}
}