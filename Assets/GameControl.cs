using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {


	public static GameControl instance;
	public Text gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		}

		if (instance != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
//		if (gameOver == true && Input.GetMouseButtonDown (0)) {
//			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
//		}
	}


	public void playerCollided(){
		gameOverText.text="Game Over!\nTap to Retry!";
		gameOver = true;
	}
}
