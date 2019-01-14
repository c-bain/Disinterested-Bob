using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private float speed = 1.5f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.x -= speed * Time.deltaTime;
		transform.position = temp;


	}
}
