using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
	private float playerSpeed =  4.0f;
	private Button jumpButton;
	private Rigidbody2D rb;



	void Awake(){
		rb = GetComponent<Rigidbody2D> ();
		jumpButton = GameObject.Find ("Jump").GetComponent<Button> ();
		jumpButton.onClick.AddListener (() => Jump ());

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.x += playerSpeed * Time.deltaTime;
		transform.position = temp;

	}


	public void Jump(){
		rb.gravityScale *= -1;
		Vector3 temp = transform.localScale;
		temp.y *= -1;
		transform.localScale = temp;
	}
}
