using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour {

	//public GameObject refObj;
	//GameObject prevObj;
	//GroundManagerScript d1;
	public GameObject barrierObj;
	public GameObject[] barrierObjs;

	private int num;

	void Awake() {
		num = Random.Range(1, barrierObjs.Length);
		List<int> tempNums = new List<int>() { 0, 1, 2, 3, 4 };
		//refObj = GameObject.Find("GroundCreater");
		//d1 = refObj.GetComponent<GroundManagerScript>();

		for (int i = 0; i < num; i++) {
			int randomIndex = Random.Range(0, tempNums.Count);
			barrierObjs[tempNums[randomIndex]].SetActive(true);
			tempNums.Remove(randomIndex);
		}


		if (this.transform.parent.name == "Ground") {
			num = 0;
		}
	}


	void Update() {
		//prevObj = d1.ReturnPrevObj();

		//if (num >= 1) {
		//	//transform.position = new Vector3(Random.Range(14f, 62f), -2.25f, 0);
		//	//var obj = Instantiate(barrierObj, prevObj.transform) as GameObject;
		//	var obj = Instantiate(barrierObj) as GameObject;
		//	//obj.transform.position = brriPos[Random.Range(0, 4)].position;
		//	//barrierObj.transform.parent = prevObj.transform;
		//	obj.transform.SetParent(prevObj.transform, false);
		//	obj.GetComponent<BoxCollider>().isTrigger = false;
		//	num--;
		//	Debug.Log("Instantiate");
		//}
	}


}