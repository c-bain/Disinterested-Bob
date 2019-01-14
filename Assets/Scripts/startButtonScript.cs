using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startButtonScript : MonoBehaviour {

	public Button play;
	// Use this for initialization
	void Awake() {
		play = GameObject.Find("startButton").GetComponent<Button>();
		play.onClick.AddListener (() => startButton ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startButton(){
		Debug.Log("You have clicked the button!");
	}


}
