using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	private bool playerLost=false;
	private Rigidbody2D rb;
	private float upForce = 200f;
	private SpriteRenderer sr;
	private bool flip;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerLost == false) {
			if (Input.GetMouseButtonDown (0)) {//left mouse button 
				rb.velocity = Vector2.zero;
				rb.AddForce (new Vector2 (0, upForce));
				rb.gravityScale *= -1;
				flip = !flip;
				sr.flipY = flip;


			}
		}
		//rb.velocity = new Vector2 (0, -1);
		Vector2 vec = transform.position;
		vec.x += 1.5f * Time.deltaTime;
		transform.position = vec;

	
	}


//	public void OnCollisionEnter2D(){
//		playerLost = true;
//		GameControl.instance.playerCollided ();
//	}





}
