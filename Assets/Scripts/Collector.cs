using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {



	private float width = 0f;

	// Use this for initialization
	void Awake() {
		width=GameObject.Find ("Background1").GetComponent<BoxCollider2D> ().size.x;
	}
	


	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Background" || target.tag == "Ground") {
			Vector3 temp = target.transform.position;
			temp.x += width * 3;
			target.transform.position = temp;
		}

		if (target.tag == "Coin") {
			target.gameObject.SetActive (false);
		}

	
	}
}
