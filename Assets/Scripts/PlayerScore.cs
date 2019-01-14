using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

	private Text scoreText;
	private int score = 0;
	// Use this for initialization
	void Awake() {
		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		scoreText.text="Score: 0";
	}





	void OnTriggerEnter2D(Collider2D target){
//		if (target.tag == "Coin") {
//			score++;
//			scoreText.text = "Score: " + score;
//			target.gameObject.SetActive (false);
//		
//		}



		if (target.tag == "enemy" || target.tag == "Coin") {
			transform.position = new Vector3 (0, 1000, 0);
			target.gameObject.SetActive (false);
			scoreText.text = "Game Over!";
			StartCoroutine (RestartGame ());
		}
	
	
	}


	IEnumerator RestartGame(){
		yield return new WaitForSecondsRealtime (2f);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
