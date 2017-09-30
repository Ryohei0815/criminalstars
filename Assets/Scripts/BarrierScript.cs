using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour {

	public GameObject refObj;
	GameObject prevObj;
	public GameObject barrierObj;
	int num;
	GroundManagerScript d1;
	float [] brriPosiX = new float[4];

	void Awake(){
		num = Random.Range(1,5);
		Debug.Log (num);
		refObj = GameObject.Find ("GroundCreater");
		d1 = refObj.GetComponent<GroundManagerScript> ();

		if (this.transform.parent.name == "Ground"){
			num = 0;
		}
	}
	

	void Update () {
		prevObj = d1.ReturnPrevObj();

		if (num >= 1) {
			transform.position = new Vector3 (Random.Range(14f,62f),-2.25f,0);
			barrierObj = Instantiate (barrierObj,transform.position,Quaternion.identity) as GameObject;
			//barrierObj.transform.parent = prevObj.transform;
			barrierObj.transform.SetParent(prevObj.transform.localScale, false);
			num--;
			Debug.Log ("Instantiate");
		}
	}


}