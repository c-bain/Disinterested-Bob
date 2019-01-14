using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	private float camSpeed = 4.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.x += camSpeed * Time.deltaTime;
		transform.position = temp;


	}
}
