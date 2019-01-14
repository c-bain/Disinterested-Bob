using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	[SerializeField]
	private GameObject[] items;
	private float minY = -3.21f , maxY = 3.21f ;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnItems (1f));
	}


	IEnumerator SpawnItems(float time){
		yield return new WaitForSecondsRealtime (time);
		Vector3 temp = new Vector3 (transform.position.x, Random.Range (minY, maxY), 0);
		Instantiate (items [Random.Range (0, items.Length)], temp, Quaternion.identity);
		StartCoroutine (SpawnItems (Random.Range (1f, 2f)));
	}
	



}




