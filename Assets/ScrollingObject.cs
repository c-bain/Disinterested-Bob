using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {


	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (GameControl.instance.scrollSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
//		if (GameControl.instance.gameOver == true) {
//			rb.velocity = Vector2.zero;
//		}
	}
}
